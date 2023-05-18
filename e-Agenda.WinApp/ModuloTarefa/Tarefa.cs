using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloTarefa
{
    internal class Tarefa
    {
        public int id;
        public string titulo;
        public string prioridade;

        public Tarefa(int id, string titulo, string prioridade)
        {
            this.id = id;
            this.titulo = titulo;
            this.prioridade = prioridade;
        }

        public override string ToString()
        {
            return "Id: " + id + ", " + titulo + ", Prioridade: " + prioridade;
        }
    }
}
