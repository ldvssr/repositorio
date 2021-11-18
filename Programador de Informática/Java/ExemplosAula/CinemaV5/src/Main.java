
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		String nomeFilme, tmpVar, nomeCliente,control;
		int horaChegada, minutoChegada;
		
		
		List<Filme> lstFilme = new ArrayList<Filme>();
		List<Cliente> lstCliente = new ArrayList<Cliente>();
		//Filme em Cartaz
		Filme filme = new Filme("Titanic",8,30);
		lstFilme.add(filme);
		filme = new Filme("Star Wars",10,30);
		lstFilme.add(filme);
		filme = new Filme("Neno",11,30);
		lstFilme.add(filme);
		
		
		Scanner scanner = new Scanner(System.in);
		Receccionista r = new Receccionista();
		do {
			
					
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
			lstCliente.add(cliente);
		
			System.out.println(r.validaEntrada(cliente,lstFilme));
			
			System.out.println("Vai entrar mais clientes? 0 - Sim/ 1- Não");
			control =scanner.nextLine();
		}while (control.equals("0"));
		
		
		for (int i = 0; i < lstCliente.size(); i++) {
			System.out.println("Nome Cliente:" +lstCliente.get(i).getNome());
		}
	}

}
