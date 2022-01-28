package com.iefp.repositories;
import java.util.List;


import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.stereotype.Repository;

import com.iefp.entity.Sala;



@Repository
public interface SalaRepository extends JpaRepository<Sala,Integer>{

	
	@Query(value = "SELECT * FROM Sala", nativeQuery = true)
	List<Sala> getRegistos();
	
	@Query(value = "SELECT * FROM Sala where sigla like ?1", nativeQuery = true)
	List<Sala> getDadosSala(String sigla);
	
	
	@Query(value = "SELECT lotacaoMaxima FROM Sala where sigla like ?1", nativeQuery = true)
	String getLotacaoMaxima(String sigla);
	
	@Query(value = "SELECT lotacaoAtual FROM Sala where sigla like ?1", nativeQuery = true)
	String getLotacaoAtual(String sigla);
}
