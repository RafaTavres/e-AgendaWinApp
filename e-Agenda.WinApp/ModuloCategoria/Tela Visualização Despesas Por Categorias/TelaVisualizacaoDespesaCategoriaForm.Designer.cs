namespace e_Agenda.WinApp.ModuloCategoria
{
    partial class TelaVisualizacaoDespesaCategoriaForm
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            lblCategoria = new Label();
            btnFechar = new Button();
            listaDespesas = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listaDespesas);
            groupBox1.Location = new Point(32, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(682, 231);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Despesas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 29);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 2;
            label1.Text = "Categoria:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCategoria.Location = new Point(99, 29);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(49, 15);
            lblCategoria.TabIndex = 1;
            lblCategoria.Text = "Churras";
            // 
            // btnFechar
            // 
            btnFechar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFechar.DialogResult = DialogResult.Cancel;
            btnFechar.Location = new Point(622, 314);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 41);
            btnFechar.TabIndex = 24;
            btnFechar.Text = "Fechar";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // listaDespesas
            // 
            listaDespesas.Dock = DockStyle.Fill;
            listaDespesas.FormattingEnabled = true;
            listaDespesas.ItemHeight = 15;
            listaDespesas.Location = new Point(3, 19);
            listaDespesas.Name = "listaDespesas";
            listaDespesas.Size = new Size(676, 209);
            listaDespesas.TabIndex = 0;
            // 
            // TelaVisualizacaoDespesaCategoriaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(718, 367);
            Controls.Add(btnFechar);
            Controls.Add(lblCategoria);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "TelaVisualizacaoDespesaCategoriaForm";
            Text = "Visualização de Despesas da Categoria";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private Label label1;
        private Label lblCategoria;
        private Button btnFechar;
        private ListBox listaDespesas;
    }
}