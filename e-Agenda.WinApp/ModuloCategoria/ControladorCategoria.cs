using e_Agenda.Dominio.ModuloCategoria;
using e_Agenda.Dominio.ModuloDespesas;
using e_Agenda.WinApp.ModuloDespesas;

namespace e_Agenda.WinApp.ModuloCategoria
{
    public class ControladorCategoria : ControladorBase
    {
        private IRepositorioCategoria repositorioCategoria;
        private IRepositorioDespesa repositorioDespesa;
        private TabelaCategoriasControl tabelaCategoria;



        public ControladorCategoria(IRepositorioCategoria repositorio, IRepositorioDespesa repositorioDespesa)
        {
            repositorioCategoria = repositorio;
            this.repositorioDespesa = repositorioDespesa;
        }



        public override string ToolTipInserir => "Inserir nova Categoria";

        public override string ToolTipEditar => "Editar categoria Existente";

        public override string ToolTipExcluir => "Deletar categoria Existente";

        public override string ToolTipFiltrar => "Indiponivel";

        public override string ToolTipAdicionarItens => "Indiponivel";

        public override string ToolTipEditarItens => "Indiponivel";

        public override bool BotaoInserirAtivado => true;

        public override bool BotaoDeletarAtivado => true;

        public override bool BotaoEditarAtivado => true;

        public override bool BotaoFiltrarAtivado => false;

        public override bool BotaoAdicionarItensAtivado => false;

        public override bool BotaoEditarItensAtivado => false;

        public override string ToolTipCategoriasDasDespesas => "Ver Despesas dessa Categoria";

        public override bool BotaoCategoriasDasDespesasAtivado => true;

        public override void Deletar()
        {
            Categoria categoria = ObterCategoriaSelecionada();

            if (categoria == null)
            {
                MessageBox.Show($"Selecione uma Categoria primeiro!",
                    "Exclusão de Categorias",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o despesa {categoria.titulo}?", "Exclusão de Categorias",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCategoria.Deletar(categoria.id);

                CarregarDespesas();
            }
        }




        public override void Editar()
        {
            Categoria categoria = ObterCategoriaSelecionada();

            if (categoria == null)
            {
                MessageBox.Show($"Selecione uma Categoria primeiro!",
                    "Edição de Categorias",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaCategoriaForm telaCategoria = new TelaCategoriaForm();
            telaCategoria.Categoria = categoria;

            DialogResult opcaoEscolhida = telaCategoria.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCategoria.Atualizar(telaCategoria.Categoria.id, telaCategoria.Categoria);

                CarregarDespesas();
            }
        }





        public override void Inserir()
        {
            TelaCategoriaForm telaCategoria = new TelaCategoriaForm();

            DialogResult opcaoEscolhida = telaCategoria.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Categoria categoria = telaCategoria.Categoria;

                repositorioCategoria.Inserir(categoria);

                CarregarDespesas();
            }
        }





        public override UserControl ObterListagem()
        {
            if (tabelaCategoria == null)
                tabelaCategoria = new TabelaCategoriasControl();

            CarregarDespesas();

            return tabelaCategoria;
        }



        private void CarregarDespesas()
        {
            List<Categoria> categorias = repositorioCategoria.RetornarTodos();
            tabelaCategoria.AtualizarRegistros(categorias);
        }




        public override string ObterTipoCadastro()
        {
            return "Cadastro de Contatos";
        }

        public override void VerCategoriasDasDespesas()
        {
            Categoria categoria = ObterCategoriaSelecionada();

            TelaVisualizacaoDespesaCategoriaForm telaVisualizacaoDespesaCategoria = new(repositorioDespesa, categoria);

            telaVisualizacaoDespesaCategoria.ShowDialog();
        }

        private Categoria ObterCategoriaSelecionada()
        {
            int id = tabelaCategoria.ObterIdSelecionado();

            return repositorioCategoria.Busca(id);
        }

    }
}
