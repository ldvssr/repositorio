package com.exercicio.controller;

import org.springframework.web.bind.annotation.RequestMapping;

public class controller {
	
	@RequestMapping(value = "/reservaServico")
	public String reserva(String nlivro, String ncliente, String email)
	{				
		
		
				
		return "Livro não existe! Livro não disponível! Livro reservado!";
	}	

}
