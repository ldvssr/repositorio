namespace _02_receitas.Models
{
    public class Tipos_receitas
    {
        public int id { get; set; }
        public string tipo { get; set; }
        public Tipos_receitas()
        {

        }
        public Tipos_receitas(int id, string tipo)
        {
            this.id = id;
            this.tipo = tipo;
        }
    }
}
