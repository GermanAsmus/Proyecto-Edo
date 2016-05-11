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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlRaiz));
            this.tableLayoutPanelControlCuentas = new System.Windows.Forms.TableLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControlContenedor = new System.Windows.Forms.TabControl();
            this.toolStripButtonNuevaCuenta = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboBoxCuenta = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripCabecera = new System.Windows.Forms.ToolStrip();
            this.tableLayoutPanelControlCuentas.SuspendLayout();
            this.toolStripCabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelControlCuentas
            // 
            this.tableLayoutPanelControlCuentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ll.png");
            // 
            // tabControlContenedor
            // 
            this.tabControlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlContenedor.Location = new System.Drawing.Point(3, 42);
            this.tabControlContenedor.Name = "tabControlContenedor";
            this.tabControlContenedor.SelectedIndex = 0;
            this.tabControlContenedor.Size = new System.Drawing.Size(360, 119);
            this.tabControlContenedor.TabIndex = 1;
            // 
            // toolStripButtonNuevaCuenta
            // 
            this.toolStripButtonNuevaCuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripButtonNuevaCuenta.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonNuevaCuenta.Image")));
            this.toolStripButtonNuevaCuenta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonNuevaCuenta.Name = "toolStripButtonNuevaCuenta";
            this.toolStripButtonNuevaCuenta.Size = new System.Drawing.Size(118, 36);
            this.toolStripButtonNuevaCuenta.Text = "Nueva Cuenta";
            this.toolStripButtonNuevaCuenta.Click += new System.EventHandler(this.toolStripButtonNuevaCuenta_Click);
            // 
            // toolStripComboBoxCuenta
            // 
            this.toolStripComboBoxCuenta.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripComboBoxCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.toolStripComboBoxCuenta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBoxCuenta.Name = "toolStripComboBoxCuenta";
            this.toolStripComboBoxCuenta.Padding = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolStripComboBoxCuenta.Size = new System.Drawing.Size(162, 39);
            this.toolStripComboBoxCuenta.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBoxCuenta_SelectedIndexChanged);
            this.toolStripComboBoxCuenta.Click += new System.EventHandler(this.toolStripComboBoxCuenta_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel1.Image")));
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(65, 36);
            this.toolStripLabel1.Text = "Abrir";
            // 
            // toolStripCabecera
            // 
            this.toolStripCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(198)))), ((int)(((byte)(222)))));
            this.toolStripCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripCabecera.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripCabecera.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripCabecera.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripCabecera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNuevaCuenta,
            this.toolStripComboBoxCuenta,
            this.toolStripLabel1});
            this.toolStripCabecera.Location = new System.Drawing.Point(0, 0);
            this.toolStripCabecera.Name = "toolStripCabecera";
            this.toolStripCabecera.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripCabecera.Size = new System.Drawing.Size(366, 39);
            this.toolStripCabecera.TabIndex = 0;
            this.toolStripCabecera.Text = "toolStrip1";
            // 
            // ControlRaiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
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
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStrip toolStripCabecera;
        private System.Windows.Forms.ToolStripButton toolStripButtonNuevaCuenta;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxCuenta;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        public System.Windows.Forms.TabControl tabControlContenedor;
    }
}
