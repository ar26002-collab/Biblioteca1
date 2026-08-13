namespace Biblioteca1
{
    partial class frmPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrestamos));
            lblEstudiante = new Label();
            lblLibro = new Label();
            lblEstadoLibro = new Label();
            lblFechaPrestamo = new Label();
            txtEstudiante = new TextBox();
            cboLibro = new ComboBox();
            cboEstadoLibro = new ComboBox();
            dtpFechaPrestamo = new DateTimePicker();
            btnRegistrarPrestamo = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvPrestamos = new DataGridView();
            picLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblEstudiante
            // 
            lblEstudiante.AutoSize = true;
            lblEstudiante.Location = new Point(157, 174);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(81, 20);
            lblEstudiante.TabIndex = 0;
            lblEstudiante.Text = "Estudiante:";
            lblEstudiante.Click += lblEstudiante_Click;
            // 
            // lblLibro
            // 
            lblLibro.AutoSize = true;
            lblLibro.Location = new Point(192, 238);
            lblLibro.Name = "lblLibro";
            lblLibro.Size = new Size(46, 20);
            lblLibro.TabIndex = 1;
            lblLibro.Text = "Libro:";
            // 
            // lblEstadoLibro
            // 
            lblEstadoLibro.AutoSize = true;
            lblEstadoLibro.Location = new Point(121, 301);
            lblEstadoLibro.Name = "lblEstadoLibro";
            lblEstadoLibro.Size = new Size(117, 20);
            lblEstadoLibro.TabIndex = 2;
            lblEstadoLibro.Text = "Estado del libro:";
            // 
            // lblFechaPrestamo
            // 
            lblFechaPrestamo.AutoSize = true;
            lblFechaPrestamo.Location = new Point(101, 360);
            lblFechaPrestamo.Name = "lblFechaPrestamo";
            lblFechaPrestamo.Size = new Size(137, 20);
            lblFechaPrestamo.TabIndex = 3;
            lblFechaPrestamo.Text = "Fecha de Préstamo:";
            // 
            // txtEstudiante
            // 
            txtEstudiante.Location = new Point(244, 167);
            txtEstudiante.Name = "txtEstudiante";
            txtEstudiante.Size = new Size(125, 27);
            txtEstudiante.TabIndex = 4;
            // 
            // cboLibro
            // 
            cboLibro.FormattingEnabled = true;
            cboLibro.Location = new Point(244, 230);
            cboLibro.Name = "cboLibro";
            cboLibro.Size = new Size(151, 28);
            cboLibro.TabIndex = 5;
            // 
            // cboEstadoLibro
            // 
            cboEstadoLibro.FormattingEnabled = true;
            cboEstadoLibro.Location = new Point(244, 293);
            cboEstadoLibro.Name = "cboEstadoLibro";
            cboEstadoLibro.Size = new Size(151, 28);
            cboEstadoLibro.TabIndex = 6;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Location = new Point(244, 355);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(250, 27);
            dtpFechaPrestamo.TabIndex = 7;
            // 
            // btnRegistrarPrestamo
            // 
            btnRegistrarPrestamo.Location = new Point(60, 428);
            btnRegistrarPrestamo.Name = "btnRegistrarPrestamo";
            btnRegistrarPrestamo.Size = new Size(148, 41);
            btnRegistrarPrestamo.TabIndex = 9;
            btnRegistrarPrestamo.Text = "Registrar Préstamo";
            btnRegistrarPrestamo.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(252, 428);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 41);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(400, 428);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 41);
            btnEliminar.TabIndex = 11;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(557, 428);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 41);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Location = new Point(72, 501);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.RowHeadersWidth = 51;
            dgvPrestamos.Size = new Size(629, 188);
            dgvPrestamos.TabIndex = 13;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(318, 12);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(144, 125);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 14;
            picLogo.TabStop = false;
            // 
            // frmPrestamos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 726);
            Controls.Add(picLogo);
            Controls.Add(dgvPrestamos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnRegistrarPrestamo);
            Controls.Add(dtpFechaPrestamo);
            Controls.Add(cboEstadoLibro);
            Controls.Add(cboLibro);
            Controls.Add(txtEstudiante);
            Controls.Add(lblFechaPrestamo);
            Controls.Add(lblEstadoLibro);
            Controls.Add(lblLibro);
            Controls.Add(lblEstudiante);
            Name = "frmPrestamos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRO DE PRÉSTAMOS - LIBRERIA ML";
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEstudiante;
        private Label lblLibro;
        private Label lblEstadoLibro;
        private Label lblFechaPrestamo;
        private TextBox txtEstudiante;
        private ComboBox cboLibro;
        private ComboBox cboEstadoLibro;
        private DateTimePicker dtpFechaPrestamo;
        private Button btnRegistrarPrestamo;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvPrestamos;
        private PictureBox picLogo;
    }
}