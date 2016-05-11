using System.ComponentModel;

namespace EdoUI
{
    partial class BloqueCuenta
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloqueCuenta));
            this.tableLayoutPanelContenedorBandeja = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripCabecera = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonRedactar = new System.Windows.Forms.ToolStripButton();
            this.tabControlMensajes = new System.Windows.Forms.TabControl();
            this.tableLayoutPanelContenedorBandeja.SuspendLayout();
            this.toolStripCabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelContenedorBandeja
            // 
            this.tableLayoutPanelContenedorBandeja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(207)))), ((int)(((byte)(243)))));
            this.tableLayoutPanelContenedorBandeja.ColumnCount = 1;
            this.tableLayoutPanelContenedorBandeja.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContenedorBandeja.Controls.Add(this.toolStripCabecera, 0, 0);
            this.tableLayoutPanelContenedorBandeja.Controls.Add(this.tabControlMensajes, 0, 1);
            this.tableLayoutPanelContenedorBandeja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContenedorBandeja.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelContenedorBandeja.Name = "tableLayoutPanelContenedorBandeja";
            this.tableLayoutPanelContenedorBandeja.RowCount = 2;
            this.tableLayoutPanelContenedorBandeja.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelContenedorBandeja.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelContenedorBandeja.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelContenedorBandeja.Size = new System.Drawing.Size(200, 160);
            this.tableLayoutPanelContenedorBandeja.TabIndex = 0;
            // 
            // toolStripCabecera
            // 
            this.toolStripCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(102)))), ((int)(((byte)(100)))));
            this.toolStripCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripCabecera.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripCabecera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRedactar});
            this.toolStripCabecera.Location = new System.Drawing.Point(0, 0);
            this.toolStripCabecera.Name = "toolStripCabecera";
            this.toolStripCabecera.Size = new System.Drawing.Size(200, 25);
            this.toolStripCabecera.TabIndex = 0;
            this.toolStripCabecera.Text = "toolStrip1";
            // 
            // toolStripButtonRedactar
            // 
            this.toolStripButtonRedactar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonRedactar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRedactar.Image")));
            this.toolStripButtonRedactar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRedactar.Name = "toolStripButtonRedactar";
            this.toolStripButtonRedactar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonRedactar.Text = "Redactar";
            this.toolStripButtonRedactar.Click += new System.EventHandler(this.toolStripButtonRedactar_Click);
            // 
            // tabControlMensajes
            // 
            this.tabControlMensajes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMensajes.Location = new System.Drawing.Point(3, 28);
            this.tabControlMensajes.Name = "tabControlMensajes";
            this.tabControlMensajes.SelectedIndex = 0;
            this.tabControlMensajes.Size = new System.Drawing.Size(194, 129);
            this.tabControlMensajes.TabIndex = 1;
            // 
            // BloqueCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelContenedorBandeja);
            this.Name = "BloqueCuenta";
            this.Size = new System.Drawing.Size(200, 160);
            this.tableLayoutPanelContenedorBandeja.ResumeLayout(false);
            this.tableLayoutPanelContenedorBandeja.PerformLayout();
            this.toolStripCabecera.ResumeLayout(false);
            this.toolStripCabecera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContenedorBandeja;
        private System.Windows.Forms.ToolStrip toolStripCabecera;
        private System.Windows.Forms.ToolStripButton toolStripButtonRedactar;
        private System.Windows.Forms.TabControl tabControlMensajes;
    }
}
