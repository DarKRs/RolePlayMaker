using System;
using System.Linq;
using System.Windows.Forms;

namespace RolePlay_Maker
{
    public partial class WeaponInfo : Form
    {
        MainForm main;
        int leng = Item.WeaponList.Count();
        public WeaponInfo()
        {
            InitializeComponent();
            main = this.Owner as MainForm;

        }

        private void WeaponInfo_Load(object sender, EventArgs e)
        {
            TreeNode ColdWeaponNode = new TreeNode("Холодное оружие");
            TreeNode LightWeaponNode = new TreeNode("Легкое оружие");
            TreeNode HeavyWeaponNode = new TreeNode("Тяжелое оружие");
            TreeNode EnergyWeaponNode = new TreeNode("Энергетическое оружие");
            //////////////////////////////////
            TreeNode Hammers = new TreeNode("Дубины и молоты");
            TreeNode Knukles = new TreeNode("Кастеты и подобное");
            TreeNode Knifes = new TreeNode("Ножи");
            TreeNode Two_handed = new TreeNode("Двуручное холодное оружие");
            TreeNode Spears = new TreeNode("Копья");
            TreeNode Other = new TreeNode("Другое");
            //////////////////////////////////
            TreeNode Pistols = new TreeNode("Пистолеты");
            TreeNode Rife = new TreeNode("Винтовки и автоматы");
            TreeNode MachinePistol = new TreeNode("Пистолеты-пулеметы");
            TreeNode Shotgun = new TreeNode("Дробовики");
            //////////////////////////////////
            TreeNode EnergyPistols = new TreeNode("Энергетические пистолеты");
            TreeNode EnergyRife = new TreeNode("Энергетические винтовки");
            TreeNode HeavyEnergyWeapon = new TreeNode("Тяжелое энергетическое оружие");
            TreeNode PowerColdWeapon = new TreeNode("Силовое холодное оружие");
            for (int i = 0; i < leng; i++)
            {
                Weapon wp = Item.WeaponList[i];
                switch (wp.Subclass) {
                    case "Дубины и молоты": Hammers.Nodes.Add(new TreeNode(wp.Name)); continue;
                    case "Кастеты и подобное": Knukles.Nodes.Add(new TreeNode(wp.Name)); continue;
                    case "Ножи": Knifes.Nodes.Add(new TreeNode(wp.Name)); continue;
                    case "Двуручное холодное оружие": Two_handed.Nodes.Add(new TreeNode(wp.Name)); continue;
                    case "Копья": Spears.Nodes.Add(new TreeNode(wp.Name)); continue;
                    case "Другое": Other.Nodes.Add(new TreeNode(wp.Name)); continue;
                    //////////////////////////
                    case "Пистолеты": Pistols.Nodes.Add(new TreeNode(wp.Name)); continue;
                    case "Винтовки и автоматы": Rife.Nodes.Add(new TreeNode(wp.Name)); continue;

                    case "Пистолеты-Пулеметы": MachinePistol.Nodes.Add(new TreeNode(wp.Name)); continue;
                    case "Дробовики": Shotgun.Nodes.Add(new TreeNode(wp.Name)); continue;
                    /////////////////////////
                    case "Тяжелое оружие": HeavyWeaponNode.Nodes.Add(new TreeNode(wp.Name)); continue;
                    case "Энергетические пистолеты": EnergyPistols.Nodes.Add(new TreeNode(wp.Name)); continue;
                    case "Энергетические ружья": EnergyRife.Nodes.Add(new TreeNode(wp.Name)); continue;
                    case "Тяжелое энергетическое оружие": HeavyEnergyWeapon.Nodes.Add(new TreeNode(wp.Name)); continue;
                    case "Силовое холодное оружие": PowerColdWeapon.Nodes.Add(new TreeNode(wp.Name)); continue;
                    default: continue;
                }
            }
            WeaponTree.Nodes.Add(ColdWeaponNode);
            WeaponTree.Nodes.Add(LightWeaponNode);
            WeaponTree.Nodes.Add(HeavyWeaponNode);
            WeaponTree.Nodes.Add(EnergyWeaponNode);
            /////////////////////
            ColdWeaponNode.Nodes.Add(Hammers);
            ColdWeaponNode.Nodes.Add(Knukles);
            ColdWeaponNode.Nodes.Add(Knifes);
            ColdWeaponNode.Nodes.Add(Two_handed);
            ColdWeaponNode.Nodes.Add(Spears);
            ColdWeaponNode.Nodes.Add(Other);
            /////////
            LightWeaponNode.Nodes.Add(Pistols);
            LightWeaponNode.Nodes.Add(Rife);
            LightWeaponNode.Nodes.Add(MachinePistol);
            LightWeaponNode.Nodes.Add(Shotgun);
            /////////
            EnergyWeaponNode.Nodes.Add(EnergyPistols);
            EnergyWeaponNode.Nodes.Add(EnergyRife);
            EnergyWeaponNode.Nodes.Add(HeavyEnergyWeapon);
            EnergyWeaponNode.Nodes.Add(PowerColdWeapon);
        }

        private void ArmorTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
             for (int i = 0; i < leng; i++)
            {
                if (WeaponTree.SelectedNode.Text != Item.WeaponList[i].Name) { continue; }
                Weapon wp = Item.WeaponList[i];
                NameText.Text = wp.Name;
                DamageText.Text = wp.RandomDamage + "+" + wp.PermanentDamage.ToString();
                AmmoText.Text = wp.AmmoType;
                Magazine.Text = wp.Magazine.ToString();
                PriceText.Text = wp.Price.ToString();
                Fraction.Text = wp.Fraction;
                DescriptionText.Text = wp.Description;
            }
        }

        private void DescriptionText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NameText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
