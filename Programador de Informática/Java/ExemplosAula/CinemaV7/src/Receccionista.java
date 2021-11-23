import java.util.List;

import javax.swing.text.StyledEditorKit.BoldAction;

public class Receccionista {

	
	public Receccionista() {
		
		
	}
	
	
	
	public String validaEntrada( Cliente cliente, List<Sala> lstSala) {
		
		int count =0;
		
		while (count < lstSala.size()) {
			if (cliente.getNomeFilme().equals(lstSala.get(count).getFilme().getNome())) {
				
				int horaFilme = (lstSala.get(count).getFilme().getHoraIncio() *60) + lstSala.get(count).getFilme().getMinutoInicio();
				int horaChegadaCliente = (cliente.getHoraChegada() * 60) + cliente.getMinutoChegada();
				if (horaChegadaCliente > horaFilme -30 && horaChegadaCliente < horaFilme +15) {
					if (lstSala.get(count).getLotacaoAtual()< lstSala.get(count).getLotacaoMaxima()) {
						lstSala.get(count).setLotacaoAtual(lstSala.get(count).getLotacaoAtual()+1);
						lstSala.get(count).getLstCliente().add(cliente);
						return "Cliente pode Entrar";
					}else {
						return "Sala Cheia";	
					}
					
				}else {
					if (horaChegadaCliente < horaFilme -30) {
						return "Cliente n�o pode entrar. Deve esperar";
					}else {
						return "Cliente n�o pode entrar. J� passou 15 minutos do Inicio";
						
					}
				}
			}
			count = count +1;
		}
		return "O cliente vai ver um filme que n�o est� em cartaz";
		


	}
	
}
