using e_Agenda.Dominio.ModuloCompromisso;
using e_Agenda.Dominio.ModuloContato;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase
    {
        private IRepositorioCompromisso repositorioCompromisso;
        private TabelaCompromissoControl tabelaCompromisso;
        public IRepositorioContato repositorioContato;

        public ControladorCompromisso(IRepositorioCompromisso repositorio, IRepositorioContato repositorioContato)
        {
            repositorioCompromisso = repositorio;
            this.repositorioContato = repositorioContato;
        }

        public override string ToolTipInserir => "Inserir novo Compromisso";

        public override string ToolTipEditar => "Editar Compromisso existente"; 

        public override string ToolTipExcluir => "Excluir Compromisso existente"; 

        public override string ToolTipFiltrar => "Filtrar Compromissos"; 

        public override bool BotaoInserirAtivado => true; 

        public override bool BotaoDeletarAtivado => true; 

        public override bool BotaoEditarAtivado => true; 

        public override bool BotaoFiltrarAtivado => true; 

        public override string ToolTipAdicionarItens => "Indisponível"; 

        public override string ToolTipEditarItens => "Indisponível"; 

        public override bool BotaoAdicionarItensAtivado => false; 

        public override bool BotaoEditarItensAtivado => false;

        public override string ToolTipCategoriasDasDespesas => "Indisponível";

        public override bool BotaoCategoriasDasDespesasAtivado => false;

        public override void Editar()
        {
            Compromisso compromisso = ObterCompromissoSelecionado();

            if (compromisso == null)
            {
                MessageBox.Show($"Selecione um compromisso primeiro!",
                    "Edição de Compromissos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();
            telaCompromisso.AdicionaContatosAComboBox(repositorioContato);
            telaCompromisso.Compromisso = compromisso;

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCompromisso.Atualizar(telaCompromisso.Compromisso.id, telaCompromisso.Compromisso);

                CarregarCompromissos();
            }
        }


        private void CarregarCompromissos()
        {
            List<Compromisso> compromissos = repositorioCompromisso.RetornarTodos();
            tabelaCompromisso.AtualizarRegistros(compromissos);
        }
        private void CarregarCompromissosComFiltro(StatusCompromissoEnum statusCompromisso, DateTime dataInicial, DateTime dataFinal)
        {
            List<Compromisso> compromissos;
            switch(statusCompromisso)
            {
                case StatusCompromissoEnum.Futuros:
                    compromissos = repositorioCompromisso.RetornarCompromissosParaOFuturo(dataInicial, dataFinal);
                    break;
                case StatusCompromissoEnum.Passados:
                    compromissos = repositorioCompromisso.RetornarCompromissosParaOPassado();
                    break;
                default:
                    compromissos = repositorioCompromisso.RetornarTodos();
                    break;
            }

            tabelaCompromisso.AtualizarRegistros(compromissos);
        }

        public override void Deletar()
        {
            Compromisso compromisso = ObterCompromissoSelecionado();

            if (compromisso == null)
            {
                MessageBox.Show($"Selecione um compromisso primeiro!",
                    "Exclusão de Compromissos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o Compromisso {compromisso.assunto}?", "Exclusão de Compromissos",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioCompromisso.Deletar(compromisso.id);

                CarregarCompromissos();
            }
        }

        public override void Inserir()
        {
            TelaCompromissoForm telaCompromisso = new TelaCompromissoForm();
            telaCompromisso.AdicionaContatosAComboBox(repositorioContato);

            DialogResult opcaoEscolhida = telaCompromisso.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Compromisso compromisso = telaCompromisso.Compromisso;

                repositorioCompromisso.Inserir(compromisso);

                CarregarCompromissos();
            }
        }

        public override UserControl ObterListagem()
        {
            if (tabelaCompromisso == null)
                tabelaCompromisso = new TabelaCompromissoControl();

            CarregarCompromissos();

            return tabelaCompromisso;
        }




        public override string ObterTipoCadastro()
        {
            return "Cadastro de Compromissos";
        }




        public override void Filtrar()
        {
            TelaFiltroDeCompromissoForm telaFiltro = new();

            if (telaFiltro.ShowDialog() == DialogResult.OK)
            {
                StatusCompromissoEnum statusCompromisso = telaFiltro.StatusSelecionado;
                DateTime dataFinal = telaFiltro.DataDetermino.Date;
                DateTime dataInicial = telaFiltro.DataDeInicio.Date;

                CarregarCompromissosComFiltro(statusCompromisso, dataInicial, dataFinal);
            }           
        }



        private Compromisso ObterCompromissoSelecionado()
        {
            int id = tabelaCompromisso.ObterIdSelecionado();

            return repositorioCompromisso.Busca(id);
        }


    }
}
