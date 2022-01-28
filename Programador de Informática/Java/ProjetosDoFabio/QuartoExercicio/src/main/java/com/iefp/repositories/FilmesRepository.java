package com.iefp.repositories;
import java.util.List;


import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.stereotype.Repository;

import com.iefp.entity.Filmes;




@Repository
public interface FilmesRepository extends JpaRepository<Filmes,Integer>{

	
	@Query(value = "SELECT * FROM Filmes", nativeQuery = true)
	List<Filmes> getRegistos();
	

}
