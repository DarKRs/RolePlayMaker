using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

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
            string Magazine = MagazineText.Text;
            string Fraction = FractionText.Text;
            string Subclass = SubClassText.Text;
            
            int num;
            List<string> data = new List<string>();
            string spreedsheetId = "";
            string ClassEng="";
            if (Class != "Холодное оружие") {
                if (Name == "" || Class == "" || Price == "" || Description == "" || Ammo == "" || Damage == "" || Magazine == "" || Fraction == "" || Subclass == "")
                {
                    MessageBox.Show("Введена не вся информация",
                         "Все пошло по пизде", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!(int.TryParse(Magazine, out num)) || !(int.TryParse(Price, out num)))
                {
                    MessageBox.Show("Только числовые значения в уроне и стоимости!",
                         "Не твори хуйню блять!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                data = new List<string>() { Name, Damage, Description, Ammo, Magazine, Price, Fraction };
                spreedsheetId = Loader.WEAPON_SPREADSHEET;
                ClassEng = "Weapon";
            }
            else if(Class == "Холодное оружие")
            {
                if (Name == "" || Class == "" || Price == "" || Description == "" ||  Damage == "" ||  Fraction == "" || Subclass == "")
                {
                    MessageBox.Show("Введена не вся информация",
                         "Все пошло по пизде", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (!(int.TryParse(Price, out num)))
                {
                    MessageBox.Show("Только числовые значения в уроне и стоимости!",
                         "Не твори хуйню блять!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                data = new List<string>() { Name, Damage, Description, Price, Fraction };
                spreedsheetId = Loader.COLD_WEAPON_SPREADSHEET;
                ClassEng = "ColdWeapon";
            }

            StatusLabel.Text = "Записываем информацию...";

            Loader ld = Loader.GetLoader();
            ld.AddToDatabase(data, spreedsheetId, Subclass, ClassEng);

            StatusLabel.Text = "Информация записана!";

            NameText.Text = ""; AmmoText.Text = ""; PriceText.Text = ""; DescriptionText.Text = ""; DamageText.Text = "";
        }

        private void ClassCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SubClassText.Items.Clear();
            AmmoText.ReadOnly = false;
            MagazineText.ReadOnly = false;
            switch (ClassCombo.Text)
            {
                case "Холодное оружие":
                    string[] cold = { "Дубины и молоты", "Кастеты и подобное", "Ножи", "Двуручное холодное оружие", "Копья", "Другое" };
                    SubClassText.Items.AddRange(cold);
                    AmmoText.ReadOnly = true;
                    MagazineText.ReadOnly = true;
                    break;
                case "Легкое оружие":
                    string[] light = { "Пистолеты", "Винтовки и автоматы", "Пистолеты-Пулеметы", "Дробовики" };
                    SubClassText.Items.AddRange(light);
                    break;
                case "Тяжелое оружие":
                    string[] heavy = { "Тяжелое оружие" };
                    SubClassText.Items.AddRange(heavy);
                    break;
                case "Энергетическое оружие":
                    string[] energy = { "Энергетические пистолеты", "Энергетические ружья", "Тяжелое энергетическое оружие ", "Силовое холодное оружие" };
                    SubClassText.Items.AddRange(energy);
                    break;
            }
        } 
            
        
    }
}
