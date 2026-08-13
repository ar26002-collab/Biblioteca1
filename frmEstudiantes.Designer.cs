namespace Biblioteca1
{
    partial class frmEstudiantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstudiantes));
            picLogo = new PictureBox();
            lblNombre = new Label();
            label2 = new Label();
            label3 = new Label();
            txtContacto = new TextBox();
            txtNombre = new TextBox();
            cboTipoUsuario = new ComboBox();
            btnNuevo = new Button();
            btnAceptar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            dgvEstudiantes = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(296, 31);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(143, 136);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(223, 255);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(173, 313);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 2;
            label2.Text = "Tipo de Usuario:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 370);
            label3.Name = "label3";
            label3.Size = new Size(136, 20);
            label3.TabIndex = 3;
            label3.Text = "Contacto/Teléfono:";
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(296, 363);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(125, 27);
            txtContacto.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(296, 248);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 5;
            // 
            // cboTipoUsuario
            // 
            cboTipoUsuario.FormattingEnabled = true;
            cboTipoUsuario.Location = new Point(296, 305);
            cboTipoUsuario.Name = "cboTipoUsuario";
            cboTipoUsuario.Size = new Size(151, 28);
            cboTipoUsuario.TabIndex = 6;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(46, 468);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 7;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(178, 468);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 8;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(315, 468);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 9;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(466, 468);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 10;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(619, 468);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstudiantes.Location = new Point(99, 560);
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.RowHeadersWidth = 51;
            dgvEstudiantes.Size = new Size(605, 157);
            dgvEstudiantes.TabIndex = 12;
            // 
            // frmEstudiantes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 758);
            Controls.Add(dgvEstudiantes);
            Controls.Add(btnLimpiar);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAceptar);
            Controls.Add(btnNuevo);
            Controls.Add(cboTipoUsuario);
            Controls.Add(txtNombre);
            Controls.Add(txtContacto);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblNombre);
            Controls.Add(picLogo);
            Name = "frmEstudiantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "REGISTRO DE ESTUDIANTES - LIBRERIA ML";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Label lblNombre;
        private Label label2;
        private Label label3;
        private TextBox txtContacto;
        private TextBox txtNombre;
        private ComboBox cboTipoUsuario;
        private Button btnNuevo;
        private Button btnAceptar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnLimpiar;
        private DataGridView dgvEstudiantes;
    }
}