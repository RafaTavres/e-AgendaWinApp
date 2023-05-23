namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TelaEditarItemsDaTarefaForm
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
            checkListItemsDaTarefa = new CheckedListBox();
            btnGravar = new Button();
            btnCancelar = new Button();
            lblPorcentagemConcluida = new Label();
            SuspendLayout();
            // 
            // checkListItemsDaTarefa
            // 
            checkListItemsDaTarefa.FormattingEnabled = true;
            checkListItemsDaTarefa.Location = new Point(12, 60);
            checkListItemsDaTarefa.Name = "checkListItemsDaTarefa";
            checkListItemsDaTarefa.Size = new Size(709, 328);
            checkListItemsDaTarefa.TabIndex = 0;
            // 
            // btnGravar
            // 
            btnGravar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGravar.DialogResult = DialogResult.OK;
            btnGravar.Location = new Point(552, 408);
            btnGravar.Name = "btnGravar";
            btnGravar.Size = new Size(75, 41);
            btnGravar.TabIndex = 24;
            btnGravar.Text = "Gravar";
            btnGravar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(633, 407);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblPorcentagemConcluida
            // 
            lblPorcentagemConcluida.AutoSize = true;
            lblPorcentagemConcluida.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblPorcentagemConcluida.Location = new Point(12, 27);
            lblPorcentagemConcluida.Name = "lblPorcentagemConcluida";
            lblPorcentagemConcluida.Size = new Size(161, 30);
            lblPorcentagemConcluida.TabIndex = 26;
            lblPorcentagemConcluida.Text = "10% Concluido";
            // 
            // TelaEditarItemsDaTarefaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 461);
            Controls.Add(lblPorcentagemConcluida);
            Controls.Add(btnCancelar);
            Controls.Add(btnGravar);
            Controls.Add(checkListItemsDaTarefa);
            Name = "TelaEditarItemsDaTarefaForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Items";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkListItemsDaTarefa;
        private Button btnGravar;
        private Button btnCancelar;
        private Label lblPorcentagemConcluida;
    }
}