using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS01
{
    class Program
    {
        static void Main(string[] args)
        {
            // create Persons (colletcion)
            Persons myFriends = new Persons();

            //create a few Personobjects
            Person person1 = new Person
            {
                Firstname = "Kirsi",
                Lastname = "Kernel",
                SocialSecurityNumber = "12-12-12-1-2"
            };

            Person person2 = new Person
            {
                Firstname = "Pekka",
                Lastname = "Pouta",
                SocialSecurityNumber = "k1493-dddddddd"
            };

            Person person3 = new Person
            {
                Firstname = "Jaska",
                Lastname = "Jokunen",
                SocialSecurityNumber = "666"
            };
            //add Person objects to Persons(myFriends)
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

            //get one person
            Person person4 = myFriends.GetPerson(0);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            }
            else
            {
                Console.WriteLine("person not found in positon");
            }
            myFriends.PrintData();
            //FindPerson
            string SocialSecurityNumber = "666";
            Console.WriteLine("Find  Person with ssn: " + SocialSecurityNumber);
            Person person5 = myFriends.FindPerson(SocialSecurityNumber);

            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }
            else
            {
                Console.WriteLine("cant find person with that ssn");
            }
        }
    }
}
