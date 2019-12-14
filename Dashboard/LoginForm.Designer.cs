namespace Dashboard
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            this.LoginErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Usuariolabel = new System.Windows.Forms.Label();
            this.Contraseñalabel = new System.Windows.Forms.Label();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.contraseñaTextBox = new System.Windows.Forms.TextBox();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.olvidoCLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.LoginErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginErrorProvider
            // 
            this.LoginErrorProvider.ContainerControl = this;
            // 
            // Usuariolabel
            // 
            this.Usuariolabel.AutoSize = true;
            this.Usuariolabel.Location = new System.Drawing.Point(98, 87);
            this.Usuariolabel.Name = "Usuariolabel";
            this.Usuariolabel.Size = new System.Drawing.Size(46, 13);
            this.Usuariolabel.TabIndex = 0;
            this.Usuariolabel.Text = "Usuario:";
            // 
            // Contraseñalabel
            // 
            this.Contraseñalabel.AutoSize = true;
            this.Contraseñalabel.Location = new System.Drawing.Point(98, 125);
            this.Contraseñalabel.Name = "Contraseñalabel";
            this.Contraseñalabel.Size = new System.Drawing.Size(64, 13);
            this.Contraseñalabel.TabIndex = 1;
            this.Contraseñalabel.Text = "Contraseña:";
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Location = new System.Drawing.Point(211, 87);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(136, 20);
            this.usuarioTextBox.TabIndex = 2;
            this.usuarioTextBox.Leave += new System.EventHandler(this.usuarioTextBox_Leave);
            // 
            // contraseñaTextBox
            // 
            this.contraseñaTextBox.Location = new System.Drawing.Point(211, 125);
            this.contraseñaTextBox.Name = "contraseñaTextBox";
            this.contraseñaTextBox.Size = new System.Drawing.Size(136, 20);
            this.contraseñaTextBox.TabIndex = 3;
            this.contraseñaTextBox.UseSystemPasswordChar = true;
            this.contraseñaTextBox.Leave += new System.EventHandler(this.contraseñaTextBox_Leave);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Location = new System.Drawing.Point(84, 260);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(87, 23);
            this.cancelarButton.TabIndex = 4;
            this.cancelarButton.Text = "Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            // 
            // aceptarButton
            // 
            this.aceptarButton.Location = new System.Drawing.Point(364, 260);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(75, 23);
            this.aceptarButton.TabIndex = 5;
            this.aceptarButton.Text = "Aceptar";
            this.aceptarButton.UseVisualStyleBackColor = true;
            // 
            // olvidoCLinkLabel
            // 
            this.olvidoCLinkLabel.AutoSize = true;
            this.olvidoCLinkLabel.Location = new System.Drawing.Point(361, 216);
            this.olvidoCLinkLabel.Name = "olvidoCLinkLabel";
            this.olvidoCLinkLabel.Size = new System.Drawing.Size(119, 13);
            this.olvidoCLinkLabel.TabIndex = 6;
            this.olvidoCLinkLabel.TabStop = true;
            this.olvidoCLinkLabel.Text = "¿Olvido su contraseña?";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.aceptarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelarButton;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.olvidoCLinkLabel);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.contraseñaTextBox);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(this.Contraseñalabel);
            this.Controls.Add(this.Usuariolabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.ShowIcon = false;
            this.Text = "Bienvenido al sistema";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider LoginErrorProvider;
        private System.Windows.Forms.Label Contraseñalabel;
        private System.Windows.Forms.Label Usuariolabel;
        private System.Windows.Forms.LinkLabel olvidoCLinkLabel;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Button cancelarButton;
        private System.Windows.Forms.TextBox contraseñaTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
    }
}

