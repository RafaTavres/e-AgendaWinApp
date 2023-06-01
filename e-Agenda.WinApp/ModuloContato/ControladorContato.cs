using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloTarefa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloContato
{
    public class ControladorContato : ControladorBase
    {
        private IRepositorioContato repositorioContato;
        private TabelaContatoControl tabelaContato;

        public ControladorContato(IRepositorioContato repositorio)
        {
            repositorioContato = repositorio;
        }

        public override string ToolTipInserir  => "Inserir novo Contato"; 

        public override string ToolTipEditar  => "Editar Contato existente"; 

        public override string ToolTipExcluir  => "Excluir Contato existente"; 

        public override string ToolTipFiltrar  => "Indiponivel"; 

        public override string ToolTipAdicionarItens  => "Indiponivel"; 

        public override string ToolTipEditarItens  => "Indiponivel"; 
        public override bool BotaoInserirAtivado  => true; 

        public override bool BotaoDeletarAtivado  => true; 

        public override bool BotaoEditarAtivado  => true; 

        public override bool BotaoFiltrarAtivado  => false; 

  

        public override bool BotaoAdicionarItensAtivado  => false; 


        public override bool BotaoEditarItensAtivado  => false;

        public override string ToolTipCategoriasDasDespesas => "Indiponivel";

        public override bool BotaoCategoriasDasDespesasAtivado => false;

        public override void Editar()
        {
            Contato contato = ObterContatoSelecionado();

            if (contato == null)
            {
                MessageBox.Show($"Selecione um contato primeiro!",
                    "Edição de Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            TelaContatoForm telaContato = new TelaContatoForm();
            telaContato.Contato = contato;

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioContato.Atualizar(telaContato.Contato.id, telaContato.Contato);

                CarregarContatos();
            }
        }

        public override void Deletar()
        {
            Contato contato = ObterContatoSelecionado();

            if (contato == null)
            {
                MessageBox.Show($"Selecione um contato primeiro!",
                    "Exclusão de Contatos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o contato {contato.nome}?", "Exclusão de Contatos",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcaoEscolhida == DialogResult.OK)
            {
                repositorioContato.Deletar(contato.id);

                CarregarContatos();
            }
        }

        public override void Inserir()
        {
            TelaContatoForm telaContato = new TelaContatoForm();

            DialogResult opcaoEscolhida = telaContato.ShowDialog();

            if (opcaoEscolhida == DialogResult.OK)
            {
                Contato contato = telaContato.Contato;

                repositorioContato.Inserir(contato);

                CarregarContatos();
            }
        }

        private void CarregarContatos()
        {
            List<Contato> contatos = repositorioContato.RetornarTodos();     
            tabelaContato.AtualizarRegistros(contatos);
        }

        public override UserControl ObterListagem()
        {
            if (tabelaContato == null)
                tabelaContato = new TabelaContatoControl();

            CarregarContatos();

            return tabelaContato;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Contatos";
        }

        private Contato ObterContatoSelecionado()
        {
            int id = tabelaContato.ObterIdSelecionado();

            return repositorioContato.Busca(id);
        }
    }
}
