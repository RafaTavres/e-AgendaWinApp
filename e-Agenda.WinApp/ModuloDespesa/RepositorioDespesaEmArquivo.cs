using e_Agenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloDespesas
{
    public class RepositorioDespesaEmArquivo : RepositorioBaseEmArquivo<Despesa>, IRepositorioDespesa
    {
        public RepositorioDespesaEmArquivo(ContextoDados contexto) : base(contexto)
        {

        }

        protected override List<Despesa> ObterRegistros()
        {
            return contextoDados.despesas;
        }
    }
}
