using System;
using System.Threading.Tasks;
//using System.Collections;

namespace Bootcamp_6
{
    class Program
    {
        /*public static async Task proces()
        {

        }*/

        static void Ejercicio9()
        {
            Persona p = new Persona("fede", 2002, 09, 11);
            p.esMayor();
            
        }
        static void Ejercicio12()
        {
            double d = 12.25;
            d.parteEntera();
            d.centavos();
        }
        

        static void Main(string[] args)
        {
            Console.WriteLine("·Bootcamp 6·");

            Ejercicio12();

            Ejercicio9();

            Rectangulo r = new Rectangulo(3, 2);

            Console.WriteLine($"Perimetro: {r.getPerimetro()} cm\nArea: {r.getArea()} cm cuadrados");

            Stack<Rectangulo> rec = new Stack<Rectangulo>(3);
            rec.push(r);
            rec.push(r);
            Console.WriteLine(rec.pop().ToString());

            Console.WriteLine(rec.pop().ToString());
            
            Stack<string> s = new Stack<string>(2);
            s.push("fede");
            s.push("soy");
            Console.WriteLine(s.pop());
            
            Console.WriteLine(s.pop());       
        }
    }

    public partial class Rectangulo
    {
        private int lado1;
        private int lado2;

        public int Lado1
        {
            get
            {
                return lado1;
            }
            set
            {
                lado1 = value;
            }
        }
        public int Lado2
        {
            get
            {
                return lado2;
            }
            set
            {
                lado2 = value;
            }
        }

        public Rectangulo(int lado1, int lado2 )
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
        }

    }

    public partial class Rectangulo
    {
        public int getPerimetro()
        {
            return Lado1 * 2 + Lado2 * 2;
        }

        public int getArea()
        {
            return Lado1 * lado2;
        }

        public override string ToString()
        {
            return $"Lado 1: {Lado1}\nLado 2: {Lado2}\nArea: {getArea()}\nPerimetro: {getPerimetro()}";
        }
    }

    public class Stack<T>
    {
        public T[] data { get; set; }
        public int i = 0;

        public Stack(int x)
        {
            data = new T[x];
        }

        public void push(T d)
        {
            data[i] = d;
            i++;
        }

        public T pop()
        {
            i--;
            return data[i];
            
        }
    }
}
