using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "ABC123 XYZ";

            AChiper aChiper = new AChiper();
            Console.WriteLine(aChiper.Encode(s));
            Console.WriteLine(aChiper.Decode(aChiper.Encode(s)));

            Console.WriteLine();

            BChiper bChiper = new BChiper();
            Console.WriteLine(bChiper.Encode(s));
            Console.WriteLine(bChiper.Decode(bChiper.Encode(s)));

            Console.ReadKey();
        }
    }
}
