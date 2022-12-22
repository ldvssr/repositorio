namespace Balao
{
    using System;
    using System.Xml.Linq;

    internal class Balao
    {

        #region Atributos

        private string _cor = "";

        private string _direcao = "";

        private int _altitude = 0;

        #endregion

        #region Propriedades

        public string Cor
        {
            get
            {
                return _cor;
            }
            set
            {
                _cor = value;
            }
        }

        public string Direcao
        {
            get
            {
                return _direcao;
            }
            set
            {
                _direcao = value;
            }
        }

        public int Altitude
        {
            get
            {
                return _altitude;
            }
            set
            {
                _altitude = value;
            }
        }
       
        #endregion

        #region Métodos



        #endregion

    }
}
