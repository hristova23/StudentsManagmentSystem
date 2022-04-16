namespace StudentsManagmentSystem.Forms
{
    using System;
    using System.Linq;
    using System.Windows.Forms;
    using Data;
    using Services.Models;
    using Services.Implementations;

    public partial class Account : Form
    {
        private readonly UserListingServiceModel user;

        public Account(UserListingServiceModel user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void CancelBtn_Click(object sender, System.EventArgs e)
        {
            foreach (TextBox txtBox in this.changePassGroupBox.Controls.OfType<TextBox>())
            {
                txtBox.Clear();
            }
        }

        private void SaveChangesBtn_Click(object sender, System.EventArgs e)
        {
            using var data = new StudentsManagmentSystemDbContext();
            var userService = new UserService(data);

            string oldPassword = oldPassTxtBox.Text;
            string newPassword = newPassTxtBox.Text;
            string confirmPassword = confirmPassTxtBox.Text;

            try
            {
                userService.UpdatePassword(this.user,oldPassword,newPassword,confirmPassword);
                CancelBtn_Click(sender, e);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void Account_Load(object sender, EventArgs e)
        {
            UsernameLbl.Text = $"{this.user.Username}";
        }
    }
}
