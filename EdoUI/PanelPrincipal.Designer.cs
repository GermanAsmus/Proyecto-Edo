namespace EdoUI
{
    partial class PanelPrincipal
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
            this.tableLayoutPanelPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.buttonInformacion = new System.Windows.Forms.Button();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.buttonCuenta = new System.Windows.Forms.Button();
            this.buttonAyuda = new System.Windows.Forms.Button();
            this.tableLayoutPanelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelPrincipal
            // 
            this.tableLayoutPanelPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanelPrincipal.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanelPrincipal.ColumnCount = 1;
            this.tableLayoutPanelPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelPrincipal.Controls.Add(this.buttonInformacion, 0, 3);
            this.tableLayoutPanelPrincipal.Controls.Add(this.buttonInicio, 0, 0);
            this.tableLayoutPanelPrincipal.Controls.Add(this.buttonCuenta, 0, 1);
            this.tableLayoutPanelPrincipal.Controls.Add(this.buttonAyuda, 0, 2);
            this.tableLayoutPanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelPrincipal.Name = "tableLayoutPanelPrincipal";
            this.tableLayoutPanelPrincipal.RowCount = 5;
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelPrincipal.Size = new System.Drawing.Size(121, 443);
            this.tableLayoutPanelPrincipal.TabIndex = 0;
            // 
            // buttonInformacion
            // 
            this.buttonInformacion.BackColor = System.Drawing.Color.Transparent;
            this.buttonInformacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInformacion.FlatAppearance.BorderSize = 0;
            this.buttonInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInformacion.Location = new System.Drawing.Point(4, 268);
            this.buttonInformacion.Name = "buttonInformacion";
            this.buttonInformacion.Size = new System.Drawing.Size(113, 81);
            this.buttonInformacion.TabIndex = 5;
            this.buttonInformacion.Text = "Información";
            this.buttonInformacion.UseVisualStyleBackColor = false;
            // 
            // buttonInicio
            // 
            this.buttonInicio.BackColor = System.Drawing.Color.Transparent;
            this.buttonInicio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInicio.FlatAppearance.BorderSize = 0;
            this.buttonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInicio.Location = new System.Drawing.Point(4, 4);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(113, 81);
            this.buttonInicio.TabIndex = 4;
            this.buttonInicio.Text = "Inicio";
            this.buttonInicio.UseVisualStyleBackColor = false;
            this.buttonInicio.Click += new System.EventHandler(this.buttonInicio_Click);
            // 
            // buttonCuenta
            // 
            this.buttonCuenta.BackColor = System.Drawing.Color.Transparent;
            this.buttonCuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCuenta.FlatAppearance.BorderSize = 0;
            this.buttonCuenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCuenta.Location = new System.Drawing.Point(4, 92);
            this.buttonCuenta.Name = "buttonCuenta";
            this.buttonCuenta.Size = new System.Drawing.Size(113, 81);
            this.buttonCuenta.TabIndex = 1;
            this.buttonCuenta.Text = "Cuentas";
            this.buttonCuenta.UseVisualStyleBackColor = false;
            this.buttonCuenta.Click += new System.EventHandler(this.buttonCuenta_Click);
            // 
            // buttonAyuda
            // 
            this.buttonAyuda.BackColor = System.Drawing.Color.Transparent;
            this.buttonAyuda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAyuda.FlatAppearance.BorderSize = 0;
            this.buttonAyuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAyuda.Location = new System.Drawing.Point(4, 180);
            this.buttonAyuda.Name = "buttonAyuda";
            this.buttonAyuda.Size = new System.Drawing.Size(113, 81);
            this.buttonAyuda.TabIndex = 2;
            this.buttonAyuda.Text = "Ayuda";
            this.buttonAyuda.UseVisualStyleBackColor = false;
            // 
            // PanelPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.tableLayoutPanelPrincipal);
            this.Name = "PanelPrincipal";
            this.Size = new System.Drawing.Size(121, 443);
            this.tableLayoutPanelPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelPrincipal;
        private System.Windows.Forms.Button buttonCuenta;
        private System.Windows.Forms.Button buttonAyuda;
        private System.Windows.Forms.Button buttonInicio;
        private System.Windows.Forms.Button buttonInformacion;
    }
}
