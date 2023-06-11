using System;
using Service;
using System.Windows.Forms;
using Domain.Models;

namespace UI
{
    public partial class FoodListMenu : Form
    {
        public FoodListMenu(Guid restaurantGuid)
        {
            InitializeComponent();
            FoodListMenu_Load(restaurantGuid);
        }

        private void FoodListMenu_Load(Guid restaurantGuid)
        {
            FoodService foodService = new FoodService();
            FoodGridView.DataSource = foodService.GetAllRestaurantFoods(restaurantGuid);
            FoodGridView.Columns["Guid"].Visible = false;
            FoodGridView.Columns["RestaurantGuid"].Visible = false;
            FoodGridView.Columns[2].HeaderText = "نام غذا";
            FoodGridView.Columns[3].HeaderText = "قیمت";

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Food GetSelectedFood()
        {
            return new Food()
            {
                Guid = (Guid)FoodGridView["Guid", FoodGridView.CurrentRow.Index].Value,
                FoodName = FoodGridView["FoodName", FoodGridView.CurrentRow.Index].Value.ToString(),
                Price = (decimal)(FoodGridView["Price", FoodGridView.CurrentRow.Index].Value),
                RestaurantGuid = (Guid)FoodGridView["RestaurantGuid", FoodGridView.CurrentRow.Index].Value,
            };
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            FoodEditForm foodEditForm = new FoodEditForm(GetSelectedFood());
            foodEditForm.ShowDialog();
            this.Close();
        }
    }
}
