using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloCompromisso;
using e_Agenda.WinApp.ModuloContato;
using e_Agenda.WinApp.ModuloTarefa;

namespace e_Agenda.WinApp
{
    public partial class TelaPrincipalForm : Form
    {
        UserControl listagem;
        private ControladorBase controlador;
        private RepositorioContato repositorioContato = new RepositorioContato(new List<Contato>());
        private RepositorioCompromisso repositorioCompromisso = new RepositorioCompromisso(new List<Compromisso>());
        private RepositorioTarefa repositorioTarefa = new RepositorioTarefa(new List<Tarefa>());

        public TelaPrincipalForm()
        {
            InitializeComponent();
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
        }
        private void ConfigurarAcoesDosBotoes(ControladorBase controlador)
        {

            btnInserir.Enabled = controlador.BotaoInserirAtivado;
            btnEditar.Enabled = controlador.BotaoEditarAtivado;
            btnDeletar.Enabled = controlador.BotaoDeletarAtivado;
            btnFiltrar.Enabled = controlador.BotaoFiltrarAtivado;
            btnAdicionatNaLista.Enabled = controlador.BotaoAdicionarItensAtivado;
            btnEditarItensDaTarefa.Enabled = controlador.BotaoEditarItensAtivado;
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