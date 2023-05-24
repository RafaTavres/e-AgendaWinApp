using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloTarefa.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;
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
        public decimal percentualConcluido;
        public PrioridadeTarefaEnum prioridade;
        public StatusTarefaEnum statusDaTarefa;
        public List<Item> itens;

        public Tarefa(string titulo, string descricao, DateTime dataCriacao, decimal percentualConcluido, PrioridadeTarefaEnum prioridade, StatusTarefaEnum statusDaTarefa, DateTime dataPrazo)
        {
            this.titulo = titulo;
            this.descricao = descricao;
            this.dataCriacao = dataCriacao;
            this.percentualConcluido = percentualConcluido;
            this.prioridade = prioridade;
            this.statusDaTarefa = statusDaTarefa;
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
            statusDaTarefa = tarefaAtualizada.statusDaTarefa;
            dataPrazo = tarefaAtualizada.dataPrazo;
        }

        public override string ToString()
        {
            if (statusDaTarefa == StatusTarefaEnum.Concluida)
            {
                return $"Id: {id}" +
                    $" | Título: {titulo}" +
                    $" | Prioridade: {prioridade}" + 
                    $" | Percentual Concluído: {Math.Round(percentualConcluido),2}" +
                    $" | Descrição: {descricao}" +
                    $" | Data de Criação: {dataCriacao.ToString("dd/MMM/yyyy")}" +
                    $" | Prazo: {dataPrazo.ToString("dd/MMM/yyyy")}" +
                    $" | Data de Conclusão: {dataConclusao.ToString("dd/MMM/yyyy")}" +
                    $" | {statusDaTarefa}";
            }
            return $"Id: {id}" +
                $" | Título: {titulo}" +
                $" | Prioridade: {prioridade}" +
                $" | Percentual Concluído: {Math.Round(percentualConcluido),2}" +
                $" | Descrição: {descricao}" +
                $" | Data de Criação: {dataCriacao.ToString("dd/MMM/yyyy")}" +
                $" | Prazo: {dataPrazo.ToString("dd/MMM/yyyy")}" +
                $" | {statusDaTarefa}";
        }

        public void ConcluiTarefa()
        {
            if (percentualConcluido == 100)
            {
                statusDaTarefa = StatusTarefaEnum.Concluida;
                dataConclusao = DateTime.UtcNow.Date;
            }
            else
            {
                statusDaTarefa = StatusTarefaEnum.Pendente;
                dataConclusao = DateTime.MinValue;
            }
        }
        public void AdicionaItem(Item item)
        {
            itens.Add(item);
        }


        public decimal CalculaPorcentagemConcluida(List<Item> itemsCheckados, List<Item> itemsAtuais)
        {
            try
            {
                decimal f = Convert.ToDecimal(itemsAtuais.Count()) / Convert.ToDecimal(itemsCheckados.Count());
                percentualConcluido = 100 / f;
            }
            catch (DivideByZeroException)
            {
                return percentualConcluido = 0;
            }
            return percentualConcluido;
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
