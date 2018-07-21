using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RolePlay_Maker
{
    
    public partial class Character : Form
    {
        string path;
        MainForm main;
        Random rand = new Random();
        public Character()
        {
            InitializeComponent();
            
            main = this.Owner as MainForm;
           
           
        }
        private void General_Load(object sender, EventArgs e)
        {
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
            
            //string file = saveFile.FileName;
           // if (saveFile.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
           // {
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

      
        private void Clear_Click(object sender, EventArgs e)
        {
            Log.Clear();
        }


        /// ////////////////////////////////////////////////////
        
        private void StrRollbutton1_Click(object sender, EventArgs e) //Бросок на силу
        {
            int roll = rand.Next(1, 20);
            if (roll == 19 || roll == 20)
            {
                Log.Text += "КРИТИЧЕСКИЙ БРОСОК НА СИЛУ  " + roll + "\n";

                return;
            }
            if (roll == 1 || roll == 2)
            {
                Log.Text += "КРИТИЧЕСКИЙ ПРОМАХ НА СИЛУ  " + roll + "\n";

                return;
            }
            Log.Text += "Ваш бросок на силу = " + roll + "\n";
        }


        private void PerRollbutton4_Click(object sender, EventArgs e)
        {
            int roll = rand.Next(1, 20);
            if (roll == 19 || roll == 20)
            {
                Log.Text += "КРИТИЧЕСКИЙ БРОСОК НА ВОСПРИЯТИЕ " + roll + "\n";

                return;
            }
            if (roll == 1 || roll == 2)
            {
                Log.Text += "КРИТИЧЕСКИЙ ПРОМАХ НА ВОСПРИЯТИЕ  " + roll + "\n";

                return;
            }
            Log.Text += "Ваш бросок на восприятие = " + roll + "\n";
        }

        private void EndRollbutton3_Click(object sender, EventArgs e)
        {
            int roll = rand.Next(1, 20);
            if (roll == 19 || roll == 20)
            {
                Log.Text += "КРИТИЧЕСКИЙ БРОСОК НА ВЫНОСЛИВОСТЬ  " + roll + "\n";

                return;
            }
            if (roll == 1 || roll == 2)
            {
                Log.Text += "КРИТИЧЕСКИЙ ПРОМАХ НА ВЫНОСЛИВОСТЬ " + roll + "\n";

                return;
            }
            Log.Text += "Ваш бросок на выносливость = " + roll + "\n";
        }

        private void ChrRollbutton2_Click(object sender, EventArgs e)
        {
            int roll = rand.Next(1, 20);
            if (roll == 19 || roll == 20)
            {
                Log.Text += "КРИТИЧЕСКИЙ БРОСОК НА ХАРИЗМУ  " + roll + "\n";

                return;
            }
            if (roll == 1 || roll == 2)
            {
                Log.Text += "КРИТИЧЕСКИЙ ПРОМАХ НА ХАРИЗМУ " + roll + "\n";

                return;
            }
            Log.Text += "Ваш бросок на харизму = " + roll + "\n";
        }

        private void IntRollbutton1_Click(object sender, EventArgs e)
        {
            int roll = rand.Next(1, 20);
            if (roll == 19 || roll == 20)
            {
                Log.Text += "КРИТИЧЕСКИЙ БРОСОК НА ИНТЕЛЕКТ  " + roll + "\n";

                return;
            }
            if (roll == 1 || roll == 2)
            {
                Log.Text += "КРИТИЧЕСКИЙ ПРОМАХ НА ИНТЕЛЕКТ  " + roll + "\n";

                return;
            }
            Log.Text += "Ваш бросок на интелект = " + roll + "\n";
        }

        private void AgiRollbutton6_Click(object sender, EventArgs e)
        {
            int roll = rand.Next(1, 20);
            if (roll == 19 || roll == 20)
            {
                Log.Text += "КРИТИЧЕСКИЙ БРОСОК НА ЛОВКОСТЬ  " + roll + "\n";

                return;
            }
            if (roll == 1 || roll == 2)
            {
                Log.Text += "КРИТИЧЕСКИЙ ПРОМАХ НА ЛОВКОСТЬ  " + roll + "\n";

                return;
            }
            Log.Text += "Ваш бросок на ловкость = " + roll + "\n";
        }

        private void LckRollbutton7_Click(object sender, EventArgs e)//Бросок на удачу
        {
            int roll = rand.Next(1, 20);
            if (roll == 19 || roll == 20)
            {
                Log.Text += "КРИТИЧЕСКИЙ БРОСОК НА УДАЧУ  " + roll + "\n";

                return;
            }
            if (roll == 1 || roll == 2)
            {
                Log.Text += "КРИТИЧЕСКИЙ ПРОМАХ НА УДАЧУ " + roll + "\n";

                return;
            }
            Log.Text += "Ваш бросок на удачу = " + roll + "\n";
        }

        private void LightWeaponRoll_Click(object sender, EventArgs e)
        {
            
            ///////////////////////////
            int value = (int)LightWeapons1.Value;
            int mod = Modificator(value);
            ///////////////////////////////////////////////
            int roll = rand.Next(1, 20);
            int summ = roll + mod;
            if (roll == 19 || roll == 20)
            {
                Log.Text += "КРИТИЧЕСКИЙ БРОСОК НА ЛЕГКОЕ ОРУЖИЕ  " + roll + "\n";

                return;
            }
            if (roll == 1 || roll == 2)
            {
                Log.Text += "КРИТИЧЕСКИЙ ПРОМАХ НА ЛЕГКОЕ ОРУЖИЕ " + roll + "\n";

                return;
            }
            Log.Text += "Ваш бросок на легкое оружие = " + summ + "(" + mod + ")" + "\n";

        }

        private void HeavyWeaponRoll_Click(object sender, EventArgs e)
        {
            
            ///////////////////////////
            int value = (int)HeavyWeapons1.Value;
            int mod = Modificator(value);
            ///////////////////////////////////////////////
            int roll = rand.Next(1, 20);
            int summ = roll + mod;
            if (roll == 19 || roll == 20)
            {
                Log.Text += "КРИТИЧЕСКИЙ БРОСОК НА ТЯЖЕЛОЕ ОРУЖИЕ  " + roll + "\n";

                return;
            }
            if (roll == 1 || roll == 2)
            {
                Log.Text += "КРИТИЧЕСКИЙ ПРОМАХ НА ТЯЖЕЛОЕ ОРУЖИЕ " + roll + "\n";

                return;
            }
            Log.Text += "Ваш бросок на тяжелое оружие = " + summ + "(" + mod + ")" + "\n"; 
        }

        private void EnergyWeaponRoll_Click(object sender, EventArgs e)
        {
            
            ///////////////////////////
            int value = (int)EnergyWeapons1.Value;
            int mod = Modificator(value);
            ///////////////////////////////////////////////
            int roll = rand.Next(1, 20);
            int summ = roll + mod;
            if (roll == 19 || roll == 20)
            {
                Log.Text += "КРИТИЧЕСКИЙ БРОСОК НА ЕНЕРГЕТИЧЕСКОЕ ОРУЖИЕ  " + roll + "\n";

                return;
            }
            if (roll == 1 || roll == 2)
            {
                Log.Text += "КРИТИЧЕСКИЙ ПРОМАХ НА ЕНЕРГЕТИЧЕСКОЕ ОРУЖИЕ " + roll + "\n";

                return;
            }
            Log.Text += "Ваш бросок на енергетическое оружие = " + summ + "(" + mod + ")" + "\n";
        }

        private void UnarmedRoll_Click(object sender, EventArgs e)
        {
           
            ///////////////////////////
            int value = (int)Unarmed1.Value;
            int mod = Modificator(value);
            ///////////////////////////////////////////////
            int roll = rand.Next(1, 20);
            int summ = roll + mod;
            if (roll == 19 || roll == 20)
            {
                Log.Text += "КРИТИЧЕСКИЙ БРОСОК НА БЕЗ ОРУЖИЯ  " + roll + "\n";

                return;
            }
            if (roll == 1 || roll == 2)
            {
                Log.Text += "КРИТИЧЕСКИЙ ПРОМАХ НА БЕЗ ОРУЖИЯ " + roll + "\n";

                return;
            }
            Log.Text += "Ваш бросок на без оружия = " + summ + "(" + mod + ")" + "\n";
        }

        private void ColdWeaponRoll_Click(object sender, EventArgs e)
        {
            
            ///////////////////////////
            int value = (int)ColdWeapons1.Value;
            int mod = Modificator(value);
            ///////////////////////////////////////////////
            int roll = rand.Next(1, 20);
            int summ = roll + mod;
            if (roll == 19 || roll == 20)
            {
                Log.Text += "КРИТИЧЕСКИЙ БРОСОК НА ХОЛОДНОЕ ОРУЖИЕ  " + roll + "\n";

                return;
            }
            if (roll == 1 || roll == 2)
            {
                Log.Text += "КРИТИЧЕСКИЙ ПРОМАХ НА ХОЛОДНОЕ ОРУЖИЕ " + roll + "\n";

                return;
            }
            Log.Text += "Ваш бросок на холодное оружие = " + summ + "(" + mod + ")" + "\n";

        }

        private void TrowWeaponRoll_Click(object sender, EventArgs e)
        {
            
            ///////////////////////////
            int value = (int)ThrowingWeapons1.Value;
            int mod = Modificator(value);
            ///////////////////////////////////////////////
            int roll = rand.Next(1, 20);
            int summ = roll + mod;
            if (roll == 19 || roll == 20)
            {
                Log.Text += "КРИТИЧЕСКИЙ БРОСОК НА МЕТАТЕЛЬНОЕ ОРУЖИЕ  " + roll + "\n";

                return;
            }
            if (roll == 1 || roll == 2)
            {
                Log.Text += "КРИТИЧЕСКИЙ ПРОМАХ НА МЕТАТЕЛЬНОЕ ОРУЖИЕ " + roll + "\n";

                return;
            }
            Log.Text += "Ваш бросок на метательное оружие = " + summ + "(" + mod + ")" + "\n";
        }

        private void MedicWeaponRoll_Click(object sender, EventArgs e)
        {
            
            ///////////////////////////
            int value = (int)Medic1.Value;
            int mod = Modificator(value);
            ///////////////////////////////////////////////
            int roll = rand.Next(1, 20);
            int summ = roll + mod;
            if (roll == 19 || roll == 20)
            {
                Log.Text += "КРИТИЧЕСКИЙ БРОСОК НА МЕДИКА  " + roll + "\n";

                return;
            }
            if (roll == 1 || roll == 2)
            {
                Log.Text += "КРИТИЧЕСКИЙ ПРОМАХ НА МЕДИКА " + roll + "\n";

                return;
            }
            Log.Text += "Ваш бросок на медика = " + summ + "(" + mod + ")" + "\n"; 
        }

        private void RepairRoll_Click(object sender, EventArgs e)
        {
           
            ///////////////////////////
            int value = (int)Repair1.Value;
            int mod = Modificator(value);
            ///////////////////////////////////////////////
            int roll = rand.Next(1, 20);
            int summ = roll + mod;
            if (roll == 19 || roll == 20)
            {
                Log.Text += "КРИТИЧЕСКИЙ БРОСОК НА РЕМОНТ  " + roll + "\n";

                return;
            }
            if (roll == 1 || roll == 2)
            {
                Log.Text += "КРИТИЧЕСКИЙ ПРОМАХ НА РЕМОНТ " + roll + "\n";

                return;
            }
            Log.Text += "Ваш бросок на ремонт = " + summ + "(" + mod + ")" + "\n";
        }

        private void ScienceRoll_Click(object sender, EventArgs e)
        {
            
            ///////////////////////////
            int value = (int)Science1.Value;
            int mod = Modificator(value);
            ///////////////////////////////////////////////
            int roll = rand.Next(1, 20);
            int summ = roll + mod;
            if (roll == 19 || roll == 20)
            {
                Log.Text += "КРИТИЧЕСКИЙ БРОСОК НА ЗНАНИЯ/НАУКУ  " + roll + "\n";

                return;
            }
            if (roll == 1 || roll == 2)
            {
                Log.Text += "КРИТИЧЕСКИЙ ПРОМАХ НА ЗНАНИЯ/НАУКУ " + roll + "\n";

                return;
            }
            Log.Text += "Ваш бросок на знания/науку = " + summ + "(" + mod + ")" + "\n";
        }

        private void OratoryRoll_Click(object sender, EventArgs e)
        {
            
            ///////////////////////////
            int value = (int)Oratory1.Value;
            int mod = Modificator(value);
            ///////////////////////////////////////////////
            int roll = rand.Next(1, 20);
            int summ = roll + mod;
            if (roll == 19 || roll == 20)
            {
                Log.Text += "КРИТИЧЕСКИЙ БРОСОК НА КРАСНОРЕЧИЕ  " + roll + "\n";

                return;
            }
            if (roll == 1 || roll == 2)
            {
                Log.Text += "КРИТИЧЕСКИЙ ПРОМАХ НА КРАСНОРЕЧИЕ " + roll + "\n";

                return;
            }
            Log.Text += "Ваш бросок на красноречие = " + summ + "(" + mod + ")" + "\n";
        }

        private void BarterRoll_Click(object sender, EventArgs e)
        {
            
            ///////////////////////////
            int value = (int)Barter1.Value;
            int mod = Modificator(value);
            ///////////////////////////////////////////////
            int roll = rand.Next(1, 20);
            int summ = roll + mod;
            if (roll == 19 || roll == 20)
            {
                Log.Text += "КРИТИЧЕСКИЙ БРОСОК НА ТОРГОВЛЮ  " + roll + "\n";

                return;
            }
            if (roll == 1 || roll == 2)
            {
                Log.Text += "КРИТИЧЕСКИЙ ПРОМАХ НА ТОРГОВЛЮ " + roll + "\n";

                return;
            }
            Log.Text += "Ваш бросок на торговлю = " + summ + "(" + mod + ")" + "\n";
        }

        private void SurvivalRoll_Click(object sender, EventArgs e)
        {
            
            ///////////////////////////
            int value = (int)Survival1.Value;
            int mod = Modificator(value);
            ///////////////////////////////////////////////
            int roll = rand.Next(1, 20);
            int summ = roll + mod;
            if (roll == 19 || roll == 20)
            {
                Log.Text += "КРИТИЧЕСКИЙ БРОСОК НА ВЫЖИВАНИЕ  " + roll + "\n";

                return;
            }
            if (roll == 1 || roll == 2)
            {
                Log.Text += "КРИТИЧЕСКИЙ ПРОМАХ НА ВЫЖИВАНИЕ " + roll + "\n";

                return;
            }
            Log.Text += "Ваш бросок на выживание = " + summ + "(" + mod + ")" + "\n";
        }

        private void LockpickRoll_Click(object sender, EventArgs e)
        {
            
            int value = (int)Lockpick1.Value;
            int mod = Modificator(value);
            ///////////////////////////////////////////////
            int roll = rand.Next(1, 20);
            int summ = roll + mod;
            if (roll == 19 || roll == 20)
            {
                Log.Text += "КРИТИЧЕСКИЙ БРОСОК НА ВЗЛОМ  " + roll + "\n";

                return;
            }
            if (roll == 1 || roll == 2)
            {
                Log.Text += "КРИТИЧЕСКИЙ ПРОМАХ НА ВЗЛОМ " + roll + "\n";

                return;
            }
            Log.Text += "Ваш бросок на взлом = " + summ + "(" + mod + ")" + "\n";
        }

        private void StealRoll_Click(object sender, EventArgs e)
        {
           
            ///////////////////////////
            int value = (int)Theft1.Value;
            int mod = Modificator(value);
            ///////////////////////////////////////////////
            int roll = rand.Next(1, 20);
            int summ = roll + mod;
            if (roll == 19 || roll == 20)
            {
                Log.Text += "КРИТИЧЕСКИЙ БРОСОК НА КРАЖУ  " + roll + "\n";

                return;
            }
            if (roll == 1 || roll == 2)
            {
                Log.Text += "КРИТИЧЕСКИЙ ПРОМАХ НА КРАЖУ " + roll + "\n";

                return;
            }
            Log.Text += "Ваш бросок на кражу = " + summ + "(" + mod + ")" + "\n";
        }

        private void StealthRoll_Click(object sender, EventArgs e)
        {
           
            ///////////////////////////
            int value = (int)Stealth1.Value;
            int mod = Modificator(value);
            ///////////////////////////////////////////////
            int roll = rand.Next(1, 20);
            int summ = roll + mod;
            if (roll == 19 || roll == 20)
            {
                Log.Text += "КРИТИЧЕСКИЙ БРОСОК НА СКРЫТНОСТЬ  " + roll + "\n";

                return;
            }
            if (roll == 1 || roll == 2)
            {
                Log.Text += "КРИТИЧЕСКИЙ ПРОМАХ НА СКРЫТНОСТЬ " + roll + "\n";

                return;
            }
            Log.Text += "Ваш бросок на скрытность = " + summ + "(" + mod + ")" + "\n";
        }

        private void SabotageRoll_Click(object sender, EventArgs e)
        { 
            ///////////////////////////
            int value = (int)SabotageExplosives1.Value;
            int mod = Modificator(value);
            ///////////////////////////////////////////////
            int roll = rand.Next(1, 20);
            int summ = roll + mod;
            if (roll == 19 || roll == 20)
            {
                Log.Text += "КРИТИЧЕСКИЙ БРОСОК НА ВЗРЫВЧАТКУ  " + roll + "\n";

                return;
            }
            if (roll == 1 || roll == 2)
            {
                Log.Text += "КРИТИЧЕСКИЙ ПРОМАХ НА ВЗРЫВЧАТКУ " + roll + "\n";

                return;
            }
            Log.Text += "Ваш бросок на взрывчатку = " + summ + "(" + mod + ")" + "\n";
        }

        private void Roll_Click(object sender, EventArgs e)
        {
            int roll = rand.Next(1, (int)RollValue.Value);
            if (roll == 19 || roll == 20)
            {
                Log.Text += "КРИТИЧЕСКИЙ БРОСОК  " + roll + "\n";

                return;
            }
            if (roll == 1 || roll == 2)
            {
                Log.Text += "КРИТИЧЕСКИЙ ПРОМАХ  " + roll + "\n";

                return;
            }
            Log.Text += "Ваш бросок = " + roll + "\n";
        }

        private int Modificator(int value)
        {
            int mod=-5;
            if (value >= 1 & value < 20)
            {
                mod = -5;
            }
            else if (value >= 20 & value < 30)
            {
                mod = -4;
            }
            else if (value >= 30 & value < 40)
            {
                mod = -3;
            }
            else if (value >= 40 & value < 50)
            {
                mod = -2;
            }
            else if (value >= 50 & value < 60)
            {
                mod = -1;
            }
            else if (value >= 60 & value < 70)
            {
                mod = 0;
            }
            else if (value >= 70 & value < 80)
            {
                mod = 1;
            }
            else if (value >= 80 & value < 90)
            {
                mod = 2;
            }
            else if (value >= 90 & value < 110)
            {
                mod = 3;
            }
            else if (value >= 110 & value < 135)
            {
                mod = 4;
            }
            else if (value >= 135 & value <= 155)
            {
                mod = 5;
            }

            return mod;
        }
    }
}