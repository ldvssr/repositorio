
public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		
		//Criamos o objeto fp
		FichaPessoal fp = new FichaPessoal("fabio", "Gondomar","93123456789", "fabiojalves@gmail.com");
		
		
		//Atualizamos a morada
		fp.atualizarMorada("Porto");
		
		//Apresentamos o nome armazenado no objeto
		System.out.println("Nome:" + fp.consultarNome());
		
		
		
		

	}

}
