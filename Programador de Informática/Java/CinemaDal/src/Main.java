
import java.sql.Connection;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		ConnectMySql conect = new ConnectMySql();
		Connection conn = conect.GetConnection();	
		
//se as tabelas de Filmes e Salas estiverem vazias adiciona registos conforme listas
		
		FilmesDal fdal = new FilmesDal();
		
		if (fdal.Listar(conn).isEmpty()) {
			if (fdal.Inserir(conn)) System.out.println("Filmes adicionados com sucesso");
			else System.out.println("UPS...");
		}
		
		SalasDal sdal = new SalasDal();
		
		if (sdal.Listar(conn).isEmpty()) {
			if (sdal.Inserir(conn)) System.out.println("Salas adicionadas com sucesso\n");
			else System.out.println("UPS...");;
		}
		
		List<Filme> listaFilmes = new ArrayList<>();
		listaFilmes = fdal.Listar(conn);
		
		System.out.println("---------- Cartaz -----------");
		
		for (Filme filme : listaFilmes) {
			System.out.println(filme.getNome()+"  Inicio: "+filme.getHoraIncio()+":"+filme.getMinutoInicio()+"h  Sala: "+filme.getSala());
		}
		System.out.println("-----------------------------");

		String nomeFilme, tmpVar, nomeCliente,control;
		int horaChegada, minutoChegada;		
		
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
			
			Cliente cliente = new Cliente(nomeCliente, horaChegada, minutoChegada);
		
			System.out.println(r.validaEntrada(conn, cliente, nomeFilme));
			
			System.out.println("\nVai entrar mais clientes? 0 - Sim/ 1- Não");
			control =scanner.nextLine();
		
		}while (control.equals("0"));
		scanner.close();
		try {
			conn.close();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}

}
