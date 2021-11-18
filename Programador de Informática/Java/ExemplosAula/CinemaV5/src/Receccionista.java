import java.util.List;

import javax.swing.text.StyledEditorKit.BoldAction;

public class Receccionista {

	
	public Receccionista() {
		
		
	}
	
	
	
	public String validaEntrada( Cliente cliente, List<Filme> lstFilme) {
		
		int count =0;
		
		while (count < lstFilme.size()) {
			if (cliente.getNomeFilme().equals(lstFilme.get(count).getNome())) {
				
				int horaFilme = (lstFilme.get(count).getHoraIncio() *60) + lstFilme.get(count).getMinutoInicio();
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
			}
			count = count +1;
		}
		return "O cliente vai ver um filme que não está em cartaz";
		


	}
	
}
