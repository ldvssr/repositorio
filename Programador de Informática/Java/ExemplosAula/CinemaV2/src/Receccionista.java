import javax.swing.text.StyledEditorKit.BoldAction;

public class Receccionista {

	
	public Receccionista() {
		
		
	}
	
	
	
	public String validaEntrada( Cliente cliente, Filme filme) {
		
		if (cliente.getNomeFilme().equals(filme.getNome())) {
			
			int horaFilme = (filme.getHoraIncio() *60) + filme.getMinutoInicio();
			int horaChegadaCliente = (cliente.getHoraChegada() * 60) + cliente.getMinutoChegada();
			if (horaChegadaCliente > horaFilme -30 && horaChegadaCliente < horaFilme +15) {
				return "Cliente pode Entrar";
			}else {
				if (horaChegadaCliente < horaFilme -30) {
					return "Cliente não pode entrar. Deve esperar";
				}else {
					return "Cliente não pode entrar. Já passou 15 minutos do Inicio";
					
				}
			}
		}else {
			return "O cliente vai ver um filme que não está em cartaz";
			
		}

	}
	
}
