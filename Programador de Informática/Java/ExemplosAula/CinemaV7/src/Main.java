
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
		
		List<Sala> lstSalas = new ArrayList<Sala>();
		
		//Filme em Cartaz
		Filme filme = new Filme("Titanic",8,30);
		lstFilme.add(filme);
		lstSalas.add(new Sala("Sala1",filme, 60, 0));
		filme = new Filme("Star Wars",10,30);
		lstFilme.add(filme);
		
		
		lstSalas.add(new Sala("Sala2",filme, 40, 0));
		filme = new Filme("Neno",11,30);
		lstSalas.add(new Sala("Sala3",filme, 45, 0));
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
		
			System.out.println(r.validaEntrada(cliente,lstSalas));
			
			System.out.println("Vai entrar mais clientes? 0 - Sim/ 1- Não");
			control =scanner.nextLine();
		}while (control.equals("0"));
		
		System.out.print("Lista de clientes que se apresentaram");
		for (int i = 0; i < lstCliente.size(); i++) {
			System.out.println("Nome Cliente:" +lstCliente.get(i).getNome());
		}
		
		
		
		//escrita em ficheiro
		GestaoFicheiro gf = new GestaoFicheiro();
		//Escrita de cabeçalho de ficheiro. - Atenção que estou a fazer um append ao ficheiro
		gf.escreverFicheiro("cliente.csv", "sala, filme, horaInicio, horaFim, nomeCliente\n");
				
		String linha="";
		System.out.println("Lista de clientes por sala");
		for (int i = 0; i < lstSalas.size(); i++) {
			

			
			
			System.out.println("Nome da Sala:"+lstSalas.get(i).getNome());
			for (int j =0 ; j< lstSalas.get(i).getLstCliente().size(); j++) {
				System.out.println("Nome de cliente:"+lstSalas.get(i).getLstCliente().get(j).getNome());
				
				//Insere no ficheiro uma linha por cliente que está na sala
				linha = lstSalas.get(i).getNome() +"," + lstSalas.get(i).getFilme().getNome() +", " + lstSalas.get(i).getFilme().getHoraIncio() +", "+
						lstSalas.get(i).getFilme().getMinutoInicio() + lstSalas.get(i).getLstCliente().get(j).getNome()+"\n";
				gf.escreverFicheiro("cliente.csv",linha);	
			}
			
			
			
		}
		
		//Procura a string que vamos escrever, no ficheiro escrito
		control = "0";
		System.out.println("Deseja procurar conteudo dentro de um ficheiro? 1 - Sim/ 0-Não");
		control =scanner.nextLine();
		if (control.equals("1")) {
			String aProcurar="";
			aProcurar =scanner.nextLine();	
			
			gf.procurarNoFicheiro("cliente.csv", aProcurar);
			
		}
		
		//mysql
		
		
		
	}

}
