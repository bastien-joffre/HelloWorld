using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message();

            String input;
            do {
                Console.WriteLine("Appuyez sur entrée pour votre message, tappez 'exit' pour quitter");
                input = Console.ReadLine();
                if (input == "") Console.WriteLine(message.getHelloMessage());
            } while (input != "exit");
        }
    }
}
