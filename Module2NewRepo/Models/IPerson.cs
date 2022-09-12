using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2NewRepo
{
     interface IPerson
    {
        int personID { get; set; }
        string TaxID { get; set; }
        string LastName { get; set; }
        string FirstName { get; set; }
        DateTime Birthday { get; set; }

        void getPerson(int inPersonID);
        string getAge();
        string goodBye();
        void createPerson(string lastName, DateTime startDate);

    }
}
