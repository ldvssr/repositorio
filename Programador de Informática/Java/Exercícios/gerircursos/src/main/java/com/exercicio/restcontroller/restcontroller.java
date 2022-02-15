package com.exercicio.restcontroller;

import org.springframework.web.bind.annotation.RequestMapping;

public class restcontroller {
	
	@RequestMapping(value = "/reservaServico")
	public String reserva(String nlivro, String ncliente, String email)
	{				
		
		
				
		return "Livro não existe! Livro não disponível! Livro reservado!";
	}

}
