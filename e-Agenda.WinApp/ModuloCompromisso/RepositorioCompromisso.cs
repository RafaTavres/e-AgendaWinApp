using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioBase
    {
        public RepositorioCompromisso(List<EntidadeBase> listaDeEntidades)
        {
            listaEntidades = listaDeEntidades;
        }
        public override Compromisso Busca(int id)
        {
            return (Compromisso)base.Busca(id);
        }

        public override bool VerificaObjetosComErro(EntidadeBase entidade)
        {
            throw new NotImplementedException();
        }
    }
}
