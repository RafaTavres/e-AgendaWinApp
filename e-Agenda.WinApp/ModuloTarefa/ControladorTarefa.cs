﻿using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase
    {
        private ListagemTarefaControl listagemTarefa;
        private RepositorioTarefa repositorioTarefas;
        public ControladorTarefa(RepositorioBase<Tarefa> repositorio)
        {
            this.repositorioTarefas = (RepositorioTarefa?)repositorio;
        }
        public override string ToolTipInserir  =>  "Inserir nova Tarefa";  

        public override string ToolTipEditar  =>  "Editar Tarefa existente";  

        public override string ToolTipExcluir  =>  "Excluir Tarefa existente";  

        public override string ToolTipFiltrar => "Não habiltato";  
    
        public override bool BotaoInserirAtivado  =>  true;   

        public override bool BotaoDeletarAtivado  =>  true;  

        public override bool BotaoEditarAtivado  =>  true;  

        public override bool BotaoFiltrarAtivado  =>  true;  

        public override string ToolTipAdicionarItens  =>  "Adicionar Items a Tarefa";  

        public override string ToolTipEditarItens  =>  "Editar Items  de uma Tarefa existente";  

        public override bool BotaoAdicionarItensAtivado  =>  true;  

        public override bool BotaoEditarItensAtivado  =>  true;  

        public override void Editar()
        {
            Tarefa tarefa = listagemTarefa.ObterTarefaSelecionada();

            if (tarefa == null)
            {
                MessageBox.Show($"Selecione uma Tarefa primeiro!",
                    "Edição de Tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaTarefaForm telaTarefa = new TelaTarefaForm();
            telaTarefa.Tarefa = tarefa;

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTarefas.Atualizar(telaTarefa.Tarefa.id, telaTarefa.Tarefa);
                CarregarTarefas();
            }
        }

        public override void Deletar()
        {
            Tarefa tarefa = listagemTarefa.ObterTarefaSelecionada();

            if (tarefa == null)
            {
                MessageBox.Show($"Selecione uma Tarefa primeiro!",
                    "Exclusão de Tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir a Tarefa {tarefa.titulo}?", "Exclusão de Compromissos",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioTarefas.Deletar(tarefa.id);

                CarregarTarefas();
            }
        }
        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefas.RetornarTodos();
            listagemTarefa.AtualizarRegistros(tarefas);
        }

        public override void Filtrar()
        {
            throw new NotImplementedException();
        }

        public override void Inserir()
        {
            TelaTarefaForm telaTarefa = new TelaTarefaForm();

            DialogResult opcaoEscolhida = telaTarefa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Tarefa tarefa = telaTarefa.Tarefa;

                repositorioTarefas.Inserir(tarefa);

                CarregarTarefas();
            }
        }

        public override UserControl ObterListagem()
        {
            if (listagemTarefa == null)
                listagemTarefa = new ListagemTarefaControl();

            CarregarTarefas();

            return listagemTarefa;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Tarefas";
        }

        public override void AdicionarItemsNaListaDeTarefa()
        {
            Tarefa tarefa = listagemTarefa.ObterTarefaSelecionada();

            TelaAdicionarItemsNaTarefaForm telaItem = new();
            telaItem.ShowDialog();

            if(telaItem.DialogResult == DialogResult.OK)
            {
                Item item = telaItem.Item;
                tarefa.itens.Add(item);
                CarregarTarefas();
            }
        }

        public override void EditarItensDaTarefa()
        {
            TelaEditarItemsDaTarefaForm telaEditarItems = new();

            Tarefa tarefa = listagemTarefa.ObterTarefaSelecionada();

            telaEditarItems.AlterarPercentualConcluido(tarefa.percentualConcluido);

            //telaEditarItems.AlterarCorDeFundoDasTarefasConcluidas();

            telaEditarItems.AlterarListaDeItems(tarefa.itens);

            telaEditarItems.ShowDialog();

            if (telaEditarItems.DialogResult == DialogResult.OK)
            {
                List<Item> itensCheckados = telaEditarItems.RetornarItemsChecados();                

                repositorioTarefas.CheckaItemsCompletos(itensCheckados, tarefa.itens);

                tarefa.percentualConcluido = repositorioTarefas.CalculaPorcentagemConcluida(itensCheckados,tarefa.itens);

                repositorioTarefas.FinalizaTarefa(tarefa);

                CarregarTarefas();
            }           

        }
    }
}
