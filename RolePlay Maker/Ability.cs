using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlay_Maker
{
    class Ability : Item
    {
        public string requirement; //Требования
        public int rangs; //Ранги
        public Ability(string Name, string requirement, int rang, string Description)
        {
            this.Type = "Ability";
            this.Name = Name;
            this.rangs = rang;
            this.requirement = requirement;
            this.Description = Description;
        }
    }
}
