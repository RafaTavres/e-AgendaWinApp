namespace e_Agenda.WinApp.ModuloTarefa
{
    public partial class TelaAdicionarItemsNaTarefaForm : Form
    {
        public Item item;
        public TelaAdicionarItemsNaTarefaForm()
        {
            InitializeComponent();
        }

        public Item Item
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtTituloDoItem.Text = value.titulo;
                txtDescricaoDOItem.Text = value.descricao;
                datePickerDataInicioDoItem.Value = value.dataCriacao;
                datePickerDataDeConclusaoItem.Value = value.dataConclusao;
            }
            get
            {
                return item;
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            item = ObterItem();

            string[] erros = item.Validar();

            if (erros.Length > 0)
            {
                TelaPrincipalForm.Instancia.AtualizarRodape(erros[0]);

                DialogResult = DialogResult.None;
            }
            
            if (txtId.Text != "0")
                item.id = Convert.ToInt32(txtId.Text);
        }

        private Item ObterItem()
        {
            string titulo = txtTituloDoItem.Text;

            string descricao = txtDescricaoDOItem.Text;

            DateTime dataInicio = datePickerDataInicioDoItem.Value.Date;

            DateTime dataConclusao = datePickerDataDeConclusaoItem.Value.Date;

            bool estahConcluida = false;

            item = new Item(titulo, descricao, dataInicio, dataConclusao, estahConcluida);

            return item;
        }
    }
}
