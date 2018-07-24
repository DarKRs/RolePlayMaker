using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using RolePlay_Maker.Forms;
using System.Threading.Tasks;

namespace RolePlay_Maker
{
    
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Loader load = new Loader();
            load.RefreshAllDatabase();

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void авторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Author f = new Author();
            f.Owner = this;
            f.ShowDialog();
        }

        private void настройкиПрофиляToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Profile f = new Profile();
            f.Owner = this;
            f.ShowDialog();*/
            MessageBox.Show("Профиль не работает и не нужен",
                     "НЕ ЛЕЗЬ БЛЯТЬ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CreatePerson_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.ShowDialog(); //блокируется основная форма
        }

        private void LoadPerson_Click(object sender, EventArgs e)
        {
            Character f = new Character();
            f.Owner = this;
            f.ShowDialog();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Network f = new Network();
            f.Owner = this;
            f.ShowDialog();
        }

        private void настройкиСетиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NetworkInfo f = new NetworkInfo();
            f.Owner = this;
            f.ShowDialog();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void броняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArmorForm f = new ArmorForm();
            f.Owner = this;
            f.ShowDialog();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddArmor f = new AddArmor();
            f.Owner = this;
            f.ShowDialog();
        }

        private void справкаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MobForm f = new MobForm();
            f.Owner = this;
            f.ShowDialog();
        }

        private void добавитьСуществоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMob f = new AddMob();
            f.Owner = this;
            f.ShowDialog();
        }

        private void справкаToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            WeaponInfo f = new WeaponInfo();
            f.Owner = this;
            f.ShowDialog();
        }

        private void добавитьОружиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddWeapon f = new AddWeapon();
            f.Owner = this;
            f.ShowDialog();
        }

        private void справкаToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AbilityInfo f = new AbilityInfo();
            f.Owner = this;
            f.ShowDialog();
        }

        private void Generator_Click(object sender, EventArgs e)
        {
            Generators f = new Generators();
            f.Owner = this;
            f.ShowDialog();
        }
    }
}
