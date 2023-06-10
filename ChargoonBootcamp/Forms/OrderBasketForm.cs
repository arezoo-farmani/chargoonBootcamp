using Domain.Handler;
using Domain.Models;
using Domain.ServiceInterfaces;
using Service;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class OrderBasketForm : Form
    {
        private static Guid _orderGuid;
        private static Order _order;

        public OrderBasketForm(Guid orderGuid)
        {
            InitializeComponent();
            _orderGuid = orderGuid;
            OrderBasketForm_Load();
        }

        private void OrderBasketForm_Load()
        {
            IOrderService orderService = new OrderService();
            if (_orderGuid != null)
            {
                _order = orderService.Get(_orderGuid);
                OrderBasketDataGrid.DataSource = _order.OrderDetails;
                SumLabel.Text = _order.TotalOrderAmount.ToString();
            }
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            IInvoiceService invoiceService = new InvoiceService();
            invoiceService.Save(new Invoice
            {
                RestaurantGuid = _order.RestaurantGuid,
                InvoiceAmount = _order.TotalOrderAmount,
            });
            string orderBasketMessage = MessageHandler.GetMessage("OrderBasketForm", "Registration", true);
            MessageBox.Show(orderBasketMessage);
        }
    }
}
