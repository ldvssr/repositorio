import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

public class FilmesDal {
	
	public FilmesDal(){
		
	}
	
public boolean Inserir(Connection conn) {
		
		List<Filme> listaFilmes = new ArrayList<>();
		listaFilmes.add(new Filme("Parasitas", 15, 15, "AB"));
		listaFilmes.add(new Filme("Joker", 19, 15, "BC"));		
		listaFilmes.add(new Filme("Bohemian Rhapsody", 21, 30, "CD"));	
		
		PreparedStatement preparedStmt;
		
		try {
			
			for (int i = 0; i < listaFilmes.size(); i++) {
		
				preparedStmt = conn.prepareStatement("INSERT INTO Filmes (nomeFilme, horaFilme, minutoFilme, sala) VALUES (?, ?, ?, ?)");
				preparedStmt.setString(1,listaFilmes.get(i).getNome());
				preparedStmt.setInt(2,listaFilmes.get(i).getHoraIncio());
				preparedStmt.setInt(3,listaFilmes.get(i).getMinutoInicio());
				preparedStmt.setString(4,listaFilmes.get(i).getSala());
				preparedStmt.execute();			
			}
     	      
		}
		catch (Exception e) {
			// TODO: handle exception
			return false;
		} 
		return true;
	}
	
	public List<Filme> Listar(Connection conn) {
		
		Statement statement;
		List<Filme> listaFilmes = new ArrayList<>();
		try {
			statement = conn.createStatement();
			ResultSet result = statement.executeQuery("SELECT * FROM Filmes");
					
			while (result.next()){	
				
				String nome = result.getString("nomeFilme");
				int hora = result.getInt("horaFilme");
				int min = result.getInt("minutoFilme");
				String sala = result.getString("sala");
				
				Filme filme = new Filme(nome, hora, min, sala);
				listaFilmes.add(filme);
			}	
				    
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		return listaFilmes;
	}
	
	
	public Filme getFilme(Connection conn, String strFilme) {
	
		String sql = "SELECT * FROM Filmes WHERE nomeFilme LIKE '"+strFilme+"'";
		
		Statement statement;
		try {
			statement = conn.createStatement();
			ResultSet result = statement.executeQuery(sql);
			
			if(result.next()){	
				Filme filme = new Filme(result.getString("nomeFilme"), result.getInt("horaFilme"), 
					    result.getInt("minutoFilme"), result.getString("sala"));
				return filme;
				}
				
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		
		}
		
		return null;
	}

}
