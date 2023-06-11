using Domain.Models;
using ResturantApp;
using System;
using System.Windows.Forms;
using Service;
using Domain.Handler;

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
            User newUser = CreateNewUser();
            BaseService userService = new BaseService();
            userService.Save<User>(newUser);
            string userRegMessage = MessageHandler.GetMessage("UserRegistrationForm", "Registration", true);
            MessageBox.Show(userRegMessage);
            ClearFields();

            this.Hide();
            ResturantsForm resturantsForm = new ResturantsForm(newUser);
            resturantsForm.Show();
        }

        private User CreateNewUser()
        {
            return new User()
            {
                Name = FirstNameTxt.Text,
                Family = LastNameTxt.Text,
                NationalCode = NationalCodeTxt.Text,
                Address = AddressTxt.Text,
                PhoneNumber = PhoneNumberTxt.Text,
            };
        }

        private void ClearFields()
        {
            FirstNameTxt.Text = "";
            LastNameTxt.Text = "";
            NationalCodeTxt.Text = "";
            AddressTxt.Text = "";
            PhoneNumberTxt.Text = "";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
