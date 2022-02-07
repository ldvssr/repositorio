using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _01_Adivinhas.Models
{
    public class Adivinhas
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Pergunta obrigatoria")]
        [Display(Name = "Pergunta")]
        public string pergunta { get; set; }
       
        [Display(Name = "Resposta")]
        public string resposta { get; set; }

        public Adivinhas(int _id, string _pergunta, string _resposta)
        {
            this.id = _id;
            this.pergunta = _pergunta;
            this.resposta = _resposta;
        }

        public Adivinhas()
        {

        }
    }
}
