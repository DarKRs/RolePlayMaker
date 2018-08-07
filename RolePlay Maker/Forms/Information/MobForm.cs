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
<<<<<<< HEAD:RolePlay Maker/Forms/MobForm.cs
        int leng = Item.Entities.Count();
=======
        int leng = Entity.MobList.Count();
>>>>>>> 2a605b63a3e87d196fc737b6fe04d36f45a4c630:RolePlay Maker/Forms/Information/MobForm.cs
        public MobForm()
        {
            InitializeComponent(); 
        }

        private void MobTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            for (int i = 0; i < leng; i++)
            {
<<<<<<< HEAD:RolePlay Maker/Forms/MobForm.cs
                if (MobTree.SelectedNode.Text != Item.Entities[i].Name) { continue; }
                Mob Mb = ((Mob)Item.Entities[i]);
=======
                if (MobTree.SelectedNode.Text != Entity.MobList[i].Name) { continue; }
                Mob Mb = Entity.MobList[i];
>>>>>>> 2a605b63a3e87d196fc737b6fe04d36f45a4c630:RolePlay Maker/Forms/Information/MobForm.cs
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
<<<<<<< HEAD:RolePlay Maker/Forms/MobForm.cs
                if (Item.Entities[i].Type != "Mob") { continue; }
                MobTree.Nodes.Add(Item.Entities[i].Name);
=======
                MobTree.Nodes.Add(Entity.MobList[i].Name);
>>>>>>> 2a605b63a3e87d196fc737b6fe04d36f45a4c630:RolePlay Maker/Forms/Information/MobForm.cs
            }
        }
    }
}
