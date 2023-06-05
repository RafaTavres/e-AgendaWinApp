
using e_Agenda.Dominio.ModuloCategoria;


namespace e_Agenda.WinApp.ModuloCategoria
{
    public partial class TelaCategoriaForm : Form
    {
        private Categoria categoria;
        public TelaCategoriaForm()
        {
            InitializeComponent();
            this.ConfigurarDialog();
        }

        public Categoria Categoria
        {
            set
            {
                ConfigurarTela(value);
            }
            get
            {
                return categoria;
            }
        }

        private void ConfigurarTela(Categoria value)
        {
            txtId.Text = value.id.ToString();
            txtTitulo.Text = value.titulo;
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
                categoria = ObterCategoria();

                string[] erros = categoria.Validar();

                if (erros.Length > 0)
                {
                    TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                    DialogResult = DialogResult.None;
                }

                if (txtId.Text != "0")
                categoria.id = Convert.ToInt32(txtId.Text);
        }

          private Categoria ObterCategoria()
          {
                string titulo = txtTitulo.Text;
           
                return categoria = new Categoria(titulo);
            
          }
    }
}
