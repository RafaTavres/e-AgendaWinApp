namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TelaAdicionarItemsNaTarefaForm
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
            txtTituloDoItem = new TextBox();
            label2 = new Label();
            txtDescricaoDOItem = new TextBox();
            label3 = new Label();
            label4 = new Label();
            datePickerDataInicioDoItem = new DateTimePicker();
            datePickerDataDeConclusaoItem = new DateTimePicker();
            btnGravar = new Button();
            btnCancelar = new Button();
            label5 = new Label();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 56);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "Tiítulo Do Item:";
            // 
            // txtTituloDoItem
            // 
            txtTituloDoItem.Location = new Point(115, 53);
            txtTituloDoItem.Name = "txtTituloDoItem";
            txtTituloDoItem.Size = new Size(323, 23);
            txtTituloDoItem.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 88);
            label2.Name = "label2";
            label2.Size = new Size(106, 15);
            label2.TabIndex = 2;
            label2.Text = "Descrição Do Item:";
            // 
            // txtDescricaoDOItem
            // 
            txtDescricaoDOItem.Location = new Point(115, 85);
            txtDescricaoDOItem.Name = "txtDescricaoDOItem";
            txtDescricaoDOItem.Size = new Size(323, 23);
            txtDescricaoDOItem.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 134);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 4;
            label3.Text = "Data de Criação:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(226, 134);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 5;
            label4.Text = "Data de Conclusão:";
            // 
            // datePickerDataInicioDoItem
            // 
            datePickerDataInicioDoItem.CustomFormat = "";
            datePickerDataInicioDoItem.Format = DateTimePickerFormat.Short;
            datePickerDataInicioDoItem.Location = new Point(102, 128);
            datePickerDataInicioDoItem.Name = "datePickerDataInicioDoItem";
            datePickerDataInicioDoItem.Size = new Size(108, 23);
            datePickerDataInicioDoItem.TabIndex = 13;
            datePickerDataInicioDoItem.Value = new DateTime(2023, 5, 18, 14, 52, 34, 0);
            // 
            // datePickerDataDeConclusaoItem
            // 
            datePickerDataDeConclusaoItem.CustomFormat = "";
            datePickerDataDeConclusaoItem.Format = DateTimePickerFormat.Short;
            datePickerDataDeConclusaoItem.Location = new Point(341, 128);
            datePickerDataDeConclusaoItem.Name = "datePickerDataDeConclusaoItem";
            datePickerDataDeConclusaoItem.Size = new Size(108, 23);
            datePickerDataDeConclusaoItem.TabIndex = 14;
            datePickerDataDeConclusaoItem.Value = new DateTime(2023, 5, 18, 14, 52, 34, 0);
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(293, 176);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 23;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(374, 176);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 23);
            label5.Name = "label5";
            label5.Size = new Size(20, 15);
            label5.TabIndex = 25;
            label5.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(115, 20);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(42, 23);
            txtId.TabIndex = 26;
            txtId.Text = "0";
            // 
            // TelaAdicionarItemsNaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 229);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(datePickerDataDeConclusaoItem);
            Controls.Add(datePickerDataInicioDoItem);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtDescricaoDOItem);
            Controls.Add(label2);
            Controls.Add(txtTituloDoItem);
            Controls.Add(label1);
            Name = "TelaAdicionarItemsNaTarefaForm";
            ShowIcon = false;
            Text = "Adicionar Items";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTituloDoItem;
        private Label label2;
        private TextBox txtDescricaoDOItem;
        private Label label3;
        private Label label4;
        private DateTimePicker datePickerDataInicioDoItem;
        private DateTimePicker datePickerDataDeConclusaoItem;
        private Button btnGravar;
        private Button btnCancelar;
        private Label label5;
        private TextBox txtId;
    }
}