using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.Compartilhado
{
    public abstract class RepositorioBase
    {
        protected int id = 1;
        protected List<EntidadeBase> listaEntidades = new List<EntidadeBase>();
        public abstract bool VerificaObjetosComErro(EntidadeBase entidade);

        private int IncrementaId()
        {
            return id++;
        }
        public void Inserir(EntidadeBase entidade)
        {
            entidade.id = id;
            listaEntidades.Add(entidade);
            IncrementaId();
        }
        public void Atualizar(int id, EntidadeBase entidade)
        {
            EntidadeBase entidade2 = Busca(id);
            entidade2.Atualizar(entidade);
        }
        public virtual EntidadeBase Busca(int id)
        {
            return listaEntidades.FirstOrDefault(x => x.id == id);

        }
        public void Deletar(int id)
        {
             listaEntidades.Remove(Busca(id));
            
        }
        public virtual List<EntidadeBase> RetornarTodos()
        {
            return listaEntidades;
        }
    }
}
