package com.exercicio.controller;

import org.springframework.web.bind.annotation.RequestMapping;

public class controller {

	@RequestMapping(value = "/calculaServico")
	public String reserva(String salario)
	{				
		
		
				
		return "salarioLiquido";
	}	

	
}
