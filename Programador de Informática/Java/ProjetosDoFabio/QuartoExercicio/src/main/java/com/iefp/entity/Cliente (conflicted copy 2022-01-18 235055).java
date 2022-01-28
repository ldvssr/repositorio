package com.iefp.entity;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;


@Entity
public class Cliente {
	
	
	@Id
	@GeneratedValue(strategy=GenerationType.AUTO)
	int id;
	
	@Column(name = "nome")
    private String nome;
    
	@Column(name="horaChegada")
	private String horaChegada;
    
    @Column(name="minutoChegada")
    private String minutoChegada;
    
    
    
    
    
    

	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public String getHoraChegada() {
		return horaChegada;
	}

	public void setHoraChegada(String horaChegada) {
		this.horaChegada = horaChegada;
	}

	public String getMinutoChegada() {
		return minutoChegada;
	}

	public void setMinutoChegada(String minutoChegada) {
		this.minutoChegada = minutoChegada;
	}

    
    
    
}
