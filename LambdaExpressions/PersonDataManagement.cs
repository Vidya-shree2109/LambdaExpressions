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
        public void CheckForSpecificName()
        {
            var result = this.personList.Where(x => x.Name == "Vidya");
            if (result != null)
            {
                Console.WriteLine("\nName is present in the list");
            }
            else
            {
                Console.WriteLine("\nName is not present in the list");
            }
            Display(result);
        }
        public void SkipRecords()
        {
            var Result = this.personList.Skip(this.personList.Where(x => x.Age < 60).Count());
            Console.WriteLine("\n");
            Console.WriteLine("Skipping The Record From The List For Age < 60 :\n");
            Display(Result);
        }
        public void RemoveRecords()
        {
            Person result = this.personList.Find(x => x.Name == "Neha");
            Console.WriteLine("\n");
            Console.WriteLine("Removing Specific Name In The List :\n");
            this.personList.Remove(result);
            Console.WriteLine("Removed NEHA\n");
            Display(this.personList);
        }
    }
}