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
            string AP = PUText.Text;
            string Price = PriceText.Text;
            string Description = DescriptionText.Text;
            if (Name == "" || AP =="" || Price =="" || Description =="")
            {
                MessageBox.Show("Введена не вся информация",
                     "Все пошло по пизде", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int num;
            if (!(int.TryParse(AP, out num)) || !(int.TryParse(Price, out num)))
            {
                MessageBox.Show("Только числовые значения в СУ и стоимости!",
                     "Не твори хуйню блять!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Name.Contains("$") || Name.Contains("&") || AP.Contains("$") || AP.Contains("&") || Price.Contains("$") || Price.Contains("&") || Description.Contains("$") || Description.Contains("&"))
            {
                MessageBox.Show("Нельзя использовать знаки $ или & , уебок",
                     "Не твори хуйню блять!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string all = "& \n" + Name + "$" + AP + "$" + Price + "$" + Description;
            string path = System.IO.Directory.GetCurrentDirectory() + @"\" + "Armor.txt";
           
                FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                StreamWriter writer = new StreamWriter(fs); //создаем «потоковый писатель» и связываем его с файловым потоком 
                writer.Write(all); //записываем в файл
                writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 
            
            
            main.RefreshData();
            MessageBox.Show("Информация записана",
                  "Все збс", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NameText.Text = "";PUText.Text = "";PriceText.Text = "";DescriptionText.Text = "";
        }
    }
}
