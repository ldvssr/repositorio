import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

public class ClientesDal {

	public ClientesDal() {
		// TODO Auto-generated constructor stub
	}

	
	public boolean Inserir(Connection conn,  Cliente cliente) {
		
		PreparedStatement preparedStmt;
		
		try {
						
			preparedStmt = conn.prepareStatement("INSERT INTO Cliente (nome , horaChegada, minutoChegada) values (?, ?, ?)");
			preparedStmt.setString (1,cliente.getNome());
			preparedStmt.setInt(2, cliente.getHoraChegada());
			preparedStmt.setInt(3, cliente.getMinutoChegada());

			preparedStmt.execute();			
     	      
		}
		catch (Exception e) {
			
			// TODO: handle exception
			System.out.println(e);
			return false;
		}
		return true;
	}
}
