using e_Agenda.WinApp.ModuloContato;

namespace e_Agenda.WinApp.ModuloCompromisso
{
    public partial class TelaCompromissoForm : Form
    {
        private Compromisso compromisso;
        public TelaCompromissoForm()
        {
            InitializeComponent();
            cmbBoxListaDeContatos.Enabled = false;
        }
        public Compromisso Compromisso
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtAssunto.Text = value.assunto;
                txtLocalPresencial.Text = value.local;
                txtLocalRemoto.Text = value.local;
                datePickerCompromisso.Value = value.data;
                datePickerHoraDeInicio.Value = value.horaDeInicio;
                datePickerHoraTermino.Value = value.horaDoTermino;
            }
            get
            {
                return compromisso;
            }
        }
        public void AdicionaContatosAComboBox(RepositorioContato repositorioContato)
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
