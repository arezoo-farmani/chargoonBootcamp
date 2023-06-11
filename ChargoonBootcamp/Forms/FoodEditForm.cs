using System;
using System.Windows.Forms;
using Service;
using Domain.Models;
using Domain.Handler;
using Domain.Enumration;

namespace UI
{
    public partial class FoodEditForm : Form
    {
        private static Food _editedFood;
        public FoodEditForm(Food food)
        {
            InitializeComponent();
            _editedFood = food;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            FoodService foodService = new FoodService();
            Food food = new Food
            {
                Guid = _editedFood.Guid,
                FoodName = FoodNameText.Text,
                Price = decimal.Parse(FoodPriceText.Text),
                RestaurantGuid = _editedFood.RestaurantGuid,
            };
            foodService.Update(food);
            string foodEditMessage = MessageHandler.GetMessage(MessageType.FoodEditFormSubmitOk);
            MessageBox.Show(foodEditMessage);
            this.Close();
        }

        private void FoodEditForm_Load(object sender, EventArgs e)
        {
            FoodNameText.Text = _editedFood.FoodName;
            FoodPriceText.Text = _editedFood.Price.ToString();
        }
    }
}
