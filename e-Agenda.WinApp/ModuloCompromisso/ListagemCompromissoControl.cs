using e_Agenda.WinApp.Compartilhado;
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
    public partial class ListagemCompromissoControl : UserControl
    {
        public ListagemCompromissoControl()
        {
            InitializeComponent();
        }
        public void AtualizarRegistros(List<Compromisso> compromissos)
        {
           listCompromissos.Items.Clear();

           foreach (Compromisso item in compromissos)
           {
                listCompromissos.Items.Add(item);
           }
        }

        public Compromisso ObterCompromissoSelecionado()
        {
           return (Compromisso)listCompromissos.SelectedItem;
        }
        
    }
}
