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
    public partial class Form2 : Form
    {
        bool SPECIAL = true;
        MainForm Fm1;
        public Form2()
        {
            InitializeComponent();
            Fm1 = this.Owner as MainForm;
            LightWeapons1.Value = 30 + (int)Agility.Value + (int)Luck.Value / 2;
            HeavyWeapons1.Value = 15 + (int)Strengt.Value + (int)Agility.Value / 2 + (int)Luck.Value / 2;
            EnergyWeapons1.Value = 10 + (int)Agility.Value + ((int)Intelligence.Value / 2) + (int)Luck.Value / 2;
            Unarmed1.Value = 30 + 2 * ((int)Strengt.Value + (int)Agility.Value) + (int)Luck.Value / 2;
            ColdWeapons1.Value = 20 + 2 * ((int)Strengt.Value + (int)Agility.Value) + (int)Luck.Value / 2;
            ThrowingWeapons1.Value = 30 + (int)Agility.Value + (int)Luck.Value / 2;
            Medic1.Value = 15 + ((int)Perception.Value + (int)Intelligence.Value) * 2 + (int)Luck.Value / 2;
            Repair1.Value = 20 + (int)Intelligence.Value + (int)Luck.Value / 2;
            Science1.Value = 20 + (2 * (int)Intelligence.Value) + (int)Luck.Value / 2;
            Oratory1.Value = 25 + 2 * (int)Charisma.Value + (int)Luck.Value / 2;
            Barter1.Value = 20 + 2 * (int)Charisma.Value + (int)Luck.Value / 2;
            Survival1.Value = 10 + 2 * ((int)Endurance.Value + (int)Intelligence.Value) + (int)Luck.Value / 2;
            Lockpick1.Value = 15 + (int)Perception.Value + (int)Agility.Value + (int)Luck.Value / 2;
            Theft1.Value = 20 + (int)Agility.Value + (int)Luck.Value / 2;
            Stealth1.Value = 25 + (int)Agility.Value + (int)Luck.Value / 2;
            SabotageExplosives1.Value = 15 + ((int)Perception.Value + (int)Agility.Value) + (int)Luck.Value / 2;
            SkillPoints.Value = 5 + 2 * (int)Intelligence.Value;
            HpValue.Value = MaxHpValue.Value;
            MaxHpValue.Value = 10 + Strengt.Value + (Endurance.Value * 2);
            HpValue.Value = MaxHpValue.Value;
            KBnumeric.Value = Agility.Value + UpedArmor.Value;
            UpedArmor.Value=0;
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
        }


        public void Perception_ValueChanged(object sender, EventArgs e) //Изменение навыков зависящих от восприятия
        {
            Medic1.Value = 15 + ((int)Perception.Value + (int)Intelligence.Value) * 2 + (int)Luck.Value / 2;
            Lockpick1.Value = 15 + (int)Perception.Value + (int)Agility.Value + (int)Luck.Value / 2;
            SabotageExplosives1.Value = 15 + ((int)Perception.Value + (int)Agility.Value) + (int)Luck.Value / 2;
        }

        private void Endurance_ValueChanged(object sender, EventArgs e) //Изменение навыков зависящих от выносливости
        {
            MaxHpValue.Value = 10 + Strengt.Value + (Endurance.Value * 2);
            Survival1.Value = 10 + 2 * ((int)Endurance.Value + (int)Intelligence.Value) + (int)Luck.Value / 2;
            HpValue.Value = MaxHpValue.Value;
        }

        private void Charisma_ValueChanged(object sender, EventArgs e) //Изменение навыков зависящих от харизмы
        {
            Oratory1.Value = 25 + 2 * (int)Charisma.Value + (int)Luck.Value / 2;
            Barter1.Value = 20 + 2 * (int)Charisma.Value + (int)Luck.Value / 2;
        }

        private void Intelligence_ValueChanged(object sender, EventArgs e) //Изменение навыков зависящих от интелекта
        {
            EnergyWeapons1.Value = 10 + (int)Agility.Value + ((int)Intelligence.Value / 2) + (int)Luck.Value / 2;
            Medic1.Value = 15 + ((int)Perception.Value + (int)Intelligence.Value) * 2 + (int)Luck.Value / 2;
            Repair1.Value = 20 + (int)Intelligence.Value + (int)Luck.Value / 2;
            Science1.Value = 20 + (2 * (int)Intelligence.Value) + (int)Luck.Value / 2;
            Survival1.Value = 10 + 2 * ((int)Endurance.Value + (int)Intelligence.Value) + (int)Luck.Value / 2;
            SkillPoints.Value = 5 + 2 * (int)Intelligence.Value;
        }

        private void Agility_ValueChanged(object sender, EventArgs e) //Изменение навыков зависящих от ловкости
        {
            LightWeapons1.Value = 30 + (int)Agility.Value + (int)Luck.Value / 2;
            HeavyWeapons1.Value = 15 + (int)Strengt.Value + (int)Agility.Value / 2 + (int)Luck.Value / 2;
            EnergyWeapons1.Value = 10 + (int)Agility.Value + ((int)Intelligence.Value / 2) + (int)Luck.Value / 2;
            Unarmed1.Value = 30 + 2 * ((int)Strengt.Value + (int)Agility.Value) + (int)Luck.Value / 2;
            ColdWeapons1.Value = 20 + 2 * ((int)Strengt.Value + (int)Agility.Value) + (int)Luck.Value / 2;
            ThrowingWeapons1.Value = 30 + (int)Agility.Value + (int)Luck.Value / 2;
            Lockpick1.Value = 15 + (int)Perception.Value + (int)Agility.Value + (int)Luck.Value / 2;
            Theft1.Value = 20 + (int)Agility.Value + (int)Luck.Value / 2;
            Stealth1.Value = 25 + (int)Agility.Value + (int)Luck.Value / 2;
            SabotageExplosives1.Value = 15 + ((int)Perception.Value + (int)Agility.Value) + (int)Luck.Value / 2;
            int ag = (int)Agility.Value;
            KBnumeric.Value = (int)(ag * 1.3);
        }

        private void Luck_ValueChanged(object sender, EventArgs e) //Изменение навыков зависящих от удачи
        {
            LightWeapons1.Value = 30 + (int)Agility.Value + (int)Luck.Value / 2;
            HeavyWeapons1.Value = 15 + (int)Strengt.Value + (int)Agility.Value / 2 + (int)Luck.Value / 2;
            EnergyWeapons1.Value = 10 + (int)Agility.Value + ((int)Intelligence.Value / 2) + (int)Luck.Value / 2;
            Unarmed1.Value = 30 + 2 * ((int)Strengt.Value + (int)Agility.Value) + (int)Luck.Value / 2;
            ColdWeapons1.Value = 20 + 2 * ((int)Strengt.Value + (int)Agility.Value) + (int)Luck.Value / 2;
            ThrowingWeapons1.Value = 30 + (int)Agility.Value + (int)Luck.Value / 2;
            Medic1.Value = 15 + ((int)Perception.Value + (int)Intelligence.Value) * 2 + (int)Luck.Value / 2;
            Repair1.Value = 20 + (int)Intelligence.Value + (int)Luck.Value / 2;
            Science1.Value = 20 + (2 * (int)Intelligence.Value) + (int)Luck.Value / 2;
            Oratory1.Value = 25 + 2 * (int)Charisma.Value + (int)Luck.Value / 2;
            Barter1.Value = 20 + 2 * (int)Charisma.Value + (int)Luck.Value / 2;
            Survival1.Value = 10 + 2 * ((int)Endurance.Value + (int)Intelligence.Value) + (int)Luck.Value / 2;
            Lockpick1.Value = 15 + (int)Perception.Value + (int)Agility.Value + (int)Luck.Value / 2;
            Theft1.Value = 20 + (int)Agility.Value + (int)Luck.Value / 2;
            Stealth1.Value = 25 + (int)Agility.Value + (int)Luck.Value / 2;
            SabotageExplosives1.Value = 15 + ((int)Perception.Value + (int)Agility.Value) + (int)Luck.Value / 2;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if(NameTextBox1.Text == "")
            {
                MessageBox.Show(
                       "Введите имя вашего персонажа!",
                       "Ты че еблан? Имя то введи!",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.DefaultDesktopOnly);
                return;
            }

            CreatefolderBrowser.ShowDialog();
            if (CreatefolderBrowser.SelectedPath == "")
            {
                MessageBox.Show(
                       "Выберите путь куда создавать персонажа",
                       "И куда перса создавать? Ты путь то выбери!",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.DefaultDesktopOnly);
                return;
            }
            string path = CreatefolderBrowser.SelectedPath;
            string name = NameTextBox1.Text + ".rpm";
            string file = Path.Combine(path,name);
            Person nwPer = new Person(NameTextBox1.Text,ClasstextBox1.Text,TraitcomboBox1.Text,(int)UpedArmor.Value, (int)Strengt.Value, (int)Perception.Value,(int)Endurance.Value,(int)Charisma.Value,
                (int)Intelligence.Value,(int)Agility.Value,(int)Luck.Value,Head.Text,Neck.Text,Shoulders.Text,Spine.Text,Chest.Text,Hand.Text,Gloves.Text,Belt.Text,Pants.Text,Shoes.Text,
                Finger1.Text,Finger2.Text,Finger3.Text,Finger4.Text,Other.Text,RightHand.Text,LeftHand.Text,Replacement.Text,BackpackTextBox1.Text);
            nwPer.Effects = Effects.Text;
            nwPer.Save(file);
            MessageBox.Show(
                       "Вы создали персонажа. Форма создания персонажа закроется",
                       "Поздравляю персонаж создан",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information,
                       MessageBoxDefaultButton.Button1,
                       MessageBoxOptions.DefaultDesktopOnly);
            Owner.Activate();
            Close();
            
        }




        private void Strengt_ValueChanged(object sender, EventArgs e)
        { 
            MaxHpValue.Value = 10 + (int)Strengt.Value + ((int)Endurance.Value * 2);
            HeavyWeapons1.Value = 15 + (int)Strengt.Value + (int)Agility.Value / 2 + (int)Luck.Value / 2;
            Unarmed1.Value = 30 + 2 * ((int)Strengt.Value + (int)Agility.Value) + (int)Luck.Value / 2;
            ColdWeapons1.Value = 20 + 2 * ((int)Strengt.Value + (int)Agility.Value) + (int)Luck.Value / 2;
            HpValue.Value = MaxHpValue.Value;
        }



        private void TraitcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch ((string)TraitcomboBox1.SelectedItem)
            {
                case "Хулиган": Effects.Text = "Черта Хулиган - +1 к Силе \n"; break;
                case "Ускоренный метаболизм": Effects.Text = "Черта Ускоренный метаболизм - 2+ к скорости лечения при сне \n Врожденная сопротивляемость ядам и сопротивляемость радиации равна 0 %.\n"; break;
                case "Миниатюрный": Effects.Text = "Черта Миниатюрный - +1 к Ловкости \n"; break;
                case "Однорукий": Effects.Text = "Черта Однорукий - +15 для одноручного оружия \n -4 к попаданию для двуручного оружия \n"; break;
                case "Сексапильность": Effects.Text = "Черта Сексапильность - \n +1 Привлекательность при общении с персонажами противоположного пола Упрощённая возможность добиться близости персонажа, позволяющего это \n -1 Привлекательность при общении с персонажами одного пола \n"; break;
                case "Каннибал": Effects.Text = "Черта Каннибал - Ням ням ням. \n Лучше не делать этого на людях. \n"; break;
                case "Тяжёлая рука": Effects.Text = "Черта Тяжёлая рука - +5 к бою без оружия \n -1 к попаданию \n"; break;
                case "Стрельба навскидку": Effects.Text = "Черта Стрельба навскидку - Возможность произвести несколько выстрелов \n -4 КБ \n"; break;
                case "Улучшенная инициатива": Effects.Text = "Черта Улучшенная инициатива - +4 к проверкам инициативы \n"; break;
                case "Добрая душа": Effects.Text = "Черта Добрая душа - Медик +15, Красноречие +15 и Бартер +15 \n Лёгкое оружие −10 , Тяжёлое оружие −10 , Энергетическое оружие −10 , Без оружия −10  и Холодное оружие −10  \n"; break;
                case "Чувствительность к химии": Effects.Text = "Черта Чувствительность к химии - Сокращение времени действия негативных эффектов препаратов в два раза и увеличение действия положительных эффектов \n Удвоенная вероятность возникновения зависимости \n"; break;
                case "Сопротивляемость химии": Effects.Text = "Черта Сопротивляемость химии - Шанс возникновения зависимости от препарата ниже в 2 раза \n Эффективность или время воздействие препаратов ниже в 2 раза \n"; break;
                case "Тренированный": Effects.Text = "Черта Тренированный - 5+ очков навыков за каждый уровень \n 1+ скорость получения способностей (то есть новая способность каждый третий уровень вместо каждого второго) \n"; break;
                case "Одарённый": Effects.Text = "Черта Одарённый - 1+ ко всем основным характеристикам \n −20 ко всем навыкам, −5 очков навыков на каждый уровень \n"; break;
                case "Эксперт": Effects.Text = "Черта Эксперт - 30+ к выбранному навыку \n -15 и -15 к двум другим \n"; break;
                case "Живучесть": Effects.Text = "Черта Живучесть - +10 ХП \n"; break;
                case "Незаметность": Effects.Text = "Черта Незаметность - Вас труднее заметить если вы действительно одеты в незаметную одежду. \n"; break;
                case "Порченый": Effects.Text = "Черта Порченый - Если вы критически промахиваетесь то промахиваются и все вокруг вас \n Высокий шанс на то, что промах станет критическим, у Вас. -3 к броску кубика. Модификаторы могут сделать бросок критическим \n"; break;
                case "Выходец из племени Арройя": Effects.Text = "Черта Выходец из племени Арройя - 15+ к холодному оружию и 15+ к без оружия и 15+ к метательному + 15 к натуралисту \n -20  к наука, энергетическое оружие,диверсия/взрывчатка, - 10 к ремонт \n"; break;
                default: Effects.Text = TraitcomboBox1.Text + "\n"; break;
            }
      
        }

        private void PlusLightWeapon_Click(object sender, EventArgs e)
        {
            ProverkaSpecial();
            if (!SPECIAL)
            {
                if (SkillPoints.Value > 0)
                {
                    LightWeapons1.Value++;
                    SkillPoints.Value--;
                }
                else
                {
                    MessageBox.Show("Ты видишь очки навыков? Я тоже не вижу!",
                        "Ну ты пиздос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void PlusHeavyWeapon_Click(object sender, EventArgs e)
        {
            ProverkaSpecial();
            if (!SPECIAL)
            {
                if (SkillPoints.Value > 0)
                {
                    HeavyWeapons1.Value++;
                    SkillPoints.Value--;
                }
                else
                {
                    MessageBox.Show("Ты видишь очки навыков? Я тоже не вижу!",
                        "Ну ты пиздос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void PlusEnergyWeapon_Click(object sender, EventArgs e)
        {
            ProverkaSpecial();
            if (!SPECIAL)
            {
                if (SkillPoints.Value > 0)
                {
                    EnergyWeapons1.Value++;
                    SkillPoints.Value--;
                }
                else
                {
                    MessageBox.Show("Ты видишь очки навыков? Я тоже не вижу!",
                        "Ну ты пиздос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void PlusUnarmed_Click(object sender, EventArgs e)
        {
            ProverkaSpecial();
            if (!SPECIAL)
            {
                if (SkillPoints.Value > 0)
                {
                    Unarmed1.Value++;
                    SkillPoints.Value--;
                }
                else
                {
                    MessageBox.Show("Ты видишь очки навыков? Я тоже не вижу!",
                        "Ну ты пиздос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void PlusColdWeapon_Click(object sender, EventArgs e)
        {
            ProverkaSpecial();
            if (!SPECIAL)
            {
                if (SkillPoints.Value > 0)
                {
                    ColdWeapons1.Value++;
                    SkillPoints.Value--;
                }
                else
                {
                    MessageBox.Show("Ты видишь очки навыков? Я тоже не вижу!",
                        "Ну ты пиздос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void PlusThrowWeapon_Click(object sender, EventArgs e)
        {
            ProverkaSpecial();
            if (!SPECIAL)
            {
                if (SkillPoints.Value > 0)
                {
                    ThrowingWeapons1.Value++;
                    SkillPoints.Value--;
                }
                else
                {
                    MessageBox.Show("Ты видишь очки навыков? Я тоже не вижу!",
                        "Ну ты пиздос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void PlusMedic_Click(object sender, EventArgs e)
        {
            ProverkaSpecial();
            if (!SPECIAL)
            {
                if (SkillPoints.Value > 0)
                {
                    Medic1.Value++;
                    SkillPoints.Value--;
                }
                else
                {
                    MessageBox.Show("Ты видишь очки навыков? Я тоже не вижу!",
                        "Ну ты пиздос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void PlusRepair_Click(object sender, EventArgs e)
        {
            ProverkaSpecial();
            if (!SPECIAL)
            {
                if (SkillPoints.Value > 0)
                {
                    Repair1.Value++;
                    SkillPoints.Value--;
                }
                else
                {
                    MessageBox.Show("Ты видишь очки навыков? Я тоже не вижу!",
                        "Ну ты пиздос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void PlusScience_Click(object sender, EventArgs e)
        {
            ProverkaSpecial();
            if (!SPECIAL)
            {
                if (SkillPoints.Value > 0)
                {
                    Science1.Value++;
                    SkillPoints.Value--;
                }
                else
                {
                    MessageBox.Show("Ты видишь очки навыков? Я тоже не вижу!",
                        "Ну ты пиздос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void PlusOratory_Click(object sender, EventArgs e)
        {
            ProverkaSpecial();
            if (!SPECIAL)
            {
                if (SkillPoints.Value > 0)
                {
                    Oratory1.Value++;
                    SkillPoints.Value--;
                }
                else
                {
                    MessageBox.Show("Ты видишь очки навыков? Я тоже не вижу!",
                        "Ну ты пиздос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void PlusBarter_Click(object sender, EventArgs e)
        {
            ProverkaSpecial();
            if (!SPECIAL)
            {
                if (SkillPoints.Value > 0)
                {
                    Barter1.Value++;
                    SkillPoints.Value--;
                }
                else
                {
                    MessageBox.Show("Ты видишь очки навыков? Я тоже не вижу!",
                        "Ну ты пиздос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void PlusSurvival_Click(object sender, EventArgs e)
        {
            ProverkaSpecial();
            if (!SPECIAL)
            {
                if (SkillPoints.Value > 0)
                {
                    Survival1.Value++;
                    SkillPoints.Value--;
                }
                else
                {
                    MessageBox.Show("Ты видишь очки навыков? Я тоже не вижу!",
                        "Ну ты пиздос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void PlusLockpick_Click(object sender, EventArgs e)
        {
            ProverkaSpecial();
            if (!SPECIAL)
            {
                if (SkillPoints.Value > 0)
                {
                    Lockpick1.Value++;
                    SkillPoints.Value--;
                }
                else
                {
                    MessageBox.Show("Ты видишь очки навыков? Я тоже не вижу!",
                        "Ну ты пиздос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void PlusSteal_Click(object sender, EventArgs e)
        {
            ProverkaSpecial();
            if (!SPECIAL)
            {
                if (SkillPoints.Value > 0)
                {
                    Theft1.Value++;
                    SkillPoints.Value--;
                }
                else
                {
                    MessageBox.Show("Ты видишь очки навыков? Я тоже не вижу!",
                        "Ну ты пиздос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void PlusStealth_Click(object sender, EventArgs e)
        {
            ProverkaSpecial();
            if (!SPECIAL)
            {
                if (SkillPoints.Value > 0)
                {
                    Stealth1.Value++;
                    SkillPoints.Value--;
                }
                else
                {
                    MessageBox.Show("Ты видишь очки навыков? Я тоже не вижу!",
                        "Ну ты пиздос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void PlusExploziv_Click(object sender, EventArgs e)
        {
            ProverkaSpecial();
            if (!SPECIAL)
            {
                if (SkillPoints.Value > 0)
                {
                    SabotageExplosives1.Value++;
                    SkillPoints.Value--;
                }
                else
                {
                    MessageBox.Show("Ты видишь очки навыков? Я тоже не вижу!",
                        "Ну ты пиздос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void ProverkaSpecial()
        {
            if (SPECIAL && MessageBox.Show("Ты закончил со S.P.E.C.I.A.L?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == DialogResult.OK)
            {
                Strengt.ReadOnly = true;
                Perception.ReadOnly = true;
                Endurance.ReadOnly = true;
                Charisma.ReadOnly = true;
                Intelligence.ReadOnly = true;
                Agility.ReadOnly = true;
                Luck.ReadOnly = true;
                SPECIAL = false;
            }
            
        }

        private void ResetSkils_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сбросить навыки??", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop) == DialogResult.OK)
            {
                SkillPoints.Value = 5 + 2 * (int)Intelligence.Value;
                LightWeapons1.Value = 30 + (int)Agility.Value + (int)Luck.Value / 2;
                HeavyWeapons1.Value = 15 + (int)Strengt.Value + (int)Agility.Value / 2 + (int)Luck.Value / 2;
                EnergyWeapons1.Value = 10 + (int)Agility.Value + ((int)Intelligence.Value / 2) + (int)Luck.Value / 2;
                Unarmed1.Value = 30 + 2 * ((int)Strengt.Value + (int)Agility.Value) + (int)Luck.Value / 2;
                ColdWeapons1.Value = 20 + 2 * ((int)Strengt.Value + (int)Agility.Value) + (int)Luck.Value / 2;
                ThrowingWeapons1.Value = 30 + (int)Agility.Value + (int)Luck.Value / 2;
                Medic1.Value = 15 + ((int)Perception.Value + (int)Intelligence.Value) * 2 + (int)Luck.Value / 2;
                Repair1.Value = 20 + (int)Intelligence.Value + (int)Luck.Value / 2;
                Science1.Value = 20 + (2 * (int)Intelligence.Value) + (int)Luck.Value / 2;
                Oratory1.Value = 25 + 2 * (int)Charisma.Value + (int)Luck.Value / 2;
                Barter1.Value = 20 + 2 * (int)Charisma.Value + (int)Luck.Value / 2;
                Survival1.Value = 10 + 2 * ((int)Endurance.Value + (int)Intelligence.Value) + (int)Luck.Value / 2;
                Lockpick1.Value = 15 + (int)Perception.Value + (int)Agility.Value + (int)Luck.Value / 2;
                Theft1.Value = 20 + (int)Agility.Value + (int)Luck.Value / 2;
                Stealth1.Value = 25 + (int)Agility.Value + (int)Luck.Value / 2;
                SabotageExplosives1.Value = 15 + ((int)Perception.Value + (int)Agility.Value) + (int)Luck.Value / 2;
            }
        }
    }
}
