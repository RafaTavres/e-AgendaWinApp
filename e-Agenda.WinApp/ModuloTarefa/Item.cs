using e_Agenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloTarefa
{
    public class Item : EntidadeBase<Item>
    {
        public string titulo;
        public string descricao;
        public DateTime dataCriacao;
        public DateTime dataConclusao;
        public bool estahConcluida;

        public Item(string titulo, string descricao, DateTime dataCriacao, bool estahConcluida)
        {
            this.titulo = titulo;
            this.descricao = descricao;
            this.dataCriacao = dataCriacao;
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
                return $"Título: {titulo}, Descrição: {descricao}, Data de Criação: {dataCriacao}, Data de Conclusão: {dataConclusao.ToString("dd/MMM/yyyy")}, Concluída: Sim";
            }
            return $"Título: {titulo}, Descrição: {descricao}, Data de Criação: {dataCriacao.ToString("dd/MMM/yyyy")}, Concluída: Não";
        }
    }
}
