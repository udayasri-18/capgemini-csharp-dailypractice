using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1Prep
{
    class ExceptionHandling
    {
        static void Main(string[] args)
        {

            int[] arr = new int[5];
            try
            {
                //arr[6] = 10;

                //int a = 10; int b = 0;
                //int c = a / b;
                //Console.WriteLine(c);

                int x=int.MaxValue;
                checked
                {
                    int y = x + 1;
                }
            }

            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide by zero exception");
            }
            catch (ArithmeticException ex)
            {
                //Console.WriteLine("Stack overflow ");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured while processing the given input");
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }
        }
    }
}
