using System;
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

        private bool CheckIsAnyResturantExist()
        {
            // if no resturant registered
            MessageLabel.Text = "رستورانی در سیستم ثبت نشده است !";
            // else 
            MessageLabel.Text = "برای مشاهده منوی رستوران روی رستوران مورد نظر کلیک کنید!";
            return true;
        }

        private void AllResturantsForm_Load()
        {
            // just for test
            ResturantsList.Items.Add("Resturant1");
            ResturantsList.Items.Add("Resturant2");
        }

        private void ResturantsList_DoubleClick(object sender, EventArgs e)
        {
            if (ResturantsList.SelectedItems.Count > 0)
            {
                Form menuForm = new MenuForm(MenuViewType.ReadOnlyMode);
                menuForm.Show();
            }
        }
    }
}
