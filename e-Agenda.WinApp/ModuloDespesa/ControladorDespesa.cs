using e_Agenda.WinApp.ModuloDespesas.Tela_Despesa;
using e_Agenda.WinApp.ModuloDespesas.ModuloCategoria;

namespace e_Agenda.WinApp.ModuloDespesas
{
    public class ControladorDespesa : ControladorBase
    {
        private IRepositorioDespesa repositorioDespesa;
        private IRepositorioCategoria repositorioCategoria;
        private TabelaDespesasControl tabelaDespesa;



        public ControladorDespesa(IRepositorioDespesa repositorio, IRepositorioCategoria repositorioCategoria)
        {
            repositorioDespesa = repositorio;
            this.repositorioCategoria = repositorioCategoria;
        }



        public override string ToolTipInserir => "Inserir nova Despesa";

        public override string ToolTipEditar => "Editar despesa Existente";

        public override string ToolTipExcluir => "Deletar despesa Existente";

        public override string ToolTipFiltrar => "Indiponivel";

        public override string ToolTipAdicionarItens => "Indiponivel";

        public override string ToolTipEditarItens => "Indiponivel";

        public override bool BotaoInserirAtivado => true;

        public override bool BotaoDeletarAtivado => true;

        public override bool BotaoEditarAtivado => true;

        public override bool BotaoFiltrarAtivado => false;

        public override bool BotaoAdicionarItensAtivado => false;

        public override bool BotaoEditarItensAtivado => false;

        public override string ToolTipCategoriasDasDespesas => "Indiponivel";

        public override bool BotaoCategoriasDasDespesasAtivado => false ;

        public override void Deletar()
        {
            Despesa despesa = ObterDespesaSelecionada();

            if (despesa == null)
            {
                MessageBox.Show($"Selecione uma Despesa primeiro!",
                    "Exclusão de Despesas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o despesa {despesa.descricao}?", "Exclusão de Despesas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioDespesa.Deletar(despesa.id);

                CarregarDespesas();
            }
        }




        public override void Editar()
        {
            Despesa despesa = ObterDespesaSelecionada();

            if (despesa == null)
            {
                MessageBox.Show($"Selecione uma Despesa primeiro!",
                    "Edição de Despesas",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaDespesaForm telaDespesa = new TelaDespesaForm(repositorioCategoria);
            telaDespesa.Despesa = despesa;

            DialogResult opcaoEscolhida = telaDespesa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioDespesa.Atualizar(telaDespesa.Despesa.id, telaDespesa.Despesa);

                CarregarDespesas();
            }
        }





        public override void Inserir()
        {
            TelaDespesaForm telaDespesa = new TelaDespesaForm(repositorioCategoria);

            DialogResult opcaoEscolhida = telaDespesa.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Despesa despesa = telaDespesa.Despesa;

                repositorioDespesa.Inserir(despesa);

                CarregarDespesas();
            }
        }





        public override UserControl ObterListagem()
        {
            if (tabelaDespesa == null)
                tabelaDespesa = new TabelaDespesasControl();

            CarregarDespesas();

            return tabelaDespesa;
        }



        private void CarregarDespesas()
        {
            List<Despesa> despesas = repositorioDespesa.RetornarTodos();
            tabelaDespesa.AtualizarRegistros(despesas);
        }




        public override string ObterTipoCadastro()
        {
            return "Cadastro de Contatos";
        }





        private Despesa ObterDespesaSelecionada()
        {
            int id = tabelaDespesa.ObterIdSelecionado();

            return repositorioDespesa.Busca(id);
        }
    }
}
