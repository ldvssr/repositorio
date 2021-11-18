import java.util.ArrayList;
import java.util.List;

public class Sala {

	
	private String nome;
	private Filme filme;
	private int lotacaoMaxima;
	private int lotacaoAtual;
	private List<Cliente> lstCliente;
	
	public Sala(String nome, Filme filme, int lotacaoMaxima, int lotacaoAtual) {
		this.nome = nome;
		this.filme = filme;
		this.lotacaoMaxima = lotacaoMaxima;
		this.lotacaoAtual = lotacaoAtual;
		lstCliente = new ArrayList<Cliente>();
		
	}
	
	
	
	
	
	
	
	
	
	
	public String getNome() {
		return nome;
	}
	public void setNome(String nome) {
		this.nome = nome;
	}
	public Filme getFilme() {
		return filme;
	}
	public void setFilme(Filme filme) {
		this.filme = filme;
	}
	public int getLotacaoMaxima() {
		return lotacaoMaxima;
	}
	public void setLotacaoMaxima(int lotacaoMaxima) {
		this.lotacaoMaxima = lotacaoMaxima;
	}
	public int getLotacaoAtual() {
		return lotacaoAtual;
	}
	public void setLotacaoAtual(int lotacaoAtual) {
		this.lotacaoAtual = lotacaoAtual;
	}
	public List<Cliente> getLstCliente() {
		return lstCliente;
	}
	public void setLstCliente(List<Cliente> lstCliente) {
		this.lstCliente = lstCliente;
	}
	
	
	
	
}
