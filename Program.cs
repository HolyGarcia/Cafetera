using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            int cafe = 2;
            int sobreCafe;
          int  resultCafe;

            Console.WriteLine("Seleccione un tamaño de vaso: ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1:  3 Onz");
            Console.WriteLine("2:  5 Onz");
            Console.WriteLine("3:  7 Onz");
            Console.WriteLine();
            Console.WriteLine("0: Salir");
            Console.WriteLine();
            Console.WriteLine();

            do
            {
        
            num = Convert.ToByte(Console.ReadLine());

                if (num == 1)
                {

                    cant = vaso3onz - 1;
                    result3 = cant;
                    vaso3onz = result3;


                    Console.WriteLine();
                    Console.WriteLine("Eligió vaso de 3 Onz");
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine(cant);
                    Console.WriteLine(result3);
                    Console.WriteLine(vaso3onz);

                    if (result3 < 1)
                    {
                        Console.WriteLine("No hay vasos de 3 Onz");
                        Console.WriteLine("presione Enter para continuar");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Seleccione un tamaño de vaso: ");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("2:  5 Onz");
                        Console.WriteLine("3:  7 Onz");
                        Console.WriteLine();
                        Console.WriteLine("0: Salir");
                        Console.WriteLine();
                        Console.WriteLine();

                        num = Convert.ToByte(Console.ReadLine());
                    }
 
                }

                if (num == 2)
                {

                    cant = vaso5onz - 1;
                    result5 = cant;
                    vaso5onz = result5;


                    Console.WriteLine();
                    Console.WriteLine("Eligió vaso de 5 Onz");
                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine(cant);
                    Console.WriteLine(result5);
                    Console.WriteLine(vaso5onz);

                    if (result5 < 1)
                    {
                        Console.WriteLine("No hay vasos de 5 Onz");
                        Console.WriteLine("presione Enter para continuar");
                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Seleccione un tamaño de vaso: ");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("1:  3 Onz");
                        Console.WriteLine("3:  7 Onz");
                        Console.WriteLine();
                        Console.WriteLine("0: Salir");
                        Console.WriteLine();
                        Console.WriteLine();

                        num = Convert.ToByte(Console.ReadLine());
                    }
                }

                    if (num == 3)
                    {

                        cant = vaso7onz - 1;
                        result7 = cant;
                        vaso7onz = result7;


                        Console.WriteLine();
                        Console.WriteLine("Eligió vaso de 7 Onz");
                        Console.WriteLine();
                        Console.WriteLine();

                        if (result7 < 1)
                        {
                            Console.WriteLine("No hay vasos de 7 Onz");
                            Console.WriteLine("presione Enter para continuar");
                            Console.ReadKey();
                            Console.Clear();

                            Console.WriteLine(cant);
                            Console.WriteLine(result7);
                            Console.WriteLine(vaso7onz);

                            Console.WriteLine("Seleccione un tamaño de vaso: ");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("1:  3 Onz");
                            Console.WriteLine("2:  5 Onz");
                            Console.WriteLine();
                            Console.WriteLine("0: Salir");
                            Console.WriteLine();
                            Console.WriteLine();

                            num = Convert.ToByte(Console.ReadLine());
                        }

                    }

                Console.WriteLine();
                Console.WriteLine("Seleccione Cantidad de Azucar: de 1 a 5 cucharadas ");
                azucar = Convert.ToByte(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();


                if (azucar > 5)
                {
                    Console.WriteLine("Cantidad invalida Seleccione: de 1 a 5 cucharadas ");
                    Console.WriteLine();
                    Console.WriteLine();
                    azucar = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine();
                }

                sobreCafe = cafe - 1;
                resultCafe = sobreCafe;


                Console.WriteLine("Hay Cafe");
                Console.WriteLine("presione Enter para continuar");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Seleccione un tamaño de vaso: ");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("1:  3 Onz");
                Console.WriteLine("2:  5 Onz");
                Console.WriteLine("3:  7 Onz");
                Console.WriteLine();
                Console.WriteLine("0: Salir");
                Console.WriteLine();
                Console.WriteLine();

                if (resultCafe < 1)
                {
                    Console.WriteLine("No hay Cafe");
                }

            } while (num != 0);

        }
    }

}