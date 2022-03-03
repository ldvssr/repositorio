using _02_receitas.Models;
using MySql.Data.MySqlClient;

namespace _02_receitas.RepositoryOrDAL
{

    public class ReceitasDB
    {

        private MySqlConnection conn;

        public ReceitasDB()
        {
            
            string connStr = "datasource=localhost;port=3306;username=root;password=;database=receitas;SslMode=none";
            
            conn = new MySqlConnection(connStr);

        }

        public List<Receitas>ListAll()
        {
            
            List<Receitas>data=new List<Receitas>();

            string query = "SELECT r.*, t.tipo_receita as tipo_de_receita FROM receita r INNER JOIN tipo_receita t on t.id=r.tipo_receita ORDER BY id";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();

                using MySqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {

                    while (sdr.Read())
                    {
                        data.Add(new Receitas(
                            int.Parse(sdr["id"].ToString()),
                            sdr["ingredientes"].ToString(),
                            sdr["preparacao"].ToString(),
                            int.Parse(sdr["nivel_dificuldade"].ToString()),
                            int.Parse(sdr["tempo_preparacao"].ToString()),
                            sdr["imagem"].ToString(),
                            int.Parse(sdr["tipo_receita"].ToString()),
                            sdr["tipo_de_receita"].ToString()
                            ));
                    }

                }

                conn.Close();

            }

            return data;

        }

        public void Add(Receitas receita)
        {
                  
                       
            conn.Open();
            
            string sqlStr = @"INSERT INTO receita (ingredientes, preparacao, nivel_dificuldade, tempo_preparacao, imagem, tipo_receita) VALUES (@1, @2, @3, @4, @5, @6)";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlStr, conn);

                cmd.Parameters.Add(new MySqlParameter("@1", receita.ingredientes));
                cmd.Parameters.Add(new MySqlParameter("@2", receita.preparacao));
                cmd.Parameters.Add(new MySqlParameter("@3", receita.nivel_dificuldade));
                cmd.Parameters.Add(new MySqlParameter("@4", receita.tempo_preparacao));
                cmd.Parameters.Add(new MySqlParameter("@5", receita.imagem));
                cmd.Parameters.Add(new MySqlParameter("@6", receita.tipo_receita));

                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                conn.Close();

            }
            finally
            {
                conn.Close();
            }

        }

        public Receitas ListById(int id)
        {
            Receitas receita = new Receitas();

            conn.Open();

            string sqlStr = @"SELECT r.*, t.tipo_receita as tipo_de_receita FROM receita r INNER JOIN tipo_receita t on t.id = r.tipo_receita WHERE r.id = @id";

            try
            {
                MySqlCommand cmd = new MySqlCommand (sqlStr, conn);
                cmd.Parameters.Add(new MySqlParameter("@id", id));

                MySqlDataReader reader = cmd.ExecuteReader();

                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        receita.id = reader.GetInt32(0);
                        receita.ingredientes = reader.GetString(1);
                        receita.preparacao = reader.GetString(2);
                        receita.nivel_dificuldade = reader.GetInt32(3);
                        receita.tempo_preparacao = reader.GetInt32(4);
                        receita.imagem = reader.GetString(5);
                        receita.tipo_receita = reader.GetInt32(6);
                        receita.tipo_de_receita = reader.GetString(7);
                    }
                }
            }
            catch (Exception e)
            {

                conn.Close();
            }
            finally
            {
                conn.Close();
            }

            return receita;

        }

        internal void Update(Receitas receita)
        {
            conn.Open();

            string sqlStr = @"UPDATE receita SET ingredientes=@1, preparacao=@2, nivel_dificuldade=@3, tempo_preparacao=@4, imagem=@5, tipo_receita=@6 WHERE id=@7";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlStr, conn);

                cmd.Parameters.Add(new MySqlParameter("@1", receita.ingredientes));
                cmd.Parameters.Add(new MySqlParameter("@2", receita.preparacao));
                cmd.Parameters.Add(new MySqlParameter("@3", receita.nivel_dificuldade));
                cmd.Parameters.Add(new MySqlParameter("@4", receita.tempo_preparacao));
                cmd.Parameters.Add(new MySqlParameter("@5", receita.imagem));
                cmd.Parameters.Add(new MySqlParameter("@6", receita.tipo_receita));
                cmd.Parameters.Add(new MySqlParameter("@7", receita.id));

                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                conn.Close();

            }
            finally
            {
                conn.Close();
            }
        }

        public List<Tipos_receitas> getTipoReceitas()
        {
            
            List<Tipos_receitas> data = new List<Tipos_receitas>();

            string query = "SELECT * FROM tipo_receita";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                
                conn.Open();

                using MySqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {

                    while (sdr.Read())
                    {

                        data.Add(new Tipos_receitas(

                            int.Parse(sdr["id"].ToString()),
                            sdr["tipo_receita"].ToString()

                            ));

                    }

                }

                conn.Close();

            }

                return data;

        }
            

        public List<Receitas> ListByEntrada(int opcao)
        {
            List<Receitas> data = new List<Receitas>();
            conn.Open();

            string sqlStr = @"SELECT r.*, t.tipo_receita AS tipo_de_receita FROM receita r INNER JOIN tipo_receita t ON t.id=r.tipo_receita WHERE t.id=@1";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                cmd.Parameters.Add(new MySqlParameter("@1", opcao));
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(new Receitas(
                        reader.GetInt32(0), // id
                        reader.GetString(1), // ingredientes
                        reader.GetString(2), // preparação
                        reader.GetInt32(3), //nivel_dificuldade
                        reader.GetInt32(4), // tempo_preparacao
                        reader.GetString(5), //imagem
                        reader.GetInt32(6), // tipo_receita
                        reader.GetString(7) // tipo_de_receita
                        ));
                }
            }
            catch (Exception e)
            {
                conn.Close();                
            } finally
            {
                conn.Close();
            }

            return data;
        }
    }

}
