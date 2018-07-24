using System;
using System.Linq;
using System.Windows.Forms;

namespace RolePlay_Maker
{
    public partial class WeaponInfo : Form
    {
        MainForm main;
        int leng = Entity.Entitys.Count();
        public WeaponInfo()
        {
            InitializeComponent();
            main = this.Owner as MainForm;

        }

        private void WeaponInfo_Load(object sender, EventArgs e)
        {

            TreeNode LightWeaponNode = new TreeNode("Легкое оружие");
            TreeNode HeavyWeaponNode = new TreeNode("Тяжелое оружие");
            TreeNode ColdWeaponNode = new TreeNode("Холодное оружие");
            for (int i = 0; i < leng; i++)
            {
                if (Entity.Entitys[i].Type != "Weapon") { continue; }
                Weapon wp = ((Weapon)Entity.Entitys[i]);
                if (wp.Class=="Легкое оружие")
                {
                    LightWeaponNode.Nodes.Add(new TreeNode(wp.name));
                }
                if (wp.Class == "Холодное оружие")
                {
                    ColdWeaponNode.Nodes.Add(new TreeNode(wp.name));
                }
                if (wp.Class == "Тяжелое оружие")
                {
                    HeavyWeaponNode.Nodes.Add(new TreeNode(wp.name));
                }

            }
            WeaponTree.Nodes.Add(LightWeaponNode);
            WeaponTree.Nodes.Add(HeavyWeaponNode);
            WeaponTree.Nodes.Add(ColdWeaponNode);
        }

        private void ArmorTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
             for (int i = 0; i < leng; i++)
            {
                if (WeaponTree.SelectedNode.Text != Entity.Entitys[i].name) { continue; }
                Weapon wp = ((Weapon)Entity.Entitys[i]);
                NameText.Text = wp.name;
                PriceText.Text = wp.Price.ToString();
                DamageText.Text = wp.PermanentDamage.ToString();
                AmmoText.Text = wp.AmmoType;
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
