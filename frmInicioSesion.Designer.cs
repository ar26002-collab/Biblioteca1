namespace Biblioteca1
{
    partial class frmInicioSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnIniciarSesion = new Button();
            btnGoogle = new Button();
            btnFacebook = new Button();
            lnkOlvidastePassword = new LinkLabel();
            piclogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)piclogo).BeginInit();
            SuspendLayout();
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(36, 173);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(135, 20);
            lblCorreo.TabIndex = 1;
            lblCorreo.Text = "Correo electrónico:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(177, 173);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(155, 27);
            txtCorreo.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(85, 234);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(86, 20);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Contraseña:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(177, 231);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(155, 27);
            txtPassword.TabIndex = 4;
            // 
            // btnIniciarSesion
            // 
            btnIniciarSesion.Location = new Point(58, 332);
            btnIniciarSesion.Name = "btnIniciarSesion";
            btnIniciarSesion.Size = new Size(113, 46);
            btnIniciarSesion.TabIndex = 5;
            btnIniciarSesion.Text = "Iniciar Sesión";
            btnIniciarSesion.UseVisualStyleBackColor = true;
            // 
            // btnGoogle
            // 
            btnGoogle.Location = new Point(255, 332);
            btnGoogle.Name = "btnGoogle";
            btnGoogle.Size = new Size(94, 42);
            btnGoogle.TabIndex = 6;
            btnGoogle.Text = "Google";
            btnGoogle.UseVisualStyleBackColor = true;
            btnGoogle.Click += button2_Click;
            // 
            // btnFacebook
            // 
            btnFacebook.Location = new Point(420, 332);
            btnFacebook.Name = "btnFacebook";
            btnFacebook.Size = new Size(94, 46);
            btnFacebook.TabIndex = 7;
            btnFacebook.Text = "Facebook";
            btnFacebook.UseVisualStyleBackColor = true;
            // 
            // lnkOlvidastePassword
            // 
            lnkOlvidastePassword.AutoSize = true;
            lnkOlvidastePassword.Location = new Point(253, 411);
            lnkOlvidastePassword.Name = "lnkOlvidastePassword";
            lnkOlvidastePassword.Size = new Size(178, 20);
            lnkOlvidastePassword.TabIndex = 8;
            lnkOlvidastePassword.TabStop = true;
            lnkOlvidastePassword.Text = "¿Olvidaste tu contraseña?";
            // 
            // piclogo
            // 
            piclogo.Image = (Image)resources.GetObject("piclogo.Image");
            piclogo.Location = new Point(297, 12);
            piclogo.Name = "piclogo";
            piclogo.Size = new Size(143, 114);
            piclogo.SizeMode = PictureBoxSizeMode.StretchImage;
            piclogo.TabIndex = 0;
            piclogo.TabStop = false;
            // 
            // frmInicioSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(lnkOlvidastePassword);
            Controls.Add(btnFacebook);
            Controls.Add(btnGoogle);
            Controls.Add(btnIniciarSesion);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtCorreo);
            Controls.Add(lblCorreo);
            Controls.Add(piclogo);
            Cursor = Cursors.PanWest;
            ForeColor = SystemColors.ControlText;
            Name = "frmInicioSesion";
            Text = "INICIO DE SESIÓN - LIBRERIA ML";
            ((System.ComponentModel.ISupportInitialize)piclogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnIniciarSesion;
        private Button btnGoogle;
        private Button btnFacebook;
        private LinkLabel lnkOlvidastePassword;
        private PictureBox piclogo;
    }
}