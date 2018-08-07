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
<<<<<<< HEAD:RolePlay Maker/Forms/AbilityInfo.cs
        int leng = Item.Entities.Count();
=======
        int leng = TraitAbilityContainer.AbilityList.Count();
>>>>>>> 2a605b63a3e87d196fc737b6fe04d36f45a4c630:RolePlay Maker/Forms/Information/AbilityInfo.cs
        public AbilityInfo()
        {
            InitializeComponent();
        }

        private void AbilityInfo_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < leng; i++)
            {
<<<<<<< HEAD:RolePlay Maker/Forms/AbilityInfo.cs
                if (Item.Entities[i].Type != "Ability") { continue; }
                AbilityTree.Nodes.Add(Item.Entities[i].Name);
=======
                AbilityTree.Nodes.Add(TraitAbilityContainer.AbilityList[i].Name);
>>>>>>> 2a605b63a3e87d196fc737b6fe04d36f45a4c630:RolePlay Maker/Forms/Information/AbilityInfo.cs
            }
        }

        private void AbilityTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            for (int i = 0; i < leng; i++)
            {
<<<<<<< HEAD:RolePlay Maker/Forms/AbilityInfo.cs
                if (AbilityTree.SelectedNode.Text != Item.Entities[i].Name) { continue; }
                Ability Ab = ((Ability)Item.Entities[i]);
=======
                if (AbilityTree.SelectedNode.Text != TraitAbilityContainer.AbilityList[i].Name) { continue; }
                Ability Ab = TraitAbilityContainer.AbilityList[i];
>>>>>>> 2a605b63a3e87d196fc737b6fe04d36f45a4c630:RolePlay Maker/Forms/Information/AbilityInfo.cs
                NameText.Text = Ab.Name;
                RangText.Text = Ab.rangs.ToString();
                ReqText.Text = Ab.requirement;
                DescriptionText.Text = Ab.Advantage;
            }
        }
    }
}
