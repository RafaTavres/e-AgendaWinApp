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
        public TelaEditarItemsDaTarefaForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public void AlterarListaDeItems(List<Item> listaDeItens)
        {
            checkListItemsDaTarefa.Items.Clear();
            foreach (var item in listaDeItens)
            {
                checkListItemsDaTarefa.Items.Add(item);
            }
        }
        public void AlterarPercentualConcluido(decimal percentualConcluido)
        {
            lblPorcentagemConcluida.Text = $"{Math.Round(percentualConcluido,2)}% Conluído";
        }
      


        public List<Item> RetornarItemsChecados()
        {
            List<Item> itensChecados = new List<Item>();

            foreach (var item in checkListItemsDaTarefa.Items)
            {
                if (checkListItemsDaTarefa.CheckedItems.Contains(item))
                {
                    itensChecados.Add((Item)item);
                }
            }
            return itensChecados;
        }


    }
}
