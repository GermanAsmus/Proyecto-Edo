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
            this.toolStripCabecera = new System.Windows.Forms.ToolStrip();
            this.tabControlContenedor = new System.Windows.Forms.TabControl();
            this.GoMailTab = new System.Windows.Forms.TabPage();
            this.QueEsGoMail = new System.Windows.Forms.TabPage();
            this.InfoGoMailPanel = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.toolStripButtonNuevaCuenta = new System.Windows.Forms.ToolStripButton();
            this.GoMailPicture = new System.Windows.Forms.PictureBox();
            this.InfoGoMailPicture = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelControlCuentas.SuspendLayout();
            this.toolStripCabecera.SuspendLayout();
            this.tabControlContenedor.SuspendLayout();
            this.GoMailTab.SuspendLayout();
            this.QueEsGoMail.SuspendLayout();
            this.InfoGoMailPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GoMailPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGoMailPicture)).BeginInit();
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
            this.tableLayoutPanelControlCuentas.Size = new System.Drawing.Size(424, 388);
            this.tableLayoutPanelControlCuentas.TabIndex = 0;
            // 
            // toolStripCabecera
            // 
            this.toolStripCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(222)))));
            this.toolStripCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripCabecera.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStripCabecera.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripCabecera.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStripCabecera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonNuevaCuenta});
            this.toolStripCabecera.Location = new System.Drawing.Point(0, 0);
            this.toolStripCabecera.Name = "toolStripCabecera";
            this.toolStripCabecera.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripCabecera.Size = new System.Drawing.Size(424, 39);
            this.toolStripCabecera.TabIndex = 0;
            this.toolStripCabecera.Text = "toolStrip1";
            // 
            // tabControlContenedor
            // 
            this.tabControlContenedor.Controls.Add(this.GoMailTab);
            this.tabControlContenedor.Controls.Add(this.QueEsGoMail);
            this.tabControlContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlContenedor.Location = new System.Drawing.Point(3, 42);
            this.tabControlContenedor.Name = "tabControlContenedor";
            this.tabControlContenedor.SelectedIndex = 0;
            this.tabControlContenedor.Size = new System.Drawing.Size(418, 343);
            this.tabControlContenedor.TabIndex = 1;
            // 
            // GoMailTab
            // 
            this.GoMailTab.Controls.Add(this.GoMailPicture);
            this.GoMailTab.Location = new System.Drawing.Point(4, 22);
            this.GoMailTab.Name = "GoMailTab";
            this.GoMailTab.Padding = new System.Windows.Forms.Padding(3);
            this.GoMailTab.Size = new System.Drawing.Size(410, 317);
            this.GoMailTab.TabIndex = 0;
            this.GoMailTab.Text = "Go-Mail";
            this.GoMailTab.UseVisualStyleBackColor = true;
            // 
            // QueEsGoMail
            // 
            this.QueEsGoMail.Controls.Add(this.InfoGoMailPanel);
            this.QueEsGoMail.Location = new System.Drawing.Point(4, 22);
            this.QueEsGoMail.Name = "QueEsGoMail";
            this.QueEsGoMail.Padding = new System.Windows.Forms.Padding(3);
            this.QueEsGoMail.Size = new System.Drawing.Size(410, 317);
            this.QueEsGoMail.TabIndex = 1;
            this.QueEsGoMail.Text = "¿Que es Go-Mail?";
            this.QueEsGoMail.UseVisualStyleBackColor = true;
            // 
            // InfoGoMailPanel
            // 
            this.InfoGoMailPanel.AutoScroll = true;
            this.InfoGoMailPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InfoGoMailPanel.Controls.Add(this.InfoGoMailPicture);
            this.InfoGoMailPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoGoMailPanel.Location = new System.Drawing.Point(3, 3);
            this.InfoGoMailPanel.Name = "InfoGoMailPanel";
            this.InfoGoMailPanel.Size = new System.Drawing.Size(404, 311);
            this.InfoGoMailPanel.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ll.png");
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
            // GoMailPicture
            // 
            this.GoMailPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GoMailPicture.Image = global::EdoUI.Properties.Resources.go_mail;
            this.GoMailPicture.Location = new System.Drawing.Point(3, 3);
            this.GoMailPicture.Name = "GoMailPicture";
            this.GoMailPicture.Size = new System.Drawing.Size(404, 311);
            this.GoMailPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.GoMailPicture.TabIndex = 0;
            this.GoMailPicture.TabStop = false;
            // 
            // InfoGoMailPicture
            // 
            this.InfoGoMailPicture.Image = global::EdoUI.Properties.Resources.Todo_lo_que_podes_hacer_con_Go_Mail;
            this.InfoGoMailPicture.Location = new System.Drawing.Point(3, 3);
            this.InfoGoMailPicture.Name = "InfoGoMailPicture";
            this.InfoGoMailPicture.Size = new System.Drawing.Size(800, 2000);
            this.InfoGoMailPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.InfoGoMailPicture.TabIndex = 0;
            this.InfoGoMailPicture.TabStop = false;
            // 
            // ControlRaiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.tableLayoutPanelControlCuentas);
            this.Name = "ControlRaiz";
            this.Size = new System.Drawing.Size(424, 388);
            this.tableLayoutPanelControlCuentas.ResumeLayout(false);
            this.tableLayoutPanelControlCuentas.PerformLayout();
            this.toolStripCabecera.ResumeLayout(false);
            this.toolStripCabecera.PerformLayout();
            this.tabControlContenedor.ResumeLayout(false);
            this.GoMailTab.ResumeLayout(false);
            this.QueEsGoMail.ResumeLayout(false);
            this.InfoGoMailPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GoMailPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGoMailPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelControlCuentas;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStrip toolStripCabecera;
        private System.Windows.Forms.ToolStripButton toolStripButtonNuevaCuenta;
        public System.Windows.Forms.TabControl tabControlContenedor;
        private System.Windows.Forms.TabPage GoMailTab;
        private System.Windows.Forms.PictureBox GoMailPicture;
        private System.Windows.Forms.TabPage QueEsGoMail;
        private System.Windows.Forms.Panel InfoGoMailPanel;
        private System.Windows.Forms.PictureBox InfoGoMailPicture;
    }
}
