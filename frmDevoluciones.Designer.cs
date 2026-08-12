namespace Biblioteca1
{
    partial class frmDevoluciones
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
            picLogo = new PictureBox();
            lblEstudiante = new Label();
            label2 = new Label();
            lblEstadoLibro = new Label();
            lblFechaDevolucion = new Label();
            txtEstudiante = new TextBox();
            cboLibro = new ComboBox();
            cboEstadoLibro = new ComboBox();
            dtpFechaDevolucion = new DateTimePicker();
            btnNuevo = new Button();
            button2 = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvDevoluciones = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDevoluciones).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Location = new Point(333, 19);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(125, 95);
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblEstudiante
            // 
            lblEstudiante.AutoSize = true;
            lblEstudiante.Location = new Point(111, 184);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(81, 20);
            lblEstudiante.TabIndex = 1;
            lblEstudiante.Text = "Estudiante:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 239);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 2;
            label2.Text = "Libro:";
            // 
            // lblEstadoLibro
            // 
            lblEstadoLibro.AutoSize = true;
            lblEstadoLibro.Location = new Point(75, 295);
            lblEstadoLibro.Name = "lblEstadoLibro";
            lblEstadoLibro.Size = new Size(117, 20);
            lblEstadoLibro.TabIndex = 3;
            lblEstadoLibro.Text = "Estado del libro:";
            // 
            // lblFechaDevolucion
            // 
            lblFechaDevolucion.AutoSize = true;
            lblFechaDevolucion.Location = new Point(42, 351);
            lblFechaDevolucion.Name = "lblFechaDevolucion";
            lblFechaDevolucion.Size = new Size(150, 20);
            lblFechaDevolucion.TabIndex = 4;
            lblFechaDevolucion.Text = "Fecha de Devolución:";
            // 
            // txtEstudiante
            // 
            txtEstudiante.Location = new Point(198, 177);
            txtEstudiante.Name = "txtEstudiante";
            txtEstudiante.Size = new Size(125, 27);
            txtEstudiante.TabIndex = 5;
            // 
            // cboLibro
            // 
            cboLibro.FormattingEnabled = true;
            cboLibro.Location = new Point(198, 231);
            cboLibro.Name = "cboLibro";
            cboLibro.Size = new Size(151, 28);
            cboLibro.TabIndex = 6;
            // 
            // cboEstadoLibro
            // 
            cboEstadoLibro.FormattingEnabled = true;
            cboEstadoLibro.Location = new Point(198, 287);
            cboEstadoLibro.Name = "cboEstadoLibro";
            cboEstadoLibro.Size = new Size(151, 28);
            cboEstadoLibro.TabIndex = 7;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Location = new Point(198, 346);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(250, 27);
            dtpFechaDevolucion.TabIndex = 8;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(27, 445);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 9;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(168, 445);
            button2.Name = "button2";
            button2.Size = new Size(94, 51);
            button2.TabIndex = 10;
            button2.Text = "Registrar Devolución";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(311, 445);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 11;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(463, 445);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(634, 445);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dgvDevoluciones
            // 
            dgvDevoluciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDevoluciones.Location = new Point(41, 526);
            dgvDevoluciones.Name = "dgvDevoluciones";
            dgvDevoluciones.RowHeadersWidth = 51;
            dgvDevoluciones.Size = new Size(687, 188);
            dgvDevoluciones.TabIndex = 14;
            // 
            // frmDevoluciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 746);
            Controls.Add(dgvDevoluciones);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(button2);
            Controls.Add(btnNuevo);
            Controls.Add(dtpFechaDevolucion);
            Controls.Add(cboEstadoLibro);
            Controls.Add(cboLibro);
            Controls.Add(txtEstudiante);
            Controls.Add(lblFechaDevolucion);
            Controls.Add(lblEstadoLibro);
            Controls.Add(label2);
            Controls.Add(lblEstudiante);
            Controls.Add(picLogo);
            Name = "frmDevoluciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRO DE DEVOLUCIONES - LIBRERIA ML";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDevoluciones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Label lblEstudiante;
        private Label label2;
        private Label lblEstadoLibro;
        private Label lblFechaDevolucion;
        private TextBox txtEstudiante;
        private ComboBox cboLibro;
        private ComboBox cboEstadoLibro;
        private DateTimePicker dtpFechaDevolucion;
        private Button btnNuevo;
        private Button button2;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvDevoluciones;
    }
}