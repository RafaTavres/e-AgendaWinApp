namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TelaTarefaForm
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
            txtTitulo = new TextBox();
            label3 = new Label();
            txtDescricao = new TextBox();
            groupBox1 = new GroupBox();
            rdBtnPrioridadeBaixa = new RadioButton();
            rdBtnPrioridadeAlta = new RadioButton();
            rdBtnPrioridadeMedia = new RadioButton();
            btnGravar = new Button();
            btnCancelar = new Button();
            label5 = new Label();
            datePickerDataInicio = new DateTimePicker();
            label4 = new Label();
            datePickerDataTermino = new DateTimePicker();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 31);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 5;
            label1.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(114, 28);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 23;
            txtId.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 75);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 24;
            label2.Text = "Título:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(114, 72);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(193, 23);
            txtTitulo.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 117);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 26;
            label3.Text = "Descrição";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(114, 117);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(193, 23);
            txtDescricao.TabIndex = 27;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdBtnPrioridadeBaixa);
            groupBox1.Controls.Add(rdBtnPrioridadeAlta);
            groupBox1.Controls.Add(rdBtnPrioridadeMedia);
            groupBox1.Location = new Point(344, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(115, 126);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prioridade";
            // 
            // rdBtnPrioridadeBaixa
            // 
            rdBtnPrioridadeBaixa.AutoSize = true;
            rdBtnPrioridadeBaixa.Location = new Point(26, 82);
            rdBtnPrioridadeBaixa.Name = "rdBtnPrioridadeBaixa";
            rdBtnPrioridadeBaixa.Size = new Size(53, 19);
            rdBtnPrioridadeBaixa.TabIndex = 20;
            rdBtnPrioridadeBaixa.TabStop = true;
            rdBtnPrioridadeBaixa.Text = "Baixa";
            rdBtnPrioridadeBaixa.UseVisualStyleBackColor = true;
            // 
            // rdBtnPrioridadeAlta
            // 
            rdBtnPrioridadeAlta.AutoSize = true;
            rdBtnPrioridadeAlta.Location = new Point(26, 32);
            rdBtnPrioridadeAlta.Name = "rdBtnPrioridadeAlta";
            rdBtnPrioridadeAlta.Size = new Size(46, 19);
            rdBtnPrioridadeAlta.TabIndex = 18;
            rdBtnPrioridadeAlta.TabStop = true;
            rdBtnPrioridadeAlta.Text = "Alta";
            rdBtnPrioridadeAlta.UseVisualStyleBackColor = true;
            // 
            // rdBtnPrioridadeMedia
            // 
            rdBtnPrioridadeMedia.AutoSize = true;
            rdBtnPrioridadeMedia.Location = new Point(26, 57);
            rdBtnPrioridadeMedia.Name = "rdBtnPrioridadeMedia";
            rdBtnPrioridadeMedia.Size = new Size(58, 19);
            rdBtnPrioridadeMedia.TabIndex = 19;
            rdBtnPrioridadeMedia.TabStop = true;
            rdBtnPrioridadeMedia.Text = "Média";
            rdBtnPrioridadeMedia.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(290, 205);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 29;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(371, 205);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 30;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 156);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 31;
            label5.Text = "Data de Início:";
            // 
            // datePickerDataInicio
            // 
            datePickerDataInicio.CustomFormat = "HH:mm";
            datePickerDataInicio.Format = DateTimePickerFormat.Short;
            datePickerDataInicio.Location = new Point(138, 150);
            datePickerDataInicio.Name = "datePickerDataInicio";
            datePickerDataInicio.Size = new Size(108, 23);
            datePickerDataInicio.TabIndex = 32;
            datePickerDataInicio.Value = new DateTime(2023, 5, 18, 14, 52, 34, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 190);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 33;
            label4.Text = "Data de Término:";
            // 
            // datePickerDataTermino
            // 
            datePickerDataTermino.CustomFormat = "HH:mm";
            datePickerDataTermino.Format = DateTimePickerFormat.Short;
            datePickerDataTermino.Location = new Point(138, 184);
            datePickerDataTermino.Name = "datePickerDataTermino";
            datePickerDataTermino.Size = new Size(108, 23);
            datePickerDataTermino.TabIndex = 34;
            datePickerDataTermino.Value = new DateTime(2023, 5, 18, 14, 52, 34, 0);
            // 
            // TelaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(478, 258);
            Controls.Add(datePickerDataTermino);
            Controls.Add(label4);
            Controls.Add(datePickerDataInicio);
            Controls.Add(label5);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(groupBox1);
            Controls.Add(txtDescricao);
            Controls.Add(label3);
            Controls.Add(txtTitulo);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "TelaTarefaForm";
            ShowIcon = false;
            Text = "TelaTarefaForm";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Label label2;
        private TextBox txtTitulo;
        private Label label3;
        private TextBox txtDescricao;
        private GroupBox groupBox1;
        private RadioButton rdBtnPrioridadeBaixa;
        private RadioButton rdBtnPrioridadeAlta;
        private RadioButton rdBtnPrioridadeMedia;
        private Button btnGravar;
        private Button btnCancelar;
        private Label label5;
        private DateTimePicker datePickerDataInicio;
        private Label label4;
        private DateTimePicker datePickerDataTermino;
    }
}