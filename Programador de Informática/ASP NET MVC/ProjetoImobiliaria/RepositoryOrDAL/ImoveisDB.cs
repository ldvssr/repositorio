using ProjetoImobiliaria.Models;
using MySql.Data.MySqlClient;

namespace ProjetoImobiliaria.RepositoryOrDAL
{

    public class ImoveisDB
    {

        private MySqlConnection conn;

        public ImoveisDB()
        {
                        
            string connStr = "datasource=localhost;port=3306;username=root;password=;database=imobiliaria1;SslMode=none";

            //string connStr = "datasource=localhost;port=3306;username=root;password=;database=imobiliaria;SslMode=none";

            conn = new MySqlConnection(connStr);

        }

        public List<Imoveis>ListAll()
        {
            
            List<Imoveis>data=new List<Imoveis>();
                    
            string query = "SELECT r.*, t.tipo_receita as tipo_de_receita FROM receita r INNER JOIN tipo_receita t on t.id=r.tipo_receita ORDER BY id";

            //string query = "SELECT i.*, t.tipologia as tipologia FROM imovel i INNER JOIN tipologia t on t.id=i.tipologia ORDER BY id";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                conn.Open();

                using MySqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {

                    while (sdr.Read())
                    {
                        data.Add(new Imoveis(
                            int.Parse(sdr["id"].ToString()),
                            sdr["ingredientes"].ToString(),
                            sdr["preparacao"].ToString(),
                            int.Parse(sdr["nivel_dificuldade"].ToString()),
                            int.Parse(sdr["tempo_preparacao"].ToString()),
                            sdr["imagem"].ToString(),
                            int.Parse(sdr["tipo_receita"].ToString()),
                            sdr["tipo_de_receita"].ToString()
                            ));
                        //data.Add(new Receitas(
                        //    int.Parse(sdr["id"].ToString()),
                        //    sdr["ingredientes"].ToString(),
                        //    sdr["preparacao"].ToString(),
                        //    int.Parse(sdr["nivel_dificuldade"].ToString()),
                        //    int.Parse(sdr["tempo_preparacao"].ToString()),
                        //    sdr["imagem"].ToString(),
                        //    int.Parse(sdr["tipo_receita"].ToString()),
                        //    sdr["tipo_de_receita"].ToString()
                        //    ));
                    }

                }

                conn.Close();

            }

            return data;

        }

