using ScottishGlen.Forms;

namespace ScottishGlen
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AssetForm assetForm = new AssetForm();
            assetForm.ShowDialog();
        }

        private void titleTxt_Click(object sender, EventArgs e)
        {
            titleTxt.Font = new Font(titleTxt.Font.Name, 40, titleTxt.Font.Style);
        }
    }
}
