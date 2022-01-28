package com.iefp.RestControllers;

import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class GestaodeDados {

	@RequestMapping(value = "/teste", method = RequestMethod.POST  )
	public String hello(@RequestBody String body) {
		String teste = "<htmtl><body><b>hello</b> "+body+"</body></html>";
		
		
		return teste;
	}
	
	
	
	

	
	
}
