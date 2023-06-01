using e_Agenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloContato
{
    public class RepositorioContatoEmMemoria : RepositorioBaseEmMemoria<Contato>, IRepositorioContato
    {
        public RepositorioContatoEmMemoria(List<Contato> listaDeEntidades)
        {
            listaEntidades = listaDeEntidades;
        }
        public override Contato Busca(int id)
        {
            return base.Busca(id);
        }


    }
}
