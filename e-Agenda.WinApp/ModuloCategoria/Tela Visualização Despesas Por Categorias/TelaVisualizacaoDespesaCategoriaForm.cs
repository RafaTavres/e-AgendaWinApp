using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using e_Agenda.WinApp;
using e_Agenda.WinApp.ModuloDespesas.ModuloCategoria;

namespace e_Agenda.WinApp.ModuloDespesas.Tela_Vizualização_Despesas_Por_Categorias
{
    public partial class TelaVisualizacaoDespesaCategoriaForm : Form
    {
        IRepositorioDespesa repositorioDespesa;
        Categoria categoria;
        public TelaVisualizacaoDespesaCategoriaForm(IRepositorioDespesa repositorioDespesa, Categoria categoria)
        {
            InitializeComponent();
            this.repositorioDespesa = repositorioDespesa;
            this.categoria = categoria;
            ConfigurarLabel();
            ConfigurarLista();
            this.ConfigurarDialog();
        }
        private void ConfigurarLista()
        {
            foreach (Despesa item in repositorioDespesa.RetornarTodos())
            {
                if (item.categorias.Contains(categoria))
                {
                    listaDespesas.Items.Add(item.ToString());
                }

            }
        }
        private void ConfigurarLabel()
        {
            lblCategoria.Text = categoria.titulo;
        }
    }
}
