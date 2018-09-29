using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colegiatura
{
    class EstAlumnos
    {
        int CostoM;
        double Descuento = 0, TotalP = 0, IVA = 0, TotalR = 0, TotalI = 0, Total = 0;
        public int Cargar()
        {
            Console.Write("Ingrese el costo de las materias: ");
            CostoM = int.Parse(Console.ReadLine());
            return CostoM;
        }

        public Boolean Comprobar(String NombreE)
        {
            Boolean band = true;

            if (NombreE == "FIN" || NombreE == "fin")
            {
                band = false;
            }
            return band;
        }

        public string Mensaje() {
            string mensaje = "---Gracias por usar la plataforma---";
            return mensaje;
        }
        public double Calcular(double CM, string NE, double MC, double PE)
        {
            if (PE >= 9)
            {
                Total = CM * MC;
                Descuento = Total * 0.30;
                TotalP = Total - Descuento;
            }
            else
            {
                Total = CM * MC;
                IVA = Total * 0.10;
                TotalP = Total + IVA;
            }
            return TotalP;
        }

        public double TotalRec (double CM, double PE, double MC )
        {
            if (PE >= 9)
            {
                Total = CM * MC;
                Descuento = Total * 0.30;
                TotalP = Total - Descuento;
            }
            else
            {
                Total = CM * MC;
                IVA = Total * 0.10;
                TotalP = Total + IVA;
            }
            TotalR = TotalR + TotalP;
            return TotalR;
        }

        public double TotalIVA(double CM, double PE, double MC)
        {
            if (PE < 9)
            {
                Total = CM * MC;
                IVA = Total * 0.10;
            }
            TotalI = TotalI + IVA;
            return TotalI;
        }

        public double Ganancia(double TotalR, double TotalI) 
        {
            double ganancia;
            ganancia = TotalR - TotalI;
            return ganancia;
        }
    }
}
