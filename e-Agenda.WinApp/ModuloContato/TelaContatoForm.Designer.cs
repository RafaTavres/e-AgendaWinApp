namespace e_Agenda.WinApp.ModuloContato
{
    partial class TelaContatoForm
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
            label5 = new Label();
            txtNome = new TextBox();
            txtTelefone = new TextBox();
            txtCargo = new TextBox();
            txtEmail = new TextBox();
            txtEmpresa = new TextBox();
            btnGravar = new Button();
            btnCancelar = new Button();
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
            label2.Location = new Point(42, 42);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 5;
            label2.Text = "Nome:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 74);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 11;
            label3.Text = "Telefone:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 106);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 14;
            label6.Text = "Cargo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(263, 81);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 15;
            label4.Text = "E-mail:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(252, 106);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 16;
            label5.Text = "Empresa:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(91, 42);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(395, 23);
            txtNome.TabIndex = 17;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(91, 74);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(149, 23);
            txtTelefone.TabIndex = 18;
            // 
            // txtCargo
            // 
            txtCargo.Location = new Point(91, 103);
            txtCargo.Name = "txtCargo";
            txtCargo.Size = new Size(149, 23);
            txtCargo.TabIndex = 19;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(313, 74);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(149, 23);
            txtEmail.TabIndex = 20;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(313, 103);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(149, 23);
            txtEmpresa.TabIndex = 21;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(337, 180);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 22;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            btnGravar.Click += btnGravar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(418, 180);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 23;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaContatoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 233);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(txtEmpresa);
            Controls.Add(txtEmail);
            Controls.Add(txtCargo);
            Controls.Add(txtTelefone);
            Controls.Add(txtNome);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtId);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "TelaContatoForm";
            Text = "Cadastro de Contatos";
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
        private TextBox txtNome;
        private TextBox txtTelefone;
        private TextBox txtCargo;
        private TextBox txtEmail;
        private TextBox txtEmpresa;
        private Button btnGravar;
        private Button btnCancelar;
    }
}