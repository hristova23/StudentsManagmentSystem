namespace StudentsManagmentSystem.Forms
{
    using System;
    using System.Windows.Forms;

    using Data;
    using Services.Implementations;

    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
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

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            using var data = new StudentsManagmentSystemDbContext();
            var userService = new UserService(data);

            string username = UsernameTxtBox.Text;
            string password = PasswordTxtBox.Text;

            try
            {
                userService.Create(username, password);
                BackToLoginLbl_Click(sender, e);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void BackToLoginLbl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
            this.Close();
        }
    }
}
