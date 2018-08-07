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
        int leng = Item.Entities.Count();
        public AbilityInfo()
        {
            InitializeComponent();
        }

        private void AbilityInfo_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < leng; i++)
            {
                if (Item.Entities[i].Type != "Ability") { continue; }
                AbilityTree.Nodes.Add(Item.Entities[i].Name);
            }
        }

        private void AbilityTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            for (int i = 0; i < leng; i++)
            {
                if (AbilityTree.SelectedNode.Text != Item.Entities[i].Name) { continue; }
                Ability Ab = ((Ability)Item.Entities[i]);
                NameText.Text = Ab.Name;
                RangText.Text = Ab.rangs.ToString();
                ReqText.Text = Ab.requirement;
                DescriptionText.Text = Ab.Description;
            }
        }
    }
}
