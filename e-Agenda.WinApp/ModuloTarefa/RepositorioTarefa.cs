using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCompromisso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void CheckaItemsCompletos(List<Item> itemsCheckados, List<Item> itemsAtuais)
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
                    else
                    {
                        itemAtual.estahConcluida = false;
                        itemAtual.dataConclusao = DateTime.MinValue;
                    }
                }
            }           
        }

        public double CalculaPorcentagemConcluida(List<Item> itemsCheckados,List<Item> itemsAtuais)
        {
            double f = itemsAtuais.Count() / itemsCheckados.Count();
            double porcentagem = 100 / f;                          
            return porcentagem;
        }

        public void FinalizaTarefa(Tarefa tarefa)
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

        public override bool VerificaObjetosComErro(Tarefa t)
        {
            throw new NotImplementedException();
        }
    }
}
