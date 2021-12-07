package clientJSon;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Scanner;

import org.apache.http.HttpResponse;
import org.apache.http.client.HttpClient;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.impl.client.HttpClientBuilder;
import org.json.JSONObject;

public class app
{

	public static void main(String[] args)
	{
		String js="";
		//Criar um canal de comunicação HTTP
		HttpClient client =  HttpClientBuilder.create().build();
		
		//Desconstruir a url
		String urlServico = "http://vpn.fjalves.xyz:8080/aulas-0.0.1-SNAPSHOT/validaEntrada?";
		
		Scanner leitura = new Scanner(System.in);
				
		System.out.println("Qual é o nome do filme? ");
		String inputFilme = "";
		inputFilme = leitura.nextLine();		
		String paramFilme = "filme="+inputFilme;
				
		System.out.println("Qual é a hora de chegada? ");
		String inputHoraChegada = "";
		inputHoraChegada = leitura.nextLine();		
		String paramHoraChegada = "horaChegada="+inputHoraChegada;
				
		System.out.println("Qual é o minuto de chegada? ");
		String inputMinutoChegada = "";
		inputMinutoChegada = leitura.nextLine();		
		String paramMinutoChegada = "minutoChegada="+inputMinutoChegada;
		urlServico = urlServico + paramFilme + "&" + paramHoraChegada + "&" + paramMinutoChegada;
				
		leitura.close();
				
		//Identificar o endpoint de contacto da API
		//HttpGet request = new HttpGet("http://vpn.fjalves.xyz:8080/aulas-0.0.1-SNAPSHOT/validaEntrada?filme=Titanic&horaChegada=8&minutoChegada=15");
		HttpGet request = new HttpGet(urlServico);
		try
		{
			//Executar a comunicação
			HttpResponse response = client.execute(request);
			//Descarregar para o buffer o conteudo de retorno do serviço
			BufferedReader rd = new BufferedReader (new InputStreamReader(response.getEntity().getContent()));
			String line = "";
			//Colocar todo o conteudo dentro de uma String
			while ((line = rd.readLine()) != null)
			{
				js = js + line;
			}
		  
			//Converter a STRING em um JSON Object
			JSONObject jObj = new JSONObject(js);
			 
			//APresentar o conteúdo da variável result que está dentro do JSON OBject
			System.out.println ("Resultado: "+jObj.get("result"));
			  
			System.out.println ("Filme: "+jObj.get("Filme"));
			  
			System.out.println ("Horas: "+jObj.get("Hora")+":"+jObj.get("Minuto"));		  
		}
		catch (IOException e)
		{
			// TODO Auto-generated catch block
			e.printStackTrace();
		}		  
	}
}