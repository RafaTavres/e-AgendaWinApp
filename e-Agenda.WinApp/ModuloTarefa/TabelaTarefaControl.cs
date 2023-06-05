
using e_Agenda.Dominio.ModuloTarefa;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TabelaTarefaControl : UserControl
    {

        public TabelaTarefaControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            tabelaTarefas.ConfigurarGridZebrado();

            tabelaTarefas.ConfigurarGridSomenteLeitura();

            tabelaTarefas.ConfigurarGridDockFill();
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
                    Name = "titulo",
                    HeaderText = "Título"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "prioridade",
                    HeaderText = "Prioridade"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "percentualConcluido",
                    HeaderText = "% Concluído"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "dataCriacao",
                    HeaderText = "Data Criação"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "dataPrazo",
                    HeaderText = "Data Prazo"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "statusDaTarefa",
                    HeaderText = "Status"
                }
            };

            tabelaTarefas.Columns.AddRange(colunas);
        }


        public void AtualizarRegistros(List<Tarefa> tarefas)
        {
            tabelaTarefas.Rows.Clear();
            foreach (Tarefa tarefa in tarefas)
            {
                tabelaTarefas.Rows.Add(tarefa.id, tarefa.titulo, tarefa.prioridade, Math.Round(tarefa.percentualConcluido,2),tarefa.dataCriacao.ToString("dd/MMM/yyyy"),tarefa.dataPrazo.ToString("dd/MMM/yyyy"),tarefa.statusDaTarefa);
            }
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(tabelaTarefas.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}
