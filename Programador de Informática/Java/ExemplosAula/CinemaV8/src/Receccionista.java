import java.sql.Connection;
import java.util.List;

import javax.swing.text.StyledEditorKit.BoldAction;

public class Receccionista {

	
	public Receccionista() {
		
		
	}
	
	
	
	public String validaEntrada( Cliente cliente, List<Filme> lstFilme,MysqlManipulate mysqlMap, Connection conn) {
		
		int count =0;
		
		while (count < lstFilme.size()) {
			if (cliente.getNomeFilme().equals(lstFilme.get(count).getNome())) {
				
				int horaFilme = (lstFilme.get(count).getHoraIncio() *60) + lstFilme.get(count).getMinutoInicio();
				int horaChegadaCliente = (cliente.getHoraChegada() * 60) + cliente.getMinutoChegada();
				if (horaChegadaCliente > horaFilme -30 && horaChegadaCliente < horaFilme +15) {
					if (Integer.valueOf(mysqlMap.selectLotacaoAtualSala(conn, lstFilme.get(count).getSala()))< Integer.valueOf(mysqlMap.selectLotacaoMaximaSala(conn, lstFilme.get(count).getSala()))) {
						mysqlMap.updateLotacaoSala(conn, lstFilme.get(count).getSala(),String.valueOf(Integer.valueOf(mysqlMap.selectLotacaoAtualSala(conn, lstFilme.get(count).getSala())) +1),lstFilme.get(count).getSala());
						mysqlMap.insert(conn, cliente.getNome(), String.valueOf(cliente.getHoraChegada()),String.valueOf(cliente.getMinutoChegada()));
						return "Cliente pode Entrar";
					}else {
						return "Sala Cheia";	
					}
					
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
