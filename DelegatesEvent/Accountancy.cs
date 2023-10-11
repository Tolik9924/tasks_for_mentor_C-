using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEvent
{
    public class Accountancy
    {
        
        public void PayingFellowship(int mark)
        {
            int access = 5;                                   

            if (mark >= access)
            {
                Console.WriteLine("Student has scholarship.");
            }
            else
            {
                Console.WriteLine("Student does not have scholarship.");
            }            
        }
    }
}
