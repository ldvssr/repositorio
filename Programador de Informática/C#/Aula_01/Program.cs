using System;
using System.Collections.Generic;

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
                //Ou (Para saber qual a mensagem do sistema).
                Console.WriteLine(e.Message);
                //Ou (Quando a mensagem do sistema não é bem perceptível ao utilizador adicionamos uma mensagem auxiliar).
                Console.WriteLine($"O sistema devolveu a mensagem '{e.Message}'");
            }

            //Para ir buscar os argumentos passados nas propriedades do projeto, este projeto, depurar, argumentos do aplicativo.
            //Console.WriteLine(args[0]);
            //Console.WriteLine(args[1]);

            //O cifrão é utilizado para reconhecer os argumentos dentro das chavetas.
            //Console.WriteLine($"Olá {args[0]} {args[1]}");

            //Ou outra forma de escrever.
            //Console.WriteLine("Olá " + args[0] + " " + args[1]);

            int a1 = 5;
            float a2 = 6.5f;
            double a3 = 7.8;
            string a4 = "Daniel";
            bool a5 = true;
            Boolean a6 = false;

            //--------------------------

            List<string> lista = new List<string>();

            lista.Add("Daniel");
            lista.Add("Ventura");

            foreach(var lst in lista)
            {
                Console.WriteLine(lst);
            }

            //Imprimir a variável a1.
            Console.WriteLine(a1);

            //Para não fechar logo, pedimos para receber um input.
            Console.ReadKey();
        }
    }
}
