using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certamen.NET
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Ponga el monto que solicitará :");
                double monto = double.Parse(Console.ReadLine());

            Console.WriteLine("Ponga una cantidad de cuotas :");
            int cuotas = int.Parse(Console.ReadLine());

            Consola c1 = new Consola();
                c1.monto_solicitado = monto;
                c1.cuotas = cuotas;

            c1.calcular_todo();






            Console.ReadLine();
        }

    }

}
