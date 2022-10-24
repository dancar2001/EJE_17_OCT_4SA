using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJE_17_OCT_4SA
{
    class cardenas
    {
        static void Main(string[] args)
        {
            //variables
            float c, resultado;
            string valor = "";
            Console.Write("ingrese el valor de grados centigrados");
            valor = Console.ReadLine();
            c = Convert.ToUInt32(valor);

            
            resultado = 9 / 5 * c + 32;
            Console.WriteLine("el valor en fanhert es {0}:",resultado);
            Console.ReadLine();


            resultado = (c - 32) / 1.8f;
            Console.WriteLine("el valor en centigrados es {0}:", resultado);
            Console.ReadLine();

            resultado = c + 273;
            Console.WriteLine("el valor en Kelvin es {0}:", resultado);
            Console.ReadLine();







        }

    }
}
