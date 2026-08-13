namespace Biblioteca1
{
    partial class frmLibros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLibros));
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
            btnActualizar = new Button();
            dgvLibros = new DataGridView();
            picLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(54, 233);
            lblId.Name = "lblId";
            lblId.Size = new Size(87, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID del libro:";
            lblId.Click += label1_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(147, 226);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(84, 564);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(367, 564);
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
            lblTitulo.Location = new Point(91, 287);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(50, 20);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Título:";
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(147, 280);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(236, 27);
            txtTitulo.TabIndex = 5;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(92, 342);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(49, 20);
            lblAutor.TabIndex = 6;
            lblAutor.Text = "Autor:";
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(146, 335);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(236, 27);
            txtAutor.TabIndex = 7;
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Location = new Point(73, 397);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(68, 20);
            lblEditorial.TabIndex = 8;
            lblEditorial.Text = "Editorial:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(64, 451);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(77, 20);
            lblCategoria.TabIndex = 9;
            lblCategoria.Text = "Categoria:";
            // 
            // txtEditorial
            // 
            txtEditorial.Location = new Point(147, 390);
            txtEditorial.Name = "txtEditorial";
            txtEditorial.Size = new Size(235, 27);
            txtEditorial.TabIndex = 10;
            // 
            // cboCategoria
            // 
            cboCategoria.FormattingEnabled = true;
            cboCategoria.Location = new Point(147, 443);
            cboCategoria.Name = "cboCategoria";
            cboCategoria.Size = new Size(233, 28);
            cboCategoria.TabIndex = 12;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(84, 504);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(57, 20);
            lblEstado.TabIndex = 13;
            lblEstado.Text = "Estado:";
            // 
            // cboEstado
            // 
            cboEstado.FormattingEnabled = true;
            cboEstado.Location = new Point(147, 496);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(151, 28);
            cboEstado.TabIndex = 15;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(518, 564);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 16;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(223, 564);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 18;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // dgvLibros
            // 
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(84, 628);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.RowHeadersWidth = 51;
            dgvLibros.Size = new Size(611, 188);
            dgvLibros.TabIndex = 19;
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(269, 21);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(192, 142);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 20;
            picLogo.TabStop = false;
            // 
            // frmLibros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 850);
            Controls.Add(picLogo);
            Controls.Add(dgvLibros);
            Controls.Add(btnActualizar);
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
            Name = "frmLibros";
            Text = "REGISTRO DE LIBROS - LIBRERIA ML";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
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
        private Button btnActualizar;
        private DataGridView dgvLibros;
        private PictureBox picLogo;
    }
}
