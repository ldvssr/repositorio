
import java.util.Scanner;

// Classe
public class Classe
{
	
	// Declaração de variáveis	
	String estaStringLe = ("");
	
	// Procedimentos
	public void Impressao()
	{
		// Impressão
		String estaStringImprime = ("Escreve um frase!");
		System.out.println(estaStringImprime);
	}
	
	
	public void Leitura()
	{
		// Leitura
		Scanner sc = new Scanner(System.in);	
		estaStringLe = sc.nextLine();
		sc.close();	
	}	
	
	
	public void Escrita()
	{
		// Escrita
		System.out.println("Esta é a frase que escreves-te: \""+estaStringLe+"\"");		
	}
		
}