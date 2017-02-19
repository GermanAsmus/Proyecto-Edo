namespace EdoUI.Cuenta
{
    partial class BandejaCuenta
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
            this.tlp_Cuentas = new System.Windows.Forms.TableLayoutPanel();
            this.btn_NuevaCuenta = new System.Windows.Forms.Button();
            this.l_Cuentas = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bandejaMensaje1 = new EdoUI.Mensaje.BandejaMensaje();
            this.tlp_Cuentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp_Cuentas
            // 
            this.tlp_Cuentas.ColumnCount = 2;
            this.tlp_Cuentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Cuentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Cuentas.Controls.Add(this.btn_NuevaCuenta, 0, 0);
            this.tlp_Cuentas.Controls.Add(this.l_Cuentas, 0, 1);
            this.tlp_Cuentas.Controls.Add(this.dataGridView1, 0, 2);
            this.tlp_Cuentas.Controls.Add(this.bandejaMensaje1, 1, 2);
            this.tlp_Cuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Cuentas.Location = new System.Drawing.Point(0, 0);
            this.tlp_Cuentas.Name = "tlp_Cuentas";
            this.tlp_Cuentas.RowCount = 3;
            this.tlp_Cuentas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Cuentas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Cuentas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Cuentas.Size = new System.Drawing.Size(500, 600);
            this.tlp_Cuentas.TabIndex = 0;
            // 
            // btn_NuevaCuenta
            // 
            this.btn_NuevaCuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_NuevaCuenta.Location = new System.Drawing.Point(3, 3);
            this.btn_NuevaCuenta.Name = "btn_NuevaCuenta";
            this.btn_NuevaCuenta.Size = new System.Drawing.Size(244, 34);
            this.btn_NuevaCuenta.TabIndex = 0;
            this.btn_NuevaCuenta.Text = "Nueva Cuenta";
            this.btn_NuevaCuenta.UseVisualStyleBackColor = true;
            this.btn_NuevaCuenta.Click += new System.EventHandler(this.btn_NuevaCuenta_Click);
            // 
            // l_Cuentas
            // 
            this.l_Cuentas.AutoSize = true;
            this.l_Cuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_Cuentas.Location = new System.Drawing.Point(3, 43);
            this.l_Cuentas.Margin = new System.Windows.Forms.Padding(3);
            this.l_Cuentas.Name = "l_Cuentas";
            this.l_Cuentas.Size = new System.Drawing.Size(244, 13);
            this.l_Cuentas.TabIndex = 3;
            this.l_Cuentas.Text = "Tus cuentas:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(244, 535);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // bandejaMensaje1
            // 
            this.bandejaMensaje1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bandejaMensaje1.Location = new System.Drawing.Point(253, 62);
            this.bandejaMensaje1.MinimumSize = new System.Drawing.Size(200, 400);
            this.bandejaMensaje1.Name = "bandejaMensaje1";
            this.bandejaMensaje1.Size = new System.Drawing.Size(244, 535);
            this.bandejaMensaje1.TabIndex = 5;
            // 
            // BandejaCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tlp_Cuentas);
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "BandejaCuenta";
            this.Size = new System.Drawing.Size(500, 600);
            this.tlp_Cuentas.ResumeLayout(false);
            this.tlp_Cuentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Cuentas;
        private System.Windows.Forms.Button btn_NuevaCuenta;
        private System.Windows.Forms.Label l_Cuentas;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Mensaje.BandejaMensaje bandejaMensaje1;
    }
}
