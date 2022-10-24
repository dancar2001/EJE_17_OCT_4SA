using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJE_17_OCT_4SA
{
    class compra
    {
        static void Main(string[] args)
        {
            byte canth, cantpa, cantcola;
            double total_pagar;
            const double precham = 1.25;
            const double prepa = 0.8;
            const double precol = 0.75;
            string valor = "";
            int num;
            long resultado;

            Console.Write("ingrese la cantidad de hamburguesas");
            valor = Console.ReadLine();
            canth = byte.Parse(valor);
            Console.Write("ingrese la cantidad de papas;");
            valor = Console.ReadLine();
            cantpa = byte.Parse(valor);
            Console.Write("ingrese la cantidad de colas");
            valor = Console.ReadLine();
            cantcola = byte.Parse(valor);
            total_pagar = (canth * precham) + (cantpa * prepa) + (cantcola * precol);
            Console.WriteLine("el total a pagar es {0}",total_pagar);
            Console.Write("ingrese un numero");
            valor = Console.ReadLine();
            num = int.Parse(valor);
            resultado = Math.Abs(num);
            Console.WriteLine("el valor absoluto es{0}", resultado);
            Console.ReadLine();



            

        
        }

    }
}
