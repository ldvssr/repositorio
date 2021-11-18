
public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		//Filme em Cartaz
		Filme filme = new Filme("Titanic",8,30);
		
		//Cliente que vai entrar
		Cliente cliente = new Cliente("Fabio","Titanic",9,40);
		
		Receccionista r = new Receccionista();
		System.out.println(r.validaEntrada(cliente,filme));
		
	}

}
