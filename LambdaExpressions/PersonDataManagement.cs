using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    public class PersonDataManagement
    {
        List<Person> personList = new List<Person>();
        public void AddDefaultData()
        {
            personList.Add(new Person { SSN = 1, Name = "Vidya", Address = "Bangalore", Age = 23 });
            personList.Add(new Person { SSN = 2, Name = "Neha", Address = "Tumkur", Age = 25 });
            personList.Add(new Person { SSN = 3, Name = "Siri", Address = "Mysore", Age = 35 });
            personList.Add(new Person { SSN = 4, Name = "Rakesh", Address = "Bangalore", Age = 27 });
            personList.Add(new Person { SSN = 5, Name = "Pradeep", Address = "Mangalore", Age = 46 });
            Display(personList);
        }
        public void Display(IEnumerable<Person> list)
        {
            foreach (var person in list)
            {
                Console.WriteLine("SSN : " + person.SSN + "\t" + "Name : " + person.Name + "\t" + "Address : " + person.Address + "\t" + "Age : " + person.Age);
            }
        }
    }
}