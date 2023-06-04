using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Restaurant.Forms
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

       

        private void FactorListBtn_Click(object sender, EventArgs e)
        {
            InvoicesListForm invoicesListForm = new Forms.InvoicesListForm();
            invoicesListForm.ShowDialog();
        }

        private void FoodMenuBtn_Click(object sender, EventArgs e)
        {
            FoodMenu foodMenu = new Forms.FoodMenu();
            foodMenu.ShowDialog();
        }
    }
}
