using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoSock
{
    class Produto
    {
        //ESTADO
        public string nome;
        public float valor;
        public float quantidade;
        public int iva;
        public string codigoID;            
        public float valorTotal;
        public bool isInvalido;
        //Construtor Padrão
        public Produto()
        {

        }
        //Construtores Parametrizados
        public Produto(String nome, float valor, float quantidade, int iva, String codigoID, float margemDeLucro, bool isInvalid)
        {

            this.nome = nome;
            this.valor = valor;
            this.quantidade = quantidade;
            this.iva = iva;
            this.codigoID = codigoID;
            this.valorTotal = quantidade * valor;
            this.isInvalido = isInvalid;

        }

        //Overload de Construtores
        public Produto(string nome, float valor, float quantidade, int iva, string codigoID, float margemDeLucro)
        {

            this.nome = nome;
            this.valor = valor;
            this.quantidade = quantidade;
            this.iva = iva;
            this.codigoID = codigoID;
            this.valorTotal = quantidade * valor;
            this.isInvalido = false;

        }

        public override string ToString()
        {
            
            return this.nome + " : " + this.valor + " | quantidade: " + this.quantidade +" INVALIDO? " + this.isInvalido;            

        }

    }
}

/*
 *
using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoStock
{
    class Produto
    {

         //ESTADO
         public String nome;
         public float valor;
         public float quantidade;
         public int iva;
         public String codigoID;
         public float margemDeLucro;
         public float valorTotal;
         public bool isInvalido;

        //TODO
        //Fazer Classe
        //Produto - Nome, Preço, Quantidade , IVA, códigoID, margemDeLucro, isInvalido;

        //Construtor Padrão
        public Produto()
        {

        }

        //Construtores Parametrizados

        public Produto(String nome, float valor, float quantidade, int iva, String codigoID, float margemDeLucro,bool isInvalid)
        {
            this.nome = nome;
            this.valor = valor;
            this.quantidade = quantidade;
            this.iva = iva;
            this.codigoID = codigoID;
            this.valorTotal = quantidade * valor;
            this.isInvalido = isInvalid;

        }

        //overload de Construtores
        public Produto(String nome, float valor, float quantidade, int iva, String codigoID, float margemDeLucro)
        {
            this.nome = nome;
            this.valor = valor;
            this.quantidade = quantidade;
            this.iva = iva;
            this.codigoID = codigoID;
            this.valorTotal = quantidade * valor;
            this.isInvalido = false;

        }

        public override string ToString()
        {
            return this.nome+ ": " + this.valor + " | quantidade: " + this.quantidade + " INVALIDO? " + this.isInvalido;
        }
    }
}
*
*/