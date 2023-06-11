using Domain.Enumration;
using Domain.Handler;
using Domain.Models;
using ResturantApp;
using Service;
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
            PhoneNumberTxt.Text = LoginForm.PhoneNumber;
        }

        private void RestaurantSubmitBtn_Click(object sender, EventArgs e)
        {
            Restaurant newRestaurant = CreateNewRestaurant();
            BaseService restaurantService = new BaseService();
            restaurantService.Save<Restaurant>(newRestaurant);
            string restaurantRegMessage = MessageHandler.GetMessage(MessageType.RestaurantSubmitOk);
            MessageBox.Show(restaurantRegMessage);
            ClearFields();

            this.Hide();
            ResturantOwnerForm resturantOwnerForm = new ResturantOwnerForm(newRestaurant);
            resturantOwnerForm.Show();
        }

        private Restaurant CreateNewRestaurant()
        {
            return new Restaurant()
            {
                RestaurantName = ResturantNameTxt.Text,
                RestaurantPossessor = ResturantOwnerTxt.Text,
                OpenTime = (int)HourFromTxt.Value,
                Closetime = (int)HourFromTxt.Value,
                Address = AddressTxt.Text,
                PhoneNumber = PhoneNumberTxt.Text,
            };
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

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


