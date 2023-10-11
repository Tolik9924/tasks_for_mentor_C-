using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEvent
{
    public class Accountancy
    {
        Student student = new Student();
        public void PayingFellowship(int count)
        {
            int access = 5;
            Console.WriteLine("Count: " + count);
            int average = student.Marks.Sum() / count;            

            if (average > access)
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
