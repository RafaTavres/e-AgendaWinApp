using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloContato;
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
                datePickerDataTermino.Value = value.dataConclusao;
                txtDescricao.Text = value.descricao;
            }
            get
            {
                return tarefa;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;

            string descricao = txtDescricao.Text;

            DateTime dataInicio = DateTime.Now;

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

            tarefa = new Tarefa(titulo, descricao, dataInicio, percentualConcluido, prioridadeTarefa, estahConcluida);

            if (txtId.Text != "0")
                tarefa.id = Convert.ToInt32(txtId.Text);
        }
    }
}
