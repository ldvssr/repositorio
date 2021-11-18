import java.io.BufferedReader;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileWriter;
import java.io.IOException;
import java.io.InputStreamReader;

public class GestaoDeFicheiros {

	
	public GestaoDeFicheiros() {
		
	}
	
	
	
	
	public void escritaFicheiros(String nomeFicheiro, String conteudo) {
		
		
		FileWriter myWriter;
		try {
			myWriter = new FileWriter(nomeFicheiro);
			myWriter.write(conteudo);
			myWriter.close();
		} catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}


	}
	
	
	public void leituraFicheiros(String nomeFicheiro) {
		
								
		FileInputStream fstream;
		try {
			fstream = new FileInputStream(nomeFicheiro);
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
			System.out.println("Não Existe ficheiro");
		} catch (IOException e) {
			// TODO Auto-generated catch block
			System.out.println("Erro de leitura das linhas");
		}
		
		

		
		
	}
}
