using Repository.Models;
using Service;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UI.Enumration;

namespace UI
{
    public partial class ResturantsForm : Form
    {
        public ResturantsForm()
        {
            InitializeComponent();
            AllResturantsForm_Load();
        }

        private void AllResturantsForm_Load()
        {
            IRestaurantService restaurantService = new RestaurantService();
            if (restaurantService.IsAnyRestaurantExist())
            {
                MessageLabel.Text = "برای مشاهده منوی رستوران روی رستوران مورد نظر کلیک کنید!";
                List<RestaurantList> allRestaurants = restaurantService.GetAllRestaurants();
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
            string resturantGuid = RestaurantsDataGrid.Rows[e.RowIndex]?.Cells[1]?.Value?.ToString();
            if (resturantGuid != null)
            {
                Form menuForm = new MenuForm(MenuViewType.OrderMode, new Guid(resturantGuid));
                menuForm.Show();
            }
        }
    }
}
