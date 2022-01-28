package com.iefp.RestControllers;


import java.util.List;


import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.iefp.entity.Filmes;
import com.iefp.repositories.FilmesRepository;

@RestController
public class RecionistaController {
	
	
	@Autowired
	private FilmesRepository fRepo;
	
	
	
    @RequestMapping("/getFilmes")
    public List<Filmes> getFilmes() {
    	
    
        return fRepo.getRegistos();
    }
    
    
    
    
}
