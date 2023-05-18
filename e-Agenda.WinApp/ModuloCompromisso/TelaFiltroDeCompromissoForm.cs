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
        public RepositorioCompromisso repositorioCompromisso;
        public TelaFiltroDeCompromissoForm(RepositorioCompromisso repositorioCompromisso)
        {
            InitializeComponent();
            this.repositorioCompromisso = repositorioCompromisso;
        }

        public void btnFiltrar_Click(object sender, EventArgs e)
        {
            listaFiltrada = new List<Compromisso>();
            if (rdBtnVisualizarTodos.Checked)
            {
                listaFiltrada = repositorioCompromisso.RetornarTodos();
            }
            else if (rdBtnVisualizarFuturos.Checked)
            {
                listaFiltrada = repositorioCompromisso.RetornarCompromissosParaOFuturo();
            }
            else if (rdBtnVisualizarPassados.Checked)
            {
                listaFiltrada = repositorioCompromisso.RetornarCompromissosParaOPassado();
            }
        }
    }
}
