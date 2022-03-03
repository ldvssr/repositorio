using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _03_Imobiliaria.Models
{
    public class Imobiliaria
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Ingredientes")]
        public string ingredientes { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Preparação")]
        public string preparacao { get; set; }

        [Display(Name = "Nível de Dificuldade")]
        public int nivel_dificuldade { get; set; }

        [Display(Name = "Tempo de Preparação")]
        public int tempo_preparacao { get; set; }

        [Display(Name = "Imagem da Receita")]
        public string imagem { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [Display(Name = "Tipo de Receita")]
        public int tipo_receita { get; set; }

        [Display(Name = "Tipo de Receita")]
        public string tipo_de_receita { get; set; }

        public Receitas()
        {

        }

        public Receitas(int id, string ingredientes, string preparacao, int nivel_dificuldade, int tempo_preparacao, string imagem, int tipo_receita, string tipo_de_receita)
        {
            this.id = id;
            this.ingredientes = ingredientes;
            this.preparacao = preparacao;
            this.nivel_dificuldade = nivel_dificuldade;
            this.tempo_preparacao = tempo_preparacao;
            this.imagem = imagem;
            this.tipo_receita = tipo_receita;
            this.tipo_de_receita = tipo_de_receita;

        }

    }

}
