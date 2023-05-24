﻿using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloDespesas.Dominio;
using System.Collections.Generic;
using System.Data;


namespace e_Agenda.WinApp.ModuloDespesas.Tela_Despesa
{
    public partial class TelaDespesaForm : Form
    {
        private Despesa despesa;
        RepositorioCategoria repositorioCategoria;
        public Despesa Despesa
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtDescricao.Text = value.descricao;
                txtValor.Text = value.valor.ToString();
                datePickerDataDaDespesa.Value = value.data.Date;
            }
            get
            {
                return despesa;
            }
        }


        public TelaDespesaForm(RepositorioCategoria repositorioCategoria)
        {
            InitializeComponent();
            this.repositorioCategoria = repositorioCategoria;
            ConfigurarLista();
            this.ConfigurarDialog();
        }

        private void ConfigurarLista()
        {
            foreach (Categoria item in repositorioCategoria.RetornarTodos())
            {
                listaCategorias.Items.Add(item);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            despesa = ObterDespesa();

            string[] erros = despesa.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }

            if (txtId.Text != "0")
                despesa.id = Convert.ToInt32(txtId.Text);
        }

        private Despesa ObterDespesa()
        {
            string descricao = txtDescricao.Text;
            decimal? valor = 0;
            try
            {
                valor = Convert.ToDecimal(txtValor.Text);
            }
            catch (FormatException)
            {
                valor = null;
            }

            DateTime data = datePickerDataDaDespesa.Value.Date;

            string? formaPagamento = ObterFormaPagamento();

            List<Categoria> listaDeCategorias = RetornarCategoriasChecados();

            return despesa = new Despesa(descricao, valor, data, formaPagamento, listaDeCategorias);
        }

        public List<Categoria> RetornarCategoriasChecados()
        {
            return listaCategorias.CheckedItems.Cast<Categoria>().ToList();
        }
        public string? ObterFormaPagamento()
        {
            if (listaFormaPagamento.SelectedItem == "Dinheiro")
            {
                return (string?)listaFormaPagamento.SelectedItem;
            }
            if (listaFormaPagamento.SelectedItem == "PIX")
            {
                return (string?)listaFormaPagamento.SelectedItem;
            }
            if (listaFormaPagamento.SelectedItem == "Cartão")
            {
                return (string?)listaFormaPagamento.SelectedItem;
            }
            return null;
        }
    }
}
