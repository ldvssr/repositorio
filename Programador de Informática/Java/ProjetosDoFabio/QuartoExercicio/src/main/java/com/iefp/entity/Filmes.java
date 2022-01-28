package com.iefp.entity;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;


@Entity
public class Filmes {
	
	
	@Id
	@GeneratedValue(strategy=GenerationType.AUTO)
	int id;
	
	@Column(name = "nomeFilme")
    private String teste;
    
	@Column(name="horaFilme")
	private String horaFilme;
    
    @Column(name="minutoFilme")
    private String minutoFilme;
    
    @Column(name = "sala")
    private String sala;


	public String getHoraFilme() {
		return horaFilme;
	}

	public void setHoraFilme(String horaFilme) {
		this.horaFilme = horaFilme;
	}

	public String getMinutoFilme() {
		return minutoFilme;
	}

	public void setMinutoFilme(String minutoFilme) {
		this.minutoFilme = minutoFilme;
	}

	public String getSala() {
		return sala;
	}

	public void setSala(String sala) {
		this.sala = sala;
	}

	public String getNomeFilme() {
		return teste;
	}

	public void setNomeFilme(String nomeFilme) {
		this.teste = nomeFilme;
	}
    
    
    
    
    
    

    
    
    
}
