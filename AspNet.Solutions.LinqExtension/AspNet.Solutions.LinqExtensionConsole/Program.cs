using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNet.Solutions.LinqExtensionConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = new List<string>()
            {
                "demo1",
                "demo2",
                "demo3",
                "demo4",
                "demo5"
            };

            Console.WriteLine(list.GetNth(4));

            Console.ReadLine();

        }
    }
}
