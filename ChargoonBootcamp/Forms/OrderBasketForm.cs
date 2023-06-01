using System;
using System.Windows.Forms;

namespace UI
{
    public partial class OrderBasketForm : Form
    {
        public OrderBasketForm()
        {
            InitializeComponent();
        }

        private void PayBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("پرداخت با موفقیت انجام شد");
        }
    }
}
