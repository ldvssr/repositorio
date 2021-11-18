import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		//Declarar variáveis para armazenar valores lidos da consola
		String nome, morada, contato, email;
		
		String control;
		
		Scanner scanner = new Scanner(System.in);
		System.out.println("digite o nome que pretende guardar:");
		nome = scanner.nextLine();
		
		System.out.println("digite a morada:");
		morada = scanner.nextLine();
		
		System.out.println("digite o contacto:");
		contato = scanner.nextLine();
		
		System.out.println("digite o email:");
		email = scanner.nextLine();
		
		

		
		
		//Criamos o objeto fp
		FichaPessoal fp = new FichaPessoal(nome, morada,contato,email);
		
		
		//Valida se queremos atualizar a morada
		System.out.println("Pretente atualizar a morada? 1 - Sim / 0 -Não");
		scanner = new Scanner(System.in);
		control = scanner.nextLine();
		if (control.equals("1")) {
			
			morada = scanner.nextLine();
			fp.atualizarMorada(morada);
		
		}
		
		
		
		
		//Apresentamos o nome armazenado no objeto
		System.out.println("Nome:" + fp.consultarNome());
		
		scanner.close();
		
		

	}

}
