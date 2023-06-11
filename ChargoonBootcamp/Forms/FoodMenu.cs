using Domain.Models;
using Domain.Handler;
using System;
using System.Windows.Forms;
using Service;
using Domain.Enumration;
using System.Text.RegularExpressions;
using System.Drawing;

namespace UI
{
    public partial class FoodMenu : Form
    {
        private static Guid _restaurantGuid;

        public FoodMenu(Guid restaurantGuid)
        {
            InitializeComponent();
            _restaurantGuid = restaurantGuid;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (!IsValidPrice(FoodPriceText.Text))
            {
                FoodPriceText.BackColor = Color.IndianRed;
                return;
            }
            Food food = new Food
            {
                FoodName = FoodNameText.Text,
                Price = decimal.Parse(FoodPriceText.Text),
                RestaurantGuid = _restaurantGuid
            };
            FoodService foodService = new FoodService();
            foodService.Save(food);
            string foodRegMessage = MessageHandler.GetMessage(MessageType.FoodMenuSubmitOk);
            MessageBox.Show(foodRegMessage);
        }

        private void ListMenuBtn_Click_1(object sender, EventArgs e)
        {
            FoodListMenu foodListMenu = new FoodListMenu(_restaurantGuid);
            foodListMenu.ShowDialog();
        }
        private bool IsValidPrice(string foodPrice)
        {
            string onlyNumericCharectersPattern = @"^\d+$";
            return Regex.IsMatch(foodPrice, onlyNumericCharectersPattern);
        }
    }
}
