using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime;

namespace Bootcamp_6
{
    public class Persona
    {
        public string nombre { get; set; }
        public DateTime birthDate { get; set; }

        public Persona(string nombre, int year, int month, int day)
        {
            this.birthDate = new DateTime(year, month, day);
            this.nombre = nombre;
        }
    }

    public static class Extensiones
    {
        public static void esMayor(this Persona p)
        {
            DateTime hoy = new DateTime(2022, 05, 09);
            int edad = hoy.Year - p.birthDate.Year;
            if ( edad < 18)
            {
                Console.WriteLine($"{p.nombre} es menor de edad");
            }
            else Console.WriteLine($"{p.nombre} es mayor de edad");
        }

        public static void centavos(this double d)
        {
            string s = d.ToString();
            string[] subs = s.Split(',');
            Console.WriteLine($"Centavos: {subs[1]}");
        }
        public static void parteEntera(this double d)
        {
            string s = d.ToString();
            string[] subs = s.Split(',');
            Console.WriteLine($"Parte entera: {subs[0]}");
        }
    }
}
