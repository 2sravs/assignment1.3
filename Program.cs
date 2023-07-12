using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conassign1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = "30";
                Console.WriteLine(input);
                int tryParsedInt;
                int.TryParse(input, out tryParsedInt);
                Console.WriteLine("tryparsed number is: \t" + tryParsedInt);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error!!!" + ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
