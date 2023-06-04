using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using UI;
using Newtonsoft.Json;
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
            string jsonData = File.ReadAllText(@"C:\Users\Administrator\Desktop\food.json");
            List<string> listFood = JsonConvert.DeserializeObject<List<string>>(jsonData);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
       
    }
}
