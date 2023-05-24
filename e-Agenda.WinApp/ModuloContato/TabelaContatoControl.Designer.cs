namespace e_Agenda.WinApp.ModuloContato
{
    partial class TabelaContatoControl
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
            tabelaContato = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelaContato).BeginInit();
            SuspendLayout();
            // 
            // tabelaContato
            // 
            tabelaContato.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaContato.Location = new Point(115, 94);
            tabelaContato.Name = "tabelaContato";
            tabelaContato.RowTemplate.Height = 25;
            tabelaContato.Size = new Size(240, 150);
            tabelaContato.TabIndex = 0;
            // 
            // ListagemContatoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabelaContato);
            Name = "ListagemContatoControl";
            Size = new Size(594, 405);
            ((System.ComponentModel.ISupportInitialize)tabelaContato).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelaContato;
    }
}
