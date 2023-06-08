using Domain.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp_Restaurant.Forms
{
    public partial class FoodListMenu : Form
    {
        public FoodListMenu()
        {
            InitializeComponent();
        }

        private void FoodListMenu_Load(object sender, EventArgs e)
        {
            List<Food> food = new List<Food>();
           // DataRepository<Food> dataRepository = new DataRepository<Food>();
           // food = dataRepository.GetAll();
            FoodGridView.DataSource = food;
            FoodGridView.Columns["Guid"].Visible = false;
            FoodGridView.Columns[0].HeaderText = "نام غذا";
            FoodGridView.Columns[1].HeaderText = "قیمت";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            FoodMenu foodMenu = new FoodMenu(FoodGridView[0, FoodGridView.CurrentRow.Index].Value.ToString(), (decimal)(FoodGridView[1, FoodGridView.CurrentRow.Index].Value));
            foodMenu.ShowDialog();
        }
    }
}
