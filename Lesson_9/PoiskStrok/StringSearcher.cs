using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoiskStrok
{
    public class StringSearcher
    {       
        public delegate void EventHandler(string a);
        public event EventHandler Equal;
        public StringSearcher(List<string> spisokStrok)
        {           
        }
        public void Search(List <string> spisokStrok)
        {           
            foreach (string n in spisokStrok)
            {
                if (n == "Аптека, улица, фонарь." & Equal != null)
                {
                    Equal(n);
                }
            }
        }
    }
}
