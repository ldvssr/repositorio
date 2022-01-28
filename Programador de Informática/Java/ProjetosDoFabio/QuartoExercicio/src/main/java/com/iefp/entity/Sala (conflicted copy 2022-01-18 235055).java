package com.iefp.entity;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;


@Entity
public class Sala {
	
	
	@Id
	@GeneratedValue(strategy=GenerationType.AUTO)
	int id;
	
	@Column(name = "sigla")
    private String sigla;
    
	@Column(name="nomeSala")
	private String nomeSala;
    
    @Column(name="lotacaoMaxima")
    private String lotacaoMaxima;

    
    @Column(name="lotacaoAtual")
    private String lotacaoAtual;


	public String getSigla() {
		return sigla;
	}


	public void setSigla(String sigla) {
		this.sigla = sigla;
	}


	public String getNomeSala() {
		return nomeSala;
	}


	public void setNomeSala(String nomeSala) {
		this.nomeSala = nomeSala;
	}


	public String getLotacaoMaxima() {
		return lotacaoMaxima;
	}


	public void setLotacaoMaxima(String lotacaoMaxima) {
		this.lotacaoMaxima = lotacaoMaxima;
	}


	public String getLotacaoAtual() {
		return lotacaoAtual;
	}


	public void setLotacaoAtual(String lotacaoAtual) {
		this.lotacaoAtual = lotacaoAtual;
	}
    

    
    
    
    
    

    
    
    
}
