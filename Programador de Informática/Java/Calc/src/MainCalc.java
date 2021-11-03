

public class MainCalc {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		String op1 = "-";
		Calc maqCal = new Calc(1.0,2.0);
		
		if (op1.equals("+")) {
			System.out.println("Resultado "+ maqCal.sum());
		}else {
			if (op1.equals("-")) {
				System.out.println("Resultado"+maqCal.min());
			}else {
				if(op1.equals("*")) {
					System.out.println("Resultado"+maqCal.mult());
				}else {
					System.out.println("Resultado"+maqCal.div());
				}
			}
		}
		
		System.out.println("Outra abordagem");
		
		switch (op1) {
		case "+": 
			
			System.out.println("Resultado "+ maqCal.sum());
			break;
		case "-":
			System.out.println("Resultado"+maqCal.min());
			break;
		case "*":
			System.out.println("Resultado"+maqCal.mult());
			break;
		default:
			System.out.println("Resultado"+maqCal.div());
			break;
		}
	}

}
