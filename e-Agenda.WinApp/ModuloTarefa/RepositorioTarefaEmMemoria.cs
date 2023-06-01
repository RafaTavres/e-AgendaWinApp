using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloTarefa.Dominio;

namespace e_Agenda.WinApp.ModuloTarefa
{
    internal class RepositorioTarefaEmMemoria : RepositorioBaseEmMemoria<Tarefa>, IRepositorioTarefa
    {
        public RepositorioTarefaEmMemoria(List<Tarefa> listaDeEntidades)
        {
            listaEntidades = listaDeEntidades;
        }
        public override Tarefa Busca(int id)
        {
            return base.Busca(id);
        }


        public void Editar(int id, Tarefa tarefa)
        {
            Atualizar(id,tarefa);
        }

        public void Excluir(Tarefa tarefaSelecionada)
        {
            Deletar(tarefaSelecionada.id);
        }


        public List<Tarefa> RetornarTarefasComPrioridadeAlta()
        {
            return listaEntidades.FindAll(t => t.prioridade == PrioridadeTarefaEnum.Alta);
        }

        public List<Tarefa> RetornarTarefasComPrioridadeMedia()
        {
            return listaEntidades.FindAll(t => t.prioridade == PrioridadeTarefaEnum.Media);
        }

        public List<Tarefa> RetornarTarefasComPrioridadeBaixa()
        {
            return listaEntidades.FindAll(t => t.prioridade == PrioridadeTarefaEnum.Baixa);
        }

        public List<Tarefa> RetornarTarefasPendentes()
        {
            return listaEntidades.FindAll(t => t.statusDaTarefa == StatusTarefaEnum.Pendente);
        }

        public List<Tarefa> RetornarTarefasConcluidas()
        {
            return listaEntidades.FindAll(t => t.statusDaTarefa == StatusTarefaEnum.Concluida);
        }

        public List<Tarefa> SelecionarTodosOrdenadosPorPrioridade()
        {
            return listaEntidades
                .OrderByDescending(t => t.prioridade)
                .ToList();
        }

        public void MarcaItemsCompletos(List<Item> itemsCheckados, List<Item> itemsAtuais)
        {
            foreach (var itemCheckado in itemsCheckados)
            {
                foreach (var itemAtual  in itemsAtuais)
                {
                    if(itemAtual == itemCheckado)
                    {
                         itemAtual.estahConcluida = true;
                         itemAtual.dataConclusao = DateTime.Now.Date;
                        
                    }                   
                }
            }           
        }

        public void DesmarcaItemsImcompletos(List<Item> itemsDesmarcados, List<Item> itemsAtuais)
        {
            foreach (var itemDesmarcado in itemsDesmarcados)
            {
                foreach (var itemAtual in itemsAtuais)
                {
                    if (itemAtual == itemDesmarcado)
                    {
                        itemAtual.estahConcluida = false;
                        itemAtual.dataConclusao = DateTime.MinValue;
                        
                    }
                }
            }
        }


        public List<Item> RetornarItemsConcluidos(List<Item> itensChecados)
        {
            List<Item> itensConcluidos = new();

            foreach (var item in itensChecados)
            {
                if (item.estahConcluida == true)
                {
                    itensConcluidos.Add(item);
                }
            }
            return itensConcluidos;
        }

    }
}
