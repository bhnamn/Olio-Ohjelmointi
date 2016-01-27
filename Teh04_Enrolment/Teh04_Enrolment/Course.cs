using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teh04_Enrolment
{
    class Course
    {
        public string Name { get; set; }
        public string Semester { get; set; }
        public List<Class> Classes { get; }

        public Course()
        {
            Classes = new List<Class>();
        }

        public void AddClass(Class newClass)
        {
            Classes.Add(newClass);
        }

        public override string ToString()
        {
            string sCourse = "Course name: " + Name + "Semester: " + Model + "Classes: \n";
            foreach (Class newClass in Classes)
            {
                sCourse += newClass.ToString() + "\n";
            }
            return sCourse;
        }
    }
}
