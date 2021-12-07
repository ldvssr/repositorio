/*

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.Scanner;


import org.apache.http.HttpResponse;
import org.apache.http.client.HttpClient;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.impl.client.HttpClientBuilder;
import org.json.JSONObject;

public class Main
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

*/

import java.sql.Connection;
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		String dbURL = "jdbc:mysql://vpn.fjalves.xyz:3306/danielRosario";
    	String username = "danielRosario";
    	String password = "tzfkxp1xs";
    	
    	
    	Connection conn; 
    	System.out.println("passou");
    	MysqlManipulate mysqlMap = new MysqlManipulate();
    	conn = mysqlMap.connect(dbURL, username, password);
		String nomeFilme, tmpVar, nomeCliente,control;
		int horaChegada, minutoChegada;
		
		
		List<Filme> lstFilme = new ArrayList<Filme>();
		lstFilme = mysqlMap.selectFilmes(conn, lstFilme);
		List<Cliente> lstCliente = new ArrayList<Cliente>();
		
		List<Sala> lstSalas = new ArrayList<Sala>();
		
		//Filme em Cartaz
		/*
		 * Filme filme = new Filme("Titanic",8,30); lstFilme.add(filme); Sala sala = new
		 * Sala("Sala1",filme, 60, 0); lstSalas.add(sala);
		 * 
		 * 
		 * filme = new Filme("Star Wars",10,30); lstFilme.add(filme); lstSalas.add(new
		 * Sala("Sala2",filme, 40, 0));
		 * 
		 * 
		 * filme = new Filme("Neno",11,30); lstSalas.add(new Sala("Sala3",filme, 45,
		 * 0)); lstFilme.add(filme);
		 */
		 
		
		
		Scanner scanner = new Scanner(System.in);
		Receccionista r = new Receccionista();
		do {
			
					
			System.out.println("nome cliente");
			nomeCliente = scanner.nextLine();
			
			System.out.println("digite o nome do filme que vai deseja ver");
			nomeFilme = scanner.nextLine();
			
			System.out.println("digite a hora de chegada");
			tmpVar =scanner.nextLine();
			horaChegada = Integer.valueOf(tmpVar);
			
			System.out.println("digite a minuto de chegada");
			tmpVar =scanner.nextLine();
			minutoChegada = Integer.valueOf(tmpVar);
			
			
			//Cliente que vai entrar
			Cliente cliente = new Cliente(nomeCliente,nomeFilme,horaChegada,minutoChegada);
			lstCliente.add(cliente);
		
			System.out.println(r.validaEntrada(cliente,lstFilme,mysqlMap,conn));
			
			System.out.println("Vai entrar mais clientes? 0 - Sim/ 1- Não");
			control =scanner.nextLine();
		}while (control.equals("0"));									
	}
}