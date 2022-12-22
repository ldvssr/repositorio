namespace Post
{
    public partial class frmPost : Form
    {
        public frmPost()
        {
            InitializeComponent();
            StartListView();
        }

        List<Post> _listaPosts = new List<Post>();

        private void btnSubmeter_Click(object sender, EventArgs e)
        {
            Post _post = new Post(tbTitulo.Text, tbDescricao.Text);

            _listaPosts.Add(_post);

            FillListView();

            tbTitulo.ResetText();

            tbDescricao.ResetText();
        }

        private void StartListView()
        {
            lvPosts.Columns.Clear();   
            lvPosts.View = View.Details; 
            lvPosts.GridLines = true;    
            lvPosts.FullRowSelect = true; 
                                    
            lvPosts.Columns.Add("Título", 110, HorizontalAlignment.Center);
            lvPosts.Columns.Add("Descrição", 200, HorizontalAlignment.Center);
            lvPosts.Columns.Add("Data/Hora", 180, HorizontalAlignment.Center);
            lvPosts.Columns.Add("Gostos", 90, HorizontalAlignment.Center);
            lvPosts.Columns.Add("Desgostos", 90, HorizontalAlignment.Center);
        }

        private void FillListView()
        {
            lvPosts.Items.Clear();
            for (int i = 0; i < _listaPosts.Count; i++)
            {
                string[] arrayPost =
                {
                _listaPosts[i].Titulo,
                _listaPosts[i].Descricao,
                _listaPosts[i].Data.ToString(),
                _listaPosts[i].Gosto.ToString(),
                _listaPosts[i].Desgosto.ToString(),
                };                
                lvPosts.Items.Add(new ListViewItem(arrayPost));
            }
        }

        private void btnGosto_Click(object sender, EventArgs e)
        {
            if (lvPosts.SelectedIndices.Count != 1)
            {
                return;
            }

            _listaPosts[lvPosts.SelectedIndices[0]].Gostar();

            lvPosts.Items[lvPosts.SelectedIndices[0]].SubItems[3].Text = _listaPosts[lvPosts.SelectedIndices[0]].Gosto.ToString();
        }

        private void btnDesgosto_Click(object sender, EventArgs e)
        {
            if (lvPosts.SelectedIndices.Count != 1)
            {
                return;
            }

            _listaPosts[lvPosts.SelectedIndices[0]].Desgostar();

            lvPosts.Items[lvPosts.SelectedIndices[0]].SubItems[4].Text = _listaPosts[lvPosts.SelectedIndices[0]].Desgosto.ToString();
        }
    }
}