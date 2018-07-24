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
        int leng = Entity.ArmorList.Count();
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
            TreeNode HatsNode = new TreeNode("Шлемы/Головные уборы");
            TreeNode OtherNode = new TreeNode("Акссесуары");
            for (int i = 0; i < leng; i++)
            {
                Armor arm = Entity.ArmorList[i];
                switch (arm.Class)
                {
                    case "Одежда": ClothesNode.Nodes.Add(new TreeNode(arm.name)); continue;
                    case "Легкая броня": LightArmorNode.Nodes.Add(new TreeNode(arm.name)); continue;
                    case "Средняя броня": MediumArmorNode.Nodes.Add(new TreeNode(arm.name)); continue;
                    case "Тяжелая броня": HeavyArmorNode.Nodes.Add(new TreeNode(arm.name)); continue;
                    case "Силовая броня": PowerArmorNode.Nodes.Add(new TreeNode(arm.name)); continue;
                    case "Шлемы и головные уборы": HatsNode.Nodes.Add(new TreeNode(arm.name)); continue;
                    case "Акссесуары": OtherNode.Nodes.Add(new TreeNode(arm.name)); continue;
                    default: continue;
                }
            }
            ArmorTree.Nodes.Add(ClothesNode);
            ArmorTree.Nodes.Add(LightArmorNode);
            ArmorTree.Nodes.Add(MediumArmorNode);
            ArmorTree.Nodes.Add(HeavyArmorNode);
            ArmorTree.Nodes.Add(PowerArmorNode);
            ArmorTree.Nodes.Add(HatsNode);
            ArmorTree.Nodes.Add(OtherNode);

        }

        private void ArmorTree_AfterSelect(object sender, TreeViewEventArgs e)
        {

            for(int i=0; i < leng; i++)
            {
                if(ArmorTree.SelectedNode.Text != Entity.ArmorList[i].name) { continue; }
                Armor Arm= Entity.ArmorList[i];
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
