using e_Agenda.Dominio.ModuloTarefa;

namespace e_Agenda.WinApp.ModuloTarefa.Tela_Filtro_Tarefa
{
    public partial class TelaFiltroTarefasForm : Form
    {
        public TelaFiltroTarefasForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();

        }
        public PrioridadeTarefaEnum PrioridadeTarefa
        {
            get
            {
                if (rdBtnVizualizarPrioridadeAlta.Checked)
                    return PrioridadeTarefaEnum.Alta;

                else if (rdBtnVizualizarPrioridadeMedia.Checked)
                    return PrioridadeTarefaEnum.Media;

                else if (rdBtnVizualizarPrioridadeBaixa.Checked)
                    return PrioridadeTarefaEnum.Baixa;
                else
                    return PrioridadeTarefaEnum.Todos;
            }
        }

        public StatusTarefaEnum? StatusDaTarefa
        {
            get
            {
                if (rdBtnTarefasPendentes.Checked)
                    return StatusTarefaEnum.Pendente;

                else if (rdBtnTarefasConcluidas.Checked)
                    return StatusTarefaEnum.Concluida;
                else 
                    return null;
            }
        }

    }
}
