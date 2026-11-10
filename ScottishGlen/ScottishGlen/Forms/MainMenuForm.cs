using ScottishGlen.Forms;

namespace ScottishGlen;

public partial class MainMenuForm : Form
{
    public MainMenuForm()
    {
        InitializeComponent();
    }

    private void assetBtn_Click(object sender, EventArgs e)
    {
        AssetForm assetForm = new AssetForm();
        assetForm.ShowDialog();
    }

    

    
}
