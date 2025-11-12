using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;
using Spectre.Console;



namespace crudApplication
{

    class Program
    {
        static void Main(string[] args)
        {

              CRUD.Version1.StudentManagement studentManagementV1 = new CRUD.Version1.StudentManagement();
            studentManagementV1.Run();

            CRUD.Version2.StudentManagement studentManagementV2 = new CRUD.Version2.StudentManagement();
            studentManagementV2.Run();

        }     

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