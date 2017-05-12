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


            Console.Clear();

            bool salir = false;
            string otravez;
            while (salir != true)
            {
                const double precioboleto = 33;
                int cargacomun;
                double cargajubA;
                double cargajuB;
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
                        cargajubA = Convert.ToInt32(Console.ReadLine());



                        if (cargajubA == 50)
                        {




                            descuentoJubA = cargajubA * 0.50;
                            totalJubA = cargajubA - descuentoJubA;
                            cantidadboletosJubA = (cargajubA / precioboleto);

                            int a = (int)cantidadboletosJubA;
                            string cantidadboletosJubA_aux = Convert.ToString(cantidadboletosJubA);

                            // Console.WriteLine("CADENA CONVERTIDA: " + cantidadboletosJubA_aux);





                            Console.WriteLine("Se acredito: " + cargajubA + " Y debe de pagar " + totalJubA);
                            Console.WriteLine("Su carga sirve para:  " + cantidadboletosJubA_aux.Trim().Substring(0, 1)+ " boleto");
                            Console.ReadLine();



                        }


                        else if (cargajubA == 500)
                        {


                            Console.WriteLine("Ingrese monto");
                            cargajuB = Convert.ToInt32(Console.ReadLine());
                            
                            descuentoJubB = cargajubA * 0.25;
                            totalJubA = cargajuB - descuentoJubB;

                            cantidadboletosJubB = (cargajuB / precioboleto);

                            int a = (int)cantidadboletosJubB;
                            string cantidadboletosJubB_aux = Convert.ToString(cantidadboletosJubB);



                            Console.WriteLine("Se acredito: " + cargajubA + " Y debe de pagar " + totalJubA);
                            Console.WriteLine("Su carga sirve para:  " + cantidadboletosJubB_aux.Trim().Substring(0, 2) + " boletos");
                            Console.ReadLine();


                        }

                        else
                        {

                            Console.WriteLine("Las cargas habilitadas son 50 y 500");
                            Console.ReadLine();
                        }




                        break;




                    default: Console.WriteLine("No es una opcion" + opcion);
                        Console.ReadLine();
                        break;







                }

                Console.WriteLine("Desea realizar otra carga s/n");
                otravez = Console.ReadLine().ToLower();
                if (otravez == "n")
                {
                    salir = true;
                }
            }









        }
    }
}