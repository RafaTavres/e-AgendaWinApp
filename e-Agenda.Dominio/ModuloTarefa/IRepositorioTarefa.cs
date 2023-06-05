namespace e_Agenda.Dominio.ModuloTarefa
{
    public interface IRepositorioTarefa : IRepositorio<Tarefa>
    {
        List<Tarefa> RetornarTarefasConcluidas();
        List<Tarefa> RetornarTarefasPendentes();
        List<Tarefa> SelecionarTodosOrdenadosPorPrioridade();
        List<Tarefa> RetornarTarefasComPrioridadeAlta();

        List<Tarefa> RetornarTarefasComPrioridadeMedia();

        List<Tarefa> RetornarTarefasComPrioridadeBaixa();       
        List<Item> RetornarItemsConcluidos(List<Item> itens);
        void MarcaItemsCompletos(List<Item> itensCheckados, List<Item> itens);
        void DesmarcaItemsImcompletos(List<Item> itensPendentes, List<Item> itens);
    }
}
