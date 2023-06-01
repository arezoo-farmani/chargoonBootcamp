using System;
using System.Drawing;
using System.Windows.Forms;
using UI;

namespace ResturantApp
{
    public partial class LoginForm : Form
    {
        private Color _defaultTextBoxColor;
        public static string LoginPhoneNumber;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            _defaultTextBoxColor = PhoneNumberTxt.BackColor;
            if (PhoneNumberTxt.Text == "")
            {
                PhoneNumberTxt.BackColor = Color.IndianRed;
                return;
            }
            else
            {
                LoginPhoneNumber = PhoneNumberTxt.Text;
                this.Hide();
                Form registrationForm = new RegistrationForm();
                registrationForm.Show();
            }
        }

        private void PhoneNumberTxt_TextChanged(object sender, EventArgs e)
        {
            if (PhoneNumberTxt.Text != "" && PhoneNumberTxt.BackColor == Color.IndianRed)
            {
                PhoneNumberTxt.BackColor = _defaultTextBoxColor;
            }
        }
    }
}