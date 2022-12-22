namespace Veiculo
{
    public partial class frmVeiculo : Form
    {
        private readonly Veiculo _veiculo;

        public frmVeiculo()
        {
            InitializeComponent();
            _veiculo = new Veiculo();
        }
    }
}