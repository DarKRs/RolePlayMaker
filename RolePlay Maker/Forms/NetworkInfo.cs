using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RolePlay_Maker
{
    public partial class NetworkInfo : Form
    {
        MainForm main;
        string path;
        public NetworkInfo()
        {
            InitializeComponent();
            main = this.Owner as MainForm;
            path = System.IO.Directory.GetCurrentDirectory() + @"\" + "Info.ini";

        }

        private void Save_Click(object sender, EventArgs e)
        {
            int Port = int.Parse(PortText.Text);
            try
            {
                using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
                using (BinaryWriter binWriter = new BinaryWriter(fs))
                {
                    binWriter.Write(IPText.Text);
                    binWriter.Write(Port);
                    ////////////////////////
                    MessageBox.Show("Настройки сохранены",
                    "Суккес", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Dispose();
                    Close();
                }
            }
            catch
            {
                DialogResult rezult = MessageBox.Show("Ошибка сохранения файла попробуйте в другой жизни",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Dispose();
                Close();
            }
                
     }


        private void Cancel_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
    }
}
