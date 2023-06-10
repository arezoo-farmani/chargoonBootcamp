using Domain.Models;
using System;
using System.Windows.Forms;
using Service;

namespace WindowsFormsApp_Restaurant.Forms
{
    public partial class FoodMenu : Form
    {
        private static Guid _restaurantGuid;
        public FoodMenu()
        {
            InitializeComponent();

        }
        public FoodMenu(Guid Guid)
        {
            InitializeComponent();
            _restaurantGuid = Guid;
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            Food food = new Food
            {
                Guid = Guid.NewGuid(),
                FoodName = FoodNameText.Text,
                Price = decimal.Parse(FoodPriceText.Text),
                RestaurantGuid = _restaurantGuid
            };
            FoodService foodService = new FoodService();
            foodService.Save(food);
            MessageBox.Show("Food Has Been Registered successfully.");
        }
        private void ListMenuBtn_Click_1(object sender, EventArgs e)
        {
            FoodListMenu foodListMenu = new Forms.FoodListMenu();
            foodListMenu.ShowDialog();
        }
    }
}
