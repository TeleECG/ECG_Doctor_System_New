using System;
using System.Collections.Generic;
using System.IO;
using Data_layer.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq;



namespace DatabaseSeeder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           
                using (var context = new F20ST4PRJ4TeleMedDatabaseContext())
                {
                    
                }
            
        }
        private List<double> LeadReader1()
        {
            using (var reader = new StreamReader(@"C:\Users\Mie\Cloud\MiesTing\Universitet - ST\4.Semester ST\4. Semesterprojekt\Software\ECG_Doctor_System_New\Data_layer\1Lead.csv"))
            {
                List<double> listA = new List<double>();
                var h1 = reader.ReadLine();
                var h2 = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    listA.Add(Convert.ToDouble(Double.Parse(values[1].Replace('.', ',')))); //Prøv parse i stedet for konvertering til double 

                }

                return listA;
            }
        }
    }
}
