
public class FichaPessoal {

	private String nome;
	
	private String morada;
	
	private String contacto;
	
	private String Email;
	
	
	
	public FichaPessoal(String nome, String morada, String contacto, String email) {
		this.nome = nome;
		this.morada = morada;
		this.contacto = contacto;
		this.Email = email;
		
	}



	public String consultarNome() {
		return nome;
	}



	public void atualizarMorada(String morada) {
		this.morada = morada;
	}
	
}
