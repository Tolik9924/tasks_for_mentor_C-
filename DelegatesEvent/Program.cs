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

            student.AddMark(14);
            student.AddMark(25);
            student.AddMark(98);

            parent.OnMarkChange(5);
            accountancy.PayingFellowship(student.Marks.Count());
        }
    }
}