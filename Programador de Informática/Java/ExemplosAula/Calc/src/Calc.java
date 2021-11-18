
public class Calc {
	
	
	
	Double value1;
	Double value2;

	
	
	
	public Calc (Double value1, Double value2) {
		this.value1 = value1;
		this.value2 = value2;
	
		
	}
	
	
	public Double mult() {
		return this.value1*this.value2;
	}
	
	public Double sum() {
		return this.value1+this.value2;
	}
	
	public Double min() {
		return this.value1-this.value2;
	}
	
	public Double div() {
		if (this.value2 <=0) {
			return -1.0;
		}else {
			return this.value1/ this.value2;	
		}
			
		
	}
	

}
