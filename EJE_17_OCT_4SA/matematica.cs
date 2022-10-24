using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJE_17_OCT_4SA
{
    class matematica
    {
        static void Main(string[] args)
        {    byte num;
            string valor = "";
            Console.Write("ingrese un numero::");
            valor = Console.ReadLine();
            num = byte.Parse(valor);
            Console.WriteLine(Math.Sqrt(num));
            Console.WriteLine(Math.Pow(num,3));
            Console.WriteLine(Math.Sin(num));
            Console.WriteLine(Math.Cos(num));
            Console.WriteLine(Math.Tan(num));
            Console.ReadLine();



           





        }
    }
}
