package com.gestaocinema.restcontroller;

import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;
import org.springframework.web.bind.annotation.RestController;

import com.gestaocinema.objcontroller.objectController;

@RestController
public class gestao
{
	
	@RequestMapping(value = "/helloworld_default_get")
	public String HeloWorld()
	{
		String teste = "<html><body><b>hello</b> world</body></html>";
		return teste;
	}
	
	@RequestMapping(value = "/helloworld_get", method = RequestMethod.GET)
	public String HelloWorldGet()
	{
		String teste = "<html><body><b>hello</b> world</body></html>";
		return teste;
	}
	
	@RequestMapping(value = "/helloworld_post", method = RequestMethod.POST)
	public String HelloWorldPost()
	{
		String teste = "<html><body><b>hello</b> world</body></html>";
		return teste;
	}
	
	@RequestMapping(value = "/helloworld_get_param", method = RequestMethod.GET)
	public String HelloWorldGetParam(String param1)
	{
		String teste = "<html><body><b>hello</b> world"+param1+"</body></html>";
		return teste;
	}
	
	@RequestMapping(value = "/helloworld_post_body", method = RequestMethod.POST)
	public String HelloWorldPostBody(@RequestBody String body)
	{
		String teste = "<html><body><b>hello body</b> "+body+"</body></html>";
		return teste;
	}
	
	@RequestMapping(value = "/chamarServico", method = RequestMethod.GET)
	public String servico()
	{
		objectController obj = new objectController();
		obj.accessController();
		String teste = "<html><body><b>hello body</b></body></html>";
		return teste;
	}
	
}
