using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloDespesas.ModuloCategoria
{
    public class RepositorioCategoriaEmArquivo : RepositorioBaseEmArquivo<Categoria>, IRepositorioCategoria
    {
        public RepositorioCategoriaEmArquivo(ContextoDados contexto) : base(contexto)
        {

        }

        protected override List<Categoria> ObterRegistros()
        {
            return contextoDados.categorias;
        }
    }
}
