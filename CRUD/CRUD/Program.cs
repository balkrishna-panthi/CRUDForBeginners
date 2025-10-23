namespace CRUD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Student");
            string choice = Console.ReadLine(); // string is a data type
            List<Student> students = new List<Student>();
            

            switch (choice)
            {
                case "1":
                    Student student1 = new Student();
                    Student student2 = new Student();
                    student1.Name = "ABC"; // assigning
                    student1.Id = 101;
                    Console.WriteLine(student1.Name + " " + student1.Id); //accessing the value of Name attribute

                    student2.Id = 102;
                    student2.Name = "XYZ"; // assigning
                    Console.WriteLine(student2.Name + " " + student2.Id); //accessing the value of Name attribute
                    students.Add(student1);
                    students.Add(student2);

                    for(int i =0; i < 2; i++)
                    {
                        Console.WriteLine(students[i].Id + " " + students[i].Name);
                    }


                    break;
                case "2":
                    Console.WriteLine("The choice is : " + choice);
                    break;
                default:
                    break;
            }
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } //study getter setter in c#
        public int Age { get; set; } 
    }
}
