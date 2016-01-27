using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo06_Teh1_PersonRegisteration
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object from persons
            Persons myFriends = new Persons();

            // creat a friends...
            Person person1 = new Person { FirstName="Jussi", LastName="Jurkka", SocialSecurityNumber="010101-020202" };
            Person person2 = new Person { FirstName = "Pekka", LastName="Taipale", SocialSecurityNumber = "030303-050505" };
            Person person3 = new Person { FirstName = "Aaro", LastName="Lautanen", SocialSecurityNumber = "040404-060606" };

            //add persons to collection
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            // print collection
            myFriends.PrintCollection();

            // get one person
            Console.WriteLine("Get one person from collection: ");
            Person person4 = myFriends.GetPerson(100);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            }
            else
            {
                Console.WriteLine("can not find person in that position...");
            }

            //find person with sotu
            string socialSecurityNumber = "040404-060606";
            Console.WriteLine("find person with sotu: " + socialSecurityNumber);
            Person person5 = myFriends.FindPerson(socialSecurityNumber);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }
            else
            {
                Console.WriteLine("not found...");
            }
        }
    }
}
