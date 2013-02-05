using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class AnstalldTest
    {
        static void Main(string[] args)
        {
            Class1 anst1 = new Anstalld();
            Anstalld anst2 = new Anstalld("Hans", "Dalby");
            anst1.Namn = "Anna";
            anst1.Adress = "Lund";
            Console.WriteLine(anst1.Name + anst1.Adress);
            Console.WriteLine(anst2.Name + anst2.Adress);
        }
    }
}
