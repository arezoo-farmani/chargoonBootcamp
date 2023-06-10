using Domain.Models;
using System;
using System.Collections.Generic;
using Service;
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
            FoodService foodService = new FoodService();
            FoodGridView.DataSource = foodService.GetAll();
            FoodGridView.Columns["Guid"].Visible = false;
            FoodGridView.Columns["RestaurantGuid"].Visible = false;
            FoodGridView.Columns[1].HeaderText = "نام غذا";
            FoodGridView.Columns[2].HeaderText = "قیمت";
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            FoodEditForm foodEditForm = new FoodEditForm((Guid)FoodGridView[0, FoodGridView.CurrentRow.Index].Value, FoodGridView[1, FoodGridView.CurrentRow.Index].Value.ToString(), (decimal)(FoodGridView[2, FoodGridView.CurrentRow.Index].Value));
            foodEditForm.ShowDialog();
            this.Close();
        }
    }
}
