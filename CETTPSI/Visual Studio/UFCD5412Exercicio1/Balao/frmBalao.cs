namespace Balao
{
    public partial class frmBalao : Form
    {
        private readonly Balao _balao;

        public frmBalao()
        {
            InitializeComponent();
            _balao = new Balao();
        }
    }
}