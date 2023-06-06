using RestaurantApp.BOLayer;
using RestaurantApp.ServiceLayer;

namespace RestaurantApp.UILayer.Forms
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
            Service service = new Service();
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

        //private bool UserExists(string phoneNumber)
        //{
        //    if (userList?.Count > 0)
        //    {
        //        foreach (User user in userList)
        //        {
        //            if (user.PhoneNumber == phoneNumber)
        //                return true;
        //        }
        //    }
        //    return false;
        //}

        //private bool RestaurantExists(string phoneNumber)
        //{
        //    if (restaurantList?.Count > 0)
        //    {
        //        foreach (Restaurant restaurant in restaurantList)
        //        {
        //            if (restaurant.PhoneNumber == phoneNumber)
        //                return true;
        //        }
        //    }
        //    return false;
        //}

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