
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void UserRegBtn_Click(object sender, EventArgs e)
        {
            Form userRegistrationForm = new UserRegistrationForm();
            userRegistrationForm.Show();
        }

        private void ResturantRegBtn_Click(object sender, EventArgs e)
        {
            Form resturantRegistartionForm = new ResturantRegistrationForm();
            resturantRegistartionForm.Show();
        }
    }
}
