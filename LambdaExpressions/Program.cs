using System;

namespace LambdaExpressions
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tWELCOME TO PERSON DATA MANAGEMENT PROGRAM\t\t\t\t\t");
            Console.WriteLine("\t\t\t\t\t-----------------------------------------\t\t\t\t\t");
            bool finish = true;
            PersonDataManagement personData = new PersonDataManagement();
            Console.WriteLine("1.Add and display default data\n2.Get Top two records\n3.Get all records between age 13 to 18\n4.Retreiving Average Age Records\n5.Check For A Specific Name\n6.Skip Record For Age < 60\n7.Exit\n");
            while (finish)
            {
                Console.Write("\nEnter an option to execute : ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        personData.AddDefaultData();
                        break;
                    case 2:
                        personData.GetTopRecords();
                        break;
                    case 3:
                        personData.GetAllRecords();
                        break;
                    case 4:
                        personData.AverageRecords();
                        break;
                    case 5:
                        personData.CheckForSpecificName();
                        break;
                    case 6:
                        personData.SkipRecords();
                        break;
                    case 7:
                        finish = false;
                        break;
                }
            }
        }
    }
}