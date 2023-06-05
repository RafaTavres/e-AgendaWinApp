using e_Agenda.Dominio.ModuloDespesas;

namespace e_Agenda.Infra.Data.Memoria.ModuloDespesas
{
    public class RepositorioDespesaEmMemoria : RepositorioBaseEmMemoria<Despesa>, IRepositorioDespesa
    {
        public RepositorioDespesaEmMemoria(List<Despesa> listaDeEntidades)
        {
            listaEntidades = listaDeEntidades;
        }
        public override Despesa Busca(int id)
        {
            return base.Busca(id);
        }
    }
}
