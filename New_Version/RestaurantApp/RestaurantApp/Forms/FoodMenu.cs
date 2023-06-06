﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp.UILayer.Forms
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

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {

        }

        private void ListMenuBtn_Click(object sender, EventArgs e)
        {
            FoodListMenu foodListMenu = new Forms.FoodListMenu();
            foodListMenu.ShowDialog();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {

        }
    }
}