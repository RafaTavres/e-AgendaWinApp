using e_Agenda.WinApp.ModuloTarefa.Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string titulo = txtTituloDoItem.Text;

            string descricao = txtDescricaoDOItem.Text;

            DateTime dataInicio = DateTime.Now;

            bool estahConcluida = false;
          
            item = new Item(titulo, descricao, dataInicio, estahConcluida);

            if (txtId.Text != "0")
                item.id = Convert.ToInt32(txtId.Text);
        }
    }
}
