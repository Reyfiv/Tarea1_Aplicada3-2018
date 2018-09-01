using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjerciciosDelLibro;


namespace EjerciciosDelLibro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---MENU---");

            Console.WriteLine("1. Capitulo 1");
            Console.WriteLine("2. Capitulo 2");
            Console.WriteLine("3. Capitulo 3");
            Console.WriteLine("4. Capitulo 4");

            Console.WriteLine(" ");

            int opcion;
            Console.WriteLine("Digite el capitulo que desea ver: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("---Capitulo 1---");

                Console.WriteLine(" ");

                Console.WriteLine("1. Ejercicio 1");
                Console.WriteLine("2. Ejercicio 5");

                Console.WriteLine("");

                int op;
                Console.WriteLine("Cual ejercicio desea: ");
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Capitulo1.Ejercicios1_5 cj = new Capitulo1.Ejercicios1_5();
                        cj.Ejercicio1();
                        break;
                    case 2:
                        Capitulo1.Ejercicios1_5 c = new Capitulo1.Ejercicios1_5();
                        c.Ejercicio5();
                        break;
                }
            }

            else if (opcion == 2)
            {
                Console.WriteLine("---Capitulo 2---");

                Console.WriteLine(" ");

                Console.WriteLine("1. Ejercicio 1");
                Console.WriteLine("2. Ejercicio 3");
                Console.WriteLine("3. Ejercicio 5");

                Console.WriteLine(" ");

                int opc;
                Console.WriteLine("Cual ejercicio desea: ");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Capitulo2.Ejercicios1_3_5 e = new Capitulo2.Ejercicios1_3_5();
                        e.Ejercicio1();
                        break;

                    case 2:
                        Capitulo2.Ejercicios1_3_5 ej = new Capitulo2.Ejercicios1_3_5();
                        ej.Ejercicio3();
                        break;

                    case 3:
                        Capitulo2.Ejercicios1_3_5 eje = new Capitulo2.Ejercicios1_3_5();
                        eje.Ejercicio5();
                        break;



                }

            }


            else if (opcion == 3)
            {
                Console.WriteLine("---Capitulo 3---");

                Console.WriteLine("");

                Console.WriteLine("1. Ejercicio 1");
                Console.WriteLine("2. Ejercicio 4");
                Console.WriteLine("3. Ejercicio 5");

                Console.WriteLine("");

                int opc;
                Console.WriteLine("Cual ejerccio desea");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Capitulo3.Ejercicios1_4_5 cp = new Capitulo3.Ejercicios1_4_5();
                        cp.Ejercicio1();
                        break;


                    case 2:
                        Capitulo3.Ejercicios1_4_5 c = new Capitulo3.Ejercicios1_4_5();
                        c.Ejercicio4();
                        break;

                    case 3:
                        Capitulo3.Ejercicios1_4_5 ej = new Capitulo3.Ejercicios1_4_5();
                        ej.Ejercicio4();
                        break;


                }
            }
            else if (opcion == 4)
            {
                Console.WriteLine("---Capitulo 4---");

                Console.WriteLine(" ");

                Console.WriteLine("1. Ejercicio 1");
                Console.WriteLine("2. Ejercicio 2");
                Console.WriteLine("3. Ejercicio 5");

                Console.WriteLine(" ");

                int opc;
                Console.WriteLine("Cual ejerccio desea:");
                opc = Convert.ToInt32(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Capitulo4.Ejercicios1_2_5 ej = new Capitulo4.Ejercicios1_2_5();
                        ej.Ejercicio1();
                        break;

                    case 2:
                        Capitulo4.Ejercicios1_2_5 c = new Capitulo4.Ejercicios1_2_5();
                        c.Ejercicio2();
                        break;
                    case 3:
                        break;
                }
            }

        }
    }
}
