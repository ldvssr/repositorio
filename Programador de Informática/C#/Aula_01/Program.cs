﻿using System;
using System.Collections.Generic;
using System.IO;

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

            //Imprimir a variável a1.
            Console.WriteLine(a1);

            Console.WriteLine(a2); 
            Console.WriteLine(a3);
            Console.WriteLine(a4); 
            Console.WriteLine(a5);
            Console.WriteLine(a6);

            //--------------------------

            List<string> lista = new List<string>();

            lista.Add("Daniel");
            lista.Add("Ventura");

            foreach(var lst in lista)
            {
                Console.WriteLine(lst);
            }

            Console.WriteLine(lista[0]);

            //--------------------------

            var cidades = new Dictionary<string, string>()
            {
                {"Norte", "Porto" },
                {"Centro", "Coimbra" },
                {"Lisboa", "Lisboa" },
                {"Alentejo", "Beja" },
                {"Algarve", "Faro" }
            };

            foreach (var kvp in cidades)
                Console.WriteLine("Key: {0}, Values: {1}", kvp.Key, kvp.Value);

            Console.WriteLine(cidades["Norte"]);

            //--------------------------

            string s = Console.ReadLine();

            //int dia;
            //try
            //{
            //    dia = Convert.ToInt32(s);
            //}catch (Exception e)
            //{
            //    dia = -1;
            //}

            int.TryParse(s, out int dia);

            if (dia == 0) dia = -1;

            //int dia = 0;

            string nome_dia = "" ;

            switch(dia)
            {
                case 0:
                    nome_dia = "Domingo";
                    break;
                case 1:
                    nome_dia = "Segunda";
                    break;
                case 2:
                    nome_dia = "Terça";
                    break;
                case 3:
                    nome_dia = "Quarta";
                    break;
                case 4:
                    nome_dia = "Quinta";
                    break;
                case 5:
                    nome_dia = "Sexta";
                    break;
                case 6:
                    nome_dia = "Sábado";
                    break;
                default:
                    nome_dia = "Inválido";
                    break;
            }

            Console.WriteLine(nome_dia);

            //--------------------------

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            //--------------------------

            for (int n = 10; n < 20; n++)
            {
                Console.WriteLine(n);
            }

            //--------------------------

            
            //--------------------------

            Program p = new Program();
            p.myTeste(5);

            //--------------------------

            p.Se();

            //--------------------------

            p.Ficheiros();

            //--------------------------

            Random rnd = new Random();
            int num = rnd.Next(1, 101);

            int controlo = 1;

            while (controlo == 1)
            {

                Console.WriteLine("\nIntroduza um número: ");

                string leitura = Console.ReadLine();

                int.TryParse(leitura, out int num_introd);

                if (num_introd < num)
                {
                    Console.WriteLine("\nnumero pequeno");
                }
                else if (num_introd > num)
                {
                    Console.WriteLine("\nnumero grande");
                }
                else
                {
                    Console.WriteLine("\nAcertou!");
                    controlo = 0;
                }

            }

            //Para não fechar logo, pedimos para receber um input.
            Console.ReadKey();

            //--------------------------

        }

        //--------------------------

        public void myTeste (int a)
        {
            a += 20;
            Console.WriteLine(a);
        }

        //--------------------------

        public void Se()
        {
            int idade = 15;

            if (idade <= 12)
            {
                Console.WriteLine("Criança");
            }
            else if (idade > 12 && idade < 20)
            {
                Console.WriteLine("Adolescente");
            }
            else if (idade >= 20 && idade <= 65)
            {
                Console.WriteLine("Adulto");
            }
            else
            {
                Console.WriteLine("Idoso");
            }
        }

        //--------------------------

        public void Ficheiros()
        {
            File.WriteAllText(@"C:\github\repositorio\Programador de Informática\C#\Aula_01\teste.txt", "Daniel;13175995,222889128\n");
            File.AppendAllText(@"C:\github\repositorio\Programador de Informática\C#\Aula_01\teste.txt", "Daniel;13175995,222889128\n");

            foreach (string line in File.ReadLines(@"C:\github\repositorio\Programador de Informática\C#\Aula_01\teste.txt"))
            {
                Console.WriteLine(line);
            }

            File.Delete(@"C:\github\repositorio\Programador de Informática\C#\Aula_01\teste.txt");

        }

        //--------------------------

        

    }
}
