using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public class ControladorCompromisso : ControladorBase
    {
        private RepositorioCompromisso repositorioCompromisso;
        private ListagemCompromissoControl listagemCompromisso;
        public RepositorioContato repositorioContato;

        public ControladorCompromisso(RepositorioBase repositorio,RepositorioContato repositorioContato)
        {
            this.repositorioCompromisso = (RepositorioCompromisso)repositorio;
            this.repositorioContato = repositorioContato;
        }

        public override string ToolTipInserir { get { return "Inserir novo Compromisso"; } }

        public override string ToolTipEditar { get { return "Editar Compromisso existente"; } }

        public override string ToolTipExcluir { get { return "Excluir Compromisso existente"; } }

        public override void Editar()
        {
            Compromisso compromisso = listagemCompromisso.ObterCompromissoSelecionado();

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
            List<EntidadeBase> compromissos = repositorioCompromisso.RetornarTodos();
            listagemCompromisso.AtualizarRegistros(compromissos);
        }

        public override void Excluir()
        {
            Compromisso compromisso = listagemCompromisso.ObterCompromissoSelecionado();

            if (compromisso == null)
            {
                MessageBox.Show($"Selecione um compromisso primeiro!",
                    "Exclusão de Compromissos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                return;
            }

            DialogResult opcaoEscolhida = MessageBox.Show($"Deseja excluir o contato {compromisso.assunto}?", "Exclusão de Compromissos",
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
            if (listagemCompromisso == null)
                listagemCompromisso = new ListagemCompromissoControl();

            CarregarCompromissos();

            return listagemCompromisso;
        }

        public override string ObterTipoCadastro()
        {
            return "Cadastro de Compromissos";
        }
    }
}
