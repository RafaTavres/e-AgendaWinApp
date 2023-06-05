using e_Agenda.Dominio.ModuloCategoria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.Infra.Data.Memoria.ModuloCategoria
{
    public class RepositorioCategoriaEmMemoria : RepositorioBaseEmMemoria<Categoria>, IRepositorioCategoria
    {
        public RepositorioCategoriaEmMemoria(List<Categoria> listaDeEntidades)
        {
            listaEntidades = listaDeEntidades;
        }
        public override Categoria Busca(int id)
        {
            return base.Busca(id);
        }
    }
}
