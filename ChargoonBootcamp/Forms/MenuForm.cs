using System.Windows.Forms;
using UI.Enumration;

namespace UI
{
    public partial class MenuForm : Form
    {
        public MenuForm(MenuViewType viewMode)
        {
            InitializeComponent();
            CustomizeFormDynamic(viewMode);
            MenuForm_Load();
        }

        private void MenuForm_Load()
        {
            //just for test
           // MenuDataGrid.DataSource = new List<object>();
        }

        private void CustomizeFormDynamic(MenuViewType viewMode)
        {
            if (viewMode == MenuViewType.ReadOnlyMode)
            {
                MenuSubmitBtn.Text = "تکمبل خرید";
                MenuDataGrid.ReadOnly = true;
                MenuDataGrid.Columns["Count"].ReadOnly = false;
            }
            else
            {
                MenuSubmitBtn.Text = viewMode == MenuViewType.AddMode ? "ثبت منو" : "ویرایش منو";
                MenuDataGrid.Columns.Remove(Add);
                MenuDataGrid.Columns.Remove(Minus);
                MenuDataGrid.Columns.Remove(Count);
            }
        }

    }
}
