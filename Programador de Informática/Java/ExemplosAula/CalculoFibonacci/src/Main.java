import java.util.ArrayList;
import java.util.List;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
	
		
		List<Double> lstValue = new ArrayList<Double>();
		lstValue.add(0.0);
		lstValue.add(1.0);
		for (int i =2; i < 100; i++) {
			
			lstValue.add(lstValue.get(i-2)+lstValue.get(i-1));
			
		}
		
		for (int i =0; i < 100; i++) {
			
			System.out.println( lstValue.get(i));
			
		}
	}

}
