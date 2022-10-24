using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJE_17_OCT_4SA
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIABLES
            float b = 1.0f, h = 1.0f, area = 0.0f, perimetro = 0.0f;
            string valor = "";

            Console.Write("Ingrese base:_");
            valor = Console.ReadLine();
            b = Convert.ToSingle(valor);


            Console.Write("Ingrese altura:_");
            valor = Console.ReadLine();
            h = Convert.ToSingle(valor);



            //proceso
            area = b * h;
            perimetro = 2 * (b + h);

            //mostrar


            Console.WriteLine("El area es {0} y el perimetro {1}", area, perimetro);
            Console.Write("Presione ENTER para SALIR");
            Console.ReadLine();
             



        }
    }
}
