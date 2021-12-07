



import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

public class MysqlManipulate {

	public Connection connect(String url, String user, String pass) {
		// TODO Auto-generated method stub
	    Connection conn = null ;
		try {
			
    	     conn = DriverManager.getConnection(url, user, pass);
    	 
    	    if (conn != null) {
    	        System.out.println("Connected");
    	    }
    	} catch (SQLException ex) {
    	    ex.printStackTrace();
    	}
		return conn;
	}

	public List<Filme> selectFilmes(Connection conn, List<Filme> lstFilmes) {
		
		String sql = "SELECT * FROM Filmes  ";
		Statement statement;
		try {
			statement = conn.createStatement();
			
			ResultSet result = statement.executeQuery(sql);
			ResultSet resultSala ;
			while (result.next()){
				lstFilmes.add(new Filme(result.getString("nomeFilme"),Integer.valueOf( result.getString("horaFilme")), Integer.valueOf(result.getString("minutoFilme")),result.getString("sala")));
				
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
	
	return lstFilmes;
	}
	
	public String  selectLotacaoAtualSala(Connection conn, String sala) {
		
		String sql = "SELECT * FROM Sala where sigla like '"+sala+"'";
		Statement statement;
		try {
			statement = conn.createStatement();
			
			ResultSet result = statement.executeQuery(sql);
			ResultSet resultSala ;
			while (result.next()){
				return result.getString("lotacaoAtual");
				
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
	
	return "";
	}
	
	public String  selectLotacaoMaximaSala(Connection conn, String sala) {
		
		String sql = "SELECT * FROM Sala where sigla like '"+sala+"'";
		Statement statement;
		try {
			statement = conn.createStatement();
			
			ResultSet result = statement.executeQuery(sql);
			ResultSet resultSala ;
			while (result.next()){
				return result.getString("lotacaoMaxima");
				
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
	
	return "";
	}
	
	public String  updateLotacaoSala(Connection conn, String sala,String lotacao, String sigla) {
		
		String sql = "update Sala set lotacaoAtual = ? where sigla like ?";
		Statement statement;
		PreparedStatement preparedStmt;
		try {
			preparedStmt = conn.prepareStatement(sql);
			
				 preparedStmt.setString (1, lotacao);
			     preparedStmt.setString (2, sigla);

			      // execute the preparedstatement
			      preparedStmt.execute();
		
			
		     	      
		   
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
	
	return "";
	}
	
	
	public Boolean insert(Connection conn, String nome, String horaChegada, String minutoChegada) {
		
		String sql = "insert into Cliente ( nome, horaChegada,minutoChegada) values (?, ?,?)";
		Statement statement;
		PreparedStatement preparedStmt;
		try {
			preparedStmt = conn.prepareStatement(sql);
			
				 preparedStmt.setString (1, nome);
			     preparedStmt.setString (2, horaChegada);
			     preparedStmt.setString (3, minutoChegada);
			      // execute the preparedstatement
			      preparedStmt.execute();
		
			
		     	      
		      conn.close();
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		return true;
	}
}
