using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stm
{
    class Program
    {
        static void Main(string[] args)
        {



            const int precioboleto = 33;
            int cargacomun;
            int cargajubA;
            int cargajuB;
            int cargaestA;
            int cargaestB;
            string opcion;

    

            
            
            Console.WriteLine("*** Sistema de carga de STM ***\n\n");

            Console.WriteLine("Menu Principal Ingrese la opcion\n");
            
            Console.WriteLine("Ingrese 1 para Jubilados A\n");
            Console.WriteLine("Ingrese 2 para Jubilados B\n");
            Console.WriteLine("Ingrese 3 para Estudiantes A\n");
            Console.WriteLine("Ingrese 4 para Estudiantes B\n");
            Console.WriteLine("Cargar STM boletos cmunes\n");
            opcion = (Console.ReadLine());


            switch (opcion)

            {
            
                case "1":

                    Console.WriteLine("Ingrese monto");
                    cargacomun = Convert.ToInt32(Console.ReadLine());

                    if (cargacomun == 200 && cargacomun == 1000)
                    {

                        Console.WriteLine("Se acredito: " + cargacomun);
                        Console.ReadLine();
                    }

                    else
                    {

                        Console.WriteLine("Las cargas habilitadas son 200 y 1000");
                        Console.ReadLine();
                    }
                
                    
                    break;

                case "2":





                    break;




                default: Console.WriteLine("No es una opcion"+ opcion);
                    Console.ReadLine();
                    break;
            
            
            
            
            
            
            
            }
        
            
            
            
            
            
            Console.ReadKey();
        
        }
    }
}
