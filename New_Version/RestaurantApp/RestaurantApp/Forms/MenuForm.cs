using RestaurantApp.UILayer.Enumeration;
using RestaurantApp.ServiceLayer;
using RestaurantApp.ServiceLayer.Interfaces;
using RestaurantApp.BOLayer;

namespace RestaurantApp.UILayer.Forms
{
    public partial class MenuForm : Form
    {
        private static MenuViewType _formViewMode;
        private static int _menuFoodCounts;
        private static Guid _restaurantGuid;

        public MenuForm(MenuViewType viewMode, Guid restaurantGuid)
        {
            InitializeComponent();
            _formViewMode = viewMode;
            _restaurantGuid = restaurantGuid;
            CustomizeFormDynamic();
            MenuForm_Load();
        }

        private void MenuForm_Load()
        {
            if (_restaurantGuid != null)
            {
                RestaurantService restaurantService = new RestaurantService();
                List<Food> menu = restaurantService.GetRestaurantMenu(_restaurantGuid);
                MenuDataGrid.DataSource = menu;
                MenuDataGrid.Columns["Guid"].Visible = false;
                MenuDataGrid.ReadOnly = true;
                _menuFoodCounts = menu.Count;
            }
        }

        private void CustomizeFormDynamic()
        {
            if (_formViewMode == MenuViewType.OrderMode)
            {
                MenuSubmitBtn.Text = "تکمبل خرید";
                MenuDataGrid.ReadOnly = true;
            }
            else
            {
                MenuSubmitBtn.Text = _formViewMode == MenuViewType.AddMode ? "ثبت منو" : "ویرایش منو";
                MenuDataGrid.Columns.Remove(Add);
                MenuDataGrid.Columns.Remove(Minus);
                MenuDataGrid.Columns.Remove(Count);
            }
        }

        private void MenuSubmitBtn_Click(object sender, System.EventArgs e)
        {
            if (_formViewMode == MenuViewType.AddMode)
            {
                // by hossein
            }
            else if (_formViewMode == MenuViewType.EditMode)
            {
                // by hosein
            }
            else if (_formViewMode == MenuViewType.OrderMode)
            {
                handleSaveOrder();
            }
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
                            FoodName = MenuDataGrid.Rows[i]?.Cells[3]?.Value?.ToString(),
                            FoodPrice = new decimal(Int32.Parse(MenuDataGrid.Rows[i]?.Cells[4]?.Value?.ToString())),
                        });
                    }
                }
                order.RestaurantGuid = _restaurantGuid;
                IOrderService orderService = new OrderService();
                var orderGuid = orderService.SaveOrder(order);
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
                senderGrid.Rows[e.RowIndex].Cells[2].Value = newCountValue.ToString();

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
