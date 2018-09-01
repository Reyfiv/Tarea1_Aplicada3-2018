using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDelLibro.Capitulo3
{
    class Ejercicios1_4_5
    {
        public void Ejercicio1()
        {
            int numero;
            string N = "";

            Console.WriteLine("Digite un numero:");
            N = Console.ReadLine();
            numero = Convert.ToInt32(N);

            if (numero % 2 == 0)
                Console.WriteLine("El numero es par");
            else
                Console.WriteLine("El numero es impar");

            Console.ReadKey();
        }


        public void Ejercicio4()
        {
            int numero;
            string m = "";

            Console.WriteLine("Digite un numero: ");
            m = Console.ReadLine();
            numero = Convert.ToInt32(m);

            int op;
            if (numero == 1)

                Console.WriteLine("Lunes");

            else if (numero == 2)

                Console.WriteLine("Martes");

            else if (numero == 3)

                Console.WriteLine("Miercoles");

            else if (numero == 4)

                Console.WriteLine("Jueves");

            else if (numero == 5)

                Console.WriteLine("Viernes");

            else if (numero == 6)

                Console.WriteLine("Sabado");

            else if (numero == 7)

                Console.WriteLine("Domingo");

            Console.ReadKey();
        }

        public void Ejercicio5()
        {

            float CLado;
            float VLado;
            float apotema;
            float perimetro;
            float area;

            string valor = "";
            int opcion;

            Console.WriteLine("---Poligonos regulares---");

            Console.WriteLine("1. Perimetro");
            Console.WriteLine("2. Area");

            Console.WriteLine(" ");

            Console.WriteLine("Que desea Calcular");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Digite cantidad de lados del poligono regular");
                    valor = Console.ReadLine();
                    CLado = Convert.ToSingle(valor);

                    Console.WriteLine("Digite valor de lados del poligo regular");
                    valor = Console.ReadLine();
                    VLado = Convert.ToSingle(valor);

                    perimetro = CLado * VLado;
                    Console.WriteLine("El perimetro es :{0}", perimetro);
                    break;

                case 2:
                    Console.WriteLine("Digite cantidad de lados del poligono regular");
                    valor = Console.ReadLine();
                    CLado = Convert.ToSingle(valor);

                    Console.WriteLine("Digite valor de lados del poligo regular");
                    valor = Console.ReadLine();

                    VLado = Convert.ToSingle(valor);
                    Console.WriteLine("Digite valor de la Apotema: ");
                    valor = Console.ReadLine();
                    apotema = Convert.ToSingle(valor);

                    area = CLado * VLado * apotema;

                    Console.WriteLine("El area es: {0}", area);

                    break;
            }

        }
    }
}
