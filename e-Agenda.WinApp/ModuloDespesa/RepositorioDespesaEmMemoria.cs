using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloDespesas
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
