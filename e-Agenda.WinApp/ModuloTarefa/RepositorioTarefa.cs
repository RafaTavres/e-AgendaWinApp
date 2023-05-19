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

        public override bool VerificaObjetosComErro(Tarefa t)
        {
            throw new NotImplementedException();
        }
    }
}
