using System.ComponentModel.DataAnnotations;

namespace _01_Adivinhas.Models
{
    public class Anedotas
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Anedota obrigatória")]
        [Display(Name = "Anedota")]
        public string anedota { get; set; }

        //[Display(Name = "Resposta")]
        //public string resposta { get; set; }

        public Anedotas(int _id, string _pergunta /*, string _resposta*/)
        {
            this.id = _id;
            this.anedota = _pergunta;
            //this.resposta = _resposta;
        }

        public Anedotas()
        {

        }
    }
}
