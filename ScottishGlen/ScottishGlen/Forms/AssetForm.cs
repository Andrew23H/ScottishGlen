using System.Management;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace ScottishGlen.Forms
{
    public partial class AssetForm : Form
    {
        public AssetForm()
        {
            InitializeComponent();
        }

        // this will collect the manufacturer and model of the computer.
        private void CollectHardwareInformation()
        {
            // get computers name
            systemNameTxt.Text = Environment.MachineName;

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

        private void BtnCollectHardware_Click(object sender, EventArgs e)
        {
            CollectHardwareInformation();
        }
    }
}