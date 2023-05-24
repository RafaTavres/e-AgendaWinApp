using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloDespesas
{
    public class RepositorioCategoria : RepositorioBase<Categoria>
    {
        public RepositorioCategoria(List<Categoria> listaDeEntidades)
        {
            listaEntidades = listaDeEntidades;
        }
        public override Categoria Busca(int id)
        {
            return base.Busca(id);
        }
    }
}
