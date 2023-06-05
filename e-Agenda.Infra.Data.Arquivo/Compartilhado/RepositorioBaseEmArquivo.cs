using e_Agenda.Dominio.Compartilhado;

namespace e_Agenda.Infra.Data.Arquivo.Compartilhado
{
    
    public abstract class RepositorioBaseEmArquivo<TEntidade> where TEntidade : EntidadeBase<TEntidade>
    {
        protected int id = 1;
        protected ContextoDados contextoDados;
       

        public RepositorioBaseEmArquivo(ContextoDados contexto)
        {
            contextoDados = contexto;
            AtualizarContador();
        }

        protected abstract List<TEntidade> ObterRegistros();

        public void Inserir(TEntidade entidade)
        {
            List<TEntidade> listaEntidades = ObterRegistros();
            AtualizarContador();

            entidade.id = id;
            listaEntidades.Add(entidade);
            id++;
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
            if (ObterRegistros().Count != 0)
            {
                id = ObterRegistros().Max(x => x.id);
                id++;
            }              
        }
    }
}
