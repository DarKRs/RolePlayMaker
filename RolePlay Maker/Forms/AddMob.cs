using System;
using System.Windows.Forms;
using System.IO;

namespace RolePlay_Maker
{
    public partial class AddMob : Form
    {
        MainForm main;
        public AddMob()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main = this.Owner as MainForm;
            string Name = NameText.Text;
            string HP = HpText.Text;
            string KB = KBText.Text;
            string Damage = DamageText.Text;
            string Description = DescriptionText.Text;
            if (Name == "" || HP == "" || KB == "" || Damage == "" || Description == "")
            {
                MessageBox.Show("Введена не вся информация",
                     "Все пошло по пизде", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int num;
            if (!(int.TryParse(Damage, out num)) || !(int.TryParse(HP, out num)) || !(int.TryParse(KB, out num)))
            {
                MessageBox.Show("Только числовые значения в уроне, хп и КБ!",
                     "Не твори хуйню блять!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (Name.Contains("$") || Name.Contains("&") || HP.Contains("$") || HP.Contains("&") || Damage.Contains("$") || Damage.Contains("&") || KB.Contains("$") || KB.Contains("&") || Description.Contains("$") || Description.Contains("&"))
            {
                MessageBox.Show("Нельзя использовать знаки $ или & , уебок",
                     "Не твори хуйню блять!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string all = "& \n" + Name + "$" + HP + "$" + KB + "$" + Damage + "$" + Description;
            string path = System.IO.Directory.GetCurrentDirectory() + @"\" + "Mob.txt";

            FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs); //создаем «потоковый писатель» и связываем его с файловым потоком 
            writer.Write(all); //записываем в файл
            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 


            main.RefreshData();
            MessageBox.Show("Информация записана",
                  "Все збс", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NameText.Text = ""; HpText.Text = ""; KBText.Text = ""; DamageText.Text = ""; DescriptionText.Text = "";
        }
    }
}
