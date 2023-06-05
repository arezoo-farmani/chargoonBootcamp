using Repository.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UI;
using Repository;
using WindowsFormsApp_Restaurant.Forms;

namespace ResturantApp
{
    public partial class LoginForm : Form
    {
        private Color _defaultTextBoxColor;
        public static string LoginPhoneNumber;
        private List<User> userList;
        private List<Restaurant> restaurantList;
        private IRepository<User> dataRepository;
        //private object PhoneNumberTextBox;
        // private string phoneNumber;

        public LoginForm()
        {
            InitializeComponent();
            
            // must change base on service layer and using generic repository
            //dataRepository = new DataRepository();
            //userList = dataRepository.GetAllUsers();
            //restaurantList = dataRepository.GetAllRestaurants();
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
            }
            if (UserExists(LoginPhoneNumber))
            {
                ResturantsForm resturantsForm = new ResturantsForm();
                resturantsForm.Show();
                this.Hide();
            }
            else if (RestaurantExists(LoginPhoneNumber))
            {
                ResturantOwnerForm ownerForm = new ResturantOwnerForm();
                ownerForm.Show();
                this.Hide();
            }
            else
            {
                RegistrationForm registerUserForm = new RegistrationForm();
                registerUserForm.Show();
                this.Hide();
            }
        }

        private bool UserExists(string phoneNumber)
        {
            if (userList?.Count > 0)
            {
                foreach (User user in userList)
                {
                    if (user.PhoneNumber == phoneNumber)
                        return true;
                }
            }
            return false;
        }

        private bool RestaurantExists(string phoneNumber)
        {
            if (restaurantList?.Count > 0)
            {
                foreach (Restaurant restaurant in restaurantList)
                {
                    if (restaurant.PhoneNumber == phoneNumber)
                        return true;
                }
            }
            return false;
        }

        //private void LoginBtn_Click(object sender, EventArgs e)
        //{
        //    _defaultTextBoxColor = PhoneNumberTxt.BackColor;
        //    if (PhoneNumberTxt.Text == "")
        //    {
        //        PhoneNumberTxt.BackColor = Color.IndianRed;
        //        return;
        //    }
        //    else
        //    {
        //        LoginPhoneNumber = PhoneNumberTxt.Text;
        //        this.Hide();
        //        Form registrationForm = new RegistrationForm();
        //        registrationForm.Show();
        //    }
        //}

        private void PhoneNumberTxt_TextChanged(object sender, EventArgs e)
        {
            if (PhoneNumberTxt.Text != "" && PhoneNumberTxt.BackColor == Color.IndianRed)
            {
                PhoneNumberTxt.BackColor = _defaultTextBoxColor;
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenuForm mainManuForm = new MainMenuForm();
            mainManuForm.ShowDialog();
        }

        private void LoginBox_Enter(object sender, EventArgs e)
        {

        }
    }
}