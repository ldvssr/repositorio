
public class Cliente {
	
	String nomeCliente;
	int horaChegada;
	int minutoChegada;
	String filme;
	
	
	
	public Cliente(String nomeCliente, int horaChegada, int minutoChegada, String filme)
	{
		
		this.nomeCliente=nomeCliente;
		this.horaChegada=horaChegada;
		this.minutoChegada=minutoChegada;
		this.filme=filme;
		
	}



	public String getNomeCliente() {
		return nomeCliente;
	}



	public int getHoraChegada() {
		return horaChegada;
	}



	public int getMinutoChegada() {
		return minutoChegada;
	}



	public String getFilme() {
		return filme;
	}
}
