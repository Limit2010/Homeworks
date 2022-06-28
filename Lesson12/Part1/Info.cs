using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    public class Info
    {
       public string Type;
        public string Name;
        public DateTime Date;

        public Info (string type, string name, DateTime date)
        {
            Type = type;
            Name = name;
            Date = date;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"{Type} {Name} {Date}");
        }

    }
}
