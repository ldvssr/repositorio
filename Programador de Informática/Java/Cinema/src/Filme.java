
public class Filme {
	
	String nomeFilme;
	int horaInicio;
	int minutoInicio;
	int sala;
	
	
	public Filme(String nomeFilme, int horaInicio, int minutoInicio, int sala)
	{
		
		this.nomeFilme=nomeFilme;
		this.horaInicio=horaInicio;
		this.minutoInicio=minutoInicio;
		this.sala=sala;
		
	}


	public int getHoraInicio() {
		return horaInicio;
	}


	public int getMinutoInicio() {
		return minutoInicio;
	}


	public int getSala() {
		return sala;
	}


	public String getNomeFilme() {
		return nomeFilme;
	}
}
