namespace Biblioteca1
{
    partial class frmReportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReportes));
            picLogo = new PictureBox();
            lblFechaInicial = new Label();
            lblFechaFinal = new Label();
            lblTipoReporte = new Label();
            dtpFechaInicial = new DateTimePicker();
            dtpFechaFinal = new DateTimePicker();
            cboTipoReporte = new ComboBox();
            btnImprimirPdf = new Button();
            btnExportarPdf = new Button();
            btnLimpiar = new Button();
            dgvReportes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(277, 26);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(185, 147);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblFechaInicial
            // 
            lblFechaInicial.AutoSize = true;
            lblFechaInicial.Location = new Point(178, 250);
            lblFechaInicial.Name = "lblFechaInicial";
            lblFechaInicial.Size = new Size(93, 20);
            lblFechaInicial.TabIndex = 1;
            lblFechaInicial.Text = "Fecha Inicial:";
            // 
            // lblFechaFinal
            // 
            lblFechaFinal.AutoSize = true;
            lblFechaFinal.Location = new Point(186, 324);
            lblFechaFinal.Name = "lblFechaFinal";
            lblFechaFinal.Size = new Size(85, 20);
            lblFechaFinal.TabIndex = 2;
            lblFechaFinal.Text = "Fecha Final:";
            // 
            // lblTipoReporte
            // 
            lblTipoReporte.AutoSize = true;
            lblTipoReporte.Location = new Point(155, 393);
            lblTipoReporte.Name = "lblTipoReporte";
            lblTipoReporte.Size = new Size(116, 20);
            lblTipoReporte.TabIndex = 3;
            lblTipoReporte.Text = "Tipo de reporte:";
            // 
            // dtpFechaInicial
            // 
            dtpFechaInicial.Location = new Point(277, 243);
            dtpFechaInicial.Name = "dtpFechaInicial";
            dtpFechaInicial.Size = new Size(250, 27);
            dtpFechaInicial.TabIndex = 4;
            // 
            // dtpFechaFinal
            // 
            dtpFechaFinal.Location = new Point(277, 317);
            dtpFechaFinal.Name = "dtpFechaFinal";
            dtpFechaFinal.Size = new Size(250, 27);
            dtpFechaFinal.TabIndex = 5;
            // 
            // cboTipoReporte
            // 
            cboTipoReporte.FormattingEnabled = true;
            cboTipoReporte.Location = new Point(277, 385);
            cboTipoReporte.Name = "cboTipoReporte";
            cboTipoReporte.Size = new Size(151, 28);
            cboTipoReporte.TabIndex = 6;
            // 
            // btnImprimirPdf
            // 
            btnImprimirPdf.Location = new Point(118, 483);
            btnImprimirPdf.Name = "btnImprimirPdf";
            btnImprimirPdf.Size = new Size(94, 48);
            btnImprimirPdf.TabIndex = 7;
            btnImprimirPdf.Text = "Imprimir PDF";
            btnImprimirPdf.UseVisualStyleBackColor = true;
            // 
            // btnExportarPdf
            // 
            btnExportarPdf.Location = new Point(352, 483);
            btnExportarPdf.Name = "btnExportarPdf";
            btnExportarPdf.Size = new Size(94, 48);
            btnExportarPdf.TabIndex = 8;
            btnExportarPdf.Text = "Exportar PDF";
            btnExportarPdf.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(587, 483);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 48);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dgvReportes
            // 
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Location = new Point(68, 556);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.RowHeadersWidth = 51;
            dgvReportes.Size = new Size(666, 188);
            dgvReportes.TabIndex = 10;
            // 
            // frmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 780);
            Controls.Add(dgvReportes);
            Controls.Add(btnLimpiar);
            Controls.Add(btnExportarPdf);
            Controls.Add(btnImprimirPdf);
            Controls.Add(cboTipoReporte);
            Controls.Add(dtpFechaFinal);
            Controls.Add(dtpFechaInicial);
            Controls.Add(lblTipoReporte);
            Controls.Add(lblFechaFinal);
            Controls.Add(lblFechaInicial);
            Controls.Add(picLogo);
            Name = "frmReportes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GESTIÓN DE REPORTES - LIBRERIA ML";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Label lblFechaInicial;
        private Label lblFechaFinal;
        private Label lblTipoReporte;
        private DateTimePicker dtpFechaInicial;
        private DateTimePicker dtpFechaFinal;
        private ComboBox cboTipoReporte;
        private Button btnImprimirPdf;
        private Button btnExportarPdf;
        private Button btnLimpiar;
        private DataGridView dgvReportes;
    }
}