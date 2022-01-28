package casa.entity;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;

@Entity
public class Cliente
{
	@Id
	@GeneratedValue(strategy=GenerationType.AUTO)
	int id;
	
	@Column(name = "nome")
	private String nome;
	
	@Column(name = "horaChegada")
	private String horaChegada;
	
	@Column(name = "minutoChegada")
	private String minutoChegada;
	
}
