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
    public partial class MobForm : Form
    {
        int leng = Item.Entities.Count();
        public MobForm()
        {
            InitializeComponent(); 
        }

        private void MobTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            for (int i = 0; i < leng; i++)
            {
                if (MobTree.SelectedNode.Text != Item.Entities[i].Name) { continue; }
                Mob Mb = ((Mob)Item.Entities[i]);
                NameText.Text = Mb.Name;
                HpText.Text = Mb.HP.ToString();
                KBText.Text = Mb.KB.ToString();
                DamageText.Text = Mb.Damage.ToString();
                DescriptionText.Text = Mb.Description;
            }
        }

        private void MobForm_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < leng; i++)
            {
                if (Item.Entities[i].Type != "Mob") { continue; }
                MobTree.Nodes.Add(Item.Entities[i].Name);
            }
        }
    }
}
