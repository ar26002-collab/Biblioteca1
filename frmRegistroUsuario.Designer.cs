namespace Biblioteca1
{
    partial class frmRegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroUsuario));
            picLogo = new PictureBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblTipoUsuario = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblConfirmarPassword = new Label();
            txtConfirmarPassword = new TextBox();
            btnRegistrar = new Button();
            cboTipoUsuario = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // picLogo
            // 
            picLogo.Image = (Image)resources.GetObject("picLogo.Image");
            picLogo.Location = new Point(339, 51);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(154, 128);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(181, 286);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(254, 279);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 2;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(191, 346);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(57, 20);
            lblCorreo.TabIndex = 3;
            lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(254, 339);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(125, 27);
            txtCorreo.TabIndex = 4;
            // 
            // lblTipoUsuario
            // 
            lblTipoUsuario.AutoSize = true;
            lblTipoUsuario.Location = new Point(133, 405);
            lblTipoUsuario.Name = "lblTipoUsuario";
            lblTipoUsuario.Size = new Size(115, 20);
            lblTipoUsuario.TabIndex = 5;
            lblTipoUsuario.Text = "Tipo de usuario:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(162, 459);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(86, 20);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(254, 452);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(125, 27);
            txtPassword.TabIndex = 8;
            // 
            // lblConfirmarPassword
            // 
            lblConfirmarPassword.AutoSize = true;
            lblConfirmarPassword.Location = new Point(94, 514);
            lblConfirmarPassword.Name = "lblConfirmarPassword";
            lblConfirmarPassword.Size = new Size(154, 20);
            lblConfirmarPassword.TabIndex = 9;
            lblConfirmarPassword.Text = "Confirmar contraseña:";
            // 
            // txtConfirmarPassword
            // 
            txtConfirmarPassword.Location = new Point(254, 507);
            txtConfirmarPassword.Name = "txtConfirmarPassword";
            txtConfirmarPassword.Size = new Size(125, 27);
            txtConfirmarPassword.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(325, 583);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(125, 51);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // cboTipoUsuario
            // 
            cboTipoUsuario.FormattingEnabled = true;
            cboTipoUsuario.Location = new Point(254, 397);
            cboTipoUsuario.Name = "cboTipoUsuario";
            cboTipoUsuario.Size = new Size(151, 28);
            cboTipoUsuario.TabIndex = 12;
            // 
            // frmRegistroUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 663);
            Controls.Add(cboTipoUsuario);
            Controls.Add(btnRegistrar);
            Controls.Add(txtConfirmarPassword);
            Controls.Add(lblConfirmarPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblTipoUsuario);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(picLogo);
            Name = "frmRegistroUsuario";
            Text = "REGISTRO DE USUARIO - LIBRERIA ML";
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picLogo;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblTipoUsuario;
        private Label lblPassword;
        private TextBox txtPassword;
        private Label lblConfirmarPassword;
        private TextBox txtConfirmarPassword;
        private Button btnRegistrar;
        private ComboBox cboTipoUsuario;
    }
}