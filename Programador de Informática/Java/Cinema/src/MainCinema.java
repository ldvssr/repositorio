import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;


public class MainCinema {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		String nomeFilme = "", nomeCliente = "";
		int horaFilme=0,minutoFilme=0,horaAtual=0,minutoAtual=0,lotacaoMaxima=10,lotacaoAtual=10;
		
		
		List<Filme> lst = new ArrayList<>();
		
		List<Cliente> lstClientes = new ArrayList<>();
		
		System.out.println("Pode mostrar-me o seu bilhete por favor?");
		
		Filme film = new Filme("Titanic",1,1,1);
		Cliente cli = new Cliente("Carlos",1,1,"Titanic");
		Sala sal = new Sala("Titanic",1,1,1,"Carlos");
		
		System.out.println("A lista dos filmes é a seguinte: ");
		
		for(int i = 0; i <lst.size(); i++)
		{
			System.out.println("Nome do filme: " + lst.get(i));
		}
		
		
		
		Scanner bilhete = new Scanner (System.in);
		
		System.out.println("Qual o seu nome? ");
		nomeCliente = bilhete.nextLine();
		
		System.out.println("Qual o filme que deseja ver?");
		nomeFilme = bilhete.nextLine();
		
		System.out.println("Indique a hora atual: ");
		horaAtual = bilhete.nextInt();
		
		System.out.println("Indique o minuto atual: ");
		minutoAtual = bilhete.nextInt();
		
		Cliente pessoa = new Cliente (nomeCliente, horaAtual, minutoAtual,nomeFilme);
		
		lstClientes.add(pessoa);
		
		
		
	}

}