        public void Add(Imoveis imovel)
        {
                  
                       
            conn.Open();
            
            string sqlStr = @"INSERT INTO receita (ingredientes, preparacao, nivel_dificuldade, tempo_preparacao, imagem, tipo_receita) VALUES (@1, @2, @3, @4, @5, @6)";

            //string sqlStr = @"INSERT INTO receita (ingredientes, preparacao, nivel_dificuldade, tempo_preparacao, imagem, tipo_receita) VALUES (@1, @2, @3, @4, @5, @6)";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlStr, conn);

                cmd.Parameters.Add(new MySqlParameter("@1", imovel.ingredientes));
                cmd.Parameters.Add(new MySqlParameter("@2", imovel.preparacao));
                cmd.Parameters.Add(new MySqlParameter("@3", imovel.nivel_dificuldade));
                cmd.Parameters.Add(new MySqlParameter("@4", imovel.tempo_preparacao));
                cmd.Parameters.Add(new MySqlParameter("@5", imovel.imagem));
                cmd.Parameters.Add(new MySqlParameter("@6", imovel.tipo_receita));

                //cmd.Parameters.Add(new MySqlParameter("@1", receita.ingredientes));
                //cmd.Parameters.Add(new MySqlParameter("@2", receita.preparacao));
                //cmd.Parameters.Add(new MySqlParameter("@3", receita.nivel_dificuldade));
                //cmd.Parameters.Add(new MySqlParameter("@4", receita.tempo_preparacao));
                //cmd.Parameters.Add(new MySqlParameter("@5", receita.imagem));
                //cmd.Parameters.Add(new MySqlParameter("@6", receita.tipo_receita));

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

        public void Details(object imovel)
        {
            
        }

        public Imoveis ListById(int id)
        {
            Imoveis imovel = new Imoveis();

            conn.Open();

            string sqlStr = @"SELECT r.*, t.tipo_receita as tipo_de_receita FROM receita r INNER JOIN tipo_receita t on t.id = r.tipo_receita WHERE r.id = @id";

            //string sqlStr = @"SELECT r.*, t.tipo_receita as tipo_de_receita FROM receita r INNER JOIN tipo_receita t on t.id = r.tipo_receita WHERE r.id = @id";

            try
            {
                MySqlCommand cmd = new MySqlCommand (sqlStr, conn);
                cmd.Parameters.Add(new MySqlParameter("@id", id));

                MySqlDataReader reader = cmd.ExecuteReader();

                if(reader.HasRows)
                {
                    while(reader.Read())
                    {
                        imovel.id = reader.GetInt32(0);
                        imovel.ingredientes = reader.GetString(1);
                        imovel.preparacao = reader.GetString(2);
                        imovel.nivel_dificuldade = reader.GetInt32(3);
                        imovel.tempo_preparacao = reader.GetInt32(4);
                        imovel.imagem = reader.GetString(5);
                        imovel.tipo_receita = reader.GetInt32(6);
                        imovel.tipo_de_receita = reader.GetString(7);

                        //receita.id = reader.GetInt32(0);
                        //receita.ingredientes = reader.GetString(1);
                        //receita.preparacao = reader.GetString(2);
                        //receita.nivel_dificuldade = reader.GetInt32(3);
                        //receita.tempo_preparacao = reader.GetInt32(4);
                        //receita.imagem = reader.GetString(5);
                        //receita.tipo_receita = reader.GetInt32(6);
                        //receita.tipo_de_receita = reader.GetString(7);
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

            return imovel;

        }

        internal void Update(Imoveis receita)
        {
            conn.Open();

            string sqlStr = @"UPDATE receita SET ingredientes=@1, preparacao=@2, nivel_dificuldade=@3, tempo_preparacao=@4, imagem=@5, tipo_receita=@6 WHERE id=@7";

            //string sqlStr = @"UPDATE receita SET ingredientes=@1, preparacao=@2, nivel_dificuldade=@3, tempo_preparacao=@4, imagem=@5, tipo_receita=@6 WHERE id=@7";

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

                //cmd.Parameters.Add(new MySqlParameter("@1", receita.ingredientes));
                //cmd.Parameters.Add(new MySqlParameter("@2", receita.preparacao));
                //cmd.Parameters.Add(new MySqlParameter("@3", receita.nivel_dificuldade));
                //cmd.Parameters.Add(new MySqlParameter("@4", receita.tempo_preparacao));
                //cmd.Parameters.Add(new MySqlParameter("@5", receita.imagem));
                //cmd.Parameters.Add(new MySqlParameter("@6", receita.tipo_receita));
                //cmd.Parameters.Add(new MySqlParameter("@7", receita.id));

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

        public List<Tipologias> getTipoReceitas()
        {
            
            List<Tipologias> data = new List<Tipologias>();

            string query = "SELECT * FROM tipo_receita";

            //string query = "SELECT * FROM tipo_receita";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                
                conn.Open();

                using MySqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {

                    while (sdr.Read())
                    {

                        data.Add(new Tipologias(

                            int.Parse(sdr["id"].ToString()),
                            sdr["tipo_receita"].ToString()

                            //int.Parse(sdr["id"].ToString()),
                            //sdr["tipo_receita"].ToString()

                            ));

                    }

                }

                conn.Close();

            }

                return data;

        }
            

        public List<Imoveis> ListByEntrada(int opcao)
        {
            List<Imoveis> data = new List<Imoveis>();
            conn.Open();

            string sqlStr = @"SELECT r.*, t.tipo_receita AS tipo_de_receita FROM receita r INNER JOIN tipo_receita t ON t.id=r.tipo_receita WHERE t.id=@1";

            //string sqlStr = @"SELECT r.*, t.tipo_receita AS tipo_de_receita FROM receita r INNER JOIN tipo_receita t ON t.id=r.tipo_receita WHERE t.id=@1";

            try
            {
                MySqlCommand cmd = new MySqlCommand(sqlStr, conn);
                cmd.Parameters.Add(new MySqlParameter("@1", opcao));
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    data.Add(new Imoveis(
                        reader.GetInt32(0), // id
                        reader.GetString(1), // ingredientes
                        reader.GetString(2), // preparação
                        reader.GetInt32(3), //nivel_dificuldade
                        reader.GetInt32(4), // tempo_preparacao
                        reader.GetString(5), //imagem
                        reader.GetInt32(6), // tipo_receita
                        reader.GetString(7) // tipo_de_receita

                        //reader.GetInt32(0), // id
                        //reader.GetString(1), // ingredientes
                        //reader.GetString(2), // preparação
                        //reader.GetInt32(3), //nivel_dificuldade
                        //reader.GetInt32(4), // tempo_preparacao
                        //reader.GetString(5), //imagem
                        //reader.GetInt32(6), // tipo_receita
                        //reader.GetString(7) // tipo_de_receita

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

        public void Delete(int id)
        {

            conn.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM receita WHERE id = @1;", conn);
                /*DELETE FROM tipo_receita WHERE id = @1*/
                cmd.Parameters.Add(new MySqlParameter("@1", id));                               
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                conn.Close();
            }
            finally
            {
                conn.Close();
            }

        }

    }

}
