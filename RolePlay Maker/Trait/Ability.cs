using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlay_Maker
{
    class Ability : TraitAbilityContainer
    {
        public string requirement; //Требования
        public int rangs; //Ранги
        public Ability(IList<object> values)
        {
            this.Name = values[0].ToString();
            this.Advantage = values[1].ToString();
            this.requirement = values[2].ToString();
            this.rangs = Int32.Parse(values[3].ToString());
        }
    }
}
