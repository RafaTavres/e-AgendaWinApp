using e_Agenda.Dominio.ModuloContato;


namespace e_Agenda.Infra.Data.Memoria.ModuloContato
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
