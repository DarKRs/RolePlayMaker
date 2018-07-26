using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlay_Maker
{
    class Armor : Item
    {
        public int AP;
        public int Price;
        public int KB;
        public string Class;
        public string Effects;

        public Armor()
        {
            this.Type = "";
            this.Class = "";
            this.Name = "Нет";
            this.KB = 0;
            this.AP = 0;
            this.Description = "";
            this.Effects = "";
            this.Price = 0;
            this.Fraction = "";
        }

        public Armor(string ClassType, string Name, int AP, int Price, string Description)
        {
            this.Type = "Armor";
            this.Class = ClassType;
            this.Name = Name;
            this.AP = AP;
            this.Price = Price;
            this.Description = Description;
        }

        public Armor(string ClassType, IList<object> values)
        {
            this.Type = "Armor";
            this.Class = ClassType;
            this.Name = values[0].ToString();
            this.KB = Int32.Parse(values[1].ToString());
            this.AP = Int32.Parse(values[2].ToString());
            this.Description = values[3].ToString();
            this.Effects = values[4].ToString();
            this.Price = Int32.Parse(values[5].ToString());
            this.Fraction = values[6].ToString();
        }

    }
}
