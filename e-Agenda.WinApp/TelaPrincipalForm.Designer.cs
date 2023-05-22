namespace e_Agenda.WinApp
{
    partial class TelaPrincipalForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipalForm));
            menuStrip2 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            contatoToolStripMenuItem = new ToolStripMenuItem();
            compromissosToolStripMenuItem = new ToolStripMenuItem();
            tarefasToolStripMenuItem = new ToolStripMenuItem();
            despesasToolStripMenuItem = new ToolStripMenuItem();
            despesasToolStripMenuItem1 = new ToolStripMenuItem();
            categoriasToolStripMenuItem = new ToolStripMenuItem();
            relatóriosToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            btnInserir = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnDeletar = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnFiltrar = new ToolStripButton();
            btnAdicionatNaLista = new ToolStripButton();
            btnEditarItensDaTarefa = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            lblTipoCadastro = new ToolStripLabel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            panelRegistros = new Panel();
            menuStrip2.SuspendLayout();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem, relatóriosToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1071, 24);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { contatoToolStripMenuItem, compromissosToolStripMenuItem, tarefasToolStripMenuItem, despesasToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // contatoToolStripMenuItem
            // 
            contatoToolStripMenuItem.Name = "contatoToolStripMenuItem";
            contatoToolStripMenuItem.Size = new Size(154, 22);
            contatoToolStripMenuItem.Text = "Contato";
            contatoToolStripMenuItem.Click += contatoToolStripMenuItem_Click;
            // 
            // compromissosToolStripMenuItem
            // 
            compromissosToolStripMenuItem.Name = "compromissosToolStripMenuItem";
            compromissosToolStripMenuItem.Size = new Size(154, 22);
            compromissosToolStripMenuItem.Text = "Compromissos";
            compromissosToolStripMenuItem.Click += compromissosToolStripMenuItem_Click;
            // 
            // tarefasToolStripMenuItem
            // 
            tarefasToolStripMenuItem.Name = "tarefasToolStripMenuItem";
            tarefasToolStripMenuItem.Size = new Size(154, 22);
            tarefasToolStripMenuItem.Text = "Tarefas";
            tarefasToolStripMenuItem.Click += tarefasToolStripMenuItem_Click;
            // 
            // despesasToolStripMenuItem
            // 
            despesasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { despesasToolStripMenuItem1, categoriasToolStripMenuItem });
            despesasToolStripMenuItem.Name = "despesasToolStripMenuItem";
            despesasToolStripMenuItem.Size = new Size(154, 22);
            despesasToolStripMenuItem.Text = "Despesas";
            // 
            // despesasToolStripMenuItem1
            // 
            despesasToolStripMenuItem1.Name = "despesasToolStripMenuItem1";
            despesasToolStripMenuItem1.Size = new Size(130, 22);
            despesasToolStripMenuItem1.Text = "Despesas";
            // 
            // categoriasToolStripMenuItem
            // 
            categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            categoriasToolStripMenuItem.Size = new Size(130, 22);
            categoriasToolStripMenuItem.Text = "Categorias";
            // 
            // relatóriosToolStripMenuItem
            // 
            relatóriosToolStripMenuItem.Name = "relatóriosToolStripMenuItem";
            relatóriosToolStripMenuItem.Size = new Size(71, 20);
            relatóriosToolStripMenuItem.Text = "Relatórios";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnInserir, btnEditar, btnDeletar, toolStripSeparator2, btnFiltrar, btnAdicionatNaLista, btnEditarItensDaTarefa, toolStripSeparator1, lblTipoCadastro });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1071, 45);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            btnInserir.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnInserir.Image = Properties.Resources.plus;
            btnInserir.ImageScaling = ToolStripItemImageScaling.None;
            btnInserir.ImageTransparentColor = Color.Magenta;
            btnInserir.Name = "btnInserir";
            btnInserir.Padding = new Padding(7, 7, 7, 0);
            btnInserir.Size = new Size(42, 42);
            btnInserir.Text = "Inserir";
            btnInserir.Click += btnInserir_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditar.Image = Properties.Resources.edit;
            btnEditar.ImageScaling = ToolStripItemImageScaling.None;
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Padding = new Padding(7);
            btnEditar.Size = new Size(42, 42);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click_1;
            // 
            // btnDeletar
            // 
            btnDeletar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnDeletar.Image = Properties.Resources.trash;
            btnDeletar.ImageScaling = ToolStripItemImageScaling.None;
            btnDeletar.ImageTransparentColor = Color.Magenta;
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Padding = new Padding(7);
            btnDeletar.Size = new Size(42, 42);
            btnDeletar.Text = "Deletar";
            btnDeletar.Click += btnDeletar_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 45);
            // 
            // btnFiltrar
            // 
            btnFiltrar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnFiltrar.Image = (Image)resources.GetObject("btnFiltrar.Image");
            btnFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            btnFiltrar.ImageTransparentColor = Color.Magenta;
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Padding = new Padding(7);
            btnFiltrar.Size = new Size(42, 42);
            btnFiltrar.Text = "Filtro";
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // btnAdicionatNaLista
            // 
            btnAdicionatNaLista.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnAdicionatNaLista.Image = (Image)resources.GetObject("btnAdicionatNaLista.Image");
            btnAdicionatNaLista.ImageScaling = ToolStripItemImageScaling.None;
            btnAdicionatNaLista.ImageTransparentColor = Color.Magenta;
            btnAdicionatNaLista.Name = "btnAdicionatNaLista";
            btnAdicionatNaLista.Padding = new Padding(7);
            btnAdicionatNaLista.Size = new Size(42, 42);
            btnAdicionatNaLista.Text = "toolStripButton4";
            btnAdicionatNaLista.Click += btnAdicionatNaLista_Click;
            // 
            // btnEditarItensDaTarefa
            // 
            btnEditarItensDaTarefa.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnEditarItensDaTarefa.Image = (Image)resources.GetObject("btnEditarItensDaTarefa.Image");
            btnEditarItensDaTarefa.ImageScaling = ToolStripItemImageScaling.None;
            btnEditarItensDaTarefa.ImageTransparentColor = Color.Magenta;
            btnEditarItensDaTarefa.Name = "btnEditarItensDaTarefa";
            btnEditarItensDaTarefa.Padding = new Padding(7);
            btnEditarItensDaTarefa.Size = new Size(42, 42);
            btnEditarItensDaTarefa.Text = "toolStripButton4";
            btnEditarItensDaTarefa.Click += btnEditarItensDaTarefa_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 45);
            // 
            // lblTipoCadastro
            // 
            lblTipoCadastro.BackColor = Color.Transparent;
            lblTipoCadastro.DisplayStyle = ToolStripItemDisplayStyle.Text;
            lblTipoCadastro.Name = "lblTipoCadastro";
            lblTipoCadastro.Size = new Size(67, 42);
            lblTipoCadastro.Text = "                    ";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1071, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(118, 17);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // panelRegistros
            // 
            panelRegistros.BorderStyle = BorderStyle.FixedSingle;
            panelRegistros.Dock = DockStyle.Fill;
            panelRegistros.Location = new Point(0, 69);
            panelRegistros.Name = "panelRegistros";
            panelRegistros.Size = new Size(1071, 359);
            panelRegistros.TabIndex = 4;
            // 
            // TelaPrincipalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 450);
            Controls.Add(panelRegistros);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip2);
            Name = "TelaPrincipalForm";
            ShowIcon = false;
            Text = "e-Agenda 2.0";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem contatoToolStripMenuItem;
        private ToolStripMenuItem compromissosToolStripMenuItem;
        private ToolStripMenuItem tarefasToolStripMenuItem;
        private ToolStripMenuItem despesasToolStripMenuItem;
        private ToolStripMenuItem despesasToolStripMenuItem1;
        private ToolStripMenuItem categoriasToolStripMenuItem;
        private ToolStripMenuItem relatóriosToolStripMenuItem;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private Panel panelRegistros;
        private ToolStripButton btnInserir;
        private ToolStripButton btnEditar;
        private ToolStripButton btnDeletar;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripLabel lblTipoCadastro;
        private ToolStripButton btnFiltrar;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnAdicionatNaLista;
        private ToolStripButton btnEditarItensDaTarefa;
    }
}