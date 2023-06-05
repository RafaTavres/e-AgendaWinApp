using e_Agenda.Dominio.ModuloCategoria;
using e_Agenda.Dominio.ModuloDespesas;


namespace e_Agenda.WinApp.ModuloCategoria
{
    public partial class TelaVisualizacaoDespesaCategoriaForm : Form
    {
        IRepositorioDespesa repositorioDespesa;
        Categoria categoria;
        public TelaVisualizacaoDespesaCategoriaForm(IRepositorioDespesa repositorioDespesa, Categoria categoria)
        {
            InitializeComponent();
            this.repositorioDespesa = repositorioDespesa;
            this.categoria = categoria;
            ConfigurarLabel();
            ConfigurarLista();
            this.ConfigurarDialog();
        }
        private void ConfigurarLista()
        {
            foreach (Despesa item in repositorioDespesa.RetornarTodos())
            {
                if (item.categorias.Contains(categoria))
                {
                    listaDespesas.Items.Add(item.ToString());
                }

            }
        }
        private void ConfigurarLabel()
        {
            lblCategoria.Text = categoria.titulo;
        }
    }
}
