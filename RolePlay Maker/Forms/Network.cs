using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;

namespace RolePlay_Maker
{
    
    public partial class Network : Form
    {
        MainForm main;
        Thread myThread;
        public string host;
        public int port = 2222;
        public string nick; 
        public Network()
        {
            InitializeComponent();
            main = this.Owner as MainForm;
            host = IpHost.Text;
            
        }



        private void CreateServer_Click(object sender, EventArgs e)
        {
           
            myThread = new Thread(new ThreadStart(Servers));
            myThread.Start();
        }

        private void Servers()
        {

            System.Diagnostics.Process.Start("Server.exe");
           
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            nick = Nick.Text;
            ChatForm f = new ChatForm();
            f.Owner = this;
            f.ShowDialog();
        }

        private void Network_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Невозможно открыть выбранный файл",
                      "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public string getNick()
        {
            return nick;
        }

        }

    }

