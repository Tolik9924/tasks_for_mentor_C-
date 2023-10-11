using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesEvent
{
    public class Student
    {
        public delegate void MyDel(int m);    
        MyDel Del;

        private string name = "Default name";
        private List<int> marks = new List<int>();

        public Student()
        {
            
        }
        public Student(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get 
            { 
                return name; 
            }
            set 
            { 
                name = value; 
            }
        }

        public List<int> Marks
        { 
            get 
            { 
                return marks; 
            }
            set 
            { 
                marks = value; 
            }
        }

        public event MyDel MarkChange;

        public void AddMark(int mark)
        {
            marks.Add(mark);
        }
    }
}
