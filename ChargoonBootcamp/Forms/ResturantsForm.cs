using Repository.Models;
using ResturantApp.Controllers;
using Service;
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
            RestaurantController controller = new RestaurantController();
            if(controller.IsAnyResturantExit())
            {
                MessageLabel.Text = "برای مشاهده منوی رستوران روی رستوران مورد نظر کلیک کنید!";
                List<RestaurantList> allData = controller.GetAllRestaurants();
                RestaurantsDataGrid.DataSource = allData;
        
                RestaurantsDataGrid.Columns["Guid"].Visible = false;

            } else
            {
                MessageLabel.Text = "رستورانی در سیستم ثبت نشده است !";
            }
        }

        private void RestaurantsDataGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
       
            string arg = RestaurantsDataGrid.Rows[e.RowIndex].Cells[0].Value.ToString();
            Console.WriteLine(arg);
            Form menuForm = new MenuForm(MenuViewType.OrderMode);
            menuForm.Show();

        }
    }
}
