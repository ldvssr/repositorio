import javax.swing.text.StyledEditorKit.BoldAction;

public class Receccionista {

	
	public Receccionista() {
		
		
	}
	
	
	
	public String validaEntrada(int horaInicio,int  minutoInicio, int horaChegada, int minutoChegada) {
		
		int horaFilme = (horaInicio *60) + minutoInicio;
		int horaChegadaCliente = (horaChegada * 60) + minutoChegada;
		if (horaChegadaCliente > horaFilme -30 && horaChegadaCliente < horaFilme +15) {
			return "Cliente pode Entrar";
		}else {
			if (horaChegadaCliente < horaFilme -30) {
				return "Cliente n�o pode entrar. Deve esperar";
			}else {
				return "Cliente n�o pode entrar. J� passou 15 minutos do Inicio";
				
			}
		}
	}
	
}
