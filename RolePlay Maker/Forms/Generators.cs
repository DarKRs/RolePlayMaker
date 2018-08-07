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
    public partial class Generators : Form
    {
        public Generators()
        {
            InitializeComponent();
        }

        private void NPCGenerator_Click(object sender, EventArgs e)
        {
            NPCGeneratorForm f = new NPCGeneratorForm();
            f.Owner = this.Owner;
            f.Show();
            this.Close();
        }

        private void QuestGeneraor_Click(object sender, EventArgs e)
        {
            QuestGeneratorForm f = new QuestGeneratorForm();
            f.Owner = this.Owner;
            f.Show();
            this.Close();
        }
    }
}
