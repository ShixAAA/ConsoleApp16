using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sedan s = new Sedan("Renault","В591РС777",5);
            s.Show();
            Cargo c = new Cargo("DAF", "О206КМ199", 55);
            c.Show();
            Console.ReadKey();
        }
    }
}
