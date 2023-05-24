using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloTarefa.Dominio;

namespace e_Agenda.WinApp.ModuloTarefa
{
    internal class RepositorioTarefa : RepositorioBase<Tarefa>
    {
        public RepositorioTarefa(List<Tarefa> listaDeEntidades)
        {
            listaEntidades = listaDeEntidades;
        }
        public override Tarefa Busca(int id)
        {
            return base.Busca(id);
        }


        public List<Tarefa> RetornarTarefasComPrioridadeAlta()
        {
            return listaEntidades.FindAll(c => c.prioridade == PrioridadeTarefaEnum.Alta);
        }

        public List<Tarefa> RetornarTarefasComPrioridadeMedia()
        {
            return listaEntidades.FindAll(c => c.prioridade == PrioridadeTarefaEnum.Media);
        }

        public List<Tarefa> RetornarTarefasComPrioridadeBaixa()
        {
            return listaEntidades.FindAll(c => c.prioridade == PrioridadeTarefaEnum.Baixa);
        }




        public void CheckaItemsCompletos(List<Item> itemsCheckados, List<Item> itemsAtuais)
        {
            foreach (var itemCheckado in itemsCheckados)
            {
                foreach (var itemAtual  in itemsAtuais)
                {
                    if(itemAtual == itemCheckado)
                    {
                        if(itemAtual.estahConcluida == false)
                        {
                            itemAtual.estahConcluida = true;
                            itemAtual.dataConclusao = DateTime.Now.Date;
                        }
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


        public decimal CalculaPorcentagemConcluida(Tarefa tarefaAtual, List<Item> itemsCheckados,List<Item> itemsAtuais)
        {
            try
            {
                decimal f = Convert.ToDecimal(itemsAtuais.Count()) / Convert.ToDecimal(itemsCheckados.Count());
                tarefaAtual.percentualConcluido = 100 / f;
            }
            catch(DivideByZeroException)
            {
                return tarefaAtual.percentualConcluido;
            }                         
            return tarefaAtual.percentualConcluido;
        }

        public void VerificaTarefaConcluida(Tarefa tarefa)
        {
            if (tarefa.percentualConcluido == 100)
            {
                tarefa.estahConcluida = true;
                tarefa.dataConclusao = DateTime.UtcNow.Date;
            }
            else
            {
                tarefa.estahConcluida = false;
                tarefa.dataConclusao = DateTime.MinValue;
            }
        }

    }
}
