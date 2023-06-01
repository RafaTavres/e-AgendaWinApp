namespace e_Agenda.WinApp.ModuloDespesas.Tela_Despesa
{
    partial class TelaDespesaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label6 = new Label();
            label4 = new Label();
            txtDescricao = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            txtValor = new MaskedTextBox();
            datePickerDataDaDespesa = new DateTimePicker();
            listaCategorias = new CheckedListBox();
            gpBoxCategorias = new GroupBox();
            listaFormaPagamento = new ListBox();
            gpBoxCategorias.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 15);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 3;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(91, 12);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 4;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 42);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 5;
            label2.Text = "Descrição:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 76);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 11;
            label3.Text = "Valor:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 106);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 14;
            label6.Text = "Data:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(205, 73);
            label4.Name = "label4";
            label4.Size = new Size(108, 15);
            label4.TabIndex = 15;
            label4.Text = "Forma Pagamento:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(91, 39);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(379, 23);
            txtDescricao.TabIndex = 17;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(314, 426);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 22;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(395, 426);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(91, 73);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(108, 23);
            txtValor.TabIndex = 25;
            txtValor.ValidatingType = typeof(DateTime);
            // 
            // datePickerDataDaDespesa
            // 
            datePickerDataDaDespesa.Format = DateTimePickerFormat.Short;
            datePickerDataDaDespesa.Location = new Point(91, 103);
            datePickerDataDaDespesa.Name = "datePickerDataDaDespesa";
            datePickerDataDaDespesa.Size = new Size(108, 23);
            datePickerDataDaDespesa.TabIndex = 26;
            // 
            // listaCategorias
            // 
            listaCategorias.Dock = DockStyle.Fill;
            listaCategorias.FormattingEnabled = true;
            listaCategorias.Location = new Point(3, 19);
            listaCategorias.Name = "listaCategorias";
            listaCategorias.Size = new Size(431, 244);
            listaCategorias.TabIndex = 28;
            // 
            // gpBoxCategorias
            // 
            gpBoxCategorias.Controls.Add(listaCategorias);
            gpBoxCategorias.Location = new Point(33, 144);
            gpBoxCategorias.Name = "gpBoxCategorias";
            gpBoxCategorias.Size = new Size(437, 266);
            gpBoxCategorias.TabIndex = 29;
            gpBoxCategorias.TabStop = false;
            gpBoxCategorias.Text = "Categorias";
            // 
            // listaFormaPagamento
            // 
            listaFormaPagamento.FormattingEnabled = true;
            listaFormaPagamento.ItemHeight = 15;
            listaFormaPagamento.Items.AddRange(new object[] { "Dinheiro", "PIX", "Cartão" });
            listaFormaPagamento.Location = new Point(319, 73);
            listaFormaPagamento.Name = "listaFormaPagamento";
            listaFormaPagamento.Size = new Size(95, 49);
            listaFormaPagamento.TabIndex = 30;
            // 
            // TelaDespesaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 479);
            Controls.Add(listaFormaPagamento);
            Controls.Add(gpBoxCategorias);
            Controls.Add(datePickerDataDaDespesa);
            Controls.Add(txtValor);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtDescricao);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "TelaDespesaForm";
            Text = "Cadastro de Despesas";
            gpBoxCategorias.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Label label2;
        private Label label3;
        private Label label6;
        private Label label4;
        private Label label5;
        private TextBox txtDescricao;
        private TextBox txtCargo;
        private TextBox txtEmpresa;
        private Button btnGravar;
        private Button btnCancelar;
        private MaskedTextBox txtTelefone;
        private MaskedTextBox txtValor;
        private DateTimePicker datePickerDataDaDespesa;
        private CheckedListBox listaCategorias;
        private GroupBox gpBoxCategorias;
        private ListBox listaFormaPagamento;
    }
}