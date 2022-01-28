package com.iefp.repositories;
import java.util.List;

import javax.transaction.Transactional;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

import com.iefp.entity.Cliente;



@Repository
public interface ClienteRepository extends JpaRepository<Cliente,Integer>{

	
	@Query(value = "SELECT * FROM Cliente", nativeQuery = true)
	List<Cliente> getRegistos();
	

}
