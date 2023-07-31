using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    public static class Utility
    {
        public static void GetTwoIntFromConsole(out int value1, out int value2)
        {
            value1 = GetIntFromConsole();
            value2 = GetIntFromConsole();

        }

        public static int GetIntFromConsole()
        {
            bool valid = true;
            int result;
            do
            {
                if (!valid)
                {
                    Console.WriteLine("Invalid number entry. Please try again.");
                }
                string strNumber1 = Console.ReadLine();
                valid = int.TryParse(strNumber1, out result);
            } while (!valid);

            return result;
        }
    }
}
