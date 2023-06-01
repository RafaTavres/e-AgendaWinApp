using e_Agenda.WinApp.ModuloTarefa.Dominio;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class RepositorioTarefaEmArquivo : RepositorioBaseEmArquivo<Tarefa>, IRepositorioTarefa
    {
        public RepositorioTarefaEmArquivo(ContextoDados contexto) : base(contexto)
        {

        }

        public void DesmarcaItemsImcompletos(List<Item> itensPendentes, List<Item> itens)
        {
            foreach (var itemDesmarcado in itensPendentes)
            {
                foreach (var itemAtual in itens)
                {
                    if (itemAtual == itemDesmarcado)
                    {
                        itemAtual.estahConcluida = false;
                        itemAtual.dataConclusao = DateTime.MinValue;

                    }
                }
            }
        }



        public void MarcaItemsCompletos(List<Item> itensCheckados, List<Item> itens)
        {
            foreach (var itemCheckado in itensCheckados)
            {
                foreach (var itemAtual in itens)
                {
                    if (itemAtual == itemCheckado)
                    {
                        itemAtual.estahConcluida = true;
                        itemAtual.dataConclusao = DateTime.Now.Date;

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






        public List<Tarefa> RetornarTarefasComPrioridadeAlta()
        {
            return ObterRegistros()
                   .Where(x => x.prioridade == PrioridadeTarefaEnum.Alta)
                   .ToList();
        }

        public List<Tarefa> RetornarTarefasComPrioridadeBaixa()
        {
            return ObterRegistros()
                   .Where(x => x.prioridade == PrioridadeTarefaEnum.Baixa)
                   .ToList();
        }

        public List<Tarefa> RetornarTarefasComPrioridadeMedia()
        {
            return ObterRegistros()
                  .Where(x => x.prioridade == PrioridadeTarefaEnum.Media)
                  .ToList();
        }

        public List<Tarefa> RetornarTarefasConcluidas()
        {
            return ObterRegistros()
                   .Where(x => x.statusDaTarefa == StatusTarefaEnum.Concluida)
                   .ToList();
        }

        public List<Tarefa> RetornarTarefasPendentes()
        {
            return ObterRegistros()
                    .Where(x => x.statusDaTarefa == StatusTarefaEnum.Pendente)
                    .ToList();
        }

        public List<Tarefa> SelecionarTodosOrdenadosPorPrioridade()
        {
            return ObterRegistros()
                .OrderByDescending(x => x.prioridade)
                .ToList();
        }

        protected override List<Tarefa> ObterRegistros()
        {
            return contextoDados.tarefas; 
        }
    }
}
