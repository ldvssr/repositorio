using System;
using System.Collections.Generic;

namespace GestaoSock
{
    class MainGestaoStock
    {
        static void Main(string[] args)
        {
                                   
            List<Produto> listaProdutos = new List<Produto>();

            for (int i = 0; i < 3; i++)
            {

                Produto produto = criarProduto();

                listaProdutos.Add(produto);

            }                      

            ImprimirLista(listaProdutos);

            Console.WriteLine("Indique um id de produto para invalidar: ");

            String codigoIDProduto = Console.ReadLine();

            InvalidarProduto(codigoIDProduto, listaProdutos);

            ImprimirLista(listaProdutos);



            Console.WriteLine("Indique um id de produto para alterar o stock: ");

            String codigoID = Console.ReadLine();

            float novaQuantidade;

            float.TryParse(Console.ReadLine(), out novaQuantidade);

            AlterarStock(codigoID, listaProdutos, novaQuantidade);

            ImprimirLista(listaProdutos);                        

        }

        static Produto criarProduto()
        {

            Console.WriteLine("Indique nome: "); 
            String nome = Console.ReadLine();

            Console.WriteLine("Indique valor: ");
            float valor;
            float.TryParse(Console.ReadLine(), out valor);

            Console.WriteLine("Indique quantidade: ");
            float quantidade;
            float.TryParse(Console.ReadLine(), out quantidade);

            Console.WriteLine("Indique iva: ");
            int iva;
            int.TryParse(Console.ReadLine(), out iva);

            Console.WriteLine("Indique codigoID ");
            String codigoID = Console.ReadLine();

            Console.WriteLine("Indique margemDeLucro: ");
            float margemDeLucro;
            float.TryParse(Console.ReadLine(), out margemDeLucro);                                 
            bool isInvalido = false;

            Produto produto = new Produto(nome, valor, quantidade, iva, codigoID, margemDeLucro, isInvalido);

            return produto;

        }

        static void ImprimirLista(List<Produto>listaProdutos)
        {

            foreach (Produto prod in listaProdutos)
            {

                Console.WriteLine(prod);

            }

        }
        
        static void InvalidarProduto (String idCodigo, List<Produto> listaProdutos)
        {

            //iterar pela lista
            //encontrar o codigo de id de cada produto e verificar se corresponde ao enviado por parametro
            //modificar o valor do bool

            foreach (Produto prod in listaProdutos)
            {

                if (prod.codigoID == idCodigo)
                {

                    prod.isInvalido = true;

                }

            }

        }
        static void AlterarStock(String idCodigo, List<Produto> listaProdutos, float novaQuantidade)
        {

            //Iterar pela lista
            //encontrar o codigo de id de cada produto e verificar se corresponde ao enviado por parametro
            //modificar o valor do bool;
            foreach (Produto prod in listaProdutos)
            {
                if (prod.codigoID == idCodigo)
                {
                    prod.quantidade = novaQuantidade;
                }
            }
        }        

    }

}

/*

using System;
using System.Collections.Generic;

namespace GestaoStock
{
    class Program
    {
        static void Main(string[] args)
        {
                List<Produto> listaProdutos = new List<Produto>();
                for (int i = 0; i < 3; i++)
                {
                Produto produto = criarProduto();
                listaProdutos.Add(produto);

                }
              
                ImprimirLista(listaProdutos);


            Console.WriteLine("Indique um id de produto para invalidar");
            String codigoIDProduto = Console.ReadLine();
            InvalidarProduto(codigoIDProduto, listaProdutos);
            ImprimirLista(listaProdutos);


            Console.WriteLine("Indique um id de produto para invalidar");
            String codigoID = Console.ReadLine();
            float novaQuantidade;
            float.TryParse(Console.ReadLine(), out novaQuantidade);
            AlterarStock(codigoID, listaProdutos,novaQuantidade);

            ImprimirLista(listaProdutos);
       

        //Função 




        //TODO
        //Fazer Classe
        //Produto - Nome, Preço, Quantidade , IVA, códigoID, margemDeLucro, isInvalido;


        //Loja com lista de Produtos

        //Lista de Compras 

        //Poder aceder à lista de produtos
        //Poder adicionar um produto
        //Poder invalidar um produto
        //Poder alterar numero De Stock


        //Função Procurar um codigoID, na lista de produtos,



    }

        static Produto criarProduto()
        {
            Console.WriteLine("Indique nome:");
            String nome = Console.ReadLine();

            Console.WriteLine("Indique valor");
            float valor;
            float.TryParse(Console.ReadLine(), out valor);

            Console.WriteLine("Indique Quantidade");
            float quantidade;
            float.TryParse(Console.ReadLine(), out quantidade);

            Console.WriteLine("Indique Iva ");
            int iva;
            int.TryParse(Console.ReadLine(), out iva);


            Console.WriteLine("Indique codigoId: ");
            String codigoID = Console.ReadLine();
           

            Console.WriteLine("Indique margem Lucro: ");
            float margemDeLucro;
            float.TryParse(Console.ReadLine(), out margemDeLucro);

            bool isInvalido = false;
            Produto produto = new Produto(nome, valor, quantidade, iva, codigoID, margemDeLucro, isInvalido);

            return produto;

        }


        static void ImprimirLista(List<Produto> listaProdutos)
        {

            foreach(Produto prod in listaProdutos) {

                Console.WriteLine(prod);
            }


        }



        static void InvalidarProduto(String idCodigo, List<Produto> listaProdutos)
        {

            //Iterar pela lista
            //encontrar o codigo de id de cada produto e verificar se corresponde ao enviado por parametro
            //modificar o valor do bool;
            foreach (Produto prod in listaProdutos)
            {
                if (prod.codigoID == idCodigo)
                {
                    prod.isInvalido = true;
                }
            }
        }

        static void AlterarStock(String idCodigo, List<Produto> listaProdutos, float novaQuantidade)
        {

            //Iterar pela lista
            //encontrar o codigo de id de cada produto e verificar se corresponde ao enviado por parametro
            //modificar o valor do bool;
            foreach (Produto prod in listaProdutos)
            {
                if (prod.codigoID == idCodigo)
                {
                    prod.quantidade = novaQuantidade;
                }
            }
        }


    }
}

*/