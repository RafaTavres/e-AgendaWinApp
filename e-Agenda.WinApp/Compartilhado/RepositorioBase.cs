using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.Compartilhado
{
    public abstract class RepositorioBase<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        protected int id = 1;
        protected List<TEntidade> listaEntidades = new List<TEntidade>();
        private int IncrementaId()
        {
            return id++;
        }
        public void Inserir(TEntidade entidade)
        {
            entidade.id = id;
            listaEntidades.Add(entidade);
            IncrementaId();
        }
        public void Atualizar(int id, TEntidade entidade)
        {
            TEntidade entidade2 = Busca(id);
            entidade2.Atualizar(entidade);
        }
        public virtual TEntidade Busca(int id)
        {
            return listaEntidades.FirstOrDefault(x => x.id == id);

        }
        public void Deletar(int id)
        {
             listaEntidades.Remove(Busca(id));
            
        }
        public virtual List<TEntidade> RetornarTodos()
        {
            return listaEntidades;
        }
    }
}
