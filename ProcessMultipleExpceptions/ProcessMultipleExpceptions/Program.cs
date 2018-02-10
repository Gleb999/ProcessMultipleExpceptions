using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessMultipleExpceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Custom Exceptions *****\n");
            Car myCar = new Car("Rusty", 90);
            try
            {
                myCar.Accelerate(190);
            }
            catch(CarIsDeadException e)
            {
                throw;
            }
            catch
            {
                Console.WriteLine("Something bad happened...");
            }

            /*catch (CarIsDeadException e)
            {
                Console.WriteLine(e.Message);
            }

            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }


            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }*/

            Console.ReadLine();
        }
    }
}
