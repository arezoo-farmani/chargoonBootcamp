using Domain.Models;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp_Restaurant.Forms
{
    public partial class FoodMenu : Form
    {
        public FoodMenu()
        {
            InitializeComponent();

        }
        public FoodMenu(string foodName, decimal foodPrice)
        {
            InitializeComponent();
            FoodNameText.Text = foodName;
            FoodPriceText.Text = foodPrice.ToString();
        }

        private void FoodMenu_Load(object sender, EventArgs e)
        {

            if (FoodNameText.Text == "" && FoodPriceText.Text == "")
            {
                EditBtn.Enabled = false;
            }
            else
            {
                EditBtn.Enabled = true;
            }
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
                Price = decimal.Parse(FoodPriceText.Text)

            };
            // using service layer
           // DataRepository<Food> dataRepository = new DataRepository<Food>();
          //  dataRepository.Save(food);
            MessageBox.Show("Food Has Been Registered successfully.");
        }

        private void ListMenuBtn_Click(object sender, EventArgs e)
        {
            FoodListMenu foodListMenu = new Forms.FoodListMenu();
            foodListMenu.ShowDialog();
            EditBtn.Enabled = true;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {


        }
    }
}
