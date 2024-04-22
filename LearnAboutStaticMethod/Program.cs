class Student
{
    private int rollno { get; set; }
    private string name { get; set; }
    private static string college = "BBDIT";
    public Student(int r, string n)
    {
        rollno = r;
        name = n;
    }
    public static void Change()
    {
        college = "CODEGYM";
    }
    public void Display()
    {
        System.Console.WriteLine(rollno + " " + name + " " + college);
    }
}

 public class Program
    {
        public static void Main(string[] args)
        {
            Student.Change();
            Student student1 = new Student(1, "Duck");
            Student student2 = new Student(2, "Tung");
            Student student3 = new Student(3, "Hung");
           
            student1.Display();
            student2.Display();
            student3.Display();
        }
    }
