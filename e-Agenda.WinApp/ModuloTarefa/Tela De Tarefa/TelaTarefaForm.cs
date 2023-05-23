using e_Agenda.WinApp.ModuloTarefa.Dominio;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaTarefaForm : Form
    {
        private Tarefa tarefa;
        public TelaTarefaForm()
        {
            InitializeComponent();
        }

        public Tarefa Tarefa
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtTitulo.Text = value.titulo;
                datePickerDataInicio.Value = value.dataCriacao;
                datePickerDataPrazo.Value = value.dataPrazo;
                txtDescricao.Text = value.descricao;

            }
            get
            {
                return tarefa;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            tarefa = ObterTarefa();
            string[] erros = tarefa.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }

            if (txtId.Text != "0")
                tarefa.id = Convert.ToInt32(txtId.Text);
        }

        private Tarefa ObterTarefa()
        {
            string titulo = txtTitulo.Text;

            string descricao = txtDescricao.Text;

            DateTime dataPrazo = datePickerDataPrazo.Value.Date;

            DateTime dataInicio = datePickerDataInicio.Value.Date;

            double percentualConcluido = 0;

            PrioridadeTarefaEnum prioridadeTarefa = PrioridadeTarefaEnum.Baixa;

            bool estahConcluida = false;

            if (rdBtnPrioridadeAlta.Checked)
            {
                prioridadeTarefa = PrioridadeTarefaEnum.Alta;
            }
            else
                if (rdBtnPrioridadeMedia.Checked)
            {
                prioridadeTarefa = PrioridadeTarefaEnum.Media;
            }
            else
                if (rdBtnPrioridadeBaixa.Checked)
            {
                prioridadeTarefa = PrioridadeTarefaEnum.Baixa;
            }

            return tarefa = new Tarefa(titulo, descricao, dataInicio, percentualConcluido, prioridadeTarefa, estahConcluida, dataPrazo);
        }

    }
}
