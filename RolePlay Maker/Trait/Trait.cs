using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlay_Maker
{
    class Trait : TraitAbilityContainer
    {

        public string Disadvantage;

        public Trait(IList<object> values)
        {
            this.Name = values[0].ToString();
            this.Advantage = values[1].ToString();
            this.Disadvantage = values[2].ToString();
        }
    }
}
