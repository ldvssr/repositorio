package mysqlConnection;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.Statement;

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
    	mysqlMap.select(conn);
    	mysqlMap.insert(conn);
    	//
	}

}
