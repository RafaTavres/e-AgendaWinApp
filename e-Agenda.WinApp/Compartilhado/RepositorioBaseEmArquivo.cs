
using e_Agenda.WinApp.ModuloCompromisso;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Xml.Serialization;

namespace e_Agenda.WinApp.Compartilhado
{
    
    public abstract class RepositorioBaseEmArquivo<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        protected int id = 1;
        protected ContextoDados contextoDados;
       

        public RepositorioBaseEmArquivo(ContextoDados contexto)
        {
            contextoDados = contexto;

            IncrementaId();
        }

        protected abstract List<TEntidade> ObterRegistros();


        private int IncrementaId()
        {
            AtualizarContador();
            return id++;
        }
        public void Inserir(TEntidade entidade)
        {
            List<TEntidade> listaEntidades = ObterRegistros();


            entidade.id = id;
            listaEntidades.Add(entidade);
            IncrementaId();
            contextoDados.GravarEntidadesEmArquivoJson();
        }
        public void Atualizar(int id, TEntidade entidade)
        {
            TEntidade entidadeAtual = Busca(id);

            entidadeAtual.Atualizar(entidade);

            contextoDados.GravarEntidadesEmArquivoJson();
        }
        public virtual TEntidade Busca(int id)
        {
            List<TEntidade> listaEntidades = ObterRegistros();

            return listaEntidades.FirstOrDefault(x => x.id == id);

        }
        public void Deletar(int id)
        {
            List<TEntidade> listaEntidades = ObterRegistros();
            listaEntidades.Remove(Busca(id));
            contextoDados.GravarEntidadesEmArquivoJson();
        }

        public virtual List<TEntidade> RetornarTodos()
        {
            return ObterRegistros();
        }

        private void AtualizarContador()
        {
            if(ObterRegistros().Count != 0)
                id = ObterRegistros().Max(x => x.id);

        }
    }
}
