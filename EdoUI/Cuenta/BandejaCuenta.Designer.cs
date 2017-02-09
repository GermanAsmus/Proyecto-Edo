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
            this.flp_Cuentas = new System.Windows.Forms.FlowLayoutPanel();
            this.l_Cuentas = new System.Windows.Forms.Label();
            this.tlp_Cuentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Cuentas
            // 
            this.tlp_Cuentas.ColumnCount = 1;
            this.tlp_Cuentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Cuentas.Controls.Add(this.flp_Cuentas, 0, 2);
            this.tlp_Cuentas.Controls.Add(this.btn_NuevaCuenta, 0, 0);
            this.tlp_Cuentas.Controls.Add(this.l_Cuentas, 0, 1);
            this.tlp_Cuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Cuentas.Location = new System.Drawing.Point(0, 0);
            this.tlp_Cuentas.Name = "tlp_Cuentas";
            this.tlp_Cuentas.RowCount = 3;
            this.tlp_Cuentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_Cuentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlp_Cuentas.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tlp_Cuentas.Size = new System.Drawing.Size(200, 400);
            this.tlp_Cuentas.TabIndex = 0;
            // 
            // btn_NuevaCuenta
            // 
            this.btn_NuevaCuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_NuevaCuenta.Location = new System.Drawing.Point(3, 3);
            this.btn_NuevaCuenta.Name = "btn_NuevaCuenta";
            this.btn_NuevaCuenta.Size = new System.Drawing.Size(194, 34);
            this.btn_NuevaCuenta.TabIndex = 0;
            this.btn_NuevaCuenta.Text = "Nueva Cuenta";
            this.btn_NuevaCuenta.UseVisualStyleBackColor = true;
            this.btn_NuevaCuenta.Click += new System.EventHandler(this.btn_NuevaCuenta_Click);
            // 
            // flp_Cuentas
            // 
            this.flp_Cuentas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_Cuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_Cuentas.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_Cuentas.Location = new System.Drawing.Point(3, 63);
            this.flp_Cuentas.Name = "flp_Cuentas";
            this.flp_Cuentas.Size = new System.Drawing.Size(194, 334);
            this.flp_Cuentas.TabIndex = 2;
            // 
            // l_Cuentas
            // 
            this.l_Cuentas.AutoSize = true;
            this.l_Cuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.l_Cuentas.Location = new System.Drawing.Point(3, 43);
            this.l_Cuentas.Margin = new System.Windows.Forms.Padding(3);
            this.l_Cuentas.Name = "l_Cuentas";
            this.l_Cuentas.Size = new System.Drawing.Size(194, 14);
            this.l_Cuentas.TabIndex = 3;
            this.l_Cuentas.Text = "Tus cuentas:";
            // 
            // BandejaCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tlp_Cuentas);
            this.Name = "BandejaCuenta";
            this.Size = new System.Drawing.Size(200, 400);
            this.tlp_Cuentas.ResumeLayout(false);
            this.tlp_Cuentas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Cuentas;
        private System.Windows.Forms.Button btn_NuevaCuenta;
        private System.Windows.Forms.FlowLayoutPanel flp_Cuentas;
        private System.Windows.Forms.Label l_Cuentas;
    }
}
