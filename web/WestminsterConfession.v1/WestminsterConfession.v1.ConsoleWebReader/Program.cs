using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WestminsterConfession.v1.Bussines.Managers;
using WestminsterConfession.v1.DB;

namespace WestminsterConfession.v1.ConsoleWebReader
{
    class Program
    {
        private static CharperManager _charperManager;
        public Program(CharperManager charperManager)
        {           
            _charperManager = charperManager;
        }        

        static void Main(string[] args)
        {
            
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Application start");


            try
            {
                var result = _charperManager.AddNewCharper(new Bussines.DTOs.DTOCharper
                {
                    NumberPosition = 1,
                    Resume = "this a resume",
                    RomanNumber = "I",
                    Title = "This is a first title"
                });


                Console.WriteLine("Charper record added: {0}", result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error to add {0}", ex.Message);
            }


            Console.WriteLine("Application END");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
        
    }

   
}
