using Repository;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using Service;
using Newtonsoft.Json.Linq;

namespace WindowsFormsApp_Restaurant.Forms
{
    public partial class FoodMenu : Form
    {
        public FoodMenu()
        {
            InitializeComponent();

        }
        public FoodMenu(string foodName,decimal foodPrice)
        {
            InitializeComponent();
            FoodNameText.Text = foodName;
            FoodPriceText.Text = foodPrice.ToString();
        }
       
        private void FoodMenu_Load(object sender, EventArgs e)
        {
           
            if(FoodNameText.Text =="" && FoodPriceText.Text=="")
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
            DataRepository<Food> dataRepository = new DataRepository<Food>();
            dataRepository.Save(food);
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
