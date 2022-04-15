namespace StudentsManagmentSystem.Forms
{
    using System.Linq;
    using System.Windows.Forms;
    using Services.Models;

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
