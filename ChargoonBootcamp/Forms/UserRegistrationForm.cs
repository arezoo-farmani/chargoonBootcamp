using ResturantApp;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class UserRegistrationForm : Form
    {
        public UserRegistrationForm()
        {
            InitializeComponent();
            CustomizeFormDynamic();
        }

        private void CustomizeFormDynamic()
        {
            PhoneNumberTxt.Text = LoginForm.LoginPhoneNumber;
        }

        private void UserSubmitBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form resturantsForm = new ResturantsForm();
            resturantsForm.Show();

        }
    }
}
