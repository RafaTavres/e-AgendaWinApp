using e_Agenda.WinApp.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloContato
{
    public class ControladorContato : ControladorBase
    {
        private RepositorioContato repositorioContato;
        private ListagemContatoControl listagemContato;

        public ControladorContato(RepositorioBase<Contato> repositorio)
        {
            repositorioContato = (RepositorioContato)repositorio;
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


        public override void Editar()
        {
            Contato contato = listagemContato.ObterContatoSelecionado();

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
            Contato contato = listagemContato.ObterContatoSelecionado();

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
            listagemContato.AtualizarRegistros(contatos);
        }

        public override UserControl ObterListagem()
        {
            if (listagemContato == null)
                listagemContato = new ListagemContatoControl();

            CarregarContatos();

            return listagemContato;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Contatos";
        }

        public override void Filtrar()
        {
            throw new NotImplementedException();
        }

        public override void AdicionarItemsNaListaDeTarefa()
        {
            throw new NotImplementedException();
        }

        public override void EditarItensDaTarefa()
        {
            throw new NotImplementedException();
        }
    }
}
