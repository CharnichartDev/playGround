using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playGround
{
    class Program
    {

        private static Func<int> f = () => 5 + 5;
        static void Main(string[] args)
        {
            Func<int, int> df = (int valui) => 5 + valui;
            Action<string> mimgo = (string g) => Console.WriteLine(g);

            Action<string> asyncAct = async (string inp) =>
            {
                string h = $"{inp} Hola wey";
                await methodTask();
                Console.WriteLine(h);
            };

            //float f = float.IsNaN; // NaN = Not a Number

            checked
            // provoca que el codigo lance una excepcion OverFlowException si el si el INT se pasa del maximo permitido
            {

            }

            asyncAct("bro!");
            Console.ReadLine();
        }

        static Task methodTask()
        {
            return Task.Delay(3000);
        }
    }
}
