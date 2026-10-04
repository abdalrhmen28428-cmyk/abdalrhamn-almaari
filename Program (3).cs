// See https://aka.ms/new-console-template for more information
using System.Data;

class person
{
    public string Name { get; set; }
    public virtual void DisplayInf()
    {
        Console.WriteLine(Name);
    }
}
    class Student : person
    {
        public int StudentId { get; set; }
        public override void DisplayInf()
        {
            Console.WriteLine(Name + "  " + StudentId);
        }
    }
    class Employee : person
    {
        public double Salary { get; set; }
        public override void DisplayInf()
        {
            Console.WriteLine(Name + "  " + Salary);
        }

    }
class Teacher : person
{
    public string CourseName { get; set; }

    public override void DisplayInf()
    {
        Console.WriteLine(Name + "   " + CourseName);
    }
}
        class Program
        {
            static void ShowInfo(person person)
            {
                person.DisplayInf();
            }
            static void Main()
            {
                List<person> people = new List<person>();
                people.Add(new Student { Name = "Ahmed", StudentId = 101 });
                people.Add(new Employee { Name = "Ali", Salary  = 5000 });
                people.Add(new Teacher  { Name = "Mohammd", CourseName = "programming" });
                foreach (person person in people)
                {
                    person.DisplayInf();
                    Console.WriteLine(person.GetType());
                }
            }
        }
    
