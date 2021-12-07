package clienteRest;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

import org.apache.http.HttpResponse;
import org.apache.http.client.HttpClient;
import org.apache.http.client.methods.HttpGet;
import org.apache.http.impl.client.HttpClientBuilder;

public class Main {

	public static void main(String[] args)
	{
		// TODO Auto-generated method stub
		HttpClient client =  HttpClientBuilder.create().build();
		HttpGet request = new HttpGet("http://vpn.fjalves.xyz:8080/aulas-0.0.1-SNAPSHOT/getCliente");
		try
		{	  
			HttpResponse response = client.execute(request);	
			BufferedReader rd = new BufferedReader (new InputStreamReader(response.getEntity().getContent()));
			String line = "";
			while ((line = rd.readLine()) != null)
				  {
				    System.out.println(line);
				  }
		} catch (IOException e)
		{
			// TODO Auto-generated catch block
		e.printStackTrace();
		}		
	}

}
