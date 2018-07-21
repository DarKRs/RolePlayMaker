using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace RolePlay_Maker
{
    public partial class CharacterNetwork : Form
    {
        private delegate void ChatEvent(string content, string clr);
        private ChatEvent _addMessage;
        private Socket _serverSocket;
        private Thread listenThread;
        private string host = "127.0.0.1";
        private int port = 2222;
        Network main;
        string path;
        string Nick;
        Random rand = new Random();
        public CharacterNetwork(string Nick)
        {
            InitializeComponent();
            main = this.Owner as Network;
            _addMessage = new ChatEvent(AddMessage);
            string nickName = Nick;
            if (string.IsNullOrEmpty(nickName))
                return;
            Send($"#setname|{nickName}");

        }

        private void CharacterNetwork_Load(object sender, EventArgs e)
        {
            IPAddress temp = IPAddress.Parse(host);
            _serverSocket = new Socket(temp.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            _serverSocket.Connect(new IPEndPoint(temp, port));
            if (_serverSocket.Connected)
            {

                AddMessage("Связь с сервером установлена.");
                listenThread = new Thread(listner);
                listenThread.IsBackground = true;
                listenThread.Start();
                AddMessage($"Добро пожаловать, {Nick}");
                nameData.Text = Nick;

            }
            else
            {
                AddMessage("Связь с сервером не установлена.");
                Close();
            }
            LoadopenFile.Filter = "RolePlayMaker(*.RPM)|*.RPM";
            LoadopenFile.ShowDialog();
            path = LoadopenFile.FileName;
            if (LoadopenFile.FileName != "") //если в окне была нажата кнопка "ОК"
            {

                try
                {
                    Person nwPer = new Person();
                    nwPer.Load(path);
                    //////////////////////////////
                    NameTextBox.Text = nwPer.Name;
                    ClasstextBox1.Text = nwPer.Class;
                    TraittextBox1.Text = nwPer.Trait;
                    HP.Value = nwPer.HP;
                    MaxHp.Value = nwPer.MaxHP;
                    XPValue.Value = nwPer.XP;
                    LvLValue.Value = nwPer.LvL;
                    KB.Value = nwPer.KB;
                    UpedArmor.Value = nwPer.KBArmor;
                    //////////////////////////////////////
                    Strength.Value = nwPer.Strength;
                    Perception.Value = nwPer.Perception;
                    Endurance.Value = nwPer.Endurance;
                    Charisma.Value = nwPer.Charisma;
                    Intelligence.Value = nwPer.Intelligence;
                    Agility.Value = nwPer.Agility;
                    Luck.Value = nwPer.Luck;
                    /////////////////////////////////////////
                    LightWeapons1.Value = (int)nwPer.LightWeapons;
                    HeavyWeapons1.Value = (int)nwPer.HeavyWeapons;
                    EnergyWeapons1.Value = (int)nwPer.EnergyWeapons;
                    Unarmed1.Value = (int)nwPer.Unarmed;
                    ColdWeapons1.Value = (int)nwPer.ColdWeapons;
                    ThrowingWeapons1.Value = (int)nwPer.ThrowingWeapons;
                    Medic1.Value = (int)nwPer.Medic;
                    Repair1.Value = (int)nwPer.Repair;
                    Science1.Value = (int)nwPer.Science;
                    Oratory1.Value = (int)nwPer.Oratory;
                    Barter1.Value = (int)nwPer.Barter;
                    Survival1.Value = (int)nwPer.Survival;
                    Lockpick1.Value = (int)nwPer.Lockpick;
                    Theft1.Value = (int)nwPer.Theft;
                    Stealth1.Value = (int)nwPer.Stealth;
                    SabotageExplosives1.Value = (int)nwPer.SabotageExplosives;
                    /////////////////////////////////
                    Head.Text = nwPer.Head;
                    Neck.Text = nwPer.Neck;
                    Shoulders.Text = nwPer.Shoulders;
                    Spine.Text = nwPer.Spine;
                    Chest.Text = nwPer.Chest;
                    Hand.Text = nwPer.Hand;
                    Gloves.Text = nwPer.Gloves;
                    Belt.Text = nwPer.Belt;
                    Pants.Text = nwPer.Pants;
                    Shoes.Text = nwPer.Shoes;
                    Finger1.Text = nwPer.Finger1;
                    Finger2.Text = nwPer.Finger2;
                    Finger3.Text = nwPer.Finger3;
                    Finger4.Text = nwPer.Finger4;
                    Other.Text = nwPer.Other;
                    RightHand.Text = nwPer.RightHand;
                    LeftHand.Text = nwPer.LeftHand;
                    Replacement.Text = nwPer.Replacement;

                    BackpackTextBox1.Text = nwPer.backpack;
                    Perks.Text = nwPer.Perks;
                    Effects.Text = nwPer.Effects;

                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
            else { Close(); }
        }

        private void SavePerson_Click(object sender, EventArgs e)
        {
            try
            {
                Person nwPer = new Person();
                ///////////////////////
                nwPer.Name = NameTextBox.Text;
                nwPer.Class = ClasstextBox1.Text;
                nwPer.Trait = TraittextBox1.Text;
                nwPer.XP = (int)XPValue.Value;
                nwPer.LvL = (int)LvLValue.Value;
                nwPer.HP = (int)HP.Value;
                nwPer.MaxHP = (int)MaxHp.Value;
                nwPer.KB = (int)KB.Value;
                nwPer.KBArmor = (int)UpedArmor.Value;
                ////////////////////////////
                nwPer.Strength = (int)Strength.Value;
                nwPer.Perception = (int)Perception.Value;
                nwPer.Endurance = (int)Endurance.Value;
                nwPer.Charisma = (int)Charisma.Value;
                nwPer.Intelligence = (int)Intelligence.Value;
                nwPer.Agility = (int)Agility.Value;
                nwPer.Luck = (int)Luck.Value;
                ////////////////////////////
                nwPer.LightWeapons = (int)LightWeapons1.Value;
                nwPer.HeavyWeapons = (int)HeavyWeapons1.Value;
                nwPer.EnergyWeapons = (int)EnergyWeapons1.Value;
                nwPer.Unarmed = (int)Unarmed1.Value;
                nwPer.ColdWeapons = (int)ColdWeapons1.Value;
                nwPer.ThrowingWeapons = (int)ThrowingWeapons1.Value;
                nwPer.Medic = (int)Medic1.Value;
                nwPer.Repair = (int)Repair1.Value;
                nwPer.Science = (int)Science1.Value;
                nwPer.Oratory = (int)Oratory1.Value;
                nwPer.Barter = (int)Barter1.Value;
                nwPer.Survival = (int)Survival1.Value;
                nwPer.Lockpick = (int)Lockpick1.Value;
                nwPer.Theft = (int)Theft1.Value;
                nwPer.Stealth = (int)Stealth1.Value;
                nwPer.SabotageExplosives = (int)SabotageExplosives1.Value;
                ////////////////////////////
                nwPer.Head = Head.Text;
                nwPer.Neck = Neck.Text;
                nwPer.Shoulders = Shoulders.Text;
                nwPer.Spine = Spine.Text;
                nwPer.Chest = Chest.Text;
                nwPer.Hand = Hand.Text;
                nwPer.Gloves = Gloves.Text;
                nwPer.Belt = Belt.Text;
                nwPer.Pants = Pants.Text;
                nwPer.Shoes = Shoes.Text;
                nwPer.Finger1 = Finger1.Text;
                nwPer.Finger2 = Finger2.Text;
                nwPer.Finger3 = Finger3.Text;
                nwPer.Finger4 = Finger4.Text;
                nwPer.Other = Other.Text;
                nwPer.RightHand = RightHand.Text;
                nwPer.LeftHand = LeftHand.Text;
                nwPer.Replacement = Replacement.Text;
                ////////////////////////////////
                nwPer.backpack = BackpackTextBox1.Text;
                nwPer.Perks = Perks.Text;
                nwPer.Effects = Effects.Text;


                nwPer.Save(path);
                MessageBox.Show("Персонаж сохранен",
                    "Суккес", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                DialogResult rezult = MessageBox.Show("Ошибка сохранения файла попробуйте в другой жизни",
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AddMessage(string Content, string Color = "Black")
        {
            if (InvokeRequired)
            {
                Invoke(_addMessage, Content, Color);
                return;
            }
            chatBox.SelectionStart = chatBox.TextLength;
            chatBox.SelectionLength = Content.Length;
            chatBox.AppendText(Content + Environment.NewLine);
        }

        public void handleCommand(string cmd)
        {

            string[] commands = cmd.Split('#');
            int countCommands = commands.Length;
            for (int i = 0; i < countCommands; i++)
            {
                try
                {
                    string currentCommand = commands[i];
                    if (string.IsNullOrEmpty(currentCommand))
                        continue;
                   
                    if (currentCommand.Contains("msg"))
                    {
                        string[] Arguments = currentCommand.Split('|');
                        AddMessage(Arguments[1], Arguments[2]);
                        continue;
                    }

                    if (currentCommand.Contains("userlist"))
                    {

                        string[] Users = currentCommand.Split('|')[1].Split(',');
                        int countUsers = Users.Length;
                        userList.Invoke((MethodInvoker)delegate { userList.Items.Clear(); });
                        for (int j = 0; j < countUsers; j++)
                        {
                            userList.Invoke((MethodInvoker)delegate { userList.Items.Add(Users[j]); });
                        }
                        continue;

                    }


                }
                catch (Exception exp) { Console.WriteLine("Error with handleCommand: " + exp.Message); }

            }
        }

        public void listner()
        {
            try
            {
                while (_serverSocket.Connected)
                {
                    byte[] buffer = new byte[2048];
                    int bytesReceive = _serverSocket.Receive(buffer);
                    handleCommand(Encoding.Unicode.GetString(buffer, 0, bytesReceive));
                }
            }
            catch
            {
                MessageBox.Show("Связь с сервером прервана");
                Application.Exit();
            }
        }


        public void Send(byte[] buffer)
        {
            try
            {
                _serverSocket.Send(buffer);
            }
            catch { }
        }
        public void Send(string Buffer)
        {
            try
            {
                _serverSocket.Send(Encoding.Unicode.GetBytes(Buffer));
            }
            catch { }
        }

        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_serverSocket.Connected)
                Send("#endsession");
        }

        private void messageData_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                string msgData = messageData.Text;
                if (string.IsNullOrEmpty(msgData))
                    return;
                if (msgData[0] == '"')
                {
                    string temp = msgData.Split(' ')[0];
                    string content = msgData.Substring(temp.Length + 1);
                    temp = temp.Replace("\"", string.Empty);
                    Send($"#private|{temp}|{content}");
                }
                else
                    Send($"#message|{msgData}");
                messageData.Text = string.Empty;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            string msgData = messageData.Text;
            if (string.IsNullOrEmpty(msgData))
                return;
            if (msgData[0] == '"')
            {
                string temp = msgData.Split(' ')[0];
                string content = msgData.Substring(temp.Length + 1);
                temp = temp.Replace("\"", string.Empty);
                Send($"#private|{temp}|{content}");
            }
            else
                Send($"#message|{msgData}");
            messageData.Text = string.Empty;
        }
    }
}
