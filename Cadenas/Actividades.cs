using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cadenas
{
    class Actividades
    {
        public void A7()
        {
            Console.Write("Ingrese su nombre: ");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Hola " + Nombre);
        }

        public void A8()
        {
            Console.Write("Ingrese una frase: ");
            string Frase = Console.ReadLine();

            int Index = Frase.IndexOf("fin");
            if (Index != -1)
            {
                Console.WriteLine("Su frase: " + "'" + Frase + "'" + " contiene la palabra fin");
            }
            else
            {
                Console.WriteLine("Presione una tecla para salir");
            }
        }

        public void A9()
        {
            Console.Write("Ingrese texto: ");
            string Texto = Console.ReadLine().ToUpper();
            Console.WriteLine("Su texto en mayúsculas es: " + Texto);
        }

        public void A10()
        {
            Console.Write("Ingrese texto: ");
            string Texto = Console.ReadLine().ToLower();
            Console.WriteLine("Su texto en minpusculas es: " + Texto);
        }

        public void A11()
        {
            Console.Write("Ingrese texto: ");
            string Texto = Console.ReadLine();
            string TextoSinTildes = Regex.Replace(Texto.Normalize(NormalizationForm.FormD), @"[^a-zA-z0-9 ]+", "");
            Console.WriteLine("Su texto sin tildes es: " + TextoSinTildes);
        }

        public void A12()
        {
            Console.Write("Ingrese frase 1: ");
            string Texto1 = Console.ReadLine();
            Console.Write("Ingrese frase 2: ");
            string Texto2 = Console.ReadLine();
            if (Texto1 == Texto2)
            {
                Console.WriteLine("Las frases son iguales");
            }
            else
            {
                Console.WriteLine("Las frases son diferentes");
            }
        }

        public void A13()
        {
            Console.Write("Ingrese frase 1: ");
            string Texto1 = Console.ReadLine();
            Console.Write("Ingrese frase 2: ");
            string Texto2 = Console.ReadLine();

            if (Texto1.Length == Texto2.Length)
            {
                Console.WriteLine("Las frases tienen la misma longitud");
            }
            else
            {
                Console.WriteLine("Las frases no tienen la misma longitud");
            }
        }

        public void A14()
        {
            Console.Write("Ingrese frase 1: ");
            string Texto1 = Console.ReadLine().ToLower();
            Console.Write("Ingrese frase 2: ");
            string Texto2 = Console.ReadLine().ToLower();

            if (Texto1 == Texto2)
            {
                Console.WriteLine("Las frases son iguales");
            }
            else
            {
                Console.WriteLine("Las frases son diferentes");
            }
        }

    }
}
