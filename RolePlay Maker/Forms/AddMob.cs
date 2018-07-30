using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

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
            if ( !(int.TryParse(HP, out num)) || !(int.TryParse(KB, out num)))
            {
                MessageBox.Show("Только числовые значения в уроне, хп и КБ!",
                     "Не твори хуйню блять!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<string> data = new List<string>() { Name, KB, HP, Description, Damage };

            StatusLabel.Text = "Записываем информацию...";

            Loader ld = Loader.GetLoader();
            ld.AddToDatabase(data, Loader.MOB_SPREADSHEET, "Mob", "Mob");

            StatusLabel.Text = "Информация записана!";

            NameText.Text = ""; HpText.Text = ""; KBText.Text = ""; DamageText.Text = ""; DescriptionText.Text = "";
        }
    }
}
