namespace e_Agenda.WinApp.ModuloTarefa
{
    partial class TabelaTarefaControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabelaTarefas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelaTarefas).BeginInit();
            SuspendLayout();
            // 
            // tabelaTarefas
            // 
            tabelaTarefas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaTarefas.Dock = DockStyle.Fill;
            tabelaTarefas.Location = new Point(0, 0);
            tabelaTarefas.Name = "tabelaTarefas";
            tabelaTarefas.RowTemplate.Height = 25;
            tabelaTarefas.Size = new Size(519, 369);
            tabelaTarefas.TabIndex = 0;
            // 
            // ListagemTarefaControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabelaTarefas);
            Name = "ListagemTarefaControl";
            Size = new Size(519, 369);
            ((System.ComponentModel.ISupportInitialize)tabelaTarefas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelaTarefas;
    }
}
