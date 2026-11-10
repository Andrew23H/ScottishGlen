using System.Management;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using Microsoft.EntityFrameworkCore;
using ScottishGlen.DataAccess;
using System.Linq;
using ScottishGlen.Models;


namespace ScottishGlen.Forms
{
    public partial class AssetForm : Form
    {
        public AssetForm()
        {
            InitializeComponent();
            LoadEmployee();
        }

        // this will load emplyees from the database and display their full name
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

        // this will collect the hardware information of the current computer.
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

        // this uses the chassis type to determine what asset type it will be https://stackoverflow.com/questions/34707746/managementobjectsearcher-on-wmi-array-property
        private void CollectAssetType()
        {
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(
                "SELECT ChassisTypes FROM Win32_SystemEnclosure"))
            {
                foreach (ManagementObject enclosure in searcher.Get())
                {
                    object chassisData = enclosure["ChassisTypes"];

                    // this number ID represents the chassistype https://learn.microsoft.com/en-gb/windows/win32/cimwin32prov/win32-systemenclosure
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

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}

        private void addAssetBtn_Click(object sender, EventArgs e)
        {
            // this will check that an employee had been selected before adding the asset to database
            if (employeeBox.SelectedValue == null)
            {
                MessageBox.Show(
                    "Please select an employee.",
                    "Missing Employee",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // this will check that the automatic hardware collection fields are complete
            if (string.IsNullOrWhiteSpace(systemNameTxt.Text) ||
                string.IsNullOrWhiteSpace(manufacturerTxt.Text) ||
                string.IsNullOrWhiteSpace(modelTxt.Text) ||
                string.IsNullOrWhiteSpace(assetTypeTxt.Text) ||
                string.IsNullOrWhiteSpace(ipAddressTxt.Text))
            {
                MessageBox.Show(
                    "Hardware info is missing!\n" +
                    "Click 'Collect Hardware'",

                    "Missing Info",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // this will create the asset object using the collected hardware ionformation
            var asset = new Asset
            {
                SystemName = systemNameTxt.Text,
                Manufacturer = manufacturerTxt.Text,
                Model = modelTxt.Text,
                AssetType = assetTypeTxt.Text,
                IpAddress = ipAddressTxt.Text,
                PurchaseDate = purchaseDateDTP.Checked ? purchaseDateDTP.Value : null,
                Notes = notesTxt.Text,
                EmployeeId = (int)employeeBox.SelectedValue

            };

            // this will add the asset to the database and save, the database will generate an ID for the asset
            using var dbContext = Program.CreateDbContext();
            dbContext.Assets.Add(asset);
            dbContext.SaveChanges();
            MessageBox.Show(
                $"Asset was added successfully! Asset ID: {asset.AssetId}",
                "Asset saved",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        }

        private void viewAssetsBtn_Click(object sender, EventArgs e)
        {
            ViewAssetsForm ViewAssetsForm = new ViewAssetsForm();
            ViewAssetsForm.ShowDialog();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // this will close the asset form and go back to the main form
            this.Close();
        }
    }
}