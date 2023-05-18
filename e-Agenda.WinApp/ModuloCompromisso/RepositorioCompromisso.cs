using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class RepositorioCompromisso : RepositorioBase<Compromisso>
    {
        public RepositorioCompromisso(List<Compromisso> listaDeEntidades)
        {
            listaEntidades = listaDeEntidades;
        }
        public override Compromisso Busca(int id)
        {
            return base.Busca(id);
        }
        public List<Compromisso> RetornarCompromissosParaOFuturo(DateTime dataIncial, DateTime dataFinal)
        {
            return listaEntidades.FindAll(c => c.data >= dataIncial && c.data <= dataFinal);
        }
        public List<Compromisso> RetornarCompromissosParaOPassado()
        {
            return listaEntidades.FindAll(c => c.data <= DateTime.UtcNow);
        }

        public override bool VerificaObjetosComErro(Compromisso c)
        {
            throw new NotImplementedException();
        }
    }
}
