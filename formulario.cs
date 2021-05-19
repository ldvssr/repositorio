using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
	class Program
	{
		static void Main(string[] args)
		{
			string nome;
			Console.WriteLine("nome");
	        nome = Console.ReadLine();
	        char genero;
			Console.WriteLine("genero");
			genero = char.Parse(Console.ReadLine());
			uint idade;
			Console.WriteLine("idade");
			idade = uint.Parse(Console.ReadLine());
			float altura;
			Console.WriteLine("altura");
			altura = float.Parse(Console.ReadLine());
			double saldo;
			Console.WriteLine("saldo");
			saldo = double.Parse(Console.ReadLine());
			Console.WriteLine(" Chama-se "+nome+" é do sexo "+genero+" tem "+idade+" anos e mede "+altura+" m, tem "+saldo+" euros no banco. ");
		}
	}
}