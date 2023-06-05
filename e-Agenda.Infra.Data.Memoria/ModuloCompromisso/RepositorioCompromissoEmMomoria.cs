
using e_Agenda.Dominio.ModuloCompromisso;

namespace e_Agenda.Infra.Data.Memoria.ModuloCompromisso
{
    public class RepositorioCompromissoEmMomoria : RepositorioBaseEmMemoria<Compromisso>, IRepositorioCompromisso
    {
        public RepositorioCompromissoEmMomoria(List<Compromisso> listaDeEntidades)
        {
            listaEntidades = listaDeEntidades;
        }
        public override Compromisso Busca(int id)
        {
            return base.Busca(id);
        }
        public List<Compromisso> RetornarCompromissosParaOFuturo(DateTime dataIncial, DateTime dataFinal)
        {
            return listaEntidades.FindAll(c => c.data.Date >= dataIncial.Date && c.data <= dataFinal.Date);
        }
        public List<Compromisso> RetornarCompromissosParaOPassado()
        {
            return listaEntidades.FindAll(c => c.data.Date <= DateTime.UtcNow.Date);
        }

    }
}
