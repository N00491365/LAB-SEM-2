using System;

namespace CajeroAutomatico
{
    class Program
    {
        static void Main(string[] args)
        {
        int monto, residuo, dosciento,ciente,cincueta,veinte, diez;
        int saldo = 100000;
        int opcion;
        Console.WriteLine("Bienvenido al cajero automático");
        Console.WriteLine("1. Retirar dinero");
        Console.WriteLine("0. Salir");
        opcion=Convert.ToInt32(Console.ReadLine());


        while (opcion != 0)
        {
            Console.WriteLine("Ingrese el monto a retirar:");
            monto = Convert.ToInt32(Console.ReadLine());
            
            if (monto > saldo)
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else
            {
                residuo = monto;
                dosciento = residuo / 200;
                residuo = residuo % 200;
                ciente = residuo / 100;
                residuo = residuo % 100;
                cincueta = residuo / 50;
                residuo = residuo % 50;
                veinte = residuo / 20;
                residuo = residuo % 20;
                diez = residuo / 10;
                residuo = residuo % 10;
                Console.WriteLine("Billetes de $200: " + dosciento);
                Console.WriteLine("Billetes de $100: " + ciente);
                Console.WriteLine("Billetes de $50: " + cincueta);
                Console.WriteLine("Billetes de $20: " + veinte);
                Console.WriteLine("Billetes de $10: " + diez);
                saldo -= monto;
            }

                Console.WriteLine("Quieres Hacer otra  Operación?");
                Console.WriteLine("1. Retirar dinero");
                Console.WriteLine("0. Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
            }

        

       
        }
    }
}