using e_Agenda.WinApp.ModuloContato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string assunto = txtAssunto.Text;

            DateTime data = datePickerCompromisso.Value;

            DateTime horaDeInicio = datePickerHoraDeInicio.Value;

            DateTime horaDoTermino = datePickerHoraTermino.Value;

            string local;

            bool ehRemoto = rdBtnOpcaoRemoto.Checked;

            if (ehRemoto == true)
                local = txtLocalRemoto.Text;
            else
                local = txtLocalPresencial.Text;


            Contato contato = null;
            if (cmbBoxListaDeContatos.Enabled == false)
            {
                contato = new Contato("Não Informado", "Não Informado", "Não Informado", "Não Informado", "Não Informado");
            }
            else
            {
                contato = (Contato)cmbBoxListaDeContatos.SelectedItem;
            }
            compromisso = new Compromisso(assunto, local, data, horaDeInicio, horaDoTermino, ehRemoto, contato);

            if (txtId.Text != "0")
                compromisso.id = Convert.ToInt32(txtId.Text);

        }

        private void checkBoxTemContato_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTemContato.Checked)
            {
                cmbBoxListaDeContatos.Enabled = true;
            }
            else if (checkBoxTemContato.Checked)
            {
                cmbBoxListaDeContatos.Enabled = false;
            }
        }
    }
}
