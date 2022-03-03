namespace ProjetoImobiliaria.Models
{
    public class Tipologias
    {
        public int id { get; set; }
        public string tipo { get; set; }
        public Tipologias()
        {

        }
        public Tipologias(int id, string tipo)
        {
            this.id = id;
            this.tipo = tipo;
        }
    }
}
