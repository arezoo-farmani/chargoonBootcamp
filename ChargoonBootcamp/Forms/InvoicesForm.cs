using Domain.ServiceInterfaces;
using Domain.ViewModels;
using Service;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace UI
{
    public partial class InvoicesForm : Form
    {
        private static Guid _restaurantGuid;
        public InvoicesForm(Guid restaurantGuid)
        {
            InitializeComponent();
            _restaurantGuid = restaurantGuid;
            InvoicesForm_Load();
        }

        private void InvoicesForm_Load()
        {
            IInvoiceService invoiceService = new InvoiceService();
            List<InvoiceListViewModel> allInvoices = invoiceService.GetAllRestaurantInvoces(_restaurantGuid);
            InvoicesDataGrid.DataSource = allInvoices;
            SumLabel.Text = CalculateTotalAmount(allInvoices).ToString() + "تومان ";
        }

        private decimal CalculateTotalAmount(List<InvoiceListViewModel> allInvoices)
        {
            decimal totalAmount = 0;
            foreach (InvoiceListViewModel invoice in allInvoices)
            {
                totalAmount += invoice.Amount;
            }
            return totalAmount;
        }
    }
}
