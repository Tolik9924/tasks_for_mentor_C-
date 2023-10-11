namespace DelegatesEvent
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Tom");
            Parent parent = new Parent();
            Accountancy accountancy = new Accountancy();
            
            student.MarkChange += parent.OnMarkChange;            
            student.MarkChange += accountancy.PayingFellowship;            

            student.AddMark(5);
            student.AddMark(3);
            student.AddMark(4);            
        }
    }
}