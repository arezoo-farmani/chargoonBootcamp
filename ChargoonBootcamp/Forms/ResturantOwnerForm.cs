using Domain.Models;
using System;
using System.Windows.Forms;
using UI.Enumration;

namespace UI
{
    public partial class ResturantOwnerForm : Form
    {
        public ResturantOwnerForm(Restaurant restaurant)
        {
            InitializeComponent();
            customizeFormDynamic();
        }

        private void customizeFormDynamic()
        {
            var isMenuExist = CheckMenuIsExist();
            MenuBtn.Text = isMenuExist ? "ویرایش منو" : "ثبت منو جدید";
        }

        private bool CheckMenuIsExist()
        {
            // if user register menu before or not
            return false;
        }

        private void MenuBtn_Click(object sender, EventArgs e)
        {
            var isMenuExist = CheckMenuIsExist();
            var menuViewMode = isMenuExist ? MenuViewType.EditMode : MenuViewType.AddMode;
            // empty guid replace with resturant guid
            Form menuForm = new MenuForm(menuViewMode, Guid.Empty);
            this.Hide();
            menuForm.Show();
        }

        private void ShowInvoicesBtn_Click(object sender, EventArgs e)
        {
            Form invoiceForm = new InvoicesForm();
            this.Hide();
            invoiceForm.Show();
        }
    }
}
