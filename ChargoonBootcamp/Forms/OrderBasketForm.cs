using ResturantApp.Controllers;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class OrderBasketForm : Form
    {
        private static Guid _orderGuid;

        public OrderBasketForm(Guid orderGuid)
        {
            InitializeComponent();
            _orderGuid = orderGuid;
            OrderBasketForm_Load();
        }

        private void OrderBasketForm_Load()
        {
            RestaurantController controller = new RestaurantController();
            if (_orderGuid != null)
            {
                var order = controller.GetOrder(_orderGuid);
                OrderBasketDataGrid.DataSource = order.OrderDetails;
                SumLabel.Text = order.TotalOrderAmount.ToString();
            }
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("پرداخت با موفقیت انجام شد");
        }
    }
}
