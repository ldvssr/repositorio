/*
 Criar código para realizar uma conexão a uma base de dados localhost MYSQL.  
 */

using MySql.Data.MySqlClient;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //connection string
            string connStr = "server=localhost;user=root;database=casamento;port=3306;password=12345";

            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                Console.WriteLine("A conectar a base de dados");
                conn.Open(); //abrir a conexao a base de dados

                string sql = "SELECT * FROM convidados";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    Console.WriteLine(reader[0] + " - " + reader[1] + " - " + reader[2] + " - " + reader[3]);
                    //Console.WriteLine(reader.GetString(0));
                }
                reader.Close();
            }
            catch (Exception err)
            { 
                Console.WriteLine(err); 
            }
            conn.Close();
        }
    }
}