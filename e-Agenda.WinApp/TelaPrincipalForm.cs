using e_Agenda.Infra.Data.Arquivo.Compartilhado;
using e_Agenda.Infra.Data.Arquivo.ModuloCategoria;
using e_Agenda.Infra.Data.Arquivo.ModuloCompromisso;
using e_Agenda.Infra.Data.Arquivo.ModuloDespesas;
using e_Agenda.Infra.Data.Arquivo.ModuloTarefa;
using e_Agenda.Infra.Data.Arquivo.ModuloContato;


using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloDespesas;
using e_Agenda.WinApp.ModuloCategoria;
using e_Agenda.WinApp.ModuloTarefa;


using e_Agenda.Dominio.ModuloDespesas;
using e_Agenda.Dominio.ModuloTarefa;
using e_Agenda.Dominio.ModuloCompromisso;
using e_Agenda.Dominio.ModuloContato;
using e_Agenda.Dominio.ModuloCategoria;


using e_Agenda.Infra.Dados.Sql.ModuloContato;

namespace e_Agenda.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        UserControl listagem;
        private ControladorBase controlador;

        static ContextoDados contextoDados = new ContextoDados(carregarDados: true);


        // private IRepositorioContato repositorioContato = new RepositorioContatoEmArquivo(contextoDados);
        private IRepositorioContato repositorioContato = new RepositorioContatoSql();
        private IRepositorioCompromisso repositorioCompromisso = new RepositorioCompromissoEmArquivo(contextoDados);
        private IRepositorioCategoria repositorioCategoria = new RepositorioCategoriaEmArquivo(contextoDados);
        private IRepositorioTarefa repositorioTarefa = new RepositorioTarefaEmArquivo(contextoDados);
        private IRepositorioDespesa repositorioDespesa = new RepositorioDespesaEmArquivo(contextoDados);


        private static TelaPrincipalForm telaPrincipal;
        public TelaPrincipalForm()
        {
            InitializeComponent();
            telaPrincipal = this;
        }
        public static TelaPrincipalForm Instancia
        {
            get
            {
                if (telaPrincipal == null)
                    telaPrincipal = new TelaPrincipalForm();

                return telaPrincipal;
            }
        }

        public void AtualizarRodape(string mensagem)
        {
            lblRodape.Text = mensagem;
        }


        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCategoria(repositorioCategoria, repositorioDespesa);
            ConfigurarTelaPrincipal(controlador);
        }

        private void contatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorContato(repositorioContato);
            ConfigurarTelaPrincipal(controlador);
        }

        private void tarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorTarefa(repositorioTarefa);
            ConfigurarTelaPrincipal(controlador);

        }

        private void compromissosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlador = new ControladorCompromisso(repositorioCompromisso, repositorioContato);
            ConfigurarTelaPrincipal(controlador);
        }


        private void despesasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            controlador = new ControladorDespesa(repositorioDespesa, repositorioCategoria);
            ConfigurarTelaPrincipal(controlador);
        }


        private void ConfigurarTelaPrincipal(ControladorBase controladorBase)
        {
            lblTipoCadastro.Text = controladorBase.ObterTipoCadastro();

            ConfigurarToolTips(controladorBase);
            ConfigurarListagem(controladorBase);
            ConfigurarAcoesDosBotoes(controladorBase);

        }

        private void ConfigurarListagem(ControladorBase controladorBase)
        {
            listagem = controladorBase.ObterListagem();

            listagem.Dock = DockStyle.Fill;

            panelRegistros.Controls.Clear();

            panelRegistros.Controls.Add(listagem);
        }

        private void ConfigurarToolTips(ControladorBase controlador)
        {

            btnInserir.ToolTipText = controlador.ToolTipInserir;
            btnEditar.ToolTipText = controlador.ToolTipEditar;
            btnDeletar.ToolTipText = controlador.ToolTipExcluir;
            btnFiltrar.ToolTipText = controlador.ToolTipFiltrar;
            btnAdicionatNaLista.ToolTipText = controlador.ToolTipAdicionarItens;
            btnEditarItensDaTarefa.ToolTipText = controlador.ToolTipEditarItens;
            btnVizualizarDespesasDasCategorias.ToolTipText = controlador.ToolTipEditarItens;
        }
        private void ConfigurarAcoesDosBotoes(ControladorBase controlador)
        {

            btnInserir.Enabled = controlador.BotaoInserirAtivado;
            btnEditar.Enabled = controlador.BotaoEditarAtivado;
            btnDeletar.Enabled = controlador.BotaoDeletarAtivado;
            btnFiltrar.Enabled = controlador.BotaoFiltrarAtivado;
            btnAdicionatNaLista.Enabled = controlador.BotaoAdicionarItensAtivado;
            btnEditarItensDaTarefa.Enabled = controlador.BotaoEditarItensAtivado;
            btnVizualizarDespesasDasCategorias.Enabled = controlador.BotaoCategoriasDasDespesasAtivado;
        }


        private void btnInserir_Click_1(object sender, EventArgs e)
        {
            if (VerificaControladorVazio(controlador)) ;
            else
                controlador.Inserir();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (VerificaControladorVazio(controlador)) ;
            else
                controlador.Editar();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (VerificaControladorVazio(controlador)) ;
            else
                controlador.Deletar();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (VerificaControladorVazio(controlador)) ;
            else
                controlador.Filtrar();
        }
        private void btnAdicionatNaLista_Click(object sender, EventArgs e)
        {
            if (VerificaControladorVazio(controlador)) ;
            else
                controlador.AdicionarItemsNaListaDeTarefa();
        }

        private void btnEditarItensDaTarefa_Click(object sender, EventArgs e)
        {
            if (VerificaControladorVazio(controlador)) ;
            else
                controlador.EditarItensDaTarefa();
        }
        private void btnVizualizarDespesasDasCategorias_Click(object sender, EventArgs e)
        {
            if (VerificaControladorVazio(controlador)) ;
            else
                controlador.VerCategoriasDasDespesas();
        }
        private bool VerificaControladorVazio(ControladorBase controlador)
        {
            if (controlador == null)
            {
                MessageBox.Show("Selecione uma opção de cadastro", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }


    }
}