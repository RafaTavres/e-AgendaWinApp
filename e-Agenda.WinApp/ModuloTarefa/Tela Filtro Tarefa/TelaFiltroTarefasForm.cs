using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCompromisso.Dominio;
using e_Agenda.WinApp.ModuloTarefa.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

    }
}
