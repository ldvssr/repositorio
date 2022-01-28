package com.gestaocinema.objcontroller;



import org.springframework.http.HttpEntity;
import org.springframework.http.HttpHeaders;
import org.springframework.http.HttpMethod;
import org.springframework.http.ResponseEntity;
import org.springframework.web.client.RestTemplate;
import org.springframework.web.util.UriComponentsBuilder;

public class objectController {

	public void accessController()
	{
		RestTemplate restTemplate = new RestTemplate();
		ResponseEntity <Object> result;
		// Headers
		HttpHeaders headers = new HttpHeaders();
		HttpEntity<String> entity = new HttpEntity<String>("parameters", headers);
		// Params
		UriComponentsBuilder builder = UriComponentsBuilder
				.fromHttpUrl(("http://vpn.fjalves.xyz:8080/aulas-0.0.1-SNAPSHOT/validaEntrada").trim());
		builder.queryParam("filme", "Titanic");
		builder.queryParam("horaChegada", "8");
		builder.queryParam("minutoChegada", "50");
		// Pedido
		result = restTemplate.exchange(builder.build().encode().toUri(), HttpMethod.GET, entity, Object.class);
		System.out.println(result.getBody());
	}
	
}
