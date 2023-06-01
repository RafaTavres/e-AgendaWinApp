using e_Agenda.WinApp.Compartilhado;
using e_Agenda.WinApp.ModuloContato;
using System.Windows.Forms;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TelaCompromissoForm : Form
    {
        private Compromisso compromisso;
        public TelaCompromissoForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
            cmbBoxListaDeContatos.Enabled = false;
        }
        public Compromisso Compromisso
        {
            set
            {
                ConfigurarTela(value);
            }
            get
            {
                return compromisso;
            }
        }

        private void ConfigurarTela(Compromisso compromissso)
        {
            txtId.Text = compromissso.id.ToString();
            txtAssunto.Text = compromissso.assunto;
            txtLocalPresencial.Text = compromissso.local;
            txtLocalRemoto.Text = compromissso.local;
            datePickerCompromisso.Value = compromissso.data;
            datePickerHoraDeInicio.Value = compromissso.horaDeInicio;
            datePickerHoraTermino.Value = compromissso.horaDoTermino;

            if (compromissso.contatoRelacionado != null)
            {
                checkBoxTemContato.Checked = true;
                cmbBoxListaDeContatos.SelectedItem = compromissso.contatoRelacionado;
            }
        }

        public void AdicionaContatosAComboBox(IRepositorioContato repositorioContato)
        {
            foreach (Contato item in repositorioContato.RetornarTodos())
            {
                cmbBoxListaDeContatos.Items.Add(item);
            }

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            compromisso = ObterCompromisso();

            string[] erros = compromisso.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }

            if (txtId.Text != "0")
                compromisso.id = Convert.ToInt32(txtId.Text);

        }

        private Compromisso ObterCompromisso()
        {
            string assunto = txtAssunto.Text;

            DateTime data = datePickerCompromisso.Value;

            DateTime horaDeInicio = datePickerHoraDeInicio.Value;

            DateTime horaDoTermino = datePickerHoraTermino.Value;

            string local = "";

            bool ehRemoto = rdBtnOpcaoRemoto.Checked;

            if (rdBtnOpcaoRemoto.Checked == true)
            {
                local = txtLocalRemoto.Text;
            }
            else
            if (rdBtnOpcaoPresencial.Checked == true)
            {
                local = txtLocalPresencial.Text;
            }

            Contato contato = null;

            if (cmbBoxListaDeContatos.SelectedItem == null || cmbBoxListaDeContatos.Enabled == false)
            {
                contato = new Contato("Não Informado", "Não Informado", "Não Informado", "Não Informado", "Não Informado");
            }
            else
            {
                contato = (Contato)cmbBoxListaDeContatos.SelectedItem;
            }


            return compromisso = new Compromisso(assunto, local, data, horaDeInicio, horaDoTermino, ehRemoto, contato);
        }

        private void checkBoxTemContato_CheckedChanged(object sender, EventArgs e)
        {
            cmbBoxListaDeContatos.Enabled = !cmbBoxListaDeContatos.Enabled;
            cmbBoxListaDeContatos.SelectedIndex = -1;
        }

        private void rdBtnOpcaoRemoto_CheckedChanged(object sender, EventArgs e)
        {
            txtLocalRemoto.Enabled = true;
            txtLocalPresencial.Enabled = false;
            txtLocalPresencial.Text = "";
        }

        private void rdBtnOpcaoPresencial_CheckedChanged(object sender, EventArgs e)
        {
            txtLocalPresencial.Enabled = true;
            txtLocalRemoto.Enabled = false;
            txtLocalRemoto.Text = "";
        }
    }
}
