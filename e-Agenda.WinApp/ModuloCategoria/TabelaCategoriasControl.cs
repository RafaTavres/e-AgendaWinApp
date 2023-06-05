using e_Agenda.Dominio.ModuloCategoria;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public partial class TabelaCategoriasControl : UserControl
    {
        public TabelaCategoriasControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            tabelaCategorias.ConfigurarGridZebrado();

            tabelaCategorias.ConfigurarGridSomenteLeitura();

            tabelaCategorias.ConfigurarGridDockFill();

        }
        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Id"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "descricao",
                    HeaderText = "Descrição"
                }
            };

            tabelaCategorias.Columns.AddRange(colunas);
        }
        public void AtualizarRegistros(List<Categoria> categorias)
        {
            tabelaCategorias.Rows.Clear();
            foreach (Categoria categoria in categorias)
            {
                tabelaCategorias.Rows.Add(categoria.id,categoria.titulo);
            }
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(tabelaCategorias.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}
