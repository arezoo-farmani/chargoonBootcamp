using ResturantApp;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class ResturantRegistrationForm : Form
    {
        public ResturantRegistrationForm()
        {
            InitializeComponent();
            CustomizeFormDynamic();
        }

        private void CustomizeFormDynamic()
        {
            PhoneNumberTxt.Text = LoginForm.LoginPhoneNumber;
        }

        private void ResturantSubmitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form resturantOwnerForm = new ResturantOwnerForm();
            resturantOwnerForm.Show();
        }
    }
}
