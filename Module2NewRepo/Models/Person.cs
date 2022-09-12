using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Module2NewRepo
{

    public abstract class Person : IPerson
    {

        private static void Main()
        {
            Type T = Type.GetType("Module2NewRepo.Person");

           PropertyInfo[] properties = T.GetProperties();

            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name + "  " + property.Name);
            }
        }
        public int personID { get; set; }
        public string TaxID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime Birthday { get; set; }

        public void getPerson(int inPersonID)
        {
            personID = inPersonID;
            LastName = "Harcroft";
        }


        public class Employee : Person
        {
            public DateTime StartDate;
            public DateTime EndDate;
        }

        public class Faculty : Employee, IPerson
        {
            public Person ChairPerson;

            public override string ToString()
            {
                return LastName + "is a faculty member";
            }

            void IPerson.createPerson(string lastName, DateTime startDate)
            {
                throw new NotImplementedException();
            }
        }
        public string getAge()
        {
            return FirstName + " is " + (DateTime.Now.Year - Birthday.Year).ToString();
        }

        public string goodBye()
        {
            Console.WriteLine("Exiting System");
            Environment.Exit(0);
            return "GoodBye";
        }

        void IPerson.createPerson(string lastName, DateTime startDate)
        {
            throw new NotImplementedException();
        }
    }

    public abstract class Employee : Person
    {
        public DateTime StartDate;
        public DateTime EndDate;
    }

    public sealed class FacultyMember : Employee, IPerson
    {
        public Person ChairPerson;

        public override string ToString()
        {
            return LastName + " is a faculty member";
        }

        void IPerson.createPerson(string lastName, DateTime startDate)
        {
            throw new NotImplementedException();
        }
    }
}