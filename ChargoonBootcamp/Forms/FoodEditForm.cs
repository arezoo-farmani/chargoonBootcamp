using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;
using Domain.Models;

namespace WindowsFormsApp_Restaurant.Forms
{
    public partial class FoodEditForm : Form
    {
        private static Guid _foodGuid;
        private static string _foodName;
        private static decimal _foodPrice;
        public FoodEditForm(Guid Guid,string foodName,decimal foodPrice)
        {
            InitializeComponent();
            _foodGuid = Guid;
            _foodName = foodName;
            _foodPrice = foodPrice;
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
                Guid = _foodGuid,
                FoodName = FoodNameText.Text,
                Price = decimal.Parse(FoodPriceText.Text)
            };
            foodService.Update(food);
            MessageBox.Show("تغییرات با موفقیت اعمال شد");
            this.Close();
        }

        private void FoodEditForm_Load(object sender, EventArgs e)
        {
            FoodNameText.Text = _foodName;
            FoodPriceText.Text = _foodPrice.ToString();
        }
    }
}
