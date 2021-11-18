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
	
		String sql = "SELECT * FROM Cliente";
		 List<String> lstModel = new ArrayList<>();
		Statement statement;
		try {
			statement = conn.createStatement();
			
			
			
			ResultSet result = statement.executeQuery(sql);
			 
			
			int count = 0;
			 
			
			while (result.next()){
				
					String name = result.getString("nome");
				    System.out.println(result.getString("id") + " " + name + " " +result.getString("horaChegada") + " " +result.getString("minutoChegada"));
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
			
				 preparedStmt.setString (1, "7");
			     preparedStmt.setString (2, "darth vader");
			     preparedStmt.setString (3, "00");
			     preparedStmt.setString (4, "15");
			     

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
