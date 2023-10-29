namespace SEApp
{
    public partial class VendorsProductsForm : Form
    {
        // Create an instance of the LoginForm
        LoginForm loginForm = new LoginForm();

        // Create an instance of the SettingsForm
        SettingsForm settingsForm = new SettingsForm();

        // Create an instance of the AddAdjustForm
        AddAdjustForm addAdjustForm = new AddAdjustForm();

        // Create an instance of the VendorsProductsForm
        VendorsProductsForm vendorsProductsForm = new VendorsProductsForm();

        // Create an instance of the Dashboard Form
        Dashboard dashboard = new Dashboard();
        public VendorsProductsForm()
        {
            InitializeComponent();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            dashboard.Show();
            this.Close();
        }

        private void btnVendorsAndProducts_Click(object sender, EventArgs e)
        {
            vendorsProductsForm.Show();
            this.Close();
        }

        private void btnAddOrAdjustVendors_Click(object sender, EventArgs e)
        {
            addAdjustForm.Show();
            this.Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            settingsForm.Show();
            this.Close();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }
    }
}
