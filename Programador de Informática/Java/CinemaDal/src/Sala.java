import java.util.ArrayList;
import java.util.List;

public class Sala {

	private String sigla;
	private String nome;
	private int lotacaoMaxima;
	private int lotacaoAtual;
	
	public Sala(String sigla, String nome, int lotacaoMaxima, int lotacaoAtual) {
		this.setSigla(sigla);
		this.nome = nome;
		this.lotacaoMaxima = lotacaoMaxima;
		this.lotacaoAtual = lotacaoAtual;
		
	}
	
	String getSigla() {
		return sigla;
	}
	private void setSigla(String sigla) {
		this.sigla = sigla;
	}
	public String getNome() {
		return nome;
	}
	public void setNome(String nome) {
		this.nome = nome;
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
}
