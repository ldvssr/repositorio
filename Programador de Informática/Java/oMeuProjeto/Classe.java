
import java.util.Scanner;

// Classe
public class Classe
{
	
	// Declara��o de vari�veis	
	String estaStringLe = ("");
	
	// Procedimentos
	public void Impressao()
	{
		// Impress�o
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
		System.out.println("Esta � a frase que escreves-te: \""+estaStringLe+"\"");		
	}
		
}