using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDelLibro.Capitulo4
{
    class Ejercicios1_2_5
    {
        public void Ejercicio1()
        {
            int numero;

            Console.WriteLine("Digite un numero");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int mult = numero * i;
                Console.WriteLine("{0} *{1} = {2}", numero, i, mult);
            }
            Console.ReadKey();

        }
        public void Ejercicio2()
        {
            int basee;
            int e;
            int exp;

            Console.WriteLine("Digite numero de base");
            basee = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite numero de base");
            exp = Convert.ToInt32(Console.ReadLine());

            e = exp;
            do
            {
                basee = basee * e;
                exp--;

            } while (exp > 0);

            Console.WriteLine("El exponente es:{0}", exp);
            Console.ReadKey();


        }


    }
}
