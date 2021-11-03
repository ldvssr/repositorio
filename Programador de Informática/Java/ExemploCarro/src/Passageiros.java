
public class Passageiros extends Carro {
	
	
	private int numPassageiros;

	public Passageiros(String marca, String modelo, int numPass) {
		super(marca, modelo);
		this.setNumPassageiros(numPass);
		// TODO Auto-generated constructor stub
	}

	public int getNumPassageiros() {
		return numPassageiros;
	}

	public void setNumPassageiros(int numPassageiros) {
		this.numPassageiros = numPassageiros;
	}

}
