using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ExceptionIntro();
            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {

                Console.WriteLine(exception.Message);
            }

            //Methodun içine method kullanabiliriz parametre alarak
            // () ve => isaretlerini kullanarak methodu parametre alabiliriz
            HandleException(() =>
            {
                Find();   
            });
            Console.ReadLine();
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string>
            {
                "Ahmet","Mehmet","Veli"
            };
            if (!students.Contains("Can"))
            {
                throw new RecordNotFoundException("Record not Found");
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3] { "Ahmet", "Mehmet", "Veli" };
                students[3] = "Can";
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

            }
        }
    }
}
