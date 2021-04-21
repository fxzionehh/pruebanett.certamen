using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Certamen.NET
{
    class Consola
    {
        
   
        public double monto_solicitado;
        public int cuotas;
        public double monto_total;
        public double valor_de_cuota;
        public double interes;

        public void calcular_valor_cuotas()
        {
            if (monto_solicitado >= 500000)
                if(cuotas >= 1 && cuotas <= 36)
                {
                    if (cuotas <= 12)
                    {
                        interes = monto_solicitado * 0.1;
                        monto_total = monto_solicitado + interes;
                        valor_de_cuota = monto_total / cuotas;
                        Console.WriteLine("El valor de cuota es: "+valor_de_cuota);
                    }else if(cuotas <= 24)
                    {
                        interes = monto_solicitado * 0.2;
                        monto_total = monto_solicitado + interes;
                        valor_de_cuota = monto_total / cuotas;
                        Console.WriteLine("El valor de la cuota es: " + valor_de_cuota);
                    }
                    else if(cuotas <= 36)
                    {
                        interes = monto_solicitado * 0.35;
                        monto_total = monto_solicitado + interes;
                        valor_de_cuota = monto_total / cuotas;
                        Console.WriteLine("El valor de la cuota es: " + valor_de_cuota);
                    }

                 }
         }

        public void calcular_monto_total()
        {
            monto_total = valor_de_cuota * cuotas;
            Console.WriteLine("El monto total es: " + monto_total);
        }
        public void calcular_todo()
        {
            this.calcular_valor_cuotas();
            this.calcular_monto_total();
        }

    }
}
