
public class Carro {

	private String marca;
	private String modelo;
	private Double velocidade;
	
	
	public Carro(String marca, String modelo) {
		
		this.setMarca(marca);
		this.setModelo(modelo);
		this.setVelocidade(0.0);
	}


	



	public String getModelo() {
		return modelo;
	}


	private void setModelo(String modelo) {
		this.modelo = modelo;
	}


	public Double getVelocidade() {
		return velocidade;
	}


	public void setVelocidade(Double velocidade) {
		this.velocidade = velocidade;
	}




	public String getMarca() {
		return marca;
	}


	public void setMarca(String marca) {
		this.marca = marca;
	}
	
	
	
	
}
