using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _01_Adivinhas.Models
{
    public class Anedotas
    {
        public int id { get; set; }

        [Display(Name="Anedota")]
        public string anedota { get; set; }

        public Anedotas(int _id, string _anedota)
        {
            this.id = _id;
            this.anedota = _anedota;
        }

        public Anedotas()
        {

        }


    }
}
