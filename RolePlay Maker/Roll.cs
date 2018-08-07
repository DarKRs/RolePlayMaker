using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RolePlay_Maker
{
    [DataContract]
    class DRoll
    {
        [DataMember]
        public int D;
        [DataMember]
        Random rnd = new Random();
        public DRoll(string D)
        {
            var re = new Regex("D");
            var _re = new Regex("d");
            D = re.Replace(D, "");
            D = _re.Replace(D, "");
            this.D = Int32.Parse(D);
        }

        public DRoll(int D)
        {

            this.D = D;
        }

        public int Roll()
        {
            return rnd.Next(1, D+1);
        } 

    }
}
