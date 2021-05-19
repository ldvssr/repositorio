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
			int n1, n2, multiplicacao;
	    Console.WriteLine("1º número");
	    n1 = int.Parse(Console.ReadLine());
	    Console.WriteLine("2º número");
	    n2 = int.Parse(Console.ReadLine());
	    multiplicacao = n1*n2;
	    Console.WriteLine(n1+" x "+n2+" = "+multiplicacao);

		}
	}
}