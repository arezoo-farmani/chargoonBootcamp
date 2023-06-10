using Domain.Models;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class ResturantOwnerForm : Form
    {
        private static Guid _restaurantGuid;
        public ResturantOwnerForm(Restaurant restaurant)
        {
            InitializeComponent();
            _restaurantGuid = restaurant.Guid;
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            FoodMenu foodMenu = new FoodMenu(_restaurantGuid);
            foodMenu.Show();
        }

        private void ShowInvoicesBtn_Click(object sender, EventArgs e)
        {
            Form invoiceForm = new InvoicesForm(_restaurantGuid);
            invoiceForm.Show();
        }
    }
}
