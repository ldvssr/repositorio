import java.sql.Connection;
import java.util.List;

import javax.swing.text.StyledEditorKit.BoldAction;

public class Receccionista {

	
	public Receccionista() {
	}
	
	public String validaEntrada(Connection conn, Cliente cliente, String strFilme) {
	
		
		FilmesDal fdal = new FilmesDal();
		SalasDal sdal = new SalasDal();
		ClientesDal cdal = new ClientesDal();
		
		Filme filme = fdal.getFilme(conn, strFilme);
			
		if (filme != null) {
				
			String strSala = filme.getSala();
			Sala sala = sdal.getSala(conn, strSala);	
			
			int horaFilme = (filme.getHoraIncio() *60) + filme.getMinutoInicio();
			int horaChegadaCliente = (cliente.getHoraChegada() * 60) + cliente.getMinutoChegada();
			
			if (horaChegadaCliente > horaFilme -30 && horaChegadaCliente < horaFilme +15) {
					
					if (sala.getLotacaoAtual() < sala.getLotacaoMaxima()) {
						
						sdal.setLotAtual(conn, strSala, sala.getLotacaoAtual());
						
						//if (cdal.Inserir(conn, cliente)) System.out.println("Cliente acrescentado à base dados");
						//else System.out.println("Algo correu mal... com a inserção do Cliente!");
						
						cdal.Inserir(conn, cliente);
						return "Cliente pode Entrar";
						
					}else {
						
						return "Sala Cheia";	
					}
					 
			}else {
				
				if (horaChegadaCliente < horaFilme -30) return "Cliente não pode entrar. Deve esperar";
				else return "Cliente não pode entrar. Já passou 15 minutos do Inicio";
					
			}
		}
		return "O cliente vai ver um filme que não está em cartaz";
		


	}
	
}
