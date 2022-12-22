namespace Veiculo
{
    using System;
    internal class Veiculo
    {

        #region Atributos

        private string _matricula = "";

        private int _quilometragem;

        private double _deposito;

        private double _combustivel;

        private int _contador;

        #endregion

        #region Propriedades

        public string Matricula
        {
            get
            {
                return _matricula;
            }
            set
            {
                _matricula = value;
            }
        }

        public int Quilometragem
        {
            get
            {
                return _quilometragem;
            }
            set
            {
                _quilometragem = value;
            }
        }

        public double Deposito
        {
            get
            {
                return _deposito;
            }
            set
            {
                _deposito = value;
            }
        }

        public double Combustivel
        {
            get
            {
                return _combustivel;
            }
            set
            {
                _combustivel = value;
            }
        }

        public int Contador
        {
            get
            {
                return _contador;
            }
            set
            {
                _contador = value;
            }
        }

        #endregion

        #region Métodos



        #endregion

    }
}
