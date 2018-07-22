using System;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
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
        static string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        static string ApplicationName = "Google Sheets API .NET Quickstart";
        public MainForm()
        {
            InitializeComponent();
            UserCredential credential;

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/sheets.googleapis.com-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Google Sheets API service.
            var service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
            RefreshDatabase(service, "All");



        }

        private void RefreshDatabase(SheetsService service, string Type)
        {
            String spreadsheetId;
            //for storing the range and corresponding type
            Dictionary<string, string> ranges = new Dictionary<string, string>();
            spreadsheetId = "19CQvYbi6OwMoLpseI8AkQzL2jFbc9YP3b4Kpu61wsEw";

            switch (Type)
            {
                case "All": //Вызывается при открытии RPMaker

                    /////Armor///////
                    ranges.Add("Одежда!A3:G", "Одежда");
                    ranges.Add("Легкая броня!A3:G", "Легкая броня");
                    ranges.Add("Средняя броня!A3:G", "Средняя броня");
                    ranges.Add("Тяжелая броня!A3:G", "Тяжелая броня");
                    ranges.Add("Силовая броня и подобное!A3:G", "Силовая броня");
                    ranges.Add("Шлемы/Головные уборы и другое!A3:G", "Шлемы и головные уборы");
                    /////Weapon//////
                    //ranges.Add("Пистолеты!A3:E", "Оружие");
                    //spreadsheetId = "1_6ND5dw_DG-qgE6nkbrH3BVgj-D8_9LgHEpNlT-NFMA"; range = ; RefreshingDBAsync(service, spreadsheetId, range, "Легкое оружие");

                    break;
                /////Armor///////
                case "Одежда":
                    ranges.Add("Одежда!A3:G", "Одежда"); break;
                case "Легкая броня":
                    ranges.Add("Легкая броня!A3:G", "Легкая броня"); break;
                case "Средняя броня":
                    ranges.Add("Средняя броня!A3:G", "Средняя броня"); break;
                case "Тяжелая броня":
                    ranges.Add("Тяжелая броня!A3:G", "Тяжелая броня"); break;
                case "Силовая броня":
                    ranges.Add("Силовая броня и подобное!A3:G", "Силовая броня"); break;
                case "Шлемы и головные уборы":
                    ranges.Add("Шлемы/Головные уборы и другое!A3:G", "Шлемы и головные уборы"); break;
                /////Weapon//////
                case "Легкое оружие":
                    spreadsheetId = "1_6ND5dw_DG-qgE6nkbrH3BVgj-D8_9LgHEpNlT-NFMA";
                    ranges.Add("Пистолеты!A3:E", "Оружие");
                    break;
                default: break;

            }
            RefreshingDBAsync(service, spreadsheetId, ranges);
        }

        private async void RefreshingDBAsync(SheetsService service, String spreadsheetId, Dictionary<string, string> rangesAndTypes)
        {
            // Define request parameters.

            Dictionary<Task<ValueRange>, string> tasks = new Dictionary<Task<ValueRange>, string>();
            foreach (var entry in rangesAndTypes)
            {
                var range = entry.Key;
                var type = entry.Value;
                SpreadsheetsResource.ValuesResource.GetRequest request =
                    service.Spreadsheets.Values.Get(spreadsheetId, range);
                tasks.Add(request.ExecuteAsync(), type);
                ValueRange response = await request.ExecuteAsync();
            }
            foreach (var entry in tasks)
            {
                var task = entry.Key;
                string type = entry.Value;

                ValueRange response = await task;
                IList<IList<Object>> values = response.Values;
                switch (type)
                {
                    //////////////////Armor//////////
                    case "Одежда":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Armor arm = new Armor("Одежда", values[i]);
                            Entity.Armor.Add(arm);
                        }
                        break;
                    case "Легкая броня":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Armor arm = new Armor("Легкая броня", values[i]);
                            Entity.Armor.Add(arm);
                        }
                        break;
                    case "Средняя броня":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Armor arm = new Armor("Средняя броня", values[i]);
                            Entity.Armor.Add(arm);
                        }
                        break;
                    case "Тяжелая броня":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Armor arm = new Armor("Тяжелая броня", values[i]);
                            Entity.Armor.Add(arm);
                        }
                        break;
                    case "Силовая броня":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Armor arm = new Armor("Силовая броня", values[i]);
                            Entity.Armor.Add(arm);
                        }
                        break;
                    case "Шлемы и головные уборы":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Armor arm = new Armor("Шлемы и головные уборы", values[i]);
                            Entity.Armor.Add(arm);
                        }
                        break;
                    ////////////////////////////Weapon/////////////////////////
                    default: break;
                }
            }
            //for debug purposes
            Console.WriteLine("Completed");
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
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
           // RefreshData();
        }

        public void RefreshData()
        {
            Entity.Entitys.Clear();
            string path = System.IO.Directory.GetCurrentDirectory() + @"\wiki\";
            LoadFile(path + "Mob.txt", "Mob");
            LoadFile(path + "Armor.txt", "Armor");
            LoadFile(path + "Weapons.txt", "Weapon");
            LoadFile(path + "Ability.txt", "Ability");
        }

        public void LoadFile(string path,string name)
        {
           try { FileStream fs = new FileStream(path, FileMode.Open);
            
            
                StreamReader reader = new StreamReader(fs);
                string file = reader.ReadToEnd();
                string[] Entit = file.Split('&');
                for (int i = 0; i < Entit.Length; i++)
                {
                    string[] Zapis = Entit[i].Split('$');
                    switch (name)
                    {
                        case "Mob":
                            Mob mb = new Mob(Zapis[0], int.Parse(Zapis[1]), int.Parse(Zapis[2]), int.Parse(Zapis[3]), Zapis[4]);
                            Entity.Entitys.Add(mb);
                            break;
                        case "Armor":
                            Armor arm = new Armor("null",Zapis[0], int.Parse(Zapis[1]), int.Parse(Zapis[2]), Zapis[3]);
                            Entity.Entitys.Add(arm);
                            break;
                        case "Weapon":
                            Weapon wp = new Weapon(Zapis[0],Zapis[1], int.Parse(Zapis[2]), Zapis[3],int.Parse(Zapis[4]), Zapis[5]);
                            Entity.Entitys.Add(wp);
                            break;
                        case "Ability":
                            Ability ab = new Ability(Zapis[0],Zapis[1],int.Parse(Zapis[2]),Zapis[3]);
                            Entity.Entitys.Add(ab);
                            break;

                    }
                }
                reader.Close();
            }
            catch(Exception ex) {  MessageBox.Show(ex.Message,
                     "Все пошло по пизде", MessageBoxButtons.OK, MessageBoxIcon.Information); Close();
            }
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
