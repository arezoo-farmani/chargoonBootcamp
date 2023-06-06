using RestaurantApp.BOLayer;
using RestaurantApp.ServiceLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RestaurantApp.UILayer.Forms
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

            Service service = new Service();
            Guid guid = service.Save<Restaurant>(newRestaurant);
            MessageBox.Show("Restaurant was registered successfully.");
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

        private void ResturantRegBox_Enter(object sender, EventArgs e)
        {

        }

        private void WorkHoursLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
