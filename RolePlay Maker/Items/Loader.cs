using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using Google.Apis.Http;
using Newtonsoft.Json;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Util.Store;
using System.Threading;
using System.Linq;
using System.Collections;
using System.Diagnostics;

namespace RolePlay_Maker
{
    class Loader
    {
        public static readonly string ARMOR_SPREADSHEET = "19CQvYbi6OwMoLpseI8AkQzL2jFbc9YP3b4Kpu61wsEw";
        public static readonly string WEAPON_SPREADSHEET = "1_6ND5dw_DG-qgE6nkbrH3BVgj-D8_9LgHEpNlT-NFMA";
        public static readonly string COLD_WEAPON_SPREADSHEET = "1ghGqXURQNqpabSYt9QRH-4ubfYcTdIZmhOQR_WW9C7A";
        //
        public static readonly string MOB_SPREADSHEET = "1jHtZc8N16qjlF_mxI7L5a_VTK3QFNEHuneHQ9XosdNM";

        static string[] Scopes = { SheetsService.Scope.Spreadsheets };
        static string ApplicationName = "My Project";
        SheetsService service;

        private static Loader loader;
        
        Loader()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                string credPath = Environment.GetFolderPath(
                    Environment.SpecialFolder.Personal);
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
        public static Loader GetLoader()
        {
            if (loader == null)
                loader = new Loader();
            return loader;
        }

        public void RefreshAllDatabase()
        {
            String spreadsheetId;
            //for storing the range and corresponding type
            Dictionary<string, string> ranges = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, string>> spreadsheetIdAndRanges = new Dictionary<string, Dictionary<string, string>>();
            /////Armor///////

            spreadsheetId = ARMOR_SPREADSHEET;
            ranges.Add("Одежда!A3:G", "Одежда");
            ranges.Add("Легкая броня!A3:G", "Легкая броня");
            ranges.Add("Средняя броня!A3:G", "Средняя броня");
            ranges.Add("Тяжелая броня!A3:G", "Тяжелая броня");
            ranges.Add("Силовая броня и подобное!A3:G", "Силовая броня");
            ranges.Add("Шлемы/Головные уборы!A3:G", "Шлемы и головные уборы");
            ranges.Add("Акссесуары!A3:G", "Акссесуары");
            spreadsheetIdAndRanges.Add(spreadsheetId, ranges);
            /////Weapon//////
            ranges = new Dictionary<string, string>();
            spreadsheetId = WEAPON_SPREADSHEET;
            ranges.Add("Пистолеты!A3:G", "Пистолеты");
            ranges.Add("Винтовки и автоматы!A3:G", "Винтовки и автоматы");
            ranges.Add("Пистолеты-Пулеметы!A3:G", "Пистолеты-Пулеметы");
            ranges.Add("Дробовики!A3:G", "Дробовики");
            ranges.Add("Тяжелое оружие!A3:G", "Тяжелое оружие");
            ranges.Add("Энергетические пистолеты!A3:G", "Энергетические пистолеты");
            ranges.Add("Энергетические ружья!A3:G", "Энергетические ружья");
            ranges.Add("Тяжелое энергетическое оружие !A3:G", "Тяжелое энергетическое оружие");
            ranges.Add("Силовое холодное оружие!A3:G", "Силовое холодное оружие");
            spreadsheetIdAndRanges.Add(spreadsheetId, ranges);
            ///////////ColdWeapon/////////////////
            ranges = new Dictionary<string, string>();
            spreadsheetId = COLD_WEAPON_SPREADSHEET;
            ranges.Add("Дубины и молоты!A3:E3", "Дубины и молоты");
            ranges.Add("Кастеты и подобное!A3:E", "Кастеты и подобное");
            ranges.Add("Ножи!A3:E", "Ножи");
            ranges.Add("Двуручное холодное оружие!A3:E", "Двуручное холодное оружие");
            ranges.Add("Копья!A3:E", "Копья");
            ranges.Add("Другое!A3:E", "Другое");
            spreadsheetIdAndRanges.Add(COLD_WEAPON_SPREADSHEET, ranges);
            /////////////////////////MOB///////////////////////
            ranges = new Dictionary<string, string>();
            spreadsheetId = MOB_SPREADSHEET;
            ranges.Add("Mob!A3:E", "Mob");
            spreadsheetIdAndRanges.Add(MOB_SPREADSHEET, ranges);
            //
            RefreshingDBAsync(spreadsheetIdAndRanges);
        }

