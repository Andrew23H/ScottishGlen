using System.Management;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using Microsoft.EntityFrameworkCore;
using ScottishGlen.DataAccess;
using System.Linq;

namespace ScottishGlen.Forms
{
    public partial class AssetForm : Form
    {
        public AssetForm()
        {
            InitializeComponent();
            LoadEmployee();
        }

        // this will load emplyees from the databasae
        private void LoadEmployee()
        {
            using var dbContext = Program.CreateDbContext();
            var employees = dbContext.Employees
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToList();

            employeeBox.DataSource = employees;
            employeeBox.DisplayMember = "FullName";
            employeeBox.ValueMember = "EmployeeId";
            employeeBox.SelectedIndex = -1;
        }

        // this will collect the manufacturer and model of the computer.
        private void CollectHardwareInformation()
        {
            // get computers name
            systemNameTxt.Text = Environment.MachineName;

            CollectAssetType();

            // this will find the name of the Model and Manufacturer of the computer
            using (ManagementObjectSearcher searcher =
                new ManagementObjectSearcher(
                    "SELECT Manufacturer, Model FROM Win32_ComputerSystem"))
            {
                foreach (ManagementObject computer in searcher.Get())
                {
                    if (computer == null)
                        continue;

                    manufacturerTxt.Text =
                      computer["Manufacturer"]?.ToString() ?? "";

                    modelTxt.Text =
                        computer["Model"]?.ToString() ?? "";
                }
            }

            // this will collect the ip address, https://learn.microsoft.com/en-us/dotnet/api/system.net.networkinformation.networkinterface?view=net-10.0 was used.
            foreach (NetworkInterface networkInterface in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (networkInterface.OperationalStatus != OperationalStatus.Up) continue;

                IPInterfaceProperties properties = networkInterface.GetIPProperties();

                foreach (UnicastIPAddressInformation address in properties.UnicastAddresses)
                {
                    // this will only collect IPv4 address
                    if (address.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        ipAddressTxt.Text = address.Address.ToString();
                        return;
                    }
                }
            }
        }

        // this will show what the asset type they are using, https://learn.microsoft.com/en-gb/windows/win32/cimwin32prov/win32-systemenclosure
        private void CollectAssetType()
        {
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(
                "SELECT ChassisTypes FROM Win32_SystemEnclosure"))
            {
                foreach (ManagementObject enclosure in searcher.Get())
                {
                    object chassisData = enclosure["ChassisTypes"];

                    if (chassisData != null)
                    {
                        ushort[] chassisTypes = (ushort[])chassisData;

                        foreach (ushort chassisType in chassisTypes)
                        {
                            string assetType = chassisType switch
                            {
                                3 or 4 or 5 or 6 or 7 => "Desktop",
                                8 => "Portable",
                                9 or 10 or 14 => "Laptop",
                                13 => "All-in-One",
                                30 or 31 or 32 => "Tablet",
                                _ => "Other"
                            };

                            assetTypeTxt.Text = assetType;
                            return;
                        }
                    }
                }
            }

            assetTypeTxt.Text = "Unknown";
        }

        private void BtnCollectHardware_Click(object sender, EventArgs e)
        {
            CollectHardwareInformation();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}