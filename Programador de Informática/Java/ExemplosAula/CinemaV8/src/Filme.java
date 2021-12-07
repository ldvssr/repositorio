
public class Filme {

	private String nome;
	
	private int horaIncio;
	
	private int minutoInicio;
	
	private String sala;
	
	public Filme (String nome, int horaInicio, int minutoInicio,String sala) {
		
		this.nome = nome;
		this.horaIncio = horaInicio;
		this.minutoInicio = minutoInicio;
		this.sala = sala;
	}

	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		nome = nome;
	}

	public int getHoraIncio() {
		return horaIncio;
	}

	public void setHoraIncio(int horaIncio) {
		this.horaIncio = horaIncio;
	}

	public int getMinutoInicio() {
		return minutoInicio;
	}

	public void setMinutoInicio(int minutoInicio) {
		this.minutoInicio = minutoInicio;
	}

	public String getSala() {
		return sala;
	}

	public void setSala(String sala) {
		this.sala = sala;
	}
	
}
