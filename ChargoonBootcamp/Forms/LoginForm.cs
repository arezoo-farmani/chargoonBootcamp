using Domain.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using UI;
using WindowsFormsApp_Restaurant.Forms;
using Domain.RepositoryInterfaces;
using Service;

namespace ResturantApp
{
    public partial class LoginForm : Form
    {
        private Color _defaultTextBoxColor;
        public static string PhoneNumber { get; set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            UserService service = new UserService();
            _defaultTextBoxColor = PhoneNumberTxt.BackColor;

            PhoneNumber = PhoneNumberTxt.Text;
            if (string.IsNullOrWhiteSpace(PhoneNumber))
            {
                PhoneNumberTxt.BackColor = Color.IndianRed;
                return;
            }

            User user = service.Exists<User>(PhoneNumber);
            if (user != null)
            {
                ResturantsForm resturantsForm = new ResturantsForm(user);
                resturantsForm.Show();
                this.Hide();
            }
            else
            {
                Restaurant restaurant = service.Exists<Restaurant>(PhoneNumber);
                if (restaurant != null)
                {
                    ResturantOwnerForm ownerForm = new ResturantOwnerForm(restaurant);
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
        }


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