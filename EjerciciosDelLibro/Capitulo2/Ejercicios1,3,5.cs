using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosDelLibro.Capitulo2
{
    class Ejercicios1_3_5
    {

        public void Ejercicio1()
        {
            float CantLado;
            float ValorLado;
            float perimetro;

            //como la funcion ReadLine() solo lee cadenas necesito una variable "string" para almacenar el valor 
            //para poder convertirlo al tipo de dato que deseo con la Clase Convert y poder hacer el calculo.

            string valor = "";

            Console.WriteLine("Digite cantidad de lados del poligono regular: ");
            valor = Console.ReadLine();
            CantLado = Convert.ToSingle(valor);

            Console.WriteLine("Digite valor de lados del poligo regular: ");
            valor = Console.ReadLine();
            ValorLado = Convert.ToSingle(valor);

            perimetro = CantLado * ValorLado;
            Console.WriteLine("El perimetro es :{0}", perimetro);

        }

        public void Ejercicio3()
        {
            float grados;
            float radianes;

            //como la funcion ReadLine() solo lee cadenas necesito una variable "string" para almacenar el valor 
            //para poder convertirlo al tipo de dato que deseo con la Clase Convert y poder hacer el calculo.

            String valor = "";

            Console.WriteLine("Digite el numero de grados: ");
            valor = Console.ReadLine();
            grados = Convert.ToSingle(valor);

            radianes = (grados * 3.14f) / 180;
            Console.WriteLine("los grados covertidos en radianes es: {0}", radianes);
            Console.ReadKey();
        }

        public void Ejercicio5()
        {
            float dolar = 0;
            float TasaEuro = 0;
            float total = 0;

            //como la funcion ReadLine() solo lee cadenas necesito una variable "string" para almacenar el valor 
            //para poder convertirlo al tipo de dato que deseo con la Clase Convert y poder hacer el calculo.

            string valor = "";

            Console.WriteLine("Digite dolares a cambiar: ");
            valor = Console.ReadLine();
            dolar = Convert.ToSingle(valor);

            Console.WriteLine("Digite tasa del euros: ");
            valor = Console.ReadLine();
            TasaEuro = Convert.ToSingle(valor);
            total = dolar / TasaEuro;
            Console.WriteLine("La cantidad de euros es: {0}", total);
            Console.ReadKey();

        }
    }

}
