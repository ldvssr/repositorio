package com.iefp.RestControllers;

import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class Gestao {

	@RequestMapping(value = "/helloword"  )
	public String hello() {
		String teste = "<htmtl><body><b>hello</b> world</body></html>";
		
		
		return teste;
	}
	
	
	
	
	@RequestMapping(value = "/helloword1", method = RequestMethod.POST)
	public String hello1(@RequestBody String body) {
		String teste = "<htmtl><body><b>hello body</b> " +body+  "  </body></html>";
		
		
		return teste;
	}
	
	
	
}
