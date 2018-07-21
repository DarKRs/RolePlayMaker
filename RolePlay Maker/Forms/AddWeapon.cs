using System;
using System.Windows.Forms;
using System.IO;

namespace RolePlay_Maker
{
    public partial class AddWeapon : Form
    {
        MainForm main;
        public AddWeapon()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            main = this.Owner as MainForm;
            string Name = NameText.Text;
            string Class = ClassCombo.Text;
            string Ammo = AmmoText.Text;
            string Damage = DamageText.Text;
            string Price = PriceText.Text;
            string Description = DescriptionText.Text;
            if (Name == "" || Class == "" || Price == "" || Description == "" || Ammo == "" || Damage == "")
            {
                MessageBox.Show("Введена не вся информация",
                     "Все пошло по пизде", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int num;
            if (!(int.TryParse(Damage, out num)) || !(int.TryParse(Price, out num)))
            {
                MessageBox.Show("Только числовые значения в уроне и стоимости!",
                     "Не твори хуйню блять!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
                if (Name.Contains("$") || Name.Contains("&") || Ammo.Contains("$") || Ammo.Contains("&") || Damage.Contains("$") || Damage.Contains("&") || Price.Contains("$") || Price.Contains("&") || Description.Contains("$") || Description.Contains("&"))
            {
                MessageBox.Show("Нельзя использовать знаки $ или & , уебок",
                     "Не твори хуйню блять!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string all = "& \n" + Class + "$" + Name + "$" + Damage + "$" + Ammo + "$" + Price + "$" + Description;
            string path = System.IO.Directory.GetCurrentDirectory() + @"\" + "Weapons.txt";

            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs); //создаем «потоковый писатель» и связываем его с файловым потоком 
            writer.Write(all); //записываем в файл
            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 


            main.RefreshData();
            MessageBox.Show("Информация записана",
                  "Все збс", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NameText.Text = ""; AmmoText.Text = ""; PriceText.Text = ""; DescriptionText.Text = ""; DamageText.Text = "";
        }
    }
}
