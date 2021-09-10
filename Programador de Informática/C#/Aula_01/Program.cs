using System;

namespace Aula_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimir Hello World!
            //Console.WriteLine("Hello World!");

            //Para que o código abaixo não o faça estourar, usamos tratamento de exepções (try/catch). 
            try
            {
                Console.WriteLine($"Olá {args[0]} {args[1]}");
            } catch (Exception e)
            {
                Console.WriteLine("Precisa de 2 argumentos!");
                //Ou.
                Console.WriteLine(e.Message);
                //Ou.
                Console.WriteLine($"O sistema devolveu a mensagem '{e.Message}'");
            }

            //Para ir buscar os argumentos passados nas propriedades do projeto, este projeto, depurar, argumentos do aplicativo.
            //Console.WriteLine(args[0]);
            //Console.WriteLine(args[1]);

            //O cifrão é utilizado para reconhecer os argumentos dentro das chavetas.
            //Console.WriteLine($"Olá {args[0]} {args[1]}");

            //Ou outra forma de escrever.
            //Console.WriteLine("Olá " + args[0] + " " + args[1]);

            //Para não fechar logo, pedimos para receber um input.
            Console.ReadKey();
        }
    }
}
