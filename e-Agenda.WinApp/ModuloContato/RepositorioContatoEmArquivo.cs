using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloContato
{
    internal class RepositorioContatoEmArquivo : RepositorioBaseEmArquivo<Contato>, IRepositorioContato
    {
        public RepositorioContatoEmArquivo(ContextoDados contexto) : base(contexto)
        {
        }

        protected override List<Contato> ObterRegistros()
        {
            return contextoDados.contatos;
        }
    }
}
