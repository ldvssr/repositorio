package casa.repositories;

import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.stereotype.Repository;

import casa.entity.Cliente;

@Repository
public interface ClienteRepository extends JpaRepository<Cliente, Integer>
{
	
	@Query(value = "SELECT * FROM CLIENTE", nativeQuery = true)
	List<Cliente> getRegistos();
	
}