        public void RefreshDatabase(string SubClass, string Class)
        {
            String spreadsheetId;
            //for storing the range and corresponding type
            Dictionary<string, string> ranges = new Dictionary<string, string>();
            Dictionary<string, Dictionary<string, string>> spreadsheetIdAndRanges = new Dictionary<string, Dictionary<string, string>>();
            string sheetID = SubClass;
            string range="";
            if (Class == "Armor")
            {
                spreadsheetId = ARMOR_SPREADSHEET;
                //DarkRs, это для readable кода

                /*It allows us to add a new columns to sheets
                 * and change a range only in one place
                */
                range = "!A3:G";

            }
            else if (Class == "Weapon")
            {
                spreadsheetId = WEAPON_SPREADSHEET;
                range = "!A3:G";

            }
            else if(Class == "ColdWeapon")
            {
                spreadsheetId = COLD_WEAPON_SPREADSHEET;
                range = "!A3:E";
                
            }
            else if(Class == "Mob")
            {
                spreadsheetId = MOB_SPREADSHEET;
                range = "!A3:E";
            }
            else
            {
                throw new Exception("Все пошло по пизде. Смотри код");
            }
            ranges.Add(sheetID + range, SubClass);
            spreadsheetIdAndRanges.Add(spreadsheetId, ranges);
            RefreshingDBAsync(spreadsheetIdAndRanges);
        }


        private async void RefreshingDBAsync(Dictionary<string, Dictionary<string, string>> spreadsheetIdAndRanges)
        {
            if (spreadsheetIdAndRanges.Count == 0)
                return;
            Dictionary<Task<ValueRange>, string> tasks = new Dictionary<Task<ValueRange>, string>();
            foreach (var entry in spreadsheetIdAndRanges)
            {
                var spreadsheetId = entry.Key;
                var rangesAndTypes = entry.Value;
                foreach (var _entry in rangesAndTypes)
                {
                    var range = _entry.Key;
                    var type = _entry.Value;
                    SpreadsheetsResource.ValuesResource.GetRequest request =
                        service.Spreadsheets.Values.Get(spreadsheetId, range);
                    tasks.Add(request.ExecuteAsync(), type);
                }
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
                    case "Легкая броня":
                    case "Средняя броня":
                    case "Тяжелая броня":
                    case "Силовая броня":
                    case "Шлемы и головные уборы":
                    case "Акссесуары":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Armor arm = new Armor(type, values[i]);
                            Item.ArmorList.Add(arm);
                        }
                        break;
                    ////////////////////////////Weapon/////////////////////////
                    case "Пистолеты":
                    case "Винтовки и автоматы":
                    case "Пистолеты-Пулеметы":
                    case "Дробовики":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Weapon wp = new Weapon(type, values[i], "LightWeapon");
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
                    case "Энергетические ружья":
                    case "Тяжелое энергетическое оружие":
                    case "Силовое холодное оружие":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Weapon wp = new Weapon(type, values[i], "EnergyWeapon");
                            Item.WeaponList.Add(wp);
                        }
                        break;
                    ///////////ColdWeapon/////////////////
                    case "Дубины и молоты":
                    case "Кастеты и подобное":
                    case "Ножи":
                    case "Двуручное холодное оружие":
                    case "Копья":
                    case "Другое":
                        for (int i = 0; i < values.Count; i++)
                        {
                            Weapon wp = new Weapon(type, values[i], "ColdWeapon");
                            Item.WeaponList.Add(wp);
                        }
                        break;
                    case "Mob":
                        for(int i=0; i < values.Count; i++)
                        {
                            Mob mb = new Mob(values[i]);
                            Entity.MobList.Add(mb);
                        }
                        break;
                    default: break;
                }
            }
            //for debug purposes
            Console.WriteLine("Completed");
            
        }
        public async void AddToDatabase(List<string> data, String spreadsheetId, string type, string Class)
        {
            // The A1 notation of a range to search for a logical table of data.
            // Values will be appended after the last row of the table.
            string range = type + "!A:G";

            IList<IList<object>> val = new List<IList<object>>();
            ValueRange requestBody = new ValueRange() { Values = val };
            requestBody.Values.Add(data.Select(x => (object)x).ToList());

            SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum valueInputOption = (SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum)2;
            SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum insertDataOption = (SpreadsheetsResource.ValuesResource.AppendRequest.InsertDataOptionEnum)1;

            SpreadsheetsResource.ValuesResource.AppendRequest request = service.Spreadsheets.Values.Append(requestBody, spreadsheetId, range);
            request.ValueInputOption = valueInputOption;
            request.InsertDataOption = insertDataOption;

            AppendValuesResponse response = await request.ExecuteAsync();
            RefreshDatabase(type, Class);
        }

    }
}
