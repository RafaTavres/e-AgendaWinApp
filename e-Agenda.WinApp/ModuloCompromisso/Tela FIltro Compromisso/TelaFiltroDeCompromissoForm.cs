using e_Agenda.Dominio.ModuloCompromisso;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TelaFiltroDeCompromissoForm : Form
    {
        public List<Compromisso> listaFiltrada;
        public TelaFiltroDeCompromissoForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
            gpBoxFiltroFuturos.Enabled = false;
        }
        public DateTime DataDeInicio
        {
            get { return datePickerDataInicio.Value; }
        }
        public DateTime DataDetermino
        {
            get { return datePickerDataFinal.Value; }
        }

        public StatusCompromissoEnum StatusSelecionado
        {
            get
            {
                if (rdBtnVisualizarFuturos.Checked)
                    return StatusCompromissoEnum.Futuros;

                else if (rdBtnVisualizarPassados.Checked)
                    return StatusCompromissoEnum.Passados;

                else
                    return StatusCompromissoEnum.Todos;
            }
        }

        private void rdBtnVisualizarFuturos_CheckedChanged(object sender, EventArgs e)
        {
            gpBoxFiltroFuturos.Enabled = !gpBoxFiltroFuturos.Enabled;
        }
    }
}
