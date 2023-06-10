using Domain.Models;
using Domain.ServiceInterfaces;
using Domain.ViewModels;
using Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class ResturantsForm : Form
    {
        private static Guid _userGuid;
        public ResturantsForm(User user)
        {
            InitializeComponent();
            AllResturantsForm_Load();
            _userGuid = user.Guid;
            this.lblInfo.Text = $"{user.Name} خوش آمدید ";
        }

        private void AllResturantsForm_Load()
        {
            IRestaurantService restaurantService = new RestaurantService();
            if (Helper.IsAnyEntityExist<Restaurant>())
            {
                MessageLabel.Text = "برای مشاهده منوی رستوران روی رستوران مورد نظر کلیک کنید!";
                List<RestaurantListViewModel> allRestaurants = restaurantService.GetAll();
                RestaurantsDataGrid.DataSource = allRestaurants;
                RestaurantsDataGrid.Columns["Guid"].Visible = false;
            }
            else
            {
                MessageLabel.Text = "رستورانی در سیستم ثبت نشده است !";
            }
        }

        private void RestaurantsDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string resturantGuid = RestaurantsDataGrid.Rows[e.RowIndex]?.Cells["Guid"]?.Value?.ToString();
            if (resturantGuid != null)
            {
                Form menuForm = new MenuForm(new Guid(resturantGuid), _userGuid);
                menuForm.Show();
            }
        }
    }
}
