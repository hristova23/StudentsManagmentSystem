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
            foreach (TextBox txtBox in this.Controls.OfType<TextBox>())
            {
                txtBox.Clear();
            }
        }

        private void SaveChangesBtn_Click(object sender, System.EventArgs e)
        {
        }
    }
}
