using Domain.Models;
using ResturantApp;
using System;
using System.Windows.Forms;
using Service;
using Domain.Handler;
using Domain.Enumration;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;

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
            if (!IsValidNationalCode(NationalCodeTxt.Text))
            {
                NationalCodeTxt.BackColor = Color.IndianRed;
                return;
            }

            User newUser = CreateNewUser();
            BaseService userService = new BaseService();
            userService.Save<User>(newUser);
            string userRegMessage = MessageHandler.GetMessage(MessageType.UserSubmitOk);
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
        private bool IsValidNationalCode(string nationalCode)
        {
            if (string.IsNullOrWhiteSpace(nationalCode) || nationalCode.Length != 10)
                return false;

            string onlyNumericCharectersPattern = @"^\d+$";
            return Regex.IsMatch(nationalCode, onlyNumericCharectersPattern);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
