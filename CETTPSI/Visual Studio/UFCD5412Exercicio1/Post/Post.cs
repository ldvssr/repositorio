namespace Post
{
    using System;
    internal class Post
    {

        #region Atributos

        private string _titulo = "";

        private string _descricao = "";

        private DateTime _data;

        private int _gosto;

        private int _desgosto;

        #endregion

        #region Propriedades

        public string Titulo
        {
            get
            {
                return _titulo;
            }
            set
            {
                _titulo = value;
            } 
        }

        public string Descricao
        {
            get
            {
                return _descricao;
            }
            set
            {
                _descricao = value;
            }
        }

        public DateTime Data
        {
            get
            {
                return _data;
            }
            set
            {
                _data = value;
            }
        }

        public int Gosto
        {
            get
            {
                return _gosto;
            }
            set
            {
                _gosto = value;
            }
        }

        public int Desgosto
        {
            get
            {
                return _desgosto;
            }
            set
            {
                _desgosto = value;
            }
        }

        #endregion

        #region Métodos

        public Post(string titulo, string descricao)
        {

            Titulo = titulo;

            Descricao = descricao;

            Data = DateTime.Now;

            Gosto = 0;

            Desgosto = 0;

        }

        public void Gostar()
        {
            Gosto ++;
        }

        public void Desgostar()
        {
            Desgosto++;
        }

        #endregion

    }
}
