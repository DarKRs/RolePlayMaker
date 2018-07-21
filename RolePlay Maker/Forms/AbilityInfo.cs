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
    public partial class AbilityInfo : Form
    {
        int leng = Entity.Entitys.Count();
        public AbilityInfo()
        {
            InitializeComponent();
        }

        private void AbilityInfo_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < leng; i++)
            {
                if (Entity.Entitys[i].Type != "Ability") { continue; }
                AbilityTree.Nodes.Add(Entity.Entitys[i].name);
            }
        }

        private void AbilityTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            for (int i = 0; i < leng; i++)
            {
                if (AbilityTree.SelectedNode.Text != Entity.Entitys[i].name) { continue; }
                Ability Ab = ((Ability)Entity.Entitys[i]);
                NameText.Text = Ab.name;
                RangText.Text = Ab.rangs.ToString();
                ReqText.Text = Ab.requirement;
                DescriptionText.Text = Ab.Description;
            }
        }
    }
}
