using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueOne = 10;
            int valueTwo = 20;
            int result;
            result = valueOne + valueTwo;
            valueTwo++;
            ++valueOne;
            result = ++valueOne + valueTwo--;
            Console.WriteLine(result); 
        }
    }
}
