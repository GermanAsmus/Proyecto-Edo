namespace EdoUI
{
    partial class ControlCuenta
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanelBandeja = new System.Windows.Forms.TableLayoutPanel();
            this.labelServidor = new System.Windows.Forms.Label();
            this.textBoxContrasenia2 = new System.Windows.Forms.TextBox();
            this.labelContrasenia2 = new System.Windows.Forms.Label();
            this.textBoxContrasenia = new System.Windows.Forms.TextBox();
            this.labelContrasenia = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.toolStripCabecera = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAceptar = new System.Windows.Forms.ToolStripButton();
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.comboBoxServidores = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanelBandeja.SuspendLayout();
            this.toolStripCabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelBandeja
            // 
            this.tableLayoutPanelBandeja.ColumnCount = 1;
            this.tableLayoutPanelBandeja.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBandeja.Controls.Add(this.labelServidor, 0, 9);
            this.tableLayoutPanelBandeja.Controls.Add(this.textBoxContrasenia2, 0, 8);
            this.tableLayoutPanelBandeja.Controls.Add(this.labelContrasenia2, 0, 7);
            this.tableLayoutPanelBandeja.Controls.Add(this.textBoxContrasenia, 0, 6);
            this.tableLayoutPanelBandeja.Controls.Add(this.labelContrasenia, 0, 5);
            this.tableLayoutPanelBandeja.Controls.Add(this.textBoxDireccion, 0, 4);
            this.tableLayoutPanelBandeja.Controls.Add(this.labelDireccion, 0, 3);
            this.tableLayoutPanelBandeja.Controls.Add(this.toolStripCabecera, 0, 0);
            this.tableLayoutPanelBandeja.Controls.Add(this.labelNombre, 0, 1);
            this.tableLayoutPanelBandeja.Controls.Add(this.textBoxNombre, 0, 2);
            this.tableLayoutPanelBandeja.Controls.Add(this.comboBoxServidores, 0, 10);
            this.tableLayoutPanelBandeja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBandeja.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBandeja.Name = "tableLayoutPanelBandeja";
            this.tableLayoutPanelBandeja.RowCount = 11;
            this.tableLayoutPanelBandeja.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBandeja.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBandeja.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBandeja.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBandeja.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBandeja.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBandeja.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBandeja.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBandeja.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBandeja.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBandeja.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBandeja.Size = new System.Drawing.Size(250, 464);
            this.tableLayoutPanelBandeja.TabIndex = 0;
            // 
            // labelServidor
            // 
            this.labelServidor.AutoSize = true;
            this.labelServidor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelServidor.Location = new System.Drawing.Point(3, 181);
            this.labelServidor.Name = "labelServidor";
            this.labelServidor.Size = new System.Drawing.Size(244, 13);
            this.labelServidor.TabIndex = 9;
            this.labelServidor.Text = "Servidor de Correo";
            // 
            // textBoxContrasenia2
            // 
            this.textBoxContrasenia2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxContrasenia2.Location = new System.Drawing.Point(3, 158);
            this.textBoxContrasenia2.Name = "textBoxContrasenia2";
            this.textBoxContrasenia2.PasswordChar = '*';
            this.textBoxContrasenia2.Size = new System.Drawing.Size(244, 20);
            this.textBoxContrasenia2.TabIndex = 8;
            this.textBoxContrasenia2.TextChanged += new System.EventHandler(this.textBoxContrasenia2_TextChanged);
            // 
            // labelContrasenia2
            // 
            this.labelContrasenia2.AutoSize = true;
            this.labelContrasenia2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelContrasenia2.Location = new System.Drawing.Point(3, 142);
            this.labelContrasenia2.Name = "labelContrasenia2";
            this.labelContrasenia2.Size = new System.Drawing.Size(244, 13);
            this.labelContrasenia2.TabIndex = 7;
            this.labelContrasenia2.Text = "Contraseña (ingrese nuevamente)";
            // 
            // textBoxContrasenia
            // 
            this.textBoxContrasenia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxContrasenia.Location = new System.Drawing.Point(3, 119);
            this.textBoxContrasenia.Name = "textBoxContrasenia";
            this.textBoxContrasenia.PasswordChar = '*';
            this.textBoxContrasenia.Size = new System.Drawing.Size(244, 20);
            this.textBoxContrasenia.TabIndex = 6;
            // 
            // labelContrasenia
            // 
            this.labelContrasenia.AutoSize = true;
            this.labelContrasenia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelContrasenia.Location = new System.Drawing.Point(3, 103);
            this.labelContrasenia.Name = "labelContrasenia";
            this.labelContrasenia.Size = new System.Drawing.Size(244, 13);
            this.labelContrasenia.TabIndex = 5;
            this.labelContrasenia.Text = "Contraseña";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDireccion.Location = new System.Drawing.Point(3, 80);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(244, 20);
            this.textBoxDireccion.TabIndex = 4;
            this.textBoxDireccion.TextChanged += new System.EventHandler(this.textBoxDireccion_TextChanged);
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDireccion.Location = new System.Drawing.Point(3, 64);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(244, 13);
            this.labelDireccion.TabIndex = 3;
            this.labelDireccion.Text = "Direccion de Correo";
            // 
            // toolStripCabecera
            // 
            this.toolStripCabecera.BackColor = System.Drawing.Color.LightSkyBlue;
            this.toolStripCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripCabecera.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripCabecera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAceptar});
            this.toolStripCabecera.Location = new System.Drawing.Point(0, 0);
            this.toolStripCabecera.Name = "toolStripCabecera";
            this.toolStripCabecera.Size = new System.Drawing.Size(250, 25);
            this.toolStripCabecera.TabIndex = 0;
            this.toolStripCabecera.Text = "toolStrip1";
            // 
            // toolStripButtonAceptar
            // 
            this.toolStripButtonAceptar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonAceptar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAceptar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAceptar.Name = "toolStripButtonAceptar";
            this.toolStripButtonAceptar.Size = new System.Drawing.Size(52, 22);
            this.toolStripButtonAceptar.Text = "Aceptar";
            this.toolStripButtonAceptar.Click += new System.EventHandler(this.toolStripButtonAceptar_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNombre.Location = new System.Drawing.Point(3, 25);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(244, 13);
            this.labelNombre.TabIndex = 1;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNombre.Location = new System.Drawing.Point(3, 41);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(244, 20);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // comboBoxServidores
            // 
            this.comboBoxServidores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxServidores.FormattingEnabled = true;
            this.comboBoxServidores.Location = new System.Drawing.Point(3, 197);
            this.comboBoxServidores.Name = "comboBoxServidores";
            this.comboBoxServidores.Size = new System.Drawing.Size(244, 21);
            this.comboBoxServidores.TabIndex = 10;
            // 
            // ControlCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelBandeja);
            this.Name = "ControlCuenta";
            this.Size = new System.Drawing.Size(250, 464);
            this.tableLayoutPanelBandeja.ResumeLayout(false);
            this.tableLayoutPanelBandeja.PerformLayout();
            this.toolStripCabecera.ResumeLayout(false);
            this.toolStripCabecera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBandeja;
        private System.Windows.Forms.ToolStrip toolStripCabecera;
        private System.Windows.Forms.ToolStripButton toolStripButtonAceptar;
        private System.Windows.Forms.Label labelContrasenia2;
        private System.Windows.Forms.TextBox textBoxContrasenia;
        private System.Windows.Forms.Label labelContrasenia;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label labelServidor;
        private System.Windows.Forms.TextBox textBoxContrasenia2;
        private System.Windows.Forms.ComboBox comboBoxServidores;
    }
}
