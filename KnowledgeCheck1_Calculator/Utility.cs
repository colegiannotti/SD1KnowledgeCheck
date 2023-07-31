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
            bool result = true;
            do
            {
                if (!result)
                {
                    Console.WriteLine("Invalid number entry. Please try again.");
                }
                string strNumber1 = Console.ReadLine();
                result = int.TryParse(strNumber1, out value1);
            } while (!result);

            do
            {
                if (!result)
                {
                    Console.WriteLine("Invalid number entry. Please try again.");
                }
                string strNumber2 = Console.ReadLine();
                result = int.TryParse(strNumber2, out value2);
            } while (!result);

        }
    }
}
