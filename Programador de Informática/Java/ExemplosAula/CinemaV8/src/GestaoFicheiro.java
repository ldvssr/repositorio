import java.io.BufferedReader;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileWriter;
import java.io.IOException;
import java.io.InputStreamReader;

public class GestaoFicheiro {

	
	
	public GestaoFicheiro() {
		
	}
	
	
	public void lerFicheiro(String ficheiro) {
	
		
		//FileInputStream fstream;
		try {
			FileInputStream fstream = new FileInputStream(ficheiro);
			BufferedReader br = new BufferedReader(new InputStreamReader(fstream));
			String strLine;

			//Lê linha a linha
			while ((strLine = br.readLine()) != null)   {
			  // Imprime conteudo da linha
			  System.out.println (strLine);
			}
			//fecha o ficheiro
			fstream.close();

		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	
	
	public void escreverFicheiro(String ficheiro, String linha) {
	    try {
	    	
	        FileWriter myWriter = new FileWriter(ficheiro,true);
	        myWriter.append(linha);
	        
	        myWriter.close();
	        
	      } catch (IOException e) {
	        System.out.println("An error occurred.");
	        e.printStackTrace();
	      }
		
	}
	
	
	public void procurarNoFicheiro(String ficheiro, String procurar) {
		
		//FileInputStream fstream;
		try {
			FileInputStream fstream = new FileInputStream(ficheiro);
			BufferedReader br = new BufferedReader(new InputStreamReader(fstream));
			String strLine;

			//Lê linha a linha
			while ((strLine = br.readLine()) != null)   {
			  
				
				if (strLine.contains(procurar)) {
					
					
					System.out.println("Encontrou a palavra  e listo a posicao :"+ strLine.split(",")[2]);
					//System.out.println("valor de str.length  " + (strLine.length()-1));
					//System.out.println("valor de str.split.length  " + (strLine.split(" ").length-1));
					
					int tamanhoDaFrase = strLine.split(" ").length;
					try {
						System.out.println(strLine.split(" ")[4]);
					}catch (ArrayIndexOutOfBoundsException e) {
						// TODO: handle exception
					}
						
					
						
					
				}else {
					
				}
				// Imprime conteudo da linha
				
				
			//  System.out.println (strLine);
			}
			//fecha o ficheiro
			fstream.close();

		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		
		
		
		
	}
	
	
}
