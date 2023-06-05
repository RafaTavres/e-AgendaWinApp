namespace e_Agenda.Dominio.Compartilhado
{
    public interface IRepositorio<TEntidade>
    {
        void Inserir(TEntidade novaEntidade);
        void Atualizar(int id, TEntidade entidade);
        void Deletar(int id);
        List<TEntidade> RetornarTodos();
        TEntidade Busca(int id);

    }

}
