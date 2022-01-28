package com.iefp.objects;

public class Cliente {

	private String nome;
	private String nomeFilme;
	private int horaChegada;
	private int minutoChegada;
	
	
	public Cliente(String nome, String nomeFilme, int horaChegada, int minutoChegada) {
		this.nome = nome;
		this.nomeFilme = nomeFilme;
		this.horaChegada = horaChegada;
		this.minutoChegada = minutoChegada;
	}


	public String getNome() {
		return nome;
	}


	public void setNome(String nome) {
		this.nome = nome;
	}


	public String getNomeFilme() {
		return nomeFilme;
	}


	public void setNomeFilme(String nomeFilme) {
		this.nomeFilme = nomeFilme;
	}


	public int getHoraChegada() {
		return horaChegada;
	}


	public void setHoraChegada(int horaChegada) {
		this.horaChegada = horaChegada;
	}


	public int getMinutoChegada() {
		return minutoChegada;
	}


	public void setMinutoChegada(int minutoChegada) {
		this.minutoChegada = minutoChegada;
	}
	
	
	
}
