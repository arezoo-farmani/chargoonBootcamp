using Repository;
using Repository.Models;
using ResturantApp;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Service;

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
            string name = ResturantNameTxt.Text;
            string possessor = ResturantOwnerTxt.Text;
            int openTime = (int)HourFromTxt.Value;
            int closeTime = (int)HourToTxt.Value;
            string address = AddressTxt.Text;
            string phoneNumber = PhoneNumberTxt.Text;

            Restaurant newRestaurant = new Restaurant
            {
                Guid = Guid.NewGuid(),
                RestaurantName = name,
                RestaurantPossessor = possessor,
                OpenTime = openTime,
                Closetime = closeTime,
                Address = address,
                PhoneNumber = phoneNumber,
                Menu = new List<Food>()
            };
            DataRepository<Restaurant> dataRepository = new DataRepository<Restaurant>();
            dataRepository.Save(newRestaurant);
            MessageBox.Show("Restaurant was registered successfully.");
            ClearFields();

            this.Hide();
            Form resturantOwnerForm = new ResturantOwnerForm();
            resturantOwnerForm.Show();
        }
        private void ClearFields()
        {
            ResturantNameTxt.Text = string.Empty;
            ResturantOwnerTxt.Text = string.Empty;
            HourFromTxt.Value = 1;
            HourToTxt.Value = 1;
            AddressTxt.Text = string.Empty;
            PhoneNumberTxt.Text = string.Empty;
        }

        private void ResturantRegBox_Enter(object sender, EventArgs e)
        {

        }

        private void WorkHoursLabel_Click(object sender, EventArgs e)
        {

        }

        private void ResturantRegistrationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
