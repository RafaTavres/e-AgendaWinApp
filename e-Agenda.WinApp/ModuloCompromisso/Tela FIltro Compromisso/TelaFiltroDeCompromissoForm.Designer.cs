namespace e_Agenda.WinApp.ModuloCompromisso
{
    partial class TelaFiltroDeCompromissoForm
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
            rdBtnVisualizarFuturos = new RadioButton();
            rdBtnVisualizarPassados = new RadioButton();
            rdBtnVisualizarTodos = new RadioButton();
            gpBoxFiltroFuturos = new GroupBox();
            datePickerDataFinal = new DateTimePicker();
            label1 = new Label();
            datePickerDataInicio = new DateTimePicker();
            label5 = new Label();
            btnFiltrar = new Button();
            btnCancelar = new Button();
            gpBoxFiltroFuturos.SuspendLayout();
            SuspendLayout();
            // 
            // rdBtnVisualizarFuturos
            // 
            rdBtnVisualizarFuturos.AutoSize = true;
            rdBtnVisualizarFuturos.Location = new Point(55, 100);
            rdBtnVisualizarFuturos.Name = "rdBtnVisualizarFuturos";
            rdBtnVisualizarFuturos.Size = new Size(252, 19);
            rdBtnVisualizarFuturos.TabIndex = 19;
            rdBtnVisualizarFuturos.TabStop = true;
            rdBtnVisualizarFuturos.Text = "Visualizar somente Compromissos Futuros:";
            rdBtnVisualizarFuturos.UseVisualStyleBackColor = true;
            rdBtnVisualizarFuturos.CheckedChanged += rdBtnVisualizarFuturos_CheckedChanged;
            // 
            // rdBtnVisualizarPassados
            // 
            rdBtnVisualizarPassados.AutoSize = true;
            rdBtnVisualizarPassados.Location = new Point(55, 65);
            rdBtnVisualizarPassados.Name = "rdBtnVisualizarPassados";
            rdBtnVisualizarPassados.Size = new Size(260, 19);
            rdBtnVisualizarPassados.TabIndex = 20;
            rdBtnVisualizarPassados.TabStop = true;
            rdBtnVisualizarPassados.Text = "Visualizar somente Compromissos Passados:";
            rdBtnVisualizarPassados.UseVisualStyleBackColor = true;
            // 
            // rdBtnVisualizarTodos
            // 
            rdBtnVisualizarTodos.AutoSize = true;
            rdBtnVisualizarTodos.Location = new Point(55, 31);
            rdBtnVisualizarTodos.Name = "rdBtnVisualizarTodos";
            rdBtnVisualizarTodos.Size = new Size(208, 19);
            rdBtnVisualizarTodos.TabIndex = 21;
            rdBtnVisualizarTodos.TabStop = true;
            rdBtnVisualizarTodos.Text = "Visualizar todos os Compromissos:";
            rdBtnVisualizarTodos.UseVisualStyleBackColor = true;
            // 
            // gpBoxFiltroFuturos
            // 
            gpBoxFiltroFuturos.Controls.Add(datePickerDataFinal);
            gpBoxFiltroFuturos.Controls.Add(label1);
            gpBoxFiltroFuturos.Controls.Add(datePickerDataInicio);
            gpBoxFiltroFuturos.Controls.Add(label5);
            gpBoxFiltroFuturos.Location = new Point(35, 141);
            gpBoxFiltroFuturos.Name = "gpBoxFiltroFuturos";
            gpBoxFiltroFuturos.Size = new Size(481, 78);
            gpBoxFiltroFuturos.TabIndex = 22;
            gpBoxFiltroFuturos.TabStop = false;
            gpBoxFiltroFuturos.Text = "Filtro para os Compromissos Futuros";
            // 
            // datePickerDataFinal
            // 
            datePickerDataFinal.CustomFormat = "HH:mm";
            datePickerDataFinal.Format = DateTimePickerFormat.Short;
            datePickerDataFinal.Location = new Point(352, 35);
            datePickerDataFinal.Name = "datePickerDataFinal";
            datePickerDataFinal.Size = new Size(108, 23);
            datePickerDataFinal.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(249, 41);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 14;
            label1.Text = "Data do Término:";
            // 
            // datePickerDataInicio
            // 
            datePickerDataInicio.CustomFormat = "HH:mm";
            datePickerDataInicio.Format = DateTimePickerFormat.Short;
            datePickerDataInicio.Location = new Point(115, 35);
            datePickerDataInicio.Name = "datePickerDataInicio";
            datePickerDataInicio.Size = new Size(108, 23);
            datePickerDataInicio.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 41);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 9;
            label5.Text = "Data de Início:";
            // 
            // btnFiltrar
            // 
            btnFiltrar.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnFiltrar.DialogResult = DialogResult.OK;
            btnFiltrar.Location = new Point(349, 238);
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
            btnCancelar.Location = new Point(441, 238);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 41);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaFiltroDeCompromissoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 303);
            Controls.Add(btnCancelar);
            Controls.Add(btnFiltrar);
            Controls.Add(gpBoxFiltroFuturos);
            Controls.Add(rdBtnVisualizarTodos);
            Controls.Add(rdBtnVisualizarPassados);
            Controls.Add(rdBtnVisualizarFuturos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "TelaFiltroDeCompromissoForm";
            ShowIcon = false;
            Text = "Filtro de Compromisso";
            gpBoxFiltroFuturos.ResumeLayout(false);
            gpBoxFiltroFuturos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rdBtnVisualizarFuturos;
        private RadioButton rdBtnVisualizarPassados;
        private RadioButton rdBtnVisualizarTodos;
        private GroupBox gpBoxFiltroFuturos;
        private Label label5;
        private DateTimePicker datePickerDataFinal;
        private Label label1;
        private DateTimePicker datePickerDataInicio;
        private Button btnFiltrar;
        private Button btnCancelar;
    }
}