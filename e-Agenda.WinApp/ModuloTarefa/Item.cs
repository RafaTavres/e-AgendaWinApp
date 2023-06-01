using e_Agenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloTarefa
{
    [Serializable]
    public class Item : EntidadeBase<Item>
    {
        public string titulo;
        public string descricao;
        public DateTime dataCriacao;
        public DateTime dataConclusao;
        public bool estahConcluida;

        public Item()
        {
            
        }
        public Item(string titulo, string descricao, DateTime dataCriacao, DateTime dataConclusao, bool estahConcluida)
        {
            this.titulo = titulo;
            this.descricao = descricao;
            this.dataCriacao = dataCriacao;
            this.dataConclusao = dataConclusao;
            this.estahConcluida = estahConcluida;
        }


        public override void Atualizar(Item itemAtualizado)
        {
            titulo = itemAtualizado.titulo;
            descricao = itemAtualizado.descricao;
            dataCriacao = itemAtualizado.dataCriacao;
            dataConclusao = itemAtualizado.dataConclusao;
            estahConcluida = itemAtualizado.estahConcluida;
        }
        public override string ToString()
        {
            if (estahConcluida == true)
            {              
                return $"Título: {titulo}" +
                    $"  |   Descrição: {descricao}" +
                    $"  |   Data de Criação: {dataCriacao.ToString("dd/MMM/yyyy")}" +
                    $"  |   Data de Conclusão: {dataConclusao.ToString("dd/MMM/yyyy")}" +
                    $"  |   Concluída: Sim";
            }
            return $"Título: {titulo}" +
                $"  |    Descrição: {descricao}" +
                $"  |    Data de Criação: {dataCriacao.ToString("dd/MMM/yyyy")}" +
                $"  |    Concluída: Não";
        }

        public override string[] Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(titulo))
                erros.Add("O campo 'titulo' é obrigatório");

            if (string.IsNullOrEmpty(descricao))
                erros.Add("O campo 'descricao' é obrigatório");

            if (dataCriacao > dataConclusao)
                erros.Add("A data de conclusão não pode ser menor que a data de criação");

            return erros.ToArray();
         }   
    }
}
