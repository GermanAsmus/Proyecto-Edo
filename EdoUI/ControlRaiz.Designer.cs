namespace EdoUI
{
    partial class ControlRaiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlRaiz));
            this.tableLayoutPanelControlCuentas = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripCabecera = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonNuevaCuenta = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxCuenta = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tabControlContenedor = new System.Windows.Forms.TabControl();
            this.tableLayoutPanelControlCuentas.SuspendLayout();
            this.toolStripCabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelControlCuentas
            // 
            this.tableLayoutPanelControlCuentas.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanelControlCuentas.ColumnCount = 1;
            this.tableLayoutPanelControlCuentas.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelControlCuentas.Controls.Add(this.toolStripCabecera, 0, 0);
            this.tableLayoutPanelControlCuentas.Controls.Add(this.tabControlContenedor, 0, 1);
            this.tableLayoutPanelControlCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelControlCuentas.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelControlCuentas.Name = "tableLayoutPanelControlCuentas";
            this.tableLayoutPanelControlCuentas.RowCount = 2;
            this.tableLayoutPanelControlCuentas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelControlCuentas.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelControlCuentas.Size = new System.Drawing.Size(366, 150);
            this.tableLayoutPanelControlCuentas.TabIndex = 0;
            // 
            // toolStripCabecera
            // 
            this.toolStripCabecera.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.toolStripCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripCabecera.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripCabecera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNuevaCuenta,
            this.toolStripComboBoxCuenta,
            this.toolStripLabel1});
            this.toolStripCabecera.Location = new System.Drawing.Point(0, 0);
            this.toolStripCabecera.Name = "toolStripCabecera";
            this.toolStripCabecera.Size = new System.Drawing.Size(366, 25);
            this.toolStripCabecera.TabIndex = 0;
            this.toolStripCabecera.Text = "toolStrip1";
            // 
            // toolStripButtonNuevaCuenta
            // 
            this.toolStripButtonNuevaCuenta.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonNuevaCuenta.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNuevaCuenta.Image")));
            this.toolStripButtonNuevaCuenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNuevaCuenta.Name = "toolStripButtonNuevaCuenta";
            this.toolStripButtonNuevaCuenta.Size = new System.Drawing.Size(86, 22);
            this.toolStripButtonNuevaCuenta.Text = "Nueva Cuenta";
            this.toolStripButtonNuevaCuenta.Click += new System.EventHandler(this.toolStripButtonNuevaCuenta_Click);
            // 
            // toolStripComboBoxCuenta
            // 
            this.toolStripComboBoxCuenta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxCuenta.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.toolStripComboBoxCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxCuenta.Name = "toolStripComboBoxCuenta";
            this.toolStripComboBoxCuenta.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBoxCuenta.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxCuenta_SelectedIndexChanged);
            this.toolStripComboBoxCuenta.Click += new System.EventHandler(this.toolStripComboBoxCuenta_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(39, 22);
            this.toolStripLabel1.Text = "Abrir: ";
            // 
            // tabControlContenedor
            // 
            this.tabControlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlContenedor.Location = new System.Drawing.Point(3, 28);
            this.tabControlContenedor.Name = "tabControlContenedor";
            this.tabControlContenedor.SelectedIndex = 0;
            this.tabControlContenedor.Size = new System.Drawing.Size(360, 119);
            this.tabControlContenedor.TabIndex = 1;
            // 
            // ControlRaiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelControlCuentas);
            this.Name = "ControlRaiz";
            this.Size = new System.Drawing.Size(366, 150);
            this.tableLayoutPanelControlCuentas.ResumeLayout(false);
            this.tableLayoutPanelControlCuentas.PerformLayout();
            this.toolStripCabecera.ResumeLayout(false);
            this.toolStripCabecera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelControlCuentas;
        private System.Windows.Forms.ToolStrip toolStripCabecera;
        private System.Windows.Forms.ToolStripButton toolStripButtonNuevaCuenta;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxCuenta;
        public System.Windows.Forms.TabControl tabControlContenedor;
    }
}
