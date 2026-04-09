using System;

namespace CajeroAutomatico
{
    class Program {
        static void Main(string[] args) {
        int monto, residuo, dosciento,ciente,cincueta,veinte, diez;
        int saldo = 500;
        int opcion;
        bool esnumero;
        string entrada;
        do {
            Console.WriteLine("Bienvenido al cajero automático");
            Console.WriteLine("Seleccione una opción para continuar");
            Console.WriteLine("1. Retirar dinero");
            Console.WriteLine("0. Salir");
            entrada = Console.ReadLine();
            esnumero = int.TryParse(entrada, out opcion);
            if (!esnumero||opcion!=1&&opcion!=0)
                Console.WriteLine("Entrada invalida. Intentelo nuevamente");  
            
        } while (!esnumero||opcion!=1&&opcion!=0);

        while (opcion == 1) {
            do {
               
                Console.WriteLine("Ingrese el monto a retirar:");
                Console.WriteLine("Saldo disponible: " + saldo);
                    entrada = Console.ReadLine();
                esnumero = int.TryParse(entrada, out monto);
                if (!esnumero) {
                   Console.WriteLine("Entrada invalida");
                   
                }else if (monto <= 0) {
                        Console.WriteLine("Ingrese un monto mayor a 0");
                    esnumero = false;
                    }
                } while (!esnumero);
            if (monto > saldo) {
                Console.WriteLine("Saldo insuficiente, saldo disponible: "+saldo);
            }else{
                if (monto % 10 != 0) {
                    Console.WriteLine("El cajero no cuenta con monedas. Ingrese una cantidad distruible en billetes");
                }else {
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
                    Console.WriteLine("Billetes entregados");
                        if (dosciento > 0)
                            Console.WriteLine("Billetes de $200: " + dosciento);
                        if (ciente > 0)
                            Console.WriteLine("Billetes de $100: " + ciente);
                        if (cincueta > 0)
                            Console.WriteLine("Billetes de $50: " + cincueta);
                        if (veinte > 0)
                            Console.WriteLine("Billetes de $20: " + veinte);
                        if (diez > 0)
                            Console.WriteLine("Billetes de $10: " + diez);
                    saldo -= monto;
                    Console.WriteLine("Saldo restante: " + saldo);
                    }
            }
            do{
                Console.WriteLine("¿Quieres repetir la Operación?");
                Console.WriteLine("1. Si");
                Console.WriteLine("0. No");
                entrada = Console.ReadLine();
                esnumero = int.TryParse(entrada, out opcion);
                if (!esnumero||opcion!=1&&opcion!=0)
                    Console.WriteLine("Entrada invalida");
                    
            } while (!esnumero||opcion!=1&&opcion!=0); 
        } 
        }
    }
}