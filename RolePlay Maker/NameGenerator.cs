using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolePlay_Maker
{
    class NameGenerator
    {
        private static readonly string[] names =
        {
            "Вайлит",
            "Шеф-Шеф",
            "Драйвер Нефи",
            "Дюк",
            "Джексон",
            "Антони",
            "Эмма",
            "Линда",
            "Маргарет",
            "Томас",
            "Патрисия",
            "Лиза",
            "Дэвид",
            "Дональд",
            "Кристофер",
            "Шэрон",
            "Стивен",
            "Джэк",
            //TODO: Add more names;
        };
        private static readonly string[] surnames =
        {
            "",
            //TODO: Add more surnames
        };

        public static string Generate(string Fraction = "")
        {
            string name = names[new Random().Next(0, names.Length)];
            string surname = surnames[new Random().Next(0, surnames.Length)];

            return Fraction + name + " " + surname;
        }
    }
}
