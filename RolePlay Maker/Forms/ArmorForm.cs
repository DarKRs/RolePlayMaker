using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RolePlay_Maker
{
    public partial class ArmorForm : Form
    {
        MainForm main;
        int leng = Entity.Armor.Count();
        public ArmorForm()
        {
            InitializeComponent();
            main = this.Owner as MainForm;
            
        }

        private void Armor_Load(object sender, EventArgs e)
        {
            TreeNode ClothesNode = new TreeNode("Одежда");
            // Добавляем новый дочерний узел к tovarNode
            TreeNode LightArmorNode = new TreeNode("Легкая броня");
            TreeNode MediumArmorNode = new TreeNode("Средняя броня");
            TreeNode HeavyArmorNode = new TreeNode("Тяжелая броня");
            TreeNode PowerArmorNode = new TreeNode("Силовая броня");
            TreeNode HatsNode = new TreeNode("Шлемы/Головные уборы и другое");
            for (int i = 0; i < leng; i++)
            {
                Armor arm = Entity.Armor[i];
                if (arm.ClassType == "Одежда")
                {
                    ClothesNode.Nodes.Add(new TreeNode(arm.name));
                }
                if (arm.ClassType == "Легкая броня")
                {
                    LightArmorNode.Nodes.Add(new TreeNode(arm.name));
                }
                if (arm.ClassType == "Средняя броня")
                {
                    MediumArmorNode.Nodes.Add(new TreeNode(arm.name));
                }
                if (arm.ClassType == "Тяжелая броня")
                {
                    HeavyArmorNode.Nodes.Add(new TreeNode(arm.name));
                }
                if (arm.ClassType == "Силовая броня")
                {
                    PowerArmorNode.Nodes.Add(new TreeNode(arm.name));
                }
                if (arm.ClassType == "Шлемы и головные уборы")
                {
                    HatsNode.Nodes.Add(new TreeNode(arm.name));
                }

            }
            ArmorTree.Nodes.Add(ClothesNode);
            ArmorTree.Nodes.Add(LightArmorNode);
            ArmorTree.Nodes.Add(MediumArmorNode);
            ArmorTree.Nodes.Add(HeavyArmorNode);
            ArmorTree.Nodes.Add(PowerArmorNode);
            ArmorTree.Nodes.Add(HatsNode);

        }

        private void ArmorTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

            for(int i=0; i < leng; i++)
            {
                if(ArmorTree.SelectedNode.Text != Entity.Armor[i].name) { continue; }
                Armor Arm= Entity.Armor[i];
                NameText.Text = Arm.name;
                PriceText.Text = Arm.Price.ToString();
                PUText.Text = Arm.AP.ToString();
                KBtextbox.Text = Arm.KB.ToString();
                DescriptionText.Text = Arm.Description + "\nЭффекты: \n" + Arm.Effects;
                Faction.Text = Arm.Fraction;
            }
            
        }

    }
}
