using e_Agenda.Dominio.ModuloCompromisso;

namespace e_Agenda.Infra.Data.Arquivo.ModuloCompromisso
{
    public class RepositorioCompromissoEmArquivo : RepositorioBaseEmArquivo<Compromisso>, IRepositorioCompromisso
    {
        public RepositorioCompromissoEmArquivo(ContextoDados contexto) : base(contexto)
        {

        }

        public List<Compromisso> RetornarCompromissosParaOFuturo(DateTime dataIncial, DateTime dataFinal)
        {
            return ObterRegistros().FindAll(c => c.data.Date >= dataIncial.Date && c.data <= dataFinal.Date);
        }
        public List<Compromisso> RetornarCompromissosParaOPassado()
        {
            return ObterRegistros().FindAll(c => c.data.Date <= DateTime.UtcNow.Date);
        }

        protected override List<Compromisso> ObterRegistros()
        {
            return contextoDados.compromissos;
        }
    }
}
