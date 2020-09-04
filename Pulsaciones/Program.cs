using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pulsaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            string Sexo;
            int Edad;
            decimal TotalDePulsaciones;
            Console.Write("Bienvenido,digite su nombre: ");
            Nombre=Console.ReadLine();
            Console.Write("Digite su Sexo para mujer (F) o para hombre (M): ");
            Sexo = Console.ReadLine();
            Console.WriteLine("Digite su edad");
            Edad= Convert.ToInt32(Console.ReadLine());
            if (Sexo.ToUpper() == "F")
            {
                TotalDePulsaciones = (220 - Edad) / 10;
            }
            else if (Sexo.ToUpper() == "M")
            {
                TotalDePulsaciones = (210 - Edad) / 10;
            }
            else
            {
                TotalDePulsaciones = 0;
            }

            Console.WriteLine($"|||Su nombre es: {Nombre} |||| Su edad es: {Edad} ||||| Su sexo es: {Sexo}|||");
            Console.WriteLine($"El total de sus pulsaciones es: {TotalDePulsaciones} ");
            Console.ReadKey();
        }
    }
}
