namespace e_Agenda.WinApp.ModuloTarefa.Tela_Filtro_Tarefa
{
    partial class TelaFiltroTarefasForm
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
            btnFiltrar = new Button();
            btnCancelar = new Button();
            rdBtnVisualizarTodos = new RadioButton();
            rdBtnVizualizarPrioridadeAlta = new RadioButton();
            rdBtnVizualizarPrioridadeMedia = new RadioButton();
            rdBtnVizualizarPrioridadeBaixa = new RadioButton();
            SuspendLayout();
            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFiltrar.DialogResult = DialogResult.OK;
            btnFiltrar.Location = new Point(123, 200);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(75, 41);
            btnFiltrar.TabIndex = 24;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(204, 200);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // rdBtnVisualizarTodos
            // 
            rdBtnVisualizarTodos.AutoSize = true;
            rdBtnVisualizarTodos.Location = new Point(31, 27);
            rdBtnVisualizarTodos.Name = "rdBtnVisualizarTodos";
            rdBtnVisualizarTodos.Size = new Size(162, 19);
            rdBtnVisualizarTodos.TabIndex = 26;
            rdBtnVisualizarTodos.TabStop = true;
            rdBtnVisualizarTodos.Text = "Visualizar todas as Tarefas:";
            rdBtnVisualizarTodos.UseVisualStyleBackColor = true;
            // 
            // rdBtnVizualizarPrioridadeAlta
            // 
            rdBtnVizualizarPrioridadeAlta.AutoSize = true;
            rdBtnVizualizarPrioridadeAlta.Location = new Point(31, 62);
            rdBtnVizualizarPrioridadeAlta.Name = "rdBtnVizualizarPrioridadeAlta";
            rdBtnVizualizarPrioridadeAlta.Size = new Size(238, 19);
            rdBtnVizualizarPrioridadeAlta.TabIndex = 27;
            rdBtnVizualizarPrioridadeAlta.TabStop = true;
            rdBtnVizualizarPrioridadeAlta.Text = "Visualizar as Tarefas com prioridade Alta:";
            rdBtnVizualizarPrioridadeAlta.UseVisualStyleBackColor = true;
            // 
            // rdBtnVizualizarPrioridadeMedia
            // 
            rdBtnVizualizarPrioridadeMedia.AutoSize = true;
            rdBtnVizualizarPrioridadeMedia.Location = new Point(31, 97);
            rdBtnVizualizarPrioridadeMedia.Name = "rdBtnVizualizarPrioridadeMedia";
            rdBtnVizualizarPrioridadeMedia.Size = new Size(250, 19);
            rdBtnVizualizarPrioridadeMedia.TabIndex = 28;
            rdBtnVizualizarPrioridadeMedia.TabStop = true;
            rdBtnVizualizarPrioridadeMedia.Text = "Visualizar as Tarefas com prioridade Média:";
            rdBtnVizualizarPrioridadeMedia.UseVisualStyleBackColor = true;
            // 
            // rdBtnVizualizarPrioridadeBaixa
            // 
            rdBtnVizualizarPrioridadeBaixa.AutoSize = true;
            rdBtnVizualizarPrioridadeBaixa.Location = new Point(31, 132);
            rdBtnVizualizarPrioridadeBaixa.Name = "rdBtnVizualizarPrioridadeBaixa";
            rdBtnVizualizarPrioridadeBaixa.Size = new Size(245, 19);
            rdBtnVizualizarPrioridadeBaixa.TabIndex = 29;
            rdBtnVizualizarPrioridadeBaixa.TabStop = true;
            rdBtnVizualizarPrioridadeBaixa.Text = "Visualizar as Tarefas com prioridade Baixa:";
            rdBtnVizualizarPrioridadeBaixa.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroTarefasForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(291, 253);
            Controls.Add(rdBtnVizualizarPrioridadeBaixa);
            Controls.Add(rdBtnVizualizarPrioridadeMedia);
            Controls.Add(rdBtnVizualizarPrioridadeAlta);
            Controls.Add(rdBtnVisualizarTodos);
            Controls.Add(btnCancelar);
            Controls.Add(btnFiltrar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "TelaFiltroTarefasForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Filtro Tarefas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnFiltrar;
        private Button btnCancelar;
        private RadioButton rdBtnVisualizarTodos;
        private RadioButton rdBtnVizualizarPrioridadeAlta;
        private RadioButton rdBtnVizualizarPrioridadeMedia;
        private RadioButton rdBtnVizualizarPrioridadeBaixa;
    }
}