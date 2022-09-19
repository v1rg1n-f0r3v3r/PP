using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PP.Model
{
    public class Objectz
    {
        public string Date { get; set; }
        public string Name { get; set; }

        public static Objectz[] GetObjects()
        {
            var result = new Objectz[]
            {
            new Objectz() { Date = "19.12.12", Name = "Камера 1" },
            new Objectz() { Date = "16.12.12", Name = "Камера 2" },
            new Objectz() { Date = "11.12.12", Name = "Камера 3" },
            new Objectz() { Date = "10.12.12", Name = "Камера 4" },
            new Objectz() { Date = "11.12.12", Name = "Камера 5" },
            new Objectz() { Date = "16.12.12", Name = "Камера 6" },
            new Objectz() { Date = "15.12.12", Name = "Камера 7" }
            };
            return result;
        }
    }
}

