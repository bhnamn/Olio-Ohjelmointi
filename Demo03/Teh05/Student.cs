using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh05
{
    class Student
    {
        private string studentID;
        private string firstName;
        private string lastName;
        private int group;
        private string password;

        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Group
        {
            get { return group; }
            set { group = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public Boolean Login(string studentID, string password)
        {
            StudentID = studentID;
            Password = password;
            if ((studentID == "K2599" & password == "tam2016") || (studentID == "k2599" & password == "tam2016"))
            {
                firstName = "Borhan";
                lastName = "Amini";
                group = 3;
                return true;
            }
            else if((studentID == "K1234" & password == "hel2016") || (studentID == "k1234" & password == "hel2016"))
            {
                firstName = "Pekka";
                lastName = "Virtanen";
                group = 2;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
