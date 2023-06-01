using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloCompromisso.Dominio;
using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloTarefa.Dominio;
using e_Agenda.WinApp.ModuloTarefa.Tela_Filtro_Tarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class ControladorTarefa : ControladorBase
    {
        private TabelaTarefaControl tabelaTarefa;
        private IRepositorioTarefa repositorioTarefas;
        public ControladorTarefa(IRepositorioTarefa repositorio)
        {
            repositorioTarefas = repositorio;
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

        public override string ToolTipCategoriasDasDespesas => "Não habiltato";

        public override bool BotaoCategoriasDasDespesasAtivado => false;

        public override void Editar()
        {
            Tarefa tarefa = ObterTarefaSelecionada();

            if (tarefa == null)
            {
                MessageBox.Show($"Selecione uma Tarefa primeiro!",
                    "Edição de Tarefas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaTarefaForm telaTarefa = new TelaTarefaForm(ehEdicao: true);
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
            Tarefa tarefa = ObterTarefaSelecionada();

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
            List<Tarefa> tarefas = repositorioTarefas.SelecionarTodosOrdenadosPorPrioridade();
            tabelaTarefa.AtualizarRegistros(tarefas);
        }



        public override void Filtrar()
        {
            TelaFiltroTarefasForm telaFiltro = new();

            if (telaFiltro.ShowDialog() == DialogResult.OK)
            {
                PrioridadeTarefaEnum prioridadeTarefa = telaFiltro.PrioridadeTarefa;
                StatusTarefaEnum? statusTarefa = telaFiltro.StatusDaTarefa;
                CarregarCompromissosComFiltro(prioridadeTarefa, statusTarefa);
            }
        }



        private void CarregarCompromissosComFiltro(PrioridadeTarefaEnum prioridadeTarefa, StatusTarefaEnum? statusTarefa)
        {

            List<Tarefa> tarefas;

            switch (statusTarefa)
            {
                case StatusTarefaEnum.Pendente:
                    tarefas = repositorioTarefas.RetornarTarefasPendentes();
                    break;
                case StatusTarefaEnum.Concluida:
                    tarefas = repositorioTarefas.RetornarTarefasConcluidas();
                    break;              
                default:
                    tarefas = repositorioTarefas.SelecionarTodosOrdenadosPorPrioridade();
                    break;
            }

            if (statusTarefa == null)
            {
                switch (prioridadeTarefa)
                {
                    case PrioridadeTarefaEnum.Alta:
                        tarefas = repositorioTarefas.RetornarTarefasComPrioridadeAlta();
                        break;
                    case PrioridadeTarefaEnum.Media:
                        tarefas = repositorioTarefas.RetornarTarefasComPrioridadeMedia();
                        break;
                    case PrioridadeTarefaEnum.Baixa:
                        tarefas = repositorioTarefas.RetornarTarefasComPrioridadeBaixa();
                        break;
                    default:
                        tarefas = repositorioTarefas.SelecionarTodosOrdenadosPorPrioridade();
                        break;
                }
            }

            tabelaTarefa.AtualizarRegistros(tarefas);
        }


        public override void Inserir()
        {
            TelaTarefaForm telaTarefa = new TelaTarefaForm(ehEdicao: false);

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
            if (tabelaTarefa == null)
                tabelaTarefa = new TabelaTarefaControl();

            CarregarTarefas();

            return tabelaTarefa;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Tarefas";
        }

        public override void AdicionarItemsNaListaDeTarefa()
        {
            Tarefa tarefa = ObterTarefaSelecionada();

            if (tarefa == null)
            {
                MessageBox.Show($"Selecione uma Tarefa primeiro!",
                    "Adição de Itens",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }
            


            TelaAdicionarItemsNaTarefaForm telaItem = new();

            telaItem.ShowDialog();



            if(telaItem.DialogResult == DialogResult.OK)
            {
                Item item = telaItem.Item;
                
                tarefa.itens.Add(item);

                List<Item> itensConcluidos = repositorioTarefas.RetornarItemsConcluidos(tarefa.itens);

                tarefa.CalculaPorcentagemConcluida(itensConcluidos, tarefa.itens);

                tarefa.ConcluiTarefa();

                CarregarTarefas();
            }
        }

        public override void EditarItensDaTarefa()
        {
            Tarefa tarefa = ObterTarefaSelecionada();

            TelaEditarItemsDaTarefaForm telaEditarItems = new(tarefa);

            if (tarefa == null)
            {
                MessageBox.Show($"Selecione uma Tarefa primeiro!",
                    "Edição de Itens",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            telaEditarItems.AlterarPercentualConcluido(tarefa.percentualConcluido);

            telaEditarItems.AlterarListaDeItems(tarefa.itens);

            telaEditarItems.ShowDialog();

            if (telaEditarItems.DialogResult == DialogResult.OK)
            {
                List<Item> itensCheckados = telaEditarItems.RetornarItemsChecados();
                List<Item> itensPendentes = telaEditarItems.ObterItensPendentes();


                repositorioTarefas.MarcaItemsCompletos(itensCheckados, tarefa.itens);

                repositorioTarefas.DesmarcaItemsImcompletos(itensPendentes, tarefa.itens);

                List<Item> itensConcluidos = repositorioTarefas.RetornarItemsConcluidos(tarefa.itens);

                tarefa.CalculaPorcentagemConcluida(itensConcluidos, tarefa.itens);

                tarefa.ConcluiTarefa();

                CarregarTarefas();
            }           

        }

        private Tarefa ObterTarefaSelecionada()
        {
            int id = tabelaTarefa.ObterIdSelecionado();

            return repositorioTarefas.Busca(id);
        }
    }
}
