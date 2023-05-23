using e_Agenda.WinApp.ModuloCompromisso.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TelaFiltroDeCompromissoForm : Form
    {
        public List<Compromisso> listaFiltrada;
        public TelaFiltroDeCompromissoForm()
        {
            InitializeComponent();
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
