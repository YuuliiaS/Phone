using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    internal class Program
    {
        public class Phone
        {
            private int number;
            private string model = "";
            private int weight;
            public void printArgs()
            {
                Console.Write(number);
                Console.Write(model);
                Console.Write(weight);
            }
            public void sendMessage(params string[] numbers)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
                Console.WriteLine();
            }
            public int getNumber()
            {
                return number;
            }
            public void recieveCall(string name)
            {
                Console.WriteLine("\n Звонит ");
                Console.Write(name);
            }
            public void recieveCall(string name, int number)
            {
                Console.WriteLine("\n Звонит ");
                Console.Write(name);
                Console.Write(number);
            }
            public Phone(int n, string m, int w) : this(n, m)
            {
                weight = w;
            }
            public Phone(int n, string m)
            {
                number = n;
                model = m;
                weight = 0;
            }
            public Phone()
            {
                number = 0;
                model = "";
                weight = 0;
            }

        }
        static void Main(string[] args)
        {
            Phone firstPhone = new Phone();
            Phone secondPhone = new Phone();
            Console.WriteLine(firstPhone.getNumber());
            firstPhone.recieveCall("\nКсения ");
            firstPhone.sendMessage("8800555453535");
            Console.WriteLine(secondPhone.getNumber());
            secondPhone.recieveCall("\nКсения ");
            secondPhone.sendMessage("18", "8833322332");
            firstPhone.printArgs();
            secondPhone.printArgs();
            firstPhone.recieveCall("Ксения ", 412423);

        }
    }
}
