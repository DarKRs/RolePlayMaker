using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RolePlay_Maker.Forms
{
    public partial class AddAbility : Form
    {
        public AddAbility()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = NameText.Text;
            string rang = RangText.Text;
            string requirement = ReqText.Text;
            string Description = DescriptionText.Text;

            int num;
            if (Name == "" || rang == "" || requirement == "" || Description == "")
            {
                MessageBox.Show("Введена не вся информация",
                     "Все пошло по пизде", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!(int.TryParse(rang, out num)))
            {
                MessageBox.Show("Только числовые значения в рангах!",
                     "Не твори хуйню блять!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<string> data = new List<string>() { Name, Description, requirement, rang };

            StatusLabel.Text = "Записываем информацию...";

            Loader ld = Loader.GetLoader();
            ld.AddToDatabase(data, Loader.ABILITIES_SPREADSHEET, "Способности", "Ability");

            StatusLabel.Text = "Информация записана!";
            NameText.Text = ""; RangText.Text = ""; ReqText.Text = ""; DescriptionText.Text = "";
        }


    }
}
