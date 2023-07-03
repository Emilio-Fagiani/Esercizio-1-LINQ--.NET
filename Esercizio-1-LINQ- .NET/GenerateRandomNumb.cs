using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_1_LINQ__.NET
{
    internal class GenerateRandomNumb
    {
        public List<int> GenerateNumb(int n)
        {
            Random random = new Random();
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int randomNum = random.Next();
                list.Add(randomNum);
                Console.WriteLine(list[i]);
            }
            return list;
        }

        public void SelectUnevenNumb(List<int> list)
        {
            var unevenNumebr = from number in list
                               where number % 2 != 0
                               select number;
            foreach (var number in unevenNumebr)
            Console.WriteLine(number);
        }
    }
}
