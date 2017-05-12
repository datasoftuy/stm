using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leapyear
{
    class Program
    {
        static void Main(string[] args)
        {


            
                const double precioboleto = 33;
                int cargacomun;
                double cargajubAB;
                
                int cargaestA;
                int cargaestB;
                string opcion;
                double descuentoJubA;
                double descuentoJubB;
                double totalJubA;
                double cantidadboletosJubA;
                double cantidadboletosJubB;
                //string cantidadboletosJubA_aux;




                Console.Clear();

                Console.WriteLine("*** Sistema de carga de STM ***\n\n");

                Console.WriteLine("Menu Principal Ingrese la opcion\n");

                Console.WriteLine("1)  Ingrese 1 para Jubilados A\n");
                Console.WriteLine("2)  Ingrese 2 para Jubilados B\n");
                Console.WriteLine("3)  Ingrese 3 para Estudiantes A\n");
                Console.WriteLine("4)  Ingrese 4 para Estudiantes B\n");
                Console.WriteLine("5)  Cargar STM boletos cmunes\n");
                opcion = (Console.ReadLine());

                Console.Clear();
                switch (opcion)
                {

                    case "1":

                        Console.WriteLine("Ingrese monto");
                        cargacomun = Convert.ToInt32(Console.ReadLine());

                        if (cargacomun == 200)
                        {

                            Console.WriteLine("Se acredito: " + cargacomun);
                            Console.ReadLine();
                        }

                        else if (cargacomun == 1000)
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

                        Console.WriteLine("Ingrese monto");
                        cargajubAB = Convert.ToInt32(Console.ReadLine());



                        if (cargajubAB == 50)
                        {


                            descuentoJubA = cargajubAB * 0.50;
                            totalJubA = cargajubAB - descuentoJubA;
                            cantidadboletosJubA = (cargajubAB / precioboleto);

                            int a = (int)cantidadboletosJubA;
                            string cantidadboletosJubA_aux = Convert.ToString(cantidadboletosJubA);

                            Console.WriteLine("Se acredito: " + cargajubAB + " Y debe de pagar " + totalJubA);
                            Console.WriteLine("Su carga sirve para:  " + cantidadboletosJubA_aux.Trim().Substring(0, 1) + " boleto");
                            Console.ReadLine();

                        }


                        else if (cargajubAB == 500)
                        {




                            descuentoJubB = cargajubAB * 0.25;
                            totalJubA = cargajubAB - descuentoJubB;

                            cantidadboletosJubB = (cargajubAB / precioboleto);

                            int a = (int)cantidadboletosJubB;
                            string cantidadboletosJubB_aux = Convert.ToString(cantidadboletosJubB);



                            Console.WriteLine("Se acredito: " + cargajubAB + " Y debe de pagar " + totalJubA);
                            Console.WriteLine("Su carga sirve para:  " + cantidadboletosJubB_aux.Trim().Substring(0, 2) + " boletos");
                            Console.ReadLine();


                        }

                        else
                        {

                            Console.WriteLine("Las cargas habilitadas son 50 y 500");
                            Console.ReadLine();
                        }


                        break;

                    default: Console.WriteLine( opcion +" No es una opcion valida del menu stm");
                        Console.ReadLine();
                        break;







                }

                
            









        }
    }
}