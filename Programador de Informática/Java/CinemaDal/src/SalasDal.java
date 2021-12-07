import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

public class SalasDal {
	
	public SalasDal() {
		
	}
	
	public boolean Inserir(Connection conn) {
		
		List<Sala> listaSalas = new ArrayList();
		listaSalas.add(new Sala("AB","Sala Imax", 5,0));
		listaSalas.add(new Sala("BC","Sala ScreenX", 3,0));
		listaSalas.add(new Sala("CD","Sala  XVison", 2,0));
		
		PreparedStatement preparedStmt;
		
		try {
			
			for (int i = 0; i < listaSalas.size(); i++) {
		
				preparedStmt = conn.prepareStatement("INSERT INTO Sala (sigla, nomeSala, lotacaoMaxima, lotacaoAtual) VALUES (?, ?, ?, ?)");
				preparedStmt.setString(1,listaSalas.get(i).getSigla());
				preparedStmt.setString(2,listaSalas.get(i).getNome());
				preparedStmt.setInt(3,listaSalas.get(i).getLotacaoMaxima());
				preparedStmt.setInt(4,listaSalas.get(i).getLotacaoAtual());
				preparedStmt.execute();			
			}
     
		}
		catch (Exception e) {
			// TODO: handle exception
			return false;
		}
		return true;
	}
	
	public List<Sala> Listar(Connection conn) {
		
		Statement statement;
		List<Sala> listaSalas = new ArrayList<>();
		try {
			statement = conn.createStatement();
			ResultSet result = statement.executeQuery("SELECT * FROM Sala");
					
			while (result.next()){	
				
				Sala sala = new Sala(result.getString("sigla"),result.getString("nomeSala"), result.getInt("lotacaoMaxima"), result.getInt("lotacaoAtual"));

				listaSalas.add(sala);
			}	
				    
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return listaSalas;
	}
	
	
	public Sala getSala(Connection conn, String strSigla) {
		
		String sql = "SELECT * FROM Sala WHERE sigla LIKE '" +strSigla + "'";
		Statement statement;
		try {
			statement = conn.createStatement();
			ResultSet result = statement.executeQuery(sql);
			
			if(result.next()){	
				
				Sala sala = new Sala(result.getString("sigla"),result.getString("nomeSala"), 
					Integer.parseInt(result.getString("lotacaoMaxima")), Integer.parseInt(result.getString("lotacaoAtual")));
				
				return sala;	
			}
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		return null;
	}
	
	
	public void setLotAtual(Connection conn, String strSigla,  int lotacao) {
		
		String sql = "UPDATE Sala SET lotacaoAtual = ? WHERE sigla like ?";
		PreparedStatement preparedStmt;

		try {
			preparedStmt = conn.prepareStatement(sql);
			
			int lotAtual = lotacao + 1;
			
			preparedStmt = conn.prepareStatement("UPDATE Sala SET lotacaoAtual = ? WHERE sigla like ?");
			preparedStmt.setString (1, String.valueOf(lotAtual));
		    preparedStmt.setString (2, strSigla);
			preparedStmt.execute();
			
			
		} catch (SQLException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	
}
