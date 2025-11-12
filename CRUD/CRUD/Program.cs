using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using Spectre.Console;



namespace crudApplication
{

    class Program
    {
        static List<Student> students = new List<Student>();

        static int Count = 1000;

        static void Main(string[] args)
        {


            while (true)
            {

                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit\n");

                Console.Write("Choose an option: ");

                string choice = Console.ReadLine().ToString();


                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;

                    case "2":
                        ViewStudents();
                        break;

                    case "3":
                        UpdateStudent();
                        break;

                    case "4":
                        DeleteStudent();
                        break;

                    case "5":
                        Console.WriteLine("Exit");
                        return;

                    default:
                        Console.WriteLine("Invalid Option");
                        break;

                }
            }

        }
        public static void AddStudent()
        {
            Student student = new Student();

            Count++; //count = count +1
            student.Id = Count;

            Console.WriteLine("Enter student Name: ");
            student.Name = Console.ReadLine();

            students.Add(student);
        }
        public static void ViewStudents()
        {
            Table table = new Table();
            if (students.Count() <= 0)
            {
                Console.WriteLine("\nRecords Not Found!!\n");
            }
            else
            {


                table.AddColumn("[green]Id[/]");
                table.AddColumn("[green]Name[/]");

                for (int i = 0; i < students.Count(); i++)
                {
                    //Console.WriteLine(students[i].Id + " " + students[i].Name);
                    table.AddRow("[blue]" + students[i].Id + "[/]", "[red]" + students[i].Name + "[/]");
                }
                AnsiConsole.Write(table);

            }
        }
        public static void UpdateStudent()
        {
            int id = GetStudentId();
            int searchCount = 0;
            for (int i = 0; i < students.Count(); i++)
            {
                if (students[i].Id == id)
                {
                    Console.WriteLine("Enter Name ");
                    students[i].Name = Console.ReadLine();
                    Console.WriteLine("Student updated successfully.");
                    break;


                }
                else
                {
                    searchCount++;
                }
            }
            if (searchCount == students.Count())
            {
                Console.WriteLine("Id not found");
            }
        }
        public static void DeleteStudent()
        {
            int id = GetStudentId();
            int searchCount1 = 0;
            for (int i = 0; i < students.Count(); i++)
            {
                if (students[i].Id == id)
                {
                    students.RemoveAt(i);
                    Console.WriteLine("Student removed.");
                    break;


                }
                else
                {
                    searchCount1++;
                }
            }
            if (searchCount1 == students.Count())
            {
                Console.WriteLine("Id not found");
            }
        }
        public static int GetStudentId()
        {
            int ID = 0;
            while (true)
            {
                //checking for a valid id
                Console.WriteLine("Enter the student Id: ");

                try
                {

                    ID = Convert.ToInt32(Console.ReadLine());
                    if (ID <= 0)
                    {
                        Console.WriteLine("Id cannot be Zero or negative");
                    }
                    else
                    {
                        break;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
            return ID;
        }

    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}

//scope
// lifetime the area under which a variable is applicable or alive

//try catch
// try contains the code that throw the exception and catch handle that exception

//getter setter
// used to protect data
// uesd to read the  value of the field(read)
// used to assign value of the field(change)

//constructor
// constructor is a special method of class.
// class constructor call automatically when an instance of the class is created.
//class ko vitra vako field ma  value initialize garna use hunxa

//method overloading
// allows to define multiple method with same name but different parameters.
//it makes code more readable and flexible.

//interface/inheritance
//it is a contract between itself and any class that implements it.

//string interpolation
//it makes p[rogram more readable to insert variables or expression into string using $.

//string concatenation
//joing tow or more string together by using +operator.

//static keyword