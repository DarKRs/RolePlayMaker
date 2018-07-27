﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RolePlay_Maker
{
    class DRoll
    {
        private int D;
        public DRoll(string D)
        {
            var re = new Regex("D");
            var _re = new Regex("d");
            D = re.Replace(D, "");
            D = _re.Replace(D, "");
            this.D = Int32.Parse(D);
        }

        public int Roll()
        {
            return new Random().Next(1, D);
        } 
    }
}