
using e_Agenda.Dominio.ModuloContato;

namespace e_Agenda.WinApp.ModuloContato
{
    public partial class TabelaContatoControl : UserControl
    {
        public TabelaContatoControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            tabelaContato.ConfigurarGridZebrado();

            tabelaContato.ConfigurarGridSomenteLeitura();

            tabelaContato.ConfigurarGridDockFill();

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
                    Name = "nome",
                    HeaderText = "Nome"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "telefone",
                    HeaderText = "Telefone"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "email",
                    HeaderText = "E-mail"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "cargo",
                    HeaderText = "Cargo"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "empresa",
                    HeaderText = "Empresa"
                }
            };

            tabelaContato.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Contato> contatos)
        {
            tabelaContato.Rows.Clear();
            foreach (Contato contato in contatos)
            {
                tabelaContato.Rows.Add(contato.id, contato.nome, contato.telefone,contato.email, contato.cargo, contato.empresa);
            }
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(tabelaContato.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}
