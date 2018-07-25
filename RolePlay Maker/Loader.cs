using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Threading;

namespace RolePlay_Maker
{
    class Loader
    {
        static string[] Scopes = { SheetsService.Scope.SpreadsheetsReadonly };
        static string ApplicationName = "Google Sheets API .NET Quickstart";
        SheetsService service;
        public Loader()
        {
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
            service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });


        }

        public void RefreshAllDatabase()
        {
            String spreadsheetId;
            //for storing the range and corresponding type
            Dictionary<string, string> ranges = new Dictionary<string, string>();
            
                    /////Armor///////
                    spreadsheetId = "19CQvYbi6OwMoLpseI8AkQzL2jFbc9YP3b4Kpu61wsEw";
                    ranges.Add("Одежда!A3:G", "Одежда");
                    ranges.Add("Легкая броня!A3:G", "Легкая броня");
                    ranges.Add("Средняя броня!A3:G", "Средняя броня");
                    ranges.Add("Тяжелая броня!A3:G", "Тяжелая броня");
                    ranges.Add("Силовая броня и подобное!A3:G", "Силовая броня");
                    ranges.Add("Шлемы/Головные уборы!A3:G", "Шлемы и головные уборы");
                    ranges.Add("Акссесуары!A3:G", "Акссесуары");
                    RefreshingDBAsync(service, spreadsheetId, ranges);
                    /////Weapon//////
                    ranges.Clear();
                    spreadsheetId = "1_6ND5dw_DG-qgE6nkbrH3BVgj-D8_9LgHEpNlT-NFMA";
                    ranges.Add("Пистолеты!A3:G", "Пистолеты");
                    ranges.Add("Винтовки и автоматы!A3:G", "Винтовки и автоматы");
                    ranges.Add("Пистолеты-Пулеметы!A3:G", "Пистолеты-Пулеметы");
                    ranges.Add("Дробовики!A3:G", "Дробовики");
                    ranges.Add("Тяжелое оружие!A3:G", "Тяжелое оружие");
                    ranges.Add("Энергетические пистолеты!A3:G", "Энергетические пистолеты");
                    ranges.Add("Энергетические ружья!A3:G", "Энергетические ружья");
                    ranges.Add("Тяжелое энергетическое оружие !A3:G", "Тяжелое энергетическое оружие");
                    ranges.Add("Силовое холодное оружие!A3:G", "Силовое холодное оружие");
                    RefreshingDBAsync(service, spreadsheetId, ranges);
                    ///////////ColdWeapon/////////////////
                    ranges.Clear(); 
                    spreadsheetId = "1ghGqXURQNqpabSYt9QRH-4ubfYcTdIZmhOQR_WW9C7A";
                    ranges.Add("Дубины и молоты!A3:E", "Дубины и молоты");
                    ranges.Add("Кастеты и подобное!A3:E", "Кастеты и подобное");
                    ranges.Add("Ножи!A3:E", "Ножи");
                    ranges.Add("Двуручное холодное оружие!A3:E", "Двуручное холодное оружие");
                    ranges.Add("Копья!A3:E", "Копья");
                    ranges.Add("Другое!A3:E", "Другое");
                    RefreshingDBAsync(service, spreadsheetId, ranges);
        }

        public void RefreshDatabase(string Class, string Type)
        {
            String spreadsheetId;
            //for storing the range and corresponding type
            Dictionary<string, string> ranges = new Dictionary<string, string>();
            if (Type == "Armor") {
                spreadsheetId = "19CQvYbi6OwMoLpseI8AkQzL2jFbc9YP3b4Kpu61wsEw";
                switch (Class)
                {
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
                }
                RefreshingDBAsync(service, spreadsheetId, ranges);
            } else if (Type == "Weapon") {
                spreadsheetId = "1_6ND5dw_DG-qgE6nkbrH3BVgj-D8_9LgHEpNlT-NFMA";
                switch (Class)
                {
                    /////Weapon//////
                    case "Легкое оружие":
                        ranges.Add("Пистолеты!A3:E", "Пистолеты");
                        ranges.Add("Винтовки и Автоматы!A3:E", "Винтовки и Автоматы");
                        ranges.Add("Пистолеты-Пулеметы!A3:E", "Пистолеты-Пулеметы");
                        ranges.Add("Дробовики!A3:E", "Дробовики");
                        break;
                }
                RefreshingDBAsync(service, spreadsheetId, ranges);
            }
            
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
                            Item.ArmorList.Add(arm);
                        }
                        break;
                    case "Легкая броня":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Armor arm = new Armor("Легкая броня", values[i]);
                            Item.ArmorList.Add(arm);
                        }
                        break;
                    case "Средняя броня":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Armor arm = new Armor("Средняя броня", values[i]);
                            Item.ArmorList.Add(arm);
                        }
                        break;
                    case "Тяжелая броня":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Armor arm = new Armor("Тяжелая броня", values[i]);
                            Item.ArmorList.Add(arm);
                        }
                        break;
                    case "Силовая броня":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Armor arm = new Armor("Силовая броня", values[i]);
                            Item.ArmorList.Add(arm);
                        }
                        break;
                    case "Шлемы и головные уборы":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Armor arm = new Armor("Шлемы и головные уборы", values[i]);
                            Item.ArmorList.Add(arm);
                        }
                        break;
                    case "Акссесуары":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Armor arm = new Armor("Акссесуары", values[i]);
                            Item.ArmorList.Add(arm);
                        }
                        break;
                    ////////////////////////////Weapon/////////////////////////
                    case "Пистолеты":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Weapon wp = new Weapon("Пистолеты", values[i], "LightWeapon");
                            Item.WeaponList.Add(wp);
                        }
                        break;
                    case "Винтовки и автоматы":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Weapon wp = new Weapon("Винтовки и автоматы", values[i], "LightWeapon");
                            Item.WeaponList.Add(wp);
                        }
                        break;
                    case "Пистолеты-Пулеметы":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Weapon wp = new Weapon("Пистолеты-Пулеметы", values[i], "LightWeapon");
                            Item.WeaponList.Add(wp);
                        }
                        break;
                    case "Дробовики":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Weapon wp = new Weapon("Дробовики", values[i], "LightWeapon");
                            Item.WeaponList.Add(wp);
                        }
                        break;
                    case "Тяжелое оружие":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Weapon wp = new Weapon("Тяжелое оружие", values[i], "HeavyWeapon");
                            Item.WeaponList.Add(wp);
                        }
                        break;
                    case "Энергетические пистолеты":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Weapon wp = new Weapon("Энергетические пистолеты", values[i], "EnergyWeapon");
                            Item.WeaponList.Add(wp);
                        }
                        break;
                    case "Энергетические ружья":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Weapon wp = new Weapon("Энергетические ружья", values[i], "EnergyWeapon");
                            Item.WeaponList.Add(wp);
                        }
                        break;
                    case "Тяжелое энергетическое оружие":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Weapon wp = new Weapon("Тяжелое энергетическое оружие", values[i], "EnergyWeapon");
                            Item.WeaponList.Add(wp);
                        }
                        break;
                    case "Силовое холодное оружие":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Weapon wp = new Weapon("Силовое холодное оружие", values[i], "EnergyWeapon");
                            Item.WeaponList.Add(wp);
                        }
                        break;
                    ///////////ColdWeapon/////////////////
                    case "Дубины и молоты":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Weapon wp = new Weapon("Дубины и молоты", values[i], "ColdWeapon");
                            Item.WeaponList.Add(wp);
                        }
                        break;
                    case "Кастеты и подобное":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Weapon wp = new Weapon("Кастеты и подобное", values[i], "ColdWeapon");
                            Item.WeaponList.Add(wp);
                        }
                        break;
                    case "Ножи":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Weapon wp = new Weapon("Ножи", values[i], "ColdWeapon");
                            Item.WeaponList.Add(wp);
                        }
                        break;
                    case "Двуручное холодное оружие":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Weapon wp = new Weapon("Двуручное холодное оружие", values[i], "ColdWeapon");
                            Item.WeaponList.Add(wp);
                        }
                        break;
                    case "Копья":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Weapon wp = new Weapon("Копья", values[i], "ColdWeapon");
                            Item.WeaponList.Add(wp);
                        }
                        break;
                    case "Другое":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Weapon wp = new Weapon("Другое", values[i], "ColdWeapon");
                            Item.WeaponList.Add(wp);
                        }
                        break;
                    default: break;
                }
            }
            //for debug purposes
            Console.WriteLine("Completed");
        }


    }
}
