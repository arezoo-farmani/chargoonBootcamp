using Repository;
using Repository.Models;
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
            string name = FirstNameTxt.Text;
            string family = LastNameTxt.Text;
            string nationalCode = NationalCodeTxt.Text;
            string address = AddressTxt.Text;
            string phoneNumber = PhoneNumberTxt.Text;
            this.Hide();
            Form resturantsForm = new ResturantsForm();
            resturantsForm.Show();

            User newUser = new User
            {
                Guid = Guid.NewGuid(),
                Name = name,
                Family = family,
                NationalCode = nationalCode,
                Address = address,
                PhoneNumber = phoneNumber
            };
            DataRepository<User> dataRepository = new DataRepository<User>();
            dataRepository.Save(newUser);

            MessageBox.Show("User was registered successfully.");
            ClearFields();
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
