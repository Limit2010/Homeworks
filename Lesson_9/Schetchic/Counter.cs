using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schetchic
{
    public class Counter
    {
        public delegate void MethodContainer();
        public event MethodContainer Count;
                
        public void OnCount()
        {
            
            for (int i=0; i <= 100; i++ )
            {
                if (i == 77)
                {
                   Count();
                }
            }
        }
    }
}
