package mysqlConnection;


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
	
	
	public List<String> select(Connection conn) {
	
		String sql = "SELECT * FROM Filmes";
		 List<String> lstModel = new ArrayList<>();
		Statement statement;
		try {
			statement = conn.createStatement();
			
			
			
			ResultSet result = statement.executeQuery(sql);
			 
			
			int count = 0;
			 
			
			while (result.next()){
				
					String name = result.getString("nomeFilme");
				    System.out.println(result.getString("id") + " " + name + " " +result.getString("horaFilme") + " " +result.getString("minutoFilme"));
				    lstModel.add(name);	
				
			    
			    
			    
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
	
	return lstModel;
	}

	
	public Boolean insert(Connection conn) {
		
		String sql = "insert into Cliente (id, nome , horaChegada, minutoChegada) values (?,?,?,?)";
		 List<String> lstModel = new ArrayList<>();
		Statement statement;
		PreparedStatement preparedStmt;
		try {
			preparedStmt = conn.prepareStatement(sql);
			
				 preparedStmt.setString (1, "8");
			     preparedStmt.setString (2, "darth maul");
			     preparedStmt.setString (3, "02");
			     preparedStmt.setString (4, "00");
			     

			      // execute the preparedstatement
			      preparedStmt.execute();
			      System.out.println("Valores Escritos");
			
		     	      
		      conn.close();
		      System.out.println("Connection Closed");
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		
		return true;
	}
	
}
