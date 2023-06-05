using e_Agenda.Dominio.ModuloContato;

namespace e_Agenda.WinApp.ModuloContato
{
    public partial class TelaContatoForm : Form
    {
        private Contato contato;

        public TelaContatoForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public Contato Contato
        {
            set
            {
                ConfigurarTela(value);
            }
            get
            {
                return contato;
            }
        }

        private void ConfigurarTela(Contato value)
        {
            txtId.Text = value.id.ToString();
            txtNome.Text = value.nome;
            txtTelefone.Text = value.telefone;
            txtEmail.Text = value.email;
            txtCargo.Text = value.cargo;
            txtEmpresa.Text = value.empresa;
        }

        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            contato = ObterContato();

            string[] erros = contato.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }

            ObterContato();

            if (txtId.Text != "0")
                contato.id = Convert.ToInt32(txtId.Text);
        }

        private Contato ObterContato()
        {
            string nome = txtNome.Text;

            string telefone = txtTelefone.Text;

            string email = txtEmail.Text;

            string cargo = txtCargo.Text;

            string empresa = txtEmpresa.Text;

            return contato = new Contato(nome, telefone, email, cargo, empresa);
        }
    }
}
