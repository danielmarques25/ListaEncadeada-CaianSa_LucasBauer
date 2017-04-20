using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaEncadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            Number[] x = new Number[100];
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = new Number(new Random().Next(0, 100), i);
                if(i != 0)
                {
                    x[i - 1].next = x[i];
                }
            }

            ListNumbers(x[0]);
            Console.ReadKey();
        }

        public static Number ListNumbers(Number number)
        {
            Number x = number;
            while(true)
            {
                if (x == null)
                {
                    Console.WriteLine("Busca Completa");
                    return x;
                }
                Console.WriteLine("Numero " + x.x + " posicionado " + x.position);
                x = x.next;
            }
        }
    }

    public class Number
    {
        public int position;
        public int x;
        public Number next;

        public Number(int x, int position)
        {
            this.x = x;
            this.position = position;
        }
        
        public void Remove()
        {
            this.next = next.next;
        }

        public void Add(Number x)
        {
            this.next = x;
        }
    }

}
