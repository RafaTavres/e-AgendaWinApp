namespace e_Agenda.WinApp.ModuloDespesas
{
    partial class TabelaCategoriasControl
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
            tabelaCategorias = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelaCategorias).BeginInit();
            SuspendLayout();
            // 
            // tabelaCategorias
            // 
            tabelaCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaCategorias.Location = new Point(3, 3);
            tabelaCategorias.Name = "tabelaCategorias";
            tabelaCategorias.RowTemplate.Height = 25;
            tabelaCategorias.Size = new Size(530, 462);
            tabelaCategorias.TabIndex = 0;
            // 
            // TabelaCategoriasControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabelaCategorias);
            Name = "TabelaCategoriasControl";
            Size = new Size(536, 468);
            ((System.ComponentModel.ISupportInitialize)tabelaCategorias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelaCategorias;
    }
}
