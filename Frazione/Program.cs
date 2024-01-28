using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Frazione frazione = new Frazione();
            frazione.N = int.Parse(Console.ReadLine());
            frazione.D = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}", frazione.ToString());
            Console.ReadLine();
           
        }
    }
}
