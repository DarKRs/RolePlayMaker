using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace RolePlay_Maker
{
    class NPCGenerator
    {
      
            public Dictionary<int, TextBox> Names;
            public Dictionary<int, ComboBox> Armor;
            public Dictionary<int, ComboBox> Hats;
            public Dictionary<int, Label> KB;
            public Dictionary<int, Label> ArmorPU;
            public Dictionary<int, NumericUpDown> HP;
            public Dictionary<int, ComboBox> Weapon;
            public Dictionary<int, ComboBox> SecondaryWeapon;
            public Dictionary<int, Button> AttackMainWeapon;
            public Dictionary<int, Button> AttackSecondaryWeapon;
            public Dictionary<int, Button> Refresh;
            //
            public Dictionary<int, int> PermanentDamage;
            public Dictionary<int, int> RandomDamage;
            //
            private List<Armor> AvailableArmor;
            private List<Armor> AvailableHats;
            private List<Weapon> AvailableWeapon;
            private List<Weapon> AvailableSecondaryWeapon;

        public NPCGenerator(List<Armor> AvailableArmor, List<Armor> AvailableHats, List<Weapon> AvailableWeapon, List<Weapon> AvailableSecondaryWeapon)
            {
                Names = new Dictionary<int, TextBox>();
                Armor = new Dictionary<int, ComboBox>();
                Hats = new Dictionary<int, ComboBox>();
                KB = new Dictionary<int, Label>();
                ArmorPU = new Dictionary<int, Label>();
                HP = new Dictionary<int, NumericUpDown>();
                Weapon = new Dictionary<int, ComboBox>();
                SecondaryWeapon = new Dictionary<int, ComboBox>();
                AttackMainWeapon = new Dictionary<int, Button>();
                AttackSecondaryWeapon = new Dictionary<int, Button>();
                Refresh = new Dictionary<int, Button>();
                //
                this.AvailableArmor = AvailableArmor;
                this.AvailableHats = AvailableHats;
                this.AvailableWeapon = AvailableWeapon;
                this.AvailableSecondaryWeapon = AvailableSecondaryWeapon;
            }

            public void SetParams_Human(string Fraction, int count)
            {
                int rnd;
                int KBValue;
                int PUValue;
                Random random = new Random();
                for (int i = 0; i < count; i++)
                {
                    KBValue = 0;
                    PUValue = 0;
                    //
                    Names.Add(i, new TextBox());
                    Names[i].Text = NameGenerator.Generate();
                    //
                    Armor.Add(i, new ComboBox());
                    Armor[i].Items.AddRange(AvailableArmor.Select(x => x.Name).ToArray());
                    rnd = random.Next(0, AvailableArmor.Count);
                    Armor[i].Text = AvailableArmor[rnd].Name;
                    Armor[i].Name = Armor[i].Name + "Armor";
                    Armor[i].SelectedValueChanged += SelectedArmorChanged;
                    KBValue += AvailableArmor[rnd].KB;
                    PUValue += AvailableArmor[rnd].AP;
                    //
                    Hats.Add(i, new ComboBox());
                    Hats[i].Items.AddRange(AvailableHats.Select(x => x.Name).ToArray());
                    rnd = random.Next(0, AvailableHats.Count);
                    Hats[i].Text = AvailableHats[rnd].Name;
                    Hats[i].Name = Hats[i].Name + "Hats";
                    Hats[i].SelectedValueChanged += SelectedArmorChanged;
                    KBValue += AvailableHats[rnd].KB;
                    PUValue += AvailableHats[rnd].AP;
                    //
                    KB.Add(i, new Label());
                    KB[i].AutoSize = true;
                    KB[i].Text = KBValue.ToString();
                    //
                    ArmorPU.Add(i, new Label());
                    ArmorPU[i].AutoSize = true;
                    ArmorPU[i].Text = PUValue.ToString();
                    //
                    HP.Add(i, new NumericUpDown());
                    HP[i].Width = 50;
                    HP[i].Value = new Random().Next(30, 75);
                    // 
                    Weapon.Add(i, new ComboBox());
                    Weapon[i].Items.AddRange(AvailableWeapon.Select(x => x.Name).ToArray());
                    rnd = random.Next(0, AvailableWeapon.Count);
                    Weapon[i].Text = AvailableWeapon[rnd].Name;
                    //TODO: Damage for Button Attack!
                    //
                    SecondaryWeapon.Add(i, new ComboBox());
                    SecondaryWeapon[i].Items.AddRange(AvailableWeapon.Select(x => x.Name).ToArray());
                    rnd = random.Next(0, AvailableSecondaryWeapon.Count);
                    SecondaryWeapon[i].Text = AvailableSecondaryWeapon[rnd].Name;
                    //
                    AttackMainWeapon.Add(i, new Button());
                    AttackMainWeapon[i].Text = "Атака основным оружием";
                    AttackMainWeapon[i].AutoSize = true;
                    AttackMainWeapon[i].Click += new EventHandler(AttackMainWeapon_Click);
                    //
                    AttackSecondaryWeapon.Add(i, new Button());
                    AttackSecondaryWeapon[i].Text = "Атака второспенным оружием";
                    AttackSecondaryWeapon[i].AutoSize = true;
            }
        }

        private void SelectedArmorChanged(object sender, EventArgs e)
        {
            Dictionary<int, ComboBox> container = new Dictionary<int, ComboBox>();
            ComboBox selectedCombobox = (ComboBox)sender;
            //determine which dictionary we should use for search a key
            if (selectedCombobox.Name.Contains("Armor"))
                container = Armor;
            else if (selectedCombobox.Name.Contains("Hats"))
                container = Hats;

            int key = -1;
            for (int i = 0; i < container.Count; i++)
            {
                if (container[i] == selectedCombobox)
                {
                    key = i;
                    break;
                }
            }

            int KBValue = 0;
            int PUValue = 0;
            for (int i = 0; i < AvailableArmor.Count; i++)
            {
                if(AvailableArmor[i].Name == Armor[key].Text)
                {
                    KBValue += AvailableArmor[i].KB;
                    PUValue += AvailableArmor[i].AP;
                    break;
                }
            }
            for (int i = 0; i < AvailableHats.Count; i++)
            {
                if (AvailableHats[i].Name == Hats[key].Text)
                {
                    KBValue += AvailableHats[i].KB;
                    PUValue += AvailableHats[i].AP;
                    break;
                }
            }

            KB[key].Text = KBValue.ToString();
            ArmorPU[key].Text = PUValue.ToString();
        }


        private void AttackMainWeapon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Knopka");
        }


    }
}
