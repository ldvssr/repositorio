
public class PrimeiroProjetoMain {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		/*
		 * Isto � um coment�rio em bloco.
		 * */
		// Isto � um coment�rio em linha.
		// Imprimir no ecr� a frase Hello World!
		System.out.println("Hello World!");
		// Estruturas condicionais.
		// Declara��o e inicializa��o de vari�vel inteiro.
		int idade = 15;
		// Estrutura condicional IF.
		if (idade < 18)
		{
			System.out.println("N�o pode entrar!");
		}
		// Concatena��o de condi��es booleanas.
		boolean amigoDoDono = true;
		// And (&&)
		if (idade < 18 && amigoDoDono == false)
		{
			System.out.println("N�o pode entrar!");
		}
		else
		{
			System.out.println("Pode entrar!");
		}
		// Or (||)
		if (idade < 18 || amigoDoDono == false)
		{
			System.out.println("N�o pode entrar!");
		}
		else
		{
			System.out.println("Pode entrar!");
		}
		// Estruturas repetitivas.
		// While.
		// Simples.
		while (idade < 18)
		{
			System.out.println(idade);
			idade = idade + 1;
		}
		// Composta.
		while (idade < 18 || amigoDoDono == false)
		{
			System.out.println(idade);
			idade = idade + 1;
		}
		// For.
		for (int i = 0; i < 10; i = i + 1)
		{
			System.out.println("Ol�!");
		}
		/* Contadores.
		 * i = i + 1 (Incrementa o valor na pr�pria linha.)
		 * i++ (Incrementa o valor na instru��o seguinte.)
		 * ++i (Incrementa o valor antes de executar a instru��o.)
		 */
		// Controladores de ciclos.
		// break;
		int x = 1;
		int y = 100;
		for (int i = x; i < y; i++)
		{
			if (i % 2 == 0)
			{
				System.out.println("i = " + i + " � divisivel por 2.");
				break;
			}
			System.out.println("valor de i = " + i);
		}
		// continue;
		for (int i = x; i < y; i++)
		{
			if (i < 50 && i < 60)
			{
				continue;
			}
			System.out.println("valor de i = " + i);
		}
		 
	}

}
