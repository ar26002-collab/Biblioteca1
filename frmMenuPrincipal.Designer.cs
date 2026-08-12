namespace Biblioteca1
{
    partial class frmMenuPrincipal
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
            lblBienvenida = new Label();
            picLogo = new PictureBox();
            btnNavLibros = new Button();
            btnNavUsuarios = new Button();
            btnNavPrestamos = new Button();
            btnNavDevoluciones = new Button();
            btnNavReportes = new Button();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(236, 124);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(314, 23);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "HOLA, BIENVENIDO/A A LIBRERIA ML";
            // 
            // picLogo
            // 
            picLogo.Location = new Point(325, 33);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(125, 62);
            picLogo.TabIndex = 1;
            picLogo.TabStop = false;
            // 
            // btnNavLibros
            // 
            btnNavLibros.Location = new Point(45, 364);
            btnNavLibros.Name = "btnNavLibros";
            btnNavLibros.Size = new Size(94, 40);
            btnNavLibros.TabIndex = 2;
            btnNavLibros.Text = "Libros";
            btnNavLibros.UseVisualStyleBackColor = true;
            // 
            // btnNavUsuarios
            // 
            btnNavUsuarios.Location = new Point(169, 364);
            btnNavUsuarios.Name = "btnNavUsuarios";
            btnNavUsuarios.Size = new Size(163, 40);
            btnNavUsuarios.TabIndex = 3;
            btnNavUsuarios.Text = "Usuarios/Estudiantes";
            btnNavUsuarios.UseVisualStyleBackColor = true;
            // 
            // btnNavPrestamos
            // 
            btnNavPrestamos.Location = new Point(381, 364);
            btnNavPrestamos.Name = "btnNavPrestamos";
            btnNavPrestamos.Size = new Size(94, 40);
            btnNavPrestamos.TabIndex = 4;
            btnNavPrestamos.Text = "Préstamos";
            btnNavPrestamos.UseVisualStyleBackColor = true;
            // 
            // btnNavDevoluciones
            // 
            btnNavDevoluciones.Location = new Point(524, 364);
            btnNavDevoluciones.Name = "btnNavDevoluciones";
            btnNavDevoluciones.Size = new Size(114, 38);
            btnNavDevoluciones.TabIndex = 5;
            btnNavDevoluciones.Text = "Devoluciones";
            btnNavDevoluciones.UseVisualStyleBackColor = true;
            // 
            // btnNavReportes
            // 
            btnNavReportes.Location = new Point(676, 364);
            btnNavReportes.Name = "btnNavReportes";
            btnNavReportes.Size = new Size(94, 40);
            btnNavReportes.TabIndex = 6;
            btnNavReportes.Text = "Reportes";
            btnNavReportes.UseVisualStyleBackColor = true;
            // 
            // frmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 517);
            Controls.Add(btnNavReportes);
            Controls.Add(btnNavDevoluciones);
            Controls.Add(btnNavPrestamos);
            Controls.Add(btnNavUsuarios);
            Controls.Add(btnNavLibros);
            Controls.Add(picLogo);
            Controls.Add(lblBienvenida);
            Name = "frmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MENÚ PRINCIPAL - LIBRERIA ML ";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private PictureBox picLogo;
        private Button btnNavLibros;
        private Button btnNavUsuarios;
        private Button btnNavPrestamos;
        private Button btnNavDevoluciones;
        private Button btnNavReportes;
    }
}