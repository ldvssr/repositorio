import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		String nomeFilme, tmpVar, nomeCliente;
		int horaChegada, minutoChegada;
		
		//Filme em Cartaz
		Filme filme = new Filme("Titanic",8,30);
		
		Scanner scanner = new Scanner(System.in);
		System.out.println("nome cliente");
		nomeCliente = scanner.nextLine();
		
		System.out.println("digite o nome do filme que vai deseja ver");
		nomeFilme = scanner.nextLine();
		
		System.out.println("digite a hora de chegada");
		tmpVar =scanner.nextLine();
		horaChegada = Integer.valueOf(tmpVar);
		
		System.out.println("digite a minuto de chegada");
		tmpVar =scanner.nextLine();
		minutoChegada = Integer.valueOf(tmpVar);
		
		
		//Cliente que vai entrar
		Cliente cliente = new Cliente(nomeCliente,nomeFilme,horaChegada,minutoChegada);
		
		Receccionista r = new Receccionista();
		System.out.println(r.validaEntrada(cliente,filme));
		
	}

}
