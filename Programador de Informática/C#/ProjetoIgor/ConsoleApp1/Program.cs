/*
 Criar código para realizar uma conexão a uma base de dados localhost MYSQL. 

//1. - Adicionar registo novo na tabela. (nome do convidado, presente, valor em euros).
//2. - Após introdução deve aparecer a quantidade total de dinheiro que o casal recebeu vomo presente.
//3. - Depois devera pedir o id e atulizar para um novo dado pedido na consola.
//4. - (OPCIONAL) modular, funcoes para melhor introducao de codigo e/ou procedimentos para cada comando criado em sql.

 */

using MySql.Data.MySqlClient;
using System;

namespace ConsoleApp1
{

    class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("\n\tBem vindo!");
                       
            int menu = 0;
            int repetir = 0;
            int opcao = 0;
                
            while (repetir == 0)
            {

                Console.WriteLine("\n\tMENU\n\t0 - SAIR\n\t1 - CONSULTAR\n\t2 - INSERIR\n\t3 - ALTERAR\n\t4 - CALCULAR\n\t5 - ELIMINAR\n\t6 - ELIMINAR TABELA\n\t7 - CRIAR TABELA\n\t8 - PREENCHER TABELA\n");
                menu = Convert.ToInt32(Console.ReadLine());

                switch (menu)
                {
                    case 0:
                        // code block
                        Console.WriteLine("\n\tescolheu opcao 0, sair\n");
                        Console.WriteLine("\n\tquer mesmo sair? 1 - sim / 0 - nao\n");
                        opcao = Convert.ToInt32(Console.ReadLine());
                        if (opcao == 1)
                        {
                            repetir = 1;
                        }
                        else
                        {
                            repetir = 0;
                        }                      
                        break;
                    case 1:
                        // code block
                        Console.WriteLine("\n\tescolheu opcao 1, consultar\n");                    
                                                                        
                        Consultar();
                                               
                        break;
                    case 2:
                        // code block
                        Console.WriteLine("\n\tescolheu opcao 2, inserir\n");

                        Inserir();

                        break;
                    case 3:
                        // code block
                        Console.WriteLine("\n\tescolheu opcao 3, alterar\n");

                        Alterar();
                        
                        break;
                    case 4:
                        // code block
                        Console.WriteLine("\n\tescolheu opcao 4, calcular\n");

                        Calcular();
                        
                        break;
                    case 5:
                        // code block
                        Console.WriteLine("\n\tescolheu opcao 5, eliminar\n");

                        Eliminar();

                        break;
                    case 6:
                        // code block
                        Console.WriteLine("\n\tescolheu opcao 6, eliminar tabela\n");

                        DropTable();

                        break;
                    case 7:
                        // code block
                        Console.WriteLine("\n\tescolheu opcao 7, criar tabela\n");

                        CreateTable();

                        break;
                    case 8:
                        // code block
                        Console.WriteLine("\n\tescolheu opcao 8, preencher tabela\n");

                        FillTable();

                        break;
                    default:
                        // code block
                        Console.WriteLine("\n\tescolheu a opcao errada\n");
                                                
                        break;
                }

            }

        }
                
        public static void Consultar()
        {
            string connStr = "server=localhost;user=root;database=casamento;port=3306;password=12345";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("\n\tA conectar a base de dados\n");
                conn.Open(); //abrir a conexao a base de dados                           

                

                string sql = "SELECT * FROM convidados";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + " - " + reader[1] + " - " + reader[2] + " - " + reader[3]);
                    //Console.WriteLine(reader.GetString(0));
                }
                reader.Close();
                Console.WriteLine("\n\tOs dados foram consultados com sucesso.\n");
                Console.WriteLine("\n");
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                Console.WriteLine("\n");
            }
            conn.Close();
            Console.WriteLine("\n\tConexão à base de dados terminada.\n");
        }
                
        public static void Inserir()
        {
            string connStr = "server=localhost;user=root;database=casamento;port=3306;password=12345";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("\n\tA conectar a base de dados\n");
                conn.Open(); //abrir a conexao a base de dados                           

                
                Console.WriteLine("\n\tQual é o nome do convidado? \n");
                string nomeInserir = Console.ReadLine();
                Console.WriteLine("\n\tQual é o nome do presente? \n");
                string nomePresenteInserir = Console.ReadLine();
                Console.WriteLine("\n\tQual é o valor do presente? \n");
                string valorPresenteInserir = Console.ReadLine();


                
                string sqlInsert = $"INSERT INTO `convidados`(`id`, `nomeConvidado`, `nomePresente`, `valorPresente`) VALUES('NULL', '{nomeInserir}', '{nomePresenteInserir}', '{valorPresenteInserir}');";
                

                MySqlCommand cmdInsert = new MySqlCommand(sqlInsert, conn);
                MySqlDataReader insertion = cmdInsert.ExecuteReader();
                insertion.Close();

                
                Console.WriteLine("\n\tOs dados foram introduzidos com sucesso.\n");
                Console.WriteLine("\n");
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                Console.WriteLine("\n");
            }
            conn.Close();
            Console.WriteLine("\n\tConexão à base de dados terminada.\n");
        }

        public static void Alterar()
        {
            string connStr = "server=localhost;user=root;database=casamento;port=3306;password=12345";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("\n\tA conectar a base de dados\n");
                conn.Open(); //abrir a conexao a base de dados                         

                
                Console.WriteLine("\n\tQual é ID para alteração dos dados? \n");
                string variavelUpdateID = Console.ReadLine();
                Console.WriteLine("\n\tQual é o nome do convidado? \n");
                string nomeUpdateInserir = Console.ReadLine();
                Console.WriteLine("\n\tQual é o nome do presente? \n");
                string nomeUpdatePresenteInserir = Console.ReadLine();
                Console.WriteLine("\n\tQual é o valor do presente? \n");
                string valorUpdatePresenteInserir = Console.ReadLine();
                string sqlInsert = $"UPDATE `convidados` SET `nomeConvidado`= '{nomeUpdateInserir}',`nomePresente`= '{nomeUpdatePresenteInserir}',`valorPresente`= '{valorUpdatePresenteInserir}' WHERE id = {variavelUpdateID};";
                MySqlCommand cmdInsert = new MySqlCommand(sqlInsert, conn);
                MySqlDataReader insertion = cmdInsert.ExecuteReader();
                insertion.Close();                

                Console.WriteLine("\n\tOs dados foram alterados com sucesso.\n");
                Console.WriteLine("\n");
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                Console.WriteLine("\n");
            }
            conn.Close();
            Console.WriteLine("\n\tConexão à base de dados terminada.\n");
        }

        public static void Calcular()
        {
            string connStr = "server=localhost;user=root;database=casamento;port=3306;password=12345";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("\n\tA conectar a base de dados\n");
                conn.Open(); //abrir a conexao a base de dados                           
                               
                string sqlCalc = "SELECT SUM(valorPresente) FROM convidados WHERE nomePresente LIKE 'Dinheiro';";
                MySqlCommand cmdCalc = new MySqlCommand(sqlCalc, conn);
                MySqlDataReader calculation = cmdCalc.ExecuteReader();

                Console.WriteLine("\n\tO valor dos presentes recebidos em dinheiro foi de: ");

                while (calculation.Read())
                {
                    Console.WriteLine(calculation[0] + " EUROS");
                    //Console.WriteLine(reader.GetString(0));
                }

                calculation.Close();

                Console.WriteLine("\n\tOs dados foram calculados com sucesso.\n");
                Console.WriteLine("\n");
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                Console.WriteLine("\n");
            }
            conn.Close();
            Console.WriteLine("\n\tConexão à base de dados terminada.\n");
        }
                
        public static void Eliminar()
        {
            string connStr = "server=localhost;user=root;database=casamento;port=3306;password=12345";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("\n\tA conectar a base de dados\n");
                conn.Open(); //abrir a conexao a base de dados
                Console.WriteLine("\n\tQual é o ID a eliminar?\n");
                string variavelID = Console.ReadLine();
                string sqlElim = $"DELETE FROM `convidados` WHERE ID = {variavelID};";
                MySqlCommand cmdElim = new MySqlCommand(sqlElim, conn);
                MySqlDataReader elimination = cmdElim.ExecuteReader();             
                elimination.Close();

                Console.WriteLine("\n\tOs dados foram calculados com sucesso.\n");
                Console.WriteLine("\n");
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                Console.WriteLine("\n");
            }
            conn.Close();
            Console.WriteLine("\n\tConexão à base de dados terminada.\n");
        }
        
        public static void DropTable()
        {
            string connStr = "server=localhost;user=root;database=casamento;port=3306;password=12345";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("\n\tA conectar a base de dados\n");
                conn.Open(); //abrir a conexao a base de dados
                //Console.WriteLine("\n\tQual é a tabela a eliminar?\n");
                //string variavelID = Console.ReadLine();
                string sqlDropTable = $"DROP TABLE convidados;";
                MySqlCommand cmdDropTable = new MySqlCommand(sqlDropTable, conn);
                MySqlDataReader dropingTable = cmdDropTable.ExecuteReader();
                dropingTable.Close();

                Console.WriteLine("\n\tA tabela convidados foi eliminada com sucesso.\n");
                Console.WriteLine("\n");
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                Console.WriteLine("\n");
            }
            conn.Close();
            Console.WriteLine("\n\tConexão à base de dados terminada.\n");
        }

        public static void CreateTable()
        {
            string connStr = "server=localhost;user=root;database=casamento;port=3306;password=12345";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("\n\tA conectar a base de dados\n");
                conn.Open(); //abrir a conexao a base de dados
                //Console.WriteLine("\n\tQual é a tabela a criar?\n");
                //string variavelTable = Console.ReadLine();
                string sqlDropTable = "CREATE TABLE `casamento`.`convidados` ( `id` INT NULL AUTO_INCREMENT , `nomeConvidado` VARCHAR(255) NOT NULL , `nomePresente` VARCHAR(255) NOT NULL , `valorPresente` INT NOT NULL , PRIMARY KEY (`id`)) ENGINE = InnoDB;";
                MySqlCommand cmdDropTable = new MySqlCommand(sqlDropTable, conn);
                MySqlDataReader dropingTable = cmdDropTable.ExecuteReader();
                dropingTable.Close();

                Console.WriteLine($"\n\tA tabela convidados foi criada com sucesso.\n");
                Console.WriteLine("\n");
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                Console.WriteLine("\n");
            }
            conn.Close();
            Console.WriteLine("\n\tConexão à base de dados terminada.\n");
        }

        private static void FillTable()
        {
            string connStr = "server=localhost;user=root;database=casamento;port=3306;password=12345";
            MySqlConnection conn = new MySqlConnection(connStr);
            try
            {
                Console.WriteLine("\n\tA conectar a base de dados\n");
                conn.Open(); //abrir a conexao a base de dados                
                string sqlFill = "INSERT INTO `convidados`(`id`, `nomeConvidado`, `nomePresente`, `valorPresente`) VALUES('1', 'Igor Lima', 'Máquina Lavar Loiça', '345');INSERT INTO `convidados`(`id`, `nomeConvidado`, `nomePresente`, `valorPresente`) VALUES('2', 'Inês Barbosa', 'Jogo Monopoly', '30');INSERT INTO `convidados`(`id`, `nomeConvidado`, `nomePresente`, `valorPresente`) VALUES('3', 'Paulo Preto', 'Conjunto Panelas Tefal', '134');INSERT INTO `convidados`(`id`, `nomeConvidado`, `nomePresente`, `valorPresente`) VALUES('4', 'Ricardo Gonçalves', 'Dinheiro', '50');INSERT INTO `convidados`(`id`, `nomeConvidado`, `nomePresente`, `valorPresente`) VALUES('5', 'Ana Oliveira', 'Cama de Casal', '89');INSERT INTO `convidados`(`id`, `nomeConvidado`, `nomePresente`, `valorPresente`) VALUES('6', 'Catarina Marques', 'Conjunto de talheres', '345');INSERT INTO `convidados`(`id`, `nomeConvidado`, `nomePresente`, `valorPresente`) VALUES('7', 'Joana Castro', 'Dinheiro', '28');";                
                MySqlCommand cmdFill = new MySqlCommand(sqlFill, conn);
                MySqlDataReader filling = cmdFill.ExecuteReader();
                filling.Close();

                Console.WriteLine("\n\tA tabela convidados foi preenchida com sucesso.\n");
                Console.WriteLine("\n");
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
                Console.WriteLine("\n");
            }
            conn.Close();
            Console.WriteLine("\n\tConexão à base de dados terminada.\n");
        }

    }

}