using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using UI;
using Service;
using WindowsFormsApp_Restaurant.Properties;
using WindowsFormsApp_Restaurant;
using ResturantApp;
using System.Windows.Forms;

namespace WindowsFormsApp_Restaurant.Forms
{
    public partial class FoodMenu : Form
    {
        public FoodMenu()
        {
            InitializeComponent();
        }

        private void FoodMenu_Load(object sender, EventArgs e)
        {
            EditBtn.Enabled = false;
        }

        private void ListMenuBtn_Click(object sender, EventArgs e)
        {
            FoodListMenu foodListMenu = new Forms.FoodListMenu();
            foodListMenu.ShowDialog();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            Food food = new Food();
            if(FoodNameText.Text=="" || FoodPriceText.Text=="")
            {
                MessageBox.Show("Please Fill All The Fileds");
            }
            else
            {
                
                var data = food.GetFoodData(FoodNameText.Text, decimal.Parse(FoodPriceText.Text));
                string jsonData = JsonConvert.SerializeObject(data);
                string UserFilePath = @"C:\Users\Administrator\Desktop\food.json";
                File.AppendAllText(UserFilePath, jsonData);
                MessageBox.Show("Succesfully Added");
            }
            
        }
    }
}
