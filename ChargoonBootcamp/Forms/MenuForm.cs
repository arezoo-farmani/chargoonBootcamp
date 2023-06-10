using Domain.Models;
using Domain.ServiceInterfaces;
using Domain.ViewModels;
using Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class MenuForm : Form
    {
        private static int _menuFoodCounts;
        private static Guid _restaurantGuid;
        private static Guid _userGuid;

        public MenuForm(Guid restaurantGuid, Guid userGuid)
        {
            InitializeComponent();
            _restaurantGuid = restaurantGuid;
            _userGuid = userGuid;
            MenuForm_Load();
        }

        private void MenuForm_Load()
        {
            if (_restaurantGuid != null && _restaurantGuid != System.Guid.Empty)
            {
                IFoodService foodService = new FoodService();
                List<FoodListViewModel> menu = foodService.GetRestaurantMenu(_restaurantGuid);
                MenuDataGrid.DataSource = menu;
                MenuDataGrid.ReadOnly = true;
                _menuFoodCounts = menu.Count;
            }
        }

        private void MenuSubmitBtn_Click(object sender, System.EventArgs e)
        {
            handleSaveOrder();
        }

        private void handleSaveOrder()
        {
            if (checkAnyFoodSelected())
            {
                Order order = new Order();
                order.OrderDetails = new List<OrderDetail>();
                for (int i = 0; i < _menuFoodCounts; i++)
                {
                    int countValue = getCountValueOfFood(i);
                    if (countValue > 0)
                    {
                        order.OrderDetails.Add(new OrderDetail()
                        {
                            Count = countValue,
                            FoodName = MenuDataGrid.Rows[i]?.Cells["FoodName"]?.Value?.ToString(),
                            FoodPrice = Convert.ToDecimal(MenuDataGrid.Rows[i]?.Cells["FoodPrice"]?.Value?.ToString()),
                        });
                    }
                }
                order.RestaurantGuid = _restaurantGuid;
                order.UserGuid = _userGuid;
                IOrderService orderService = new OrderService();
                var orderGuid = orderService.Save(order);
                handleShowOrderBasketForm(orderGuid);
            }
            else
            {
                MessageBox.Show("غذایی انتخاب نشده است!");
            }

        }

        private void handleShowOrderBasketForm(Guid orderGuid)
        {
            Form orderBasketForm = new OrderBasketForm(orderGuid);
            orderBasketForm.Show();
        }

        private void MenuDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var countValue = getCountValueOfFood(e.RowIndex);
                var newCountValue = 0;
                if (e.ColumnIndex == 0)
                {
                    newCountValue = countValue + 1;
                }
                else if (e.ColumnIndex == 1)
                {
                    newCountValue = countValue == 0 ? 0 : countValue - 1;
                }
                senderGrid.Rows[e.RowIndex].Cells["Count"].Value = newCountValue.ToString();
            }
        }

        private bool checkAnyFoodSelected()
        {
            var totalCount = 0;
            if (_menuFoodCounts > 0)
            {
                for (int i = 0; i < _menuFoodCounts; i++)
                {
                    totalCount += getCountValueOfFood(i);
                }
            }
            return totalCount > 0;
        }

        private int getCountValueOfFood(int index)
        {
            var countValue = MenuDataGrid.Rows[index]?.Cells[2]?.Value?.ToString();
            return countValue == null ? 0 : Int32.Parse(countValue);
        }

    }
}
