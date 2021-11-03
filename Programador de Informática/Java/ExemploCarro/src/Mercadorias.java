
public class Mercadorias extends Carro {

	private Double pesoBruto;
	
	public Mercadorias(String marca, String modelo, Double peso) {
		super(marca, modelo);
		this.setPesoBruto(peso);
		// TODO Auto-generated constructor stub
	}

	public Double getPesoBruto() {
		return pesoBruto;
	}

	public void setPesoBruto(Double pesoBruto) {
		this.pesoBruto = pesoBruto;
	}

}
