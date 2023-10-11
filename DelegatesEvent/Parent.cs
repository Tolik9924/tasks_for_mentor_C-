using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEvent
{
    public class Parent
    {
        public void OnMarkChange(int mark)
        {
            Console.WriteLine("Mark: " + mark);
        }
    }
}
