namespace e_Agenda.Dominio.Compartilhado
{
    [Serializable]
    public abstract class EntidadeBase<TEntidade>
    {
        public int id;

        public abstract void Atualizar(TEntidade entidadeAtualizada);

        public abstract string[] Validar();
    }
   
}
