using System.Windows.Forms;
using UI.Enumration;

namespace UI
{
    public partial class MenuForm : Form
    {
        public static MenuViewType FormViewMode;
        public MenuForm(MenuViewType viewMode)
        {
            InitializeComponent();
            FormViewMode = viewMode;
            CustomizeFormDynamic();
            MenuForm_Load();
        }

        private void MenuForm_Load()
        {
            //just for test
            // MenuDataGrid.DataSource = new List<object>();
        }

        private void CustomizeFormDynamic()
        {
            if (FormViewMode == MenuViewType.OrderMode)
            {
                MenuSubmitBtn.Text = "تکمبل خرید";
                MenuDataGrid.ReadOnly = true;
                MenuDataGrid.Columns["Count"].ReadOnly = false;
            }
            else
            {
                MenuSubmitBtn.Text = FormViewMode == MenuViewType.AddMode ? "ثبت منو" : "ویرایش منو";
                MenuDataGrid.Columns.Remove(Add);
                MenuDataGrid.Columns.Remove(Minus);
                MenuDataGrid.Columns.Remove(Count);
            }
        }

        private void MenuSubmitBtn_Click(object sender, System.EventArgs e)
        {
            if (FormViewMode == MenuViewType.AddMode)
            {
                // by hossein
            }
            else if (FormViewMode == MenuViewType.EditMode)
            {
                // by hosein
            }
            else if (FormViewMode == MenuViewType.OrderMode)
            {
                handleShowOrderBasketForm();
            }
        }

        private void handleShowOrderBasketForm()
        {
            this.Hide();
            Form orderBasketForm = new OrderBasketForm();
            orderBasketForm.Show();
        }
    }
}
