using System;
using System.Windows.Forms;

namespace RestaurantApp.UILayer.Forms
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void UserRegBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form userRegistrationForm = new UserRegistrationForm();
            userRegistrationForm.Show();
        }

        private void ResturantRegBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form resturantRegistartionForm = new ResturantRegistrationForm();
            resturantRegistartionForm.Show();
        }
    }
}
