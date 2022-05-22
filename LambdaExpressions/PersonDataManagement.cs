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
            Console.WriteLine("\n");
            Console.WriteLine("Person Data :\n");
            personList.Add(new Person { SSN = 1, Name = "Vidya", Address = "Bangalore", Age = 23 });
            personList.Add(new Person { SSN = 2, Name = "Neha", Address = "Tumkur", Age = 25 });
            personList.Add(new Person { SSN = 3, Name = "Siri", Address = "Mysore", Age = 15 });
            personList.Add(new Person { SSN = 4, Name = "Rakesh", Address = "Bangalore", Age = 17 });
            personList.Add(new Person { SSN = 5, Name = "Pradeep", Address = "Mangalore", Age = 75 });
            Display(personList);
        }
        public void Display(IEnumerable<Person> list)
        {
            foreach (var person in list)
            {
                Console.WriteLine("SSN : " + person.SSN + "\t" + "Name : " + person.Name + "\t" + "Address : " + person.Address + "\t" + "Age : " + person.Age);
            }
        }
        public void GetTopRecords()
        {
            var result = this.personList.Where(x => x.Age < 60).Take(2);
            Console.WriteLine("\n");
            Console.WriteLine("Retreiving Top Two Records :\n");
            Display(result);
        }
        public void GetAllRecords()
        {
            var result = this.personList.Where(x => x.Age > 13 && x.Age < 18);
            Console.WriteLine("\n");
            Console.WriteLine("Retreiving All The Records Between Age 13 - 18 :\n");
            Display(result);
        }
        public void AverageRecords()
        {
            var result = this.personList.Average(x => x.Age);
            Console.WriteLine("\n");
            Console.WriteLine("Retreiving Average Age From The List :\n");
            Console.WriteLine("Average Age : " + result);
        }
    }
}