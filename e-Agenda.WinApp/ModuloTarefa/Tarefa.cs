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
        public DateTime dataPrazo;
        public DateTime dataConclusao;
        public double percentualConcluido;
        public PrioridadeTarefaEnum prioridade;
        public bool estahConcluida;
        public List<Item> itens;

        public Tarefa(string titulo, string descricao, DateTime dataCriacao, double percentualConcluido, PrioridadeTarefaEnum prioridade, bool estahConcluida, DateTime dataPrazo)
        {
            this.titulo = titulo;
            this.descricao = descricao;
            this.dataCriacao = dataCriacao;
            this.percentualConcluido = percentualConcluido;
            this.prioridade = prioridade;
            this.estahConcluida = estahConcluida;
            this.dataPrazo = dataPrazo;
            itens = new();
        }

        public override void Atualizar(Tarefa tarefaAtualizada)
        {
            titulo = tarefaAtualizada.titulo;
            descricao = tarefaAtualizada.descricao;
            prioridade = tarefaAtualizada.prioridade;
            dataConclusao = tarefaAtualizada.dataConclusao;
            percentualConcluido = tarefaAtualizada.percentualConcluido;
            estahConcluida = tarefaAtualizada.estahConcluida;
            dataPrazo = tarefaAtualizada.dataPrazo;
        }

        public override string ToString()
        {
            if (estahConcluida == true)
            {
                return $"Id: {id}" +
                    $" | Título: {titulo}" +
                    $" | Prioridade: {prioridade}" +
                    $" | Descrição: {descricao}" +
                    $" | Data de Criação: {dataCriacao.ToString("dd/MMM/yyyy")}" +
                    $" | Prazo: {dataPrazo.ToString("dd/MMM/yyyy")}" +
                    $" | Data de Conclusão: {dataConclusao.ToString("dd/MMM/yyyy")}" +
                    $" | Concluída: Sim";
            }
            return $"Id: {id}" +
                $" | Título: {titulo}" +
                $" | Prioridade: {prioridade}" +
                $" | Descrição: {descricao}" +
                $" | Data de Criação: {dataCriacao.ToString("dd/MMM/yyyy")}" +
                $" | Prazo: {dataPrazo.ToString("dd/MMM/yyyy")}" +
                $" | Concluída: Não";
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(titulo))
                erros.Add("O campo 'titulo' é obrigatório");

            if (string.IsNullOrEmpty(descricao))
                erros.Add("O campo 'descricao' é obrigatório");

            if (dataCriacao > dataPrazo)
                erros.Add("A data de prazo não pode ser menor que a data de criação");

            return erros.ToArray();
        }
    }
}
