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

namespace e_Agenda.WinApp.ModuloDespesas
{
    public partial class TabelaDespesasControl : UserControl
    {
        public TabelaDespesasControl()
        {
            InitializeComponent();
            ConfigurarColunas();
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            tabelaDepesas.ConfigurarGridZebrado();

            tabelaDepesas.ConfigurarGridSomenteLeitura();

            tabelaDepesas.ConfigurarGridDockFill();

        }
        private void ConfigurarColunas()
        {
            DataGridViewColumn[] colunas = new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn()
                {
                    Name = "id",
                    HeaderText = "Id"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "descricao",
                    HeaderText = "Descrição"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "valor",
                    HeaderText = "Valor"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "data",
                    HeaderText = "Data"
                },
                new DataGridViewTextBoxColumn()
                {
                    Name = "formaaPagamento",
                    HeaderText = "Forma de Pagamento"
                }
            };

            tabelaDepesas.Columns.AddRange(colunas);
        }
        public void AtualizarRegistros(List<Despesa> despesas)
        {
            tabelaDepesas.Rows.Clear();
            foreach (Despesa despesa in despesas)
            {
                tabelaDepesas.Rows.Add(despesa.id, despesa.descricao, despesa.valor, despesa.data.ToString("dd/MMM/yyyy"), despesa.formaDePagamento);
            }
        }

        public int ObterIdSelecionado()
        {
            int id;

            try
            {
                id = Convert.ToInt32(tabelaDepesas.SelectedRows[0].Cells["id"].Value);
            }
            catch
            {
                id = -1;
            }

            return id;
        }
    }
}
