// See https://aka.ms/new-console-template for more information
class Person
{
    public string Name { get; set; }
    public string Email { get; set; }
    public Person(string name, string email)
    {
        Name = name;
        Email = email;
        Console.WriteLine("[Constructot]Person executed.");
    }
    public void DisplayBasicInf()
    {
        Console.WriteLine($"Name:{Name}|Email:{Email}");
    }
    class Student : Person
    {
        public int StudentId { get; set; }
        public double GPA { get; set; }
        public Student(string name, string email, int studentId, double gpa)
            : base(name, email)
        {
            StudentId = studentId;
            GPA = gpa;
            Console.WriteLine("[Constructot]Person executed.");
        }
    }
    class Employee : Person
    {
        public int EmployeeId { get; set; }
        public double Salary { get; set; }
        public Employee(string name, string email, int employeeId, double salary)
            : base(name, email)
        {

            EmployeeId = employeeId;
            Salary = salary;
            Console.WriteLine("[Constructor Employee executed.");
        }
        class Teacher : Employee
        {
            public string CourseName { get; set; }
            public Teacher(string name, string email, int employeeId, double salary, string courseName)
                : base(name, email, employeeId, salary)
            {
                CourseName = courseName;
                Console.WriteLine("[Constructor Employee executed.");
            }
            public void Teach()
            {
                Console.WriteLine($"Teaching Course:{CourseName}");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("=== Creating student object ===");
                Student student = new Student("Ali Hassan ", "ali@univ.edu", 2024001, 3085);
                student.DisplayBasicInf();
                Console.WriteLine($"Student ID:{student.StudentId},GPA:{student.GPA}");
                Console.WriteLine("\n===Creating Teacher object ===");
                Teacher teacher = new Teacher("Dr.Ahmed", "ahmed@univ.edu", 5001, 7500.00, "programming");
                teacher.DisplayBasicInf();
                teacher.Teach();
                Console.ReadKey();
            }
        }
    }
}