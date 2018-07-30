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
    public partial class AddTrait : Form
    {
        public AddTrait()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = NameText.Text;
            string Advantage = AdvantageText.Text;
            string Disadvantage = DisadvantageText.Text;
            if (Name == "" || Advantage == "" || Disadvantage == "" )
            {
                MessageBox.Show("Введена не вся информация",
                     "Все пошло по пизде", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            List<string> data = new List<string>() { Name, Advantage, Disadvantage};

            StatusLabel.Text = "Записываем информацию...";

            Loader ld = Loader.GetLoader();
            ld.AddToDatabase(data, Loader.TRAIT_SPREADSHEET, "Черты", "Trait");

            StatusLabel.Text = "Информация записана!";
            NameText.Text = ""; AdvantageText.Text = ""; DisadvantageText.Text = ""; 
        }
    }
}
