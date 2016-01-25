using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh05
{
    class Program
    {
        static void Main(string[] args)
        {
            string enteredStudentID;
            string enteredPassword;

            Console.WriteLine("Enter Student ID: ");
            enteredStudentID = Console.ReadLine();

            Console.WriteLine("Enter Password: ");
            enteredPassword = Console.ReadLine();

            Student oStudent = new Student();
            Boolean returnedValue = oStudent.Login(enteredStudentID, enteredPassword);
            if (returnedValue == true)
            {
                Console.WriteLine("welcome " + oStudent.FirstName + " " + oStudent.LastName);
                Console.WriteLine("Your group code is TTV15S" + oStudent.Group);
            }
            else
            {
                Console.WriteLine("Login Failed.");
                Console.WriteLine("The userID & password are not matched.");
            }
        }
    }
}
