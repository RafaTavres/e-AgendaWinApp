using e_Agenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloContato
{
    public class RepositorioContato : RepositorioBase
    {
        public RepositorioContato(List<EntidadeBase> listaDeEntidades)
        {
            listaEntidades = listaDeEntidades;
        }
        public override Contato Busca(int id)
        {
            return (Contato)base.Busca(id);
        }

        public override bool VerificaObjetosComErro(EntidadeBase entidade)
        {
            throw new NotImplementedException();
        }

    }
}
