using e_Agenda.WinApp.Compartilhado;
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
    public partial class ListagemContatoControl : UserControl
    {
        public ListagemContatoControl()
        {
            InitializeComponent();
        }

        public void AtualizarRegistros(List<EntidadeBase> contatos)
        {
            listContato.Items.Clear();

            foreach (Contato item in contatos)
            {
                listContato.Items.Add(item);
            }
        }

        public Contato ObterContatoSelecionado()
        {
            return (Contato)listContato.SelectedItem;
        }
    }
}
