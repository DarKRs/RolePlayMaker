using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RolePlay_Maker.Forms.Information
{
    public partial class TraitInfo : Form
    {
        int leng = TraitAbilityContainer.TraitList.Count();
        public TraitInfo()
        {
            InitializeComponent();
        }

        private void TraitTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            for (int i = 0; i < leng; i++)
            {
                if (TraitTree.SelectedNode.Text != TraitAbilityContainer.TraitList[i].Name) { continue; }
                Trait tr = TraitAbilityContainer.TraitList[i];
                NameText.Text = tr.Name;
                AdvantageText.Text = tr.Advantage;
                DisadvantageText.Text = tr.Disadvantage;
            }
        }

        private void TraitInfo_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < leng; i++)
            {
                TraitTree.Nodes.Add(TraitAbilityContainer.TraitList[i].Name);
            }
        }
    }
}
