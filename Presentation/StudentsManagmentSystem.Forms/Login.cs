namespace StudentsManagmentSystem.Forms
{
    using System;
    using System.Linq;
    using System.Windows.Forms;

    using Data;
    using Services.Implementations;

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public void ClearForm(object sender, EventArgs e)
        {
            foreach (TextBox txtBox in this.Controls.OfType<TextBox>())
            {
                txtBox.Clear();
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassCheckBox.Checked)
            {
                PasswordTxtBox.PasswordChar = '\0';
            }
            else
            {
                PasswordTxtBox.PasswordChar = '*';
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            using var data = new StudentsManagmentSystemDbContext();
            var userService = new UserService(data);

            string username = UsernameTxtBox.Text;
            string password = userService.HashPassword(PasswordTxtBox.Text);

            var user = userService.SearchByUsername(username);

            if (user != null &&
                user.Password == password)
            {
                //is authorized
                this.Hide();
                Main homeForm = new Main();
                homeForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid credentials.");
            }
            ClearForm(sender, e);
        }

        private void CreateAccountLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register registerForm = new Register();
            registerForm.ShowDialog();
            this.Close();
        }
    }
}
