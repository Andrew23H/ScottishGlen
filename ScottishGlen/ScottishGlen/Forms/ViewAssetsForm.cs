using System.Windows.Forms;
using ScottishGlen.DataAccess;


namespace ScottishGlen.Forms
{
    public partial class ViewAssetsForm : Form
    {
        public ViewAssetsForm()
        {
            InitializeComponent();
        }

        // this will load and display all the assets stored on the database, it joins assets with employess to show the employees fill name
        private void LoadAssets()
        {
            using var dbContext = Program.CreateDbContext();
            var assets = dbContext.Assets.Join(dbContext.Employees, asset => asset.EmployeeId, employee => employee.EmployeeId,
                (asset, employee) => new
                {
                    asset.AssetId, 
                    asset.SystemName,
                    asset.Manufacturer,
                    asset.Model,
                    asset.AssetType,
                    asset.IpAddress,
                    asset.PurchaseDate,
                    asset.Notes,
                    EmployeeName = employee.FullName
                }).ToList();
            assetsDataGridView.DataSource = assets;

            assetsDataGridView.Columns["AssetId"].HeaderText = "Asset ID";
            assetsDataGridView.Columns["SystemName"].HeaderText = "System Name";
            assetsDataGridView.Columns["AssetType"].HeaderText = "Asset Type";
            assetsDataGridView.Columns["IpAddress"].HeaderText = "IP Address";
            assetsDataGridView.Columns["PurchaseDate"].HeaderText = "Purchase Date";
            assetsDataGridView.Columns["PurchaseDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            assetsDataGridView.Columns["EmployeeName"].HeaderText = "Employee";
            
        }

        private void ViewAssetsForm_Load(object sender, EventArgs e)
        {
            LoadAssets();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}