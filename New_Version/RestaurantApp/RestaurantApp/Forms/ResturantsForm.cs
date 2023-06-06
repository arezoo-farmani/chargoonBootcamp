using RestaurantApp.ServiceLayer.Interfaces;
using RestaurantApp.BOLayer;
using RestaurantApp.ServiceLayer;
using RestaurantApp.UILayer.Enumeration;
using System.Reflection.Metadata.Ecma335;

namespace RestaurantApp.UILayer.Forms
{
    public partial class ResturantsForm : Form
    {
        public ResturantsForm(User user)
        {
            InitializeComponent();
            AllResturantsForm_Load();
            CurrentUser = user;
            this.lblInfo.Text = $"{CurrentUser.Name} خوش آمدید.";
        }
        public User CurrentUser { get; set; }

        private void AllResturantsForm_Load()
        {
            RestaurantService restaurantService = new RestaurantService();
            if (restaurantService.IsAnyResturantExist())
            {
                MessageLabel.Text = "برای مشاهده منوی رستوران روی رستوران مورد نظر کلیک کنید!";
                List<Restaurant> allRestaurants = restaurantService.GetAllRestaurants();
                RestaurantsDataGrid.DataSource = allRestaurants;
                RestaurantsDataGrid.Columns["Guid"].Visible = false;
            }
            else
            {
                MessageLabel.Text = "رستورانی در سیستم ثبت نشده است !";
            }
        }

        private void RestaurantsDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string resturantGuid = RestaurantsDataGrid.Rows[e.RowIndex]?.Cells["Guid"]?.Value?.ToString();
            if (resturantGuid != null)
            {
                Form menuForm = new MenuForm(MenuViewType.OrderMode, new Guid(resturantGuid));
                menuForm.Show();
            }
        }

    }
}
