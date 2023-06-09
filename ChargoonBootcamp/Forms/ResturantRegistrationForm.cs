using Domain.Models;
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
            PhoneNumberTxt.Text = LoginForm.PhoneNumber;
        }

        private void ResturantSubmitBtn_Click(object sender, EventArgs e)
        {
            Restaurant newRestaurant = new Restaurant();
            newRestaurant.RestaurantName = ResturantNameTxt.Text;
            newRestaurant.RestaurantPossessor = ResturantOwnerTxt.Text;
            newRestaurant.OpenTime = (int)HourFromTxt.Value;
            newRestaurant.Closetime = (int)HourFromTxt.Value;
            newRestaurant.Address = AddressTxt.Text;
            newRestaurant.PhoneNumber = PhoneNumberTxt.Text;
            newRestaurant.Menu = new List<Food>();

            UserService service = new UserService();
            Guid guid = service.Save<Restaurant>(newRestaurant);
            string restaurantRegMessage = MessageHandler.GetMessage("ResturantRegistrationForm", "Registration", true);
            MessageBox.Show(restaurantRegMessage);
            ClearFields();

            this.Hide();
            ResturantOwnerForm resturantOwnerForm = new ResturantOwnerForm(newRestaurant);
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

    }
}
