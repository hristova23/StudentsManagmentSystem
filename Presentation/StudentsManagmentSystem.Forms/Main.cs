namespace StudentsManagmentSystem.Forms
{
    using System;
    using System.Windows.Forms;

    using Services.Models;

    public partial class Main : Form
    {
        private readonly UserListingServiceModel user;
        private Form activeForm;

        public Main(UserListingServiceModel user)
        {
            this.user = user;
            InitializeComponent();
            OpenChildForm(new Search(), null);
        }

        private void AccountBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Account(this.user), sender);
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Search(), sender);
        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AddStudent(), sender);
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login loginForm = new Login();
            loginForm.ShowDialog();
            this.Close();
        }

        public void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.mainPanel.Controls.Add(childForm);
            this.mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
