namespace Dashboard.UNA.Dashboard.Formularios
{
    partial class CuentasPorCobrarForm
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
            this.TituloLabel = new System.Windows.Forms.Label();
            this.CerrarButton = new System.Windows.Forms.Button();
            this.ImprimirBbutton = new System.Windows.Forms.Button();
            this.InformacionStatusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.InformacionToolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.PrincipalDataGridView = new System.Windows.Forms.DataGridView();
            this.CedulaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TelefonoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DireccionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InformacionStatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrincipalDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TituloLabel
            // 
            this.TituloLabel.AutoSize = true;
            this.TituloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloLabel.Location = new System.Drawing.Point(174, 19);
            this.TituloLabel.Name = "TituloLabel";
            this.TituloLabel.Size = new System.Drawing.Size(275, 16);
            this.TituloLabel.TabIndex = 0;
            this.TituloLabel.Text = "Resumen de cuentas por cobrar @Año";
            this.TituloLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // CerrarButton
            // 
            this.CerrarButton.Location = new System.Drawing.Point(104, 342);
            this.CerrarButton.Name = "CerrarButton";
            this.CerrarButton.Size = new System.Drawing.Size(75, 23);
            this.CerrarButton.TabIndex = 1;
            this.CerrarButton.Text = "Cerrar";
            this.CerrarButton.UseVisualStyleBackColor = true;
            this.CerrarButton.Click += new System.EventHandler(this.CerrarButton_Click);
            // 
            // ImprimirBbutton
            // 
            this.ImprimirBbutton.Location = new System.Drawing.Point(481, 342);
            this.ImprimirBbutton.Name = "ImprimirBbutton";
            this.ImprimirBbutton.Size = new System.Drawing.Size(75, 23);
            this.ImprimirBbutton.TabIndex = 2;
            this.ImprimirBbutton.Text = "Imprimir";
            this.ImprimirBbutton.UseVisualStyleBackColor = true;
            // 
            // InformacionStatusStrip
            // 
            this.InformacionStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.InformacionToolStripProgressBar});
            this.InformacionStatusStrip.Location = new System.Drawing.Point(0, 377);
            this.InformacionStatusStrip.Name = "InformacionStatusStrip";
            this.InformacionStatusStrip.Size = new System.Drawing.Size(647, 22);
            this.InformacionStatusStrip.TabIndex = 3;
            this.InformacionStatusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(83, 17);
            this.toolStripStatusLabel1.Text = "@Informacion";
            // 
            // InformacionToolStripProgressBar
            // 
            this.InformacionToolStripProgressBar.Name = "InformacionToolStripProgressBar";
            this.InformacionToolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // PrincipalDataGridView
            // 
            this.PrincipalDataGridView.AllowUserToAddRows = false;
            this.PrincipalDataGridView.AllowUserToDeleteRows = false;
            this.PrincipalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrincipalDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CedulaColumn,
            this.NombreColumn,
            this.MontoColumn,
            this.TelefonoColumn,
            this.DireccionColumn});
            this.PrincipalDataGridView.Location = new System.Drawing.Point(12, 51);
            this.PrincipalDataGridView.Name = "PrincipalDataGridView";
            this.PrincipalDataGridView.Size = new System.Drawing.Size(623, 276);
            this.PrincipalDataGridView.TabIndex = 4;
            this.PrincipalDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrincipalDataGridView_CellContentClick);
            // 
            // CedulaColumn
            // 
            this.CedulaColumn.HeaderText = "Cedula";
            this.CedulaColumn.Name = "CedulaColumn";
            // 
            // NombreColumn
            // 
            this.NombreColumn.HeaderText = "Nombre";
            this.NombreColumn.Name = "NombreColumn";
            // 
            // MontoColumn
            // 
            this.MontoColumn.HeaderText = "Monto";
            this.MontoColumn.Name = "MontoColumn";
            // 
            // TelefonoColumn
            // 
            this.TelefonoColumn.HeaderText = "Teléfono";
            this.TelefonoColumn.Name = "TelefonoColumn";
            // 
            // DireccionColumn
            // 
            this.DireccionColumn.HeaderText = "Dirección";
            this.DireccionColumn.Name = "DireccionColumn";
            // 
            // CuentasPorCobrarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 399);
            this.Controls.Add(this.PrincipalDataGridView);
            this.Controls.Add(this.InformacionStatusStrip);
            this.Controls.Add(this.ImprimirBbutton);
            this.Controls.Add(this.CerrarButton);
            this.Controls.Add(this.TituloLabel);
            this.Name = "CuentasPorCobrarForm";
            this.Text = "Cuentas por cobrar";
            this.Load += new System.EventHandler(this.CuentasPorCobrarForm_Load);
            this.InformacionStatusStrip.ResumeLayout(false);
            this.InformacionStatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PrincipalDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloLabel;
        private System.Windows.Forms.Button CerrarButton;
        private System.Windows.Forms.Button ImprimirBbutton;
        private System.Windows.Forms.StatusStrip InformacionStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar InformacionToolStripProgressBar;
        private System.Windows.Forms.DataGridView PrincipalDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn CedulaColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TelefonoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DireccionColumn;
    }
}