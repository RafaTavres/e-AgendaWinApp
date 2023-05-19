using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_Agenda.WinApp.ModuloContato
{
    public partial class TelaContatoForm : Form
    {
        private Contato contato;

        public TelaContatoForm()
        {
            InitializeComponent();
        }

        public Contato Contato
        {
            set
            {
                txtId.Text = value.id.ToString();
                txtNome.Text = value.nome;
                txtTelefone.Text = value.telefone;
                txtEmail.Text = value.email;
                txtCargo.Text = value.cargo;
                txtEmpresa.Text = value.empresa;
            }
            get
            {
                return contato;
            }
        }


        private void btnGravar_Click_1(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            string telefone = txtTelefone.Text;

            string email = txtEmail.Text;

            string cargo = txtCargo.Text;

            string empresa = txtEmpresa.Text;

            contato = new Contato(nome, telefone, email, cargo, empresa);

            if (txtId.Text != "0")
                contato.id = Convert.ToInt32(txtId.Text);
        }
    }
}
