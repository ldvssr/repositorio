import java.util.Scanner;

public class Main 
{

	public static void main(String[] args) 
	{
		// TODO Auto-generated method stub
		
		Scanner scanner = new Scanner(System.in);
		
		int repetir = 1;
		
		while (repetir == 1)
		{
		
			System.out.println("\nEste programa solicita dois valores e uma operação, de seguida efetua a operação e apresenta o resultado.\n");
			
			System.out.println("Introduza o primeiro valor: ");
					
			//String readLine = scanner.nextLine();
			
			double valor1 = scanner.nextDouble();
			
			System.out.println("O valor introduzido foi: " + valor1);
			
			System.out.println("Introduza o segundo valor: ");
			
			double valor2 = scanner.nextDouble();
			
			System.out.println("O valor introduzido foi: " + valor2);
			
			System.out.println("Introduza a operação: ");
			
			String opcao = scanner.next();
					
			System.out.print("A operação escolhida foi: " + opcao + "\n");
			
			switch (opcao) 
			{
				case ("+"):
					System.out.print("O resultado da operação é: " + (valor1 + valor2) + "\n");
					break;
				case ("-"):
					System.out.print("O resultado da operação é: " + (valor1 - valor2) + "\n");
					break;
				case ("*"):
					System.out.print("O resultado da operação é: " + (valor1 * valor2) + "\n");
					break;
				case ("/"):
					System.out.print("O resultado da operação é: " + (valor1 / valor2) + "\n");
					break;
			}
			
			System.out.println("\nDeseja continuar a fazer operações? (S - 1 / N - 0)\n");
			
			repetir = scanner.nextInt();
			
		}
		
		scanner.close();
		
	}
	
}
