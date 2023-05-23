﻿using System;
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
        }

        public void AlterarListaDeItems(List<Item> listaDeItens)
        {
            checkListItemsDaTarefa.Items.Clear();
            foreach (var item in listaDeItens)
            {
                checkListItemsDaTarefa.Items.Add(item);
            }
        }
        public void AlterarPercentualConcluido(double percentualConcluido)
        {
            lblPorcentagemConcluida.Text = $"{percentualConcluido}% Conluído";
        }
        //public void AlterarCorDeFundoDasTarefasConcluidas()
        //{
        //    foreach (var item in checkListItemsDaTarefa.Items)
        //    {
        //        if (checkListItemsDaTarefa.CheckedItems.Contains(item))
        //        {
        //            checkListItemsDaTarefa.Enabled = false;
        //        }
        //    }
        //}
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