namespace e_Agenda.WinApp.ModuloCompromisso
{
    partial class TelaCompromissoForm
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
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            datePickerCompromisso = new DateTimePicker();
            datePickerHoraDeInicio = new DateTimePicker();
            datePickerHoraTermino = new DateTimePicker();
            checkBoxTemContato = new CheckBox();
            cmbBoxListaDeContatos = new ComboBox();
            rdBtnOpcaoRemoto = new RadioButton();
            rdBtnOpcaoPresencial = new RadioButton();
            groupBox1 = new GroupBox();
            txtLocalPresencial = new TextBox();
            txtLocalRemoto = new TextBox();
            txtAssunto = new TextBox();
            txtId = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 22);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 4;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 55);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 5;
            label2.Text = "Assunto:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 82);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 7;
            label4.Text = "Data:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 109);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 8;
            label5.Text = "Hora de Início:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 138);
            label6.Name = "label6";
            label6.Size = new Size(98, 15);
            label6.TabIndex = 9;
            label6.Text = "Hora de Término:";
            // 
            // datePickerCompromisso
            // 
            datePickerCompromisso.Location = new Point(113, 76);
            datePickerCompromisso.Name = "datePickerCompromisso";
            datePickerCompromisso.Size = new Size(230, 23);
            datePickerCompromisso.TabIndex = 11;
            // 
            // datePickerHoraDeInicio
            // 
            datePickerHoraDeInicio.CustomFormat = "HH:mm";
            datePickerHoraDeInicio.Format = DateTimePickerFormat.Time;
            datePickerHoraDeInicio.Location = new Point(112, 105);
            datePickerHoraDeInicio.Name = "datePickerHoraDeInicio";
            datePickerHoraDeInicio.ShowUpDown = true;
            datePickerHoraDeInicio.Size = new Size(108, 23);
            datePickerHoraDeInicio.TabIndex = 12;
            datePickerHoraDeInicio.Value = new DateTime(2023, 5, 18, 14, 52, 34, 0);
            // 
            // datePickerHoraTermino
            // 
            datePickerHoraTermino.CustomFormat = "HH:mm";
            datePickerHoraTermino.Format = DateTimePickerFormat.Time;
            datePickerHoraTermino.Location = new Point(112, 134);
            datePickerHoraTermino.Name = "datePickerHoraTermino";
            datePickerHoraTermino.ShowUpDown = true;
            datePickerHoraTermino.Size = new Size(108, 23);
            datePickerHoraTermino.TabIndex = 13;
            datePickerHoraTermino.Value = new DateTime(2023, 5, 18, 14, 53, 0, 0);
            // 
            // checkBoxTemContato
            // 
            checkBoxTemContato.AutoSize = true;
            checkBoxTemContato.Location = new Point(22, 168);
            checkBoxTemContato.Name = "checkBoxTemContato";
            checkBoxTemContato.Size = new Size(273, 19);
            checkBoxTemContato.TabIndex = 16;
            checkBoxTemContato.Text = "Deseja marcar um contato nesse compromisso";
            checkBoxTemContato.UseVisualStyleBackColor = true;
            checkBoxTemContato.CheckedChanged += checkBoxTemContato_CheckedChanged;
            // 
            // cmbBoxListaDeContatos
            // 
            cmbBoxListaDeContatos.DisplayMember = "nome";
            cmbBoxListaDeContatos.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBoxListaDeContatos.FormattingEnabled = true;
            cmbBoxListaDeContatos.Location = new Point(22, 193);
            cmbBoxListaDeContatos.Name = "cmbBoxListaDeContatos";
            cmbBoxListaDeContatos.Size = new Size(263, 23);
            cmbBoxListaDeContatos.TabIndex = 17;
            // 
            // rdBtnOpcaoRemoto
            // 
            rdBtnOpcaoRemoto.AutoSize = true;
            rdBtnOpcaoRemoto.Location = new Point(31, 32);
            rdBtnOpcaoRemoto.Name = "rdBtnOpcaoRemoto";
            rdBtnOpcaoRemoto.Size = new Size(70, 19);
            rdBtnOpcaoRemoto.TabIndex = 18;
            rdBtnOpcaoRemoto.TabStop = true;
            rdBtnOpcaoRemoto.Text = "Remoto:";
            rdBtnOpcaoRemoto.UseVisualStyleBackColor = true;
            rdBtnOpcaoRemoto.CheckedChanged += rdBtnOpcaoRemoto_CheckedChanged;
            // 
            // rdBtnOpcaoPresencial
            // 
            rdBtnOpcaoPresencial.AutoSize = true;
            rdBtnOpcaoPresencial.Location = new Point(31, 65);
            rdBtnOpcaoPresencial.Name = "rdBtnOpcaoPresencial";
            rdBtnOpcaoPresencial.Size = new Size(81, 19);
            rdBtnOpcaoPresencial.TabIndex = 19;
            rdBtnOpcaoPresencial.TabStop = true;
            rdBtnOpcaoPresencial.Text = "Presencial:";
            rdBtnOpcaoPresencial.UseVisualStyleBackColor = true;
            rdBtnOpcaoPresencial.CheckedChanged += rdBtnOpcaoPresencial_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtLocalPresencial);
            groupBox1.Controls.Add(txtLocalRemoto);
            groupBox1.Controls.Add(rdBtnOpcaoRemoto);
            groupBox1.Controls.Add(rdBtnOpcaoPresencial);
            groupBox1.Location = new Point(22, 239);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 126);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Localizacao";
            // 
            // txtLocalPresencial
            // 
            txtLocalPresencial.Location = new Point(121, 61);
            txtLocalPresencial.Name = "txtLocalPresencial";
            txtLocalPresencial.Size = new Size(243, 23);
            txtLocalPresencial.TabIndex = 23;
            // 
            // txtLocalRemoto
            // 
            txtLocalRemoto.Location = new Point(121, 28);
            txtLocalRemoto.Name = "txtLocalRemoto";
            txtLocalRemoto.Size = new Size(243, 23);
            txtLocalRemoto.TabIndex = 22;
            // 
            // txtAssunto
            // 
            txtAssunto.Location = new Point(113, 47);
            txtAssunto.Name = "txtAssunto";
            txtAssunto.Size = new Size(395, 23);
            txtAssunto.TabIndex = 21;
            // 
            // txtId
            // 
            txtId.Location = new Point(112, 18);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 22;
            txtId.Text = "0";
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(377, 371);
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
            btnCancelar.Location = new Point(458, 371);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 424);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtId);
            Controls.Add(txtAssunto);
            Controls.Add(groupBox1);
            Controls.Add(cmbBoxListaDeContatos);
            Controls.Add(checkBoxTemContato);
            Controls.Add(datePickerHoraTermino);
            Controls.Add(datePickerHoraDeInicio);
            Controls.Add(datePickerCompromisso);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "TelaCompromissoForm";
            ShowIcon = false;
            Text = "Compromissos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker datePickerCompromisso;
        private DateTimePicker datePickerHoraDeInicio;
        private DateTimePicker datePickerHoraTermino;
        private CheckBox checkBoxTemContato;
        private ComboBox cmbBoxListaDeContatos;
        private RadioButton rdBtnOpcaoRemoto;
        private RadioButton rdBtnOpcaoPresencial;
        private GroupBox groupBox1;
        private TextBox txtAssunto;
        private TextBox txtId;
        private TextBox txtLocalPresencial;
        private TextBox txtLocalRemoto;
        private Button btnGravar;
        private Button btnCancelar;
    }
}