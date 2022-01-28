package com.iefp.RestControllers;

import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

import com.iefp.logica.gestaoCinema;
import com.iefp.objects.Cliente;

@RestController
public class Gestao {


	
	@RequestMapping(value = "/validarEntrada", method = RequestMethod.GET)
	public String hello1( String nome, String horaChegada, String minutoChegada, String filme) {
		
		Cliente cl = new Cliente(nome, filme, Integer.valueOf(horaChegada),Integer.valueOf(minutoChegada) );
		gestaoCinema gC = new gestaoCinema();
		String resultado = gC.validaEntrada(cl);
		
		
		
		return resultado;
	}
}
