namespace LoginBakebooker
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.pbUsuario = new System.Windows.Forms.PictureBox();
            this.pbCandado = new System.Windows.Forms.PictureBox();
            this.pbBakebooker = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCandado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBakebooker)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.AutoEllipsis = true;
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.Location = new System.Drawing.Point(291, 385);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(272, 36);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(323, 229);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(241, 30);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(323, 278);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(241, 30);
            this.txtContraseña.TabIndex = 1;
            // 
            // pbUsuario
            // 
            this.pbUsuario.Image = ((System.Drawing.Image)(resources.GetObject("pbUsuario.Image")));
            this.pbUsuario.Location = new System.Drawing.Point(280, 229);
            this.pbUsuario.Name = "pbUsuario";
            this.pbUsuario.Size = new System.Drawing.Size(41, 30);
            this.pbUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUsuario.TabIndex = 3;
            this.pbUsuario.TabStop = false;
            // 
            // pbCandado
            // 
            this.pbCandado.Image = ((System.Drawing.Image)(resources.GetObject("pbCandado.Image")));
            this.pbCandado.Location = new System.Drawing.Point(280, 278);
            this.pbCandado.Name = "pbCandado";
            this.pbCandado.Size = new System.Drawing.Size(41, 30);
            this.pbCandado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCandado.TabIndex = 3;
            this.pbCandado.TabStop = false;
            // 
            // pbBakebooker
            // 
            this.pbBakebooker.BackColor = System.Drawing.Color.White;
            this.pbBakebooker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbBakebooker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbBakebooker.Image = ((System.Drawing.Image)(resources.GetObject("pbBakebooker.Image")));
            this.pbBakebooker.Location = new System.Drawing.Point(256, 32);
            this.pbBakebooker.Name = "pbBakebooker";
            this.pbBakebooker.Size = new System.Drawing.Size(335, 100);
            this.pbBakebooker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBakebooker.TabIndex = 4;
            this.pbBakebooker.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 433);
            this.Controls.Add(this.pbBakebooker);
            this.Controls.Add(this.pbCandado);
            this.Controls.Add(this.pbUsuario);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(814, 483);
            this.MinimumSize = new System.Drawing.Size(814, 454);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCandado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBakebooker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.PictureBox pbUsuario;
        private System.Windows.Forms.PictureBox pbCandado;
        private System.Windows.Forms.PictureBox pbBakebooker;
    }
}

