using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloTarefa.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class Tarefa : EntidadeBase<Tarefa>
    {
        public string titulo;
        public string descricao;
        public DateTime dataCriacao;
        public DateTime dataConclusao;
        public double percentualConcluido;
        public PrioridadeTarefaEnum prioridade;
        public bool estahConcluida;
        public List<Item> itens;

        public Tarefa(string titulo, string descricao, DateTime dataCriacao, double percentualConcluido, PrioridadeTarefaEnum prioridade, bool estahConcluida)
        {
            this.titulo = titulo;
            this.descricao = descricao;
            this.dataCriacao = dataCriacao;
            this.percentualConcluido = percentualConcluido;
            this.prioridade = prioridade;
            this.estahConcluida = estahConcluida;
            itens = new();
        }

        public override void Atualizar(Tarefa tarefaAtualizada)
        {
            titulo = tarefaAtualizada.titulo;
            descricao = tarefaAtualizada.descricao;
            prioridade = tarefaAtualizada.prioridade;
            dataCriacao = tarefaAtualizada.dataCriacao;
            dataConclusao = tarefaAtualizada.dataConclusao;
            percentualConcluido = tarefaAtualizada.percentualConcluido;
            estahConcluida = tarefaAtualizada.estahConcluida;
        }

        public override string ToString()
        {
            if (estahConcluida == true)
            {
                return $"Id: {id}, Título: {titulo}, Prioridade: {prioridade}, Descrição: {descricao}, Data de Criação: {dataCriacao.ToString("dd/MMM/yyyy")}, Data de Conclusão: {dataConclusao.ToString("dd/MMM/yyyy")}, Concluída: Sim";
            }
            return $"Id: {id}, Título: {titulo}, Prioridade: {prioridade}, Descrição: {descricao}, Data de Criação: {dataCriacao.ToString("dd/MMM/yyyy")}, Concluída: Não";
        }
    }
}
