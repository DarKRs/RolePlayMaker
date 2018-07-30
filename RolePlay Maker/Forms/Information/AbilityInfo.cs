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
        int leng = TraitAbilityContainer.AbilityList.Count();
        public AbilityInfo()
        {
            InitializeComponent();
        }

        private void AbilityInfo_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < leng; i++)
            {
                AbilityTree.Nodes.Add(TraitAbilityContainer.AbilityList[i].Name);
            }
        }

        private void AbilityTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            for (int i = 0; i < leng; i++)
            {
                if (AbilityTree.SelectedNode.Text != TraitAbilityContainer.AbilityList[i].Name) { continue; }
                Ability Ab = TraitAbilityContainer.AbilityList[i];
                NameText.Text = Ab.Name;
                RangText.Text = Ab.rangs.ToString();
                ReqText.Text = Ab.requirement;
                DescriptionText.Text = Ab.Advantage;
            }
        }
    }
}
