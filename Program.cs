using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cafetera
{
    internal class Program

    {
        static void Main(string[] args)
        {
            int num;

            int vaso3onz = 2;
            int vaso5onz = 2;
            int vaso7onz = 2;
            int result3;
            int result5;
            int result7;
            int cant;
            int azucar; 
            int cantAzucar = 6;
            int resultAzucar;
            int altAzucar;
            int cafe = 4;
            int sobreCafe;
            int resultCafe;
            int validar;

            Console.WriteLine();
            Console.WriteLine("                                                                              Cantidad Vaso de 3 Onz: " + "" + vaso3onz);
            Console.WriteLine("                                                                              Cantidad Vaso de 5 Onz: " + "" + vaso5onz);
            Console.WriteLine("                                                                              Cantidad Vaso de 7 Onz: " + "" + vaso7onz);
            Console.WriteLine("                                                                              Cantidad de cucharadas de Azucar: " + "" + cantAzucar);
            Console.WriteLine("                                                                              Cantidad paquetes de Cafe: " + "" + cafe);
            Console.WriteLine("      Seleccione un tamaño de vaso: ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("      1:  3 Onz");
            Console.WriteLine("      2:  5 Onz");
            Console.WriteLine("      3:  7 Onz");
            Console.WriteLine();
            Console.WriteLine("      0: Salir");
            Console.WriteLine();
            Console.WriteLine();


            do
            {
                

                num = Convert.ToByte(Console.ReadLine());


                do
                {

                    if (num != 0 && num != 1 && num != 2 && num != 3)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Debe Elegir una opcion valida");

                        Thread.Sleep(2000);
                        Console.Clear();

                        Console.WriteLine("      Seleccione un tamaño de vaso: ");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("      1:  3 Onz");
                        Console.WriteLine("      2:  5 Onz");
                        Console.WriteLine("      3:  7 Onz");
                        Console.WriteLine();
                        Console.WriteLine("      0: Salir");
                        Console.WriteLine();
                        Console.WriteLine();

                        num = Convert.ToByte(Console.ReadLine());
                    }


                    if (num == 1)
                    {
                        Console.Clear();

                        cant = vaso3onz - 1;
                        result3 = cant;
                        vaso3onz = result3;
                        if (vaso3onz < 0)
                        {
                            vaso3onz = 0;
                        }

                        Console.WriteLine();
                        Console.WriteLine("                                                                              Cantidad Vaso de 3 Onz: " + "" + vaso3onz);
                        Console.WriteLine("                                                                              Cantidad Vaso de 5 Onz: " + "" + vaso5onz);
                        Console.WriteLine("                                                                              Cantidad Vaso de 7 Onz: " + "" + vaso7onz);
                        Console.WriteLine("                                                                              Cantidad de cucharadas de Azucar: " + "" + cantAzucar);
                        Console.WriteLine("                                                                              Cantidad paquetes de Cafe: " + "" + cafe);
                        Console.WriteLine();

                        Console.WriteLine();
                        Console.WriteLine("     Eligió vaso de 3 Onz");
                        Console.WriteLine();
                        Console.WriteLine();



                        if (result3 < 0)
                        {
                           
                            Console.WriteLine("   No hay vasos de 3 Onz");
                            Thread.Sleep(2000);
                            Console.Clear();

                            Console.WriteLine("    Seleccione un tamaño de vaso: ");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("    2:  5 Onz");
                            Console.WriteLine("    3:  7 Onz");
                            Console.WriteLine();
                            Console.WriteLine("    0: Salir");
                            Console.WriteLine();
                            Console.WriteLine();

                            num = Convert.ToByte(Console.ReadLine());
                        }

                    }

                    if (num == 2)
                    {



                        Console.Clear();
                     
                        cant = vaso5onz - 1;
                        result5 = cant;
                        vaso5onz = result5;
                        if (vaso5onz < 0)
                        {
                            vaso5onz = 0;
                        }

                        Console.WriteLine();
                        Console.WriteLine("                                                                              Cantidad Vaso de 3 Onz: " + "" + vaso3onz);
                        Console.WriteLine("                                                                              Cantidad Vaso de 5 Onz: " + "" + vaso5onz);
                        Console.WriteLine("                                                                              Cantidad Vaso de 7 Onz: " + "" + vaso7onz);
                        Console.WriteLine("                                                                              Cantidad de cucharadas de Azucar: " + "" + cantAzucar);
                        Console.WriteLine("                                                                              Cantidad paquetes de Cafe: " + "" + cafe);
                        Console.WriteLine();


                        Console.WriteLine();
                        Console.WriteLine("       Eligió vaso de 5 Onz");
                        Console.WriteLine();
                        Console.WriteLine();

                       

                        if (result5 < 0)
                        {
                           
                            Console.WriteLine("    No hay vasos de 5 Onz");
                            Thread.Sleep(2000);
                            Console.Clear();

                            Console.WriteLine("     Seleccione un tamaño de vaso: ");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("      1:  3 Onz");
                            Console.WriteLine("      3:  7 Onz");
                            Console.WriteLine();
                            Console.WriteLine("      0: Salir");
                            Console.WriteLine();
                            Console.WriteLine();

                            num = Convert.ToByte(Console.ReadLine());
                        }
                    }

                    if (num == 3)
                    {

                        Console.Clear();

                        cant = vaso7onz - 1;
                        result7 = cant;
                        vaso7onz = result7;
                        if (vaso7onz < 0)
                        {
                            vaso7onz = 0;
                        }

                        Console.WriteLine();
                        Console.WriteLine("                                                                              Cantidad Vaso de 3 Onz: " + "" + vaso3onz);
                        Console.WriteLine("                                                                              Cantidad Vaso de 5 Onz: " + "" + vaso5onz);
                        Console.WriteLine("                                                                              Cantidad Vaso de 7 Onz: " + "" + vaso7onz);
                        Console.WriteLine("                                                                              Cantidad de cucharadas de Azucar: " + "" + cantAzucar);
                        Console.WriteLine("                                                                              Cantidad paquetes de Cafe: " + "" + cafe);
                        Console.WriteLine();

                        Console.WriteLine();
                        Console.WriteLine("       Eligió vaso de 7 Onz");
                        Console.WriteLine();
                        Console.WriteLine();

                        if (result7 < 0)
                        {
                           
                            Console.WriteLine("    No hay vasos de 7 Onz");
                            Thread.Sleep(2000);
                            Console.Clear();



                            Console.WriteLine("    Seleccione un tamaño de vaso: ");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("    1:  3 Onz");
                            Console.WriteLine("    2:  5 Onz");
                            Console.WriteLine();
                            Console.WriteLine("    0: Salir");
                            Console.WriteLine();
                            Console.WriteLine();

                            num = Convert.ToByte(Console.ReadLine());
                        }

                    }

                    if (cantAzucar <= 0)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("           No hay Azucar, Desea Continuar?");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("           1. Si");
                    Console.WriteLine("           2. No");
                    Console.WriteLine();
                    Console.WriteLine();
                    validar = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine();



                    Console.Clear();

                    if (validar == 1)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("       Eligió Café sin Azucar");
                        Console.WriteLine();
                        Thread.Sleep(2000);


                        }

                    if (validar == 2)
                    {
                        Thread.Sleep(4000);
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("Apagando.....");
                        num = 0;
                    }

                }
             

                } while (num != 0 && num != 1 && num != 2 && num != 3);


               

                do
                {
                    if (cantAzucar > 0) { 
                    Console.WriteLine();
                    Console.WriteLine("     Ingrese Cantidad de cucharadas de Azucar: ");
                    Console.WriteLine();
                    azucar = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine();
                    resultAzucar = cantAzucar;
                    Console.WriteLine();


                        if (azucar <= cantAzucar)
                    {

                        altAzucar = cantAzucar - azucar;
                        cantAzucar = altAzucar;
                            Console.Clear();


                        }
                        

                        if (azucar < 1)
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("       Eligió Café sin Azucar");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("       Presione Enter para continuar");
                            Console.ReadKey();

                        }

                        if (azucar > 6)
                    {
                        do {
                        cantAzucar = resultAzucar;
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("     Cantidad invalida de Azucar: ");
                        Console.WriteLine();
                        Console.WriteLine("     Excede la cantidad disponible, " + ""+ " Disponible: "+ cantAzucar);
                        Console.WriteLine();
                                Thread.Sleep(2000);
                        
                      

                            Console.Clear();

                            Console.WriteLine();
                            Console.WriteLine("     Ingrese Cantidad de cucharadas de Azucar: " + "" + " Disponible: " + cantAzucar);
                            Console.WriteLine();
                            azucar = Convert.ToByte(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine();

                            altAzucar = cantAzucar - azucar;
                            cantAzucar = altAzucar;


                        } while (azucar > resultAzucar);


                    }
                    }

                } while (cantAzucar < 0);

         





                Console.Clear();

                Console.WriteLine();
                Console.WriteLine("                                                                              Cantidad Vaso de 3 Onz: " + "" + vaso3onz);
                Console.WriteLine("                                                                              Cantidad Vaso de 5 Onz: " + "" + vaso5onz);
                Console.WriteLine("                                                                              Cantidad Vaso de 7 Onz: " + "" + vaso7onz);
                Console.WriteLine("                                                                              Cantidad de cucharadas de Azucar: " + "" + cantAzucar);
                Console.WriteLine("                                                                              Cantidad paquetes de Cafe: " + "" + cafe);
                Console.WriteLine();

                sobreCafe = cafe - 1;
                resultCafe = sobreCafe;
                cafe = resultCafe;


               
              
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("             Hay Cafe");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("             Preparando....");
                Console.WriteLine();
                Console.WriteLine();
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine();

                Console.WriteLine("    El Cafe está Listo!");
                Console.WriteLine();
                Console.WriteLine( "           ';                ");
                Console.WriteLine("            `.                ");
                Console.WriteLine("            `.'               ");
                Console.WriteLine("             . '              ");
                Console.WriteLine("           / / /              ");
                Console.WriteLine("      _______________         ");
                Console.WriteLine("     |               |====ɿ   ");
                Console.WriteLine("     |     CofFeE    |   //   ");
                Console.WriteLine("     |~~~~~~~~~~~~~~~|==''    ");
                Console.WriteLine("      COOOOOOOOOOOOOO         ");
                Console.WriteLine("   ___` ____________/____     ");
                Console.WriteLine("    ˋ.________________.ˊ      ");
                Console.WriteLine("                              ");
                Console.WriteLine("                              ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("  presione Enter para continuar");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine();
                Console.WriteLine("                                                                              Cantidad Vaso de 3 Onz: " + "" + vaso3onz);
                Console.WriteLine("                                                                              Cantidad Vaso de 5 Onz: " + "" + vaso5onz);
                Console.WriteLine("                                                                              Cantidad Vaso de 7 Onz: " + "" + vaso7onz);
                Console.WriteLine("                                                                              Cantidad de cucharadas de Azucar: " + "" + cantAzucar);
                Console.WriteLine("                                                                              Cantidad paquetes de Cafe: " + "" + cafe);
                Console.WriteLine("      Seleccione un tamaño de vaso: ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("      1:  3 Onz");
                Console.WriteLine("      2:  5 Onz");
                Console.WriteLine("      3:  7 Onz");
                Console.WriteLine();
                Console.WriteLine("      0: Salir");
                Console.WriteLine();
                Console.WriteLine();

                if (resultCafe <= 0)
                {
                    Console.Clear();
                   
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("         No hay Cafe...    :(");
                    Console.WriteLine();
                    Console.WriteLine("         Apagando...");
                    Thread.Sleep(2000);
                    num = 0;

                }

                if (num != 0 && num != 1 && num != 2 && num != 3)
                {
                    Console.WriteLine("Debe Elegir una opcion valida");

                    Thread.Sleep(2000);
                    Console.Clear();


                }

            } while (num != 0);

        }
    }

}
