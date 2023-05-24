using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp.ModuloDespesas
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
                txtId.Text = value.id.ToString();
                txtTitulo.Text = value.titulo;
            }
            get
            {
                return categoria;
            }
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
