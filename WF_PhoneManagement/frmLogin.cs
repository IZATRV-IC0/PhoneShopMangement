using WF_PhoneManagement;
using Microsoft.Extensions.Configuration;

namespace WF_PhoneManagement
{
    public partial class frmLogin : Form
    {
        frmNav Navigation = new frmNav();
        static string getUsername()
        {
            IConfiguration config = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json", true, true)
                                        .Build();
            var strUsername = config["user:username"];
            return strUsername;
        }
        static string getPassword()
        {
            IConfiguration config = new ConfigurationBuilder()
                                        .SetBasePath(Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json", true, true)
                                        .Build();
            var strPassword = config["user:password"];
            return strPassword;
        }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(getUsername()) && txtPassword.Text.Equals(getPassword()))
            {
                this.Hide();
                Navigation.ShowDialog();
                while (!Navigation.hasClosed)
                {

                }
                this.Show();
            } 
            else
            {
                DialogResult = MessageBox.Show("Username or password incorrect.", "Error",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Error);
            }
        }
    }
}