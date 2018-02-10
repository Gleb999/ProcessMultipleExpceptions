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
            }

            catch (CarIsDeadException e)
            {

            }

            catch (ArgumentOutOfRangeException e)
            {

            }

            catch (Exception e)
            {

            }

            finally
            {
                myCar.CrankTunes(false);
            }

            Console.ReadLine();
        }
    }
}
