using RestaurantApp.BOLayer;
using RestaurantApp.ServiceLayer;

namespace RestaurantApp.UILayer.Forms
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

            Service service = new Service();
            Guid guid = service.Save<User>(user);

            MessageBox.Show($"User was registered successfully.");
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
