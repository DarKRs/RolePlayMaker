using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RolePlay_Maker
{
    public partial class AddArmor : Form
    {
        MainForm main;
        public AddArmor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main = this.Owner as MainForm;
            string Name = NameText.Text;
            string KB = KBText.Text;
            string Type = TypeText.Text;
            string Fraction = FractionText.Text;
            string AP = PUText.Text;
            string Price = PriceText.Text;
            string Description = DescriptionText.Text;
            string Effects = EffectsText.Text;
            if (Name == "" || AP =="" || Price =="" || Description =="" || KB =="" || Type == "" || Fraction == "")
            {
                MessageBox.Show("Введена не вся информация",
                     "Все пошло по пизде", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!(int.TryParse(AP, out int num)) || !(int.TryParse(Price, out num)) || !(int.TryParse(KB, out num)))
            {
                MessageBox.Show("Только числовые значения в СУ и стоимости!",
                     "Не твори хуйню блять!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<string> data = new List<string>() {Name,KB,AP,Description,Effects,Price,Fraction };

            StatusLabel.Text = "Записываем информацию...";

            Loader ld = Loader.GetLoader();
            ld.AddToDatabase(data, Loader.ARMOR_SPREADSHEET ,Type, "Armor");

            StatusLabel.Text = "Информация записана!";
            //MessageBox.Show("Информация записана",
              //    "Все збс", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NameText.Text = "";PUText.Text = "";PriceText.Text = "";DescriptionText.Text = ""; EffectsText.Text = ""; KBText.Text = "";
        }

        private void AddArmor_Load(object sender, EventArgs e)
        {
            StatusLabel.Text = "";
        }
    }
}
