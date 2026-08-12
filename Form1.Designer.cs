namespace Biblioteca1
{
    partial class frmBiblioteca
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
            lblId = new Label();
            txtId = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            lblTitulo = new Label();
            txtTitulo = new TextBox();
            lblAutor = new Label();
            txtAutor = new TextBox();
            lblEditorial = new Label();
            lblCategoria = new Label();
            txtEditorial = new TextBox();
            cboCategoria = new ComboBox();
            lblEstado = new Label();
            cboEstado = new ComboBox();
            btnLimpiar = new Button();
            btnNuevo = new Button();
            btnActualizar = new Button();
            dgvLibros = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(36, 46);
            lblId.Name = "lblId";
            lblId.Size = new Size(87, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID del libro:";
            lblId.Click += label1_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(129, 43);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(198, 404);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(478, 404);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(73, 88);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(50, 20);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Título:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(129, 85);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(236, 27);
            txtTitulo.TabIndex = 5;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(74, 144);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(49, 20);
            lblAutor.TabIndex = 6;
            lblAutor.Text = "Autor:";
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(129, 144);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(236, 27);
            txtAutor.TabIndex = 7;
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Location = new Point(55, 199);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(68, 20);
            lblEditorial.TabIndex = 8;
            lblEditorial.Text = "Editorial:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(46, 247);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(77, 20);
            lblCategoria.TabIndex = 9;
            lblCategoria.Text = "Categoria:";
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(130, 196);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(235, 27);
            txtEditorial.TabIndex = 10;
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(129, 239);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(233, 28);
            cboCategoria.TabIndex = 12;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(66, 296);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 20);
            lblEstado.TabIndex = 13;
            lblEstado.Text = "Estado:";
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(130, 293);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(151, 28);
            cboEstado.TabIndex = 15;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(624, 404);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(66, 404);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 17;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(338, 404);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 18;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(73, 521);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersWidth = 51;
            dgvLibros.Size = new Size(611, 188);
            dgvLibros.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(410, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // frmBiblioteca
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 738);
            Controls.Add(pictureBox1);
            Controls.Add(dgvLibros);
            Controls.Add(btnActualizar);
            Controls.Add(btnNuevo);
            Controls.Add(btnLimpiar);
            Controls.Add(cboEstado);
            Controls.Add(lblEstado);
            Controls.Add(cboCategoria);
            Controls.Add(txtEditorial);
            Controls.Add(lblCategoria);
            Controls.Add(lblEditorial);
            Controls.Add(txtAutor);
            Controls.Add(lblAutor);
            Controls.Add(txtTitulo);
            Controls.Add(lblTitulo);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Name = "frmBiblioteca";
            Text = "REGISTRO DE LIBROS - LIBRERIA ML";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private Button btnAgregar;
        private Button btnEliminar;
        private Label lblTitulo;
        private TextBox txtTitulo;
        private Label lblAutor;
        private TextBox txtAutor;
        private Label lblEditorial;
        private Label lblCategoria;
        private TextBox txtEditorial;
        private ComboBox cboCategoria;
        private Label lblEstado;
        private ComboBox cboEstado;
        private Button btnLimpiar;
        private Button btnNuevo;
        private Button btnActualizar;
        private DataGridView dgvLibros;
        private PictureBox pictureBox1;
    }
}
