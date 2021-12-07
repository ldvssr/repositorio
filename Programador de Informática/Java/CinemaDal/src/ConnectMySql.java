import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;


public class ConnectMySql {

	public ConnectMySql(){
		
	}
	
	public Connection GetConnection() {
		
		String dbURL = "jdbc:mysql://vpn.fjalves.xyz:3306/danielRosario";
		String username = "danielRosario";
		String password = "tzfkxp1xs";

	    Connection conn = null ;
		try {
			
    	     conn = DriverManager.getConnection(dbURL, username, password);
    	 
    	    if (conn != null) {
    	        System.out.println("Connected");
    	    }
    	} catch (SQLException ex) {
    	    ex.printStackTrace();
    	}
		return conn;
	}
	
}
