﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leapyear
{
    class Program
    {
        static void Main(string[] args)
        {




            bool salir = false;
            string otravez;
            while (salir != true)
            {



                const double precioboleto = 33;
                int cargacomun;
                double cargajubAB;
                double cargaestAB;
                string opcion;
                double descuentoJubA;
                double descuentoJubB;
                double totalJubA;
                double cantidadboletosJubA;
                double cantidadboletosJubB;
                double abonarEST_A;
                double abonarEST_B;

                //string cantidadboletosJubA_aux;






                Console.Clear();

                Console.WriteLine("*** Sistema de carga de STM DATASOFT URUGUAY ***\n\n");

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

                    case "5":

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

                    case "3":

                                Console.WriteLine("Ingrese monto");
                                cargaestAB = Convert.ToInt32(Console.ReadLine());

                                if (cargaestAB == 5 || cargaestAB == 10 || cargaestAB == 25 || cargaestAB == 50)
                                {

                                    abonarEST_A = cargaestAB * precioboleto;
                                    double descuentoEST_A = abonarEST_A * 0.50;
                                    double totalEST_A = abonarEST_A - descuentoEST_A;


                                    Console.WriteLine("Debe de abonar: "+ totalEST_A);
                                    
                                }



                        break;

                    case "4":




                        Console.WriteLine("Ingrese monto");
                                cargaestAB = Convert.ToInt32(Console.ReadLine());

                                if (cargaestAB == 10 || cargaestAB == 25 || cargaestAB == 50 || cargaestAB == 100)
                                {

                                    abonarEST_B = cargaestAB * precioboleto;
                                    double descuentoEST_B =abonarEST_B * 0.75;
                                    double totalEST_B = abonarEST_B - descuentoEST_B;


                                    Console.WriteLine("Debe de abonar: "+ totalEST_B);
                                    
                                }





                        break;


                    default: Console.WriteLine(opcion + " No es una opcion valida del menu stm");
                        Console.ReadLine();
                        break;


                }






                Console.WriteLine("Desea realizar otra carga ? s/n");
                otravez = Console.ReadLine().ToLower();
                if (otravez == "n")
                {
                    salir = true;
                }
            }









        }
    }
}