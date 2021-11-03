
public class PrimeiroProjetoMain {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		/*
		 * Isto é um comentário em bloco.
		 * */
		// Isto é um comentário em linha.
		// Imprimir no ecrâ a frase Hello World!
		System.out.println("Hello World!");
		// Estruturas condicionais.
		// Declaração e inicialização de variável inteiro.
		int idade = 15;
		// Estrutura condicional IF.
		if (idade < 18)
		{
			System.out.println("Não pode entrar!");
		}
		// Concatenação de condições booleanas.
		boolean amigoDoDono = true;
		// And (&&)
		if (idade < 18 && amigoDoDono == false)
		{
			System.out.println("Não pode entrar!");
		}
		else
		{
			System.out.println("Pode entrar!");
		}
		// Or (||)
		if (idade < 18 || amigoDoDono == false)
		{
			System.out.println("Não pode entrar!");
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
			System.out.println("Olá!");
		}
		/* Contadores.
		 * i = i + 1 (Incrementa o valor na própria linha.)
		 * i++ (Incrementa o valor na instrução seguinte.)
		 * ++i (Incrementa o valor antes de executar a instrução.)
		 */
		// Controladores de ciclos.
		// break;
		int x = 1;
		int y = 100;
		for (int i = x; i < y; i++)
		{
			if (i % 2 == 0)
			{
				System.out.println("i = " + i + " é divisivel por 2.");
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
