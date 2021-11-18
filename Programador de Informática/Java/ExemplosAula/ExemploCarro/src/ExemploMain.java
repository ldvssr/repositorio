
public class ExemploMain {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
	
		
		Carro vw = new Carro("vw", "passat");
		vw.setVelocidade(10.0);
		System.out.println(vw.getMarca());
		System.out.println(vw.getModelo());
		System.out.println(vw.getVelocidade());
		
		vw = new Carro("nissan","leaf");
		System.out.println(vw.getMarca());
		System.out.println(vw.getModelo());
		System.out.println(vw.getVelocidade());
		
		
		vw.setVelocidade(20.0);
		System.out.println(vw.getMarca());
		System.out.println(vw.getModelo());
		System.out.println(vw.getVelocidade());
		
		
		
		
		Passageiros vito = new Passageiros("Mercedes", "Vito", 9);
		
		System.out.println("Marca:"+ vito.getMarca() + " \nModelo:" + vito.getModelo()+ "\nVelocidade: " + vito.getVelocidade() + "\nNum Passag." + vito.getNumPassageiros());
		
		
		vito.setVelocidade(20.0);
		System.out.println("Nova velocidade da Mercedes");
		System.out.println(vito.getVelocidade());
		
		
		Mercadorias dyna = new Mercadorias("Toyota","Dyna", 3500.0);
		System.out.println(dyna.getMarca()+ "   "  + dyna.getModelo() + "  " + dyna.getPesoBruto()+"kg");
		
		
	}

}
