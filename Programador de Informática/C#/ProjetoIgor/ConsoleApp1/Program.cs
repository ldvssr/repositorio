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
            Console.WriteLine("Bem vindo!");

            //1. - Adicionar registo novo na tabela. (nome do convidado, presente, valor em euros).
            //2. - Após introdução deve aparecer a quantidade total de dinheiro que o casal recebeu vomo presente.
            //3. - Depois devera pedir o id e atulizar para um novo dado pedido na consola.
            //4. - (OPCIONAL) modular, funcoes para melhor introducao de codigo e/ou procedimentos para cada comando criado em sql.

            //connection string
            string connStr = "server=localhost;user=root;database=casamento;port=3306;password=12345";

            MySqlConnection conn = new MySqlConnection(connStr);

            try
            {
                Console.WriteLine("A conectar a base de dados");
                conn.Open(); //abrir a conexao a base de dados

                //string sqlInsert = "INSERT INTO `convidados`(`id`, `nomeConvidado`, `nomePresente`, `valorPresente`) VALUES('4', 'Ricardo Gonçalves', 'Dinheiro', '50');INSERT INTO `convidados`(`id`, `nomeConvidado`, `nomePresente`, `valorPresente`) VALUES('5', 'Ana Oliveira', 'Cama de Casal', '89');INSERT INTO `convidados`(`id`, `nomeConvidado`, `nomePresente`, `valorPresente`) VALUES('6', 'Catarina Marques', 'Conjunto de talheres', '345');INSERT INTO `convidados`(`id`, `nomeConvidado`, `nomePresente`, `valorPresente`) VALUES('7', 'Joana Castro', 'Dinheiro', '28');";
                //MySqlCommand cmdInsert = new MySqlCommand(sqlInsert, conn);
                //MySqlDataReader insertion = cmdInsert.ExecuteReader();
                //insertion.Close();


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