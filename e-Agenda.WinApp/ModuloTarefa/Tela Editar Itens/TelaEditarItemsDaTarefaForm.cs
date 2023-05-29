using e_Agenda.WinApp.Compartilhado;
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
    public partial class TelaEditarItemsDaTarefaForm : Form
    {
        public TelaEditarItemsDaTarefaForm(Tarefa tarefa)
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public void AlterarListaDeItems(List<Item> listaDeItens)
        {
            checkListItemsDaTarefa.Items.Clear();
            int i = 0;
            foreach (var item in listaDeItens)
            {
                checkListItemsDaTarefa.Items.Add(item);
                if (item.estahConcluida)
                    checkListItemsDaTarefa.SetItemChecked(i, true);

                i++;
            }
        }
        public void AlterarPercentualConcluido(decimal percentualConcluido)
        {
            lblPorcentagemConcluida.Text = $"{Math.Round(percentualConcluido, 2)}% Conluído";
        }

        public List<Item> RetornarItemsChecados()
        {
            return checkListItemsDaTarefa.CheckedItems.Cast<Item>().ToList();
        }

        public List<Item> ObterItensPendentes()
        {
            return checkListItemsDaTarefa.Items.Cast<Item>()
                .Except(RetornarItemsChecados())
                .ToList();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

        }


    }
}
