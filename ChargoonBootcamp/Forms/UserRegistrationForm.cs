using Domain.Models;
using ResturantApp;
using System;
using System.Windows.Forms;
using Service;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
            PhoneNumberTxt.Text = LoginForm.PhoneNumber;
        }

        private void UserSubmitBtn_Click_1(object sender, EventArgs e)
        {
            User user = new User();
            user.Guid = Guid.NewGuid();
            user.Name = FirstNameTxt.Text;
            user.Family = LastNameTxt.Text;
            user.NationalCode = NationalCodeTxt.Text;
            user.Address = AddressTxt.Text;
            user.PhoneNumber = PhoneNumberTxt.Text;

            UserService service = new UserService();
            Guid guid = service.Save<User>(user);

            string userRegMessage = MessageHandler.GetMessage("UserRegistrationForm", "Registration", true);
            MessageBox.Show(userRegMessage);
            ClearFields();

            this.Hide();
            ResturantsForm resturantsForm = new ResturantsForm(user);
            resturantsForm.Show();
        }

        private void ClearFields()
        {
            FirstNameTxt.Text = "";
            LastNameTxt.Text = "";
            NationalCodeTxt.Text = "";
            AddressTxt.Text = "";
            PhoneNumberTxt.Text = "";
        }

        private void UserRegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void RegistrationUserBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
