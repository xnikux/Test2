using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gittest
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var thing in new List<string> (){"cat", "dog", "cow", "chicken", "pig"})
            {
                Console.Write(string.Format("Here is a animal: {0}", thing));
            }
            

        }
    }
}
