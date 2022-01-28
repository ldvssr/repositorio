package com.iefp.logica;

import java.util.ArrayList;
import java.util.List;

import com.iefp.objects.Cliente;
import com.iefp.objects.Filme;

public class gestaoCinema {
	
	
	
	
	
	
public String validaEntrada( Cliente cliente) {
		
		int count =0;
		
		List<Filme> lstFilme = new ArrayList<Filme>();
		List<Cliente> lstCliente = new ArrayList<Cliente>();
		//Filme em Cartaz
		Filme filme = new Filme("Titanic",8,30);
		lstFilme.add(filme);
		filme = new Filme("Star Wars",10,30);
		lstFilme.add(filme);
		filme = new Filme("Neno",11,30);
		lstFilme.add(filme);
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
