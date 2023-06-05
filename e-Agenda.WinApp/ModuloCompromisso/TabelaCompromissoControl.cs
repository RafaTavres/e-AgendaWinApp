using e_Agenda.Dominio.ModuloCompromisso;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TabelaCompromissoControl : UserControl
    {
        public TabelaCompromissoControl()
        {
            InitializeComponent(); 
            ConfigurarColunas();
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            tabelaCompromisso.ConfigurarGridZebrado();

            tabelaCompromisso.ConfigurarGridSomenteLeitura();

            tabelaCompromisso.ConfigurarGridDockFill();
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
                    Name = "assunto",
                    HeaderText = "Assunto"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "local",
                    HeaderText = "Local"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "data",
                    HeaderText = "Data"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "horaDeInicio",
                    HeaderText = "Hora de Início"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "horaDoTermino",
                    HeaderText = "Hora Do Termino"
                }
                ,
                new DataGridViewTextBoxColumn()
                {
                    Name = "nomeContatoRelacionado",
                    HeaderText = "Nome do Contato"
                }
                ,
                new DataGridViewTextBoxColumn()
                {
                    Name = "numeroContatoRelacionado",
                    HeaderText = "Telefone do Contato"
                }
            };

            tabelaCompromisso.Columns.AddRange(colunas);
        }

        public void AtualizarRegistros(List<Compromisso> compromissos)
        {
            tabelaCompromisso.Rows.Clear();
            foreach (Compromisso compromisso in compromissos)
            {
                tabelaCompromisso.Rows.Add(compromisso.id, compromisso.assunto, compromisso.local, compromisso.data.ToString("d"), compromisso.horaDeInicio.ToString("t"), compromisso.horaDoTermino.ToString("t"), compromisso.contatoRelacionado.nome, compromisso.contatoRelacionado.telefone);
            }
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(tabelaCompromisso.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}
