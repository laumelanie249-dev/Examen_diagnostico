using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double precio = 0.0;
            Console.WriteLine("----Venta de jugos----");
            Console.WriteLine("Menú: ");
            Console.WriteLine("[1] Naranja");
            Console.WriteLine("[2] Fresa");
            Console.WriteLine("[3] Lúcuma");
            Console.WriteLine("[4] Papaya");
            Console.WriteLine("[5] Surtido");
            Console.WriteLine("[6] Piña");
            Console.Write("Ingrese su elección de jugo: ");
            
            int opción = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Tamaño del vaso: ");
            Console.WriteLine("[1] Large");
            Console.WriteLine("[2] Medium");
            Console.WriteLine("[3] Small");
            Console.Write("Ingrese su selección de tamaño: ");
            
            int tamaño = int.Parse(Console.ReadLine());
            switch (opción)
            {
                case 1:
                    if (tamaño == 1) precio = 15.50;
                    else if (tamaño == 2) precio = 12.00;
                    else precio = 10.50;
                    break;
                case 2:
                    if (tamaño == 1) precio = 17.00;
                    else if (tamaño == 2) precio = 13.70;
                    else precio = 11.50;
                    break;
                case 3:
                    if (tamaño == 1) precio = 14.20;
                    else if (tamaño == 2) precio = 11.50;
                    else precio = 9.70;
                    break;
                case 4:
                    if (tamaño == 1) precio = 10.00;
                    else if (tamaño == 2) precio = 8.50;
                    else precio = 6.50;
                    break;
                case 5:
                    if (tamaño == 1) precio = 20.00;
                    else if (tamaño == 2) precio = 17.00;
                    else precio = 15.00;
                    break;
                default:
                    if (tamaño == 1) precio = 11.50;
                    else if (tamaño == 2) precio = 9.40;
                    else precio = 7.20;
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("Método de pago: ");
            Console.WriteLine("[1] Efectivo");
            Console.WriteLine("[2] Tarjeta");
            Console.Write("Seleccione el método de pago a realizar: ");
            int pago = int.Parse(Console.ReadLine());
            double total = 0.0;
            if (pago == 1) total = 0.92 * precio;
            else total = 1.07 * precio;
            Console.WriteLine("");
            Console.WriteLine("Ud. pagará: " + total);
            Console.ReadKey();
        }
    }
}
