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
    public partial class MenuFormTest : Form
    {
        public MenuFormTest()
        {
            InitializeComponent();
        }

        private void FoodMenuBtn_Click(object sender, EventArgs e)
        {
            FoodMenu foodMenu = new FoodMenu();
            foodMenu.ShowDialog();
        }

        private void FactorListBtn_Click(object sender, EventArgs e)
        {
            FactorsListForm factorList = new FactorsListForm();
            factorList.ShowDialog();
        }
    }
}
