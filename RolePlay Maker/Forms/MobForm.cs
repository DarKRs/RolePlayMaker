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
        int leng = Entity.Entitys.Count();
        public MobForm()
        {
            InitializeComponent(); 
        }

        private void MobTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            for (int i = 0; i < leng; i++)
            {
                if (MobTree.SelectedNode.Text != Entity.Entitys[i].name) { continue; }
                Mob Mb = ((Mob)Entity.Entitys[i]);
                NameText.Text = Mb.name;
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
                if (Entity.Entitys[i].Type != "Mob") { continue; }
                MobTree.Nodes.Add(Entity.Entitys[i].name);
            }
        }
    }
}
