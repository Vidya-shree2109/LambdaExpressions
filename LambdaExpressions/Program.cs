using System;

namespace LambdaExpressions
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tWELCOME TO PERSON DATA MANAGEMENT PROGRAM\t\t\t\t\t");
            Console.WriteLine("\t\t\t\t\t-----------------------------------------\t\t\t\t\t");
            PersonDataManagement data = new PersonDataManagement();
            data.AddDefaultData();
            data.GetTopRecords();
        }
    }
}