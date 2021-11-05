
public class Sala {
	
	String nomeFilme;
	int id;
	int lotacaoMaxima;
	int lotacaoAtual;
	String nomeClientes;
		
	
	
	public Sala(String nomeFilme, int id, int lotacaoMaxima, int lotacaoActual, String nomeClientes)
	{
		
		this.nomeFilme=nomeFilme;
		this.id=id;
		this.lotacaoMaxima=lotacaoMaxima;
		this.lotacaoAtual=lotacaoActual;
		this.nomeClientes=nomeClientes;
		
	}



	public String getNomeFilme() {
		return nomeFilme;
	}



	public int getId() {
		return id;
	}



	public int getLotacaoMaxima() {
		return lotacaoMaxima;
	}



	public int getLotacaoAtual() {
		return lotacaoAtual;
	}



	public String getNomeClientes() {
		return nomeClientes;
	}
}
