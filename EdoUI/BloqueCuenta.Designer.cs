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
            this.tableLayoutPanelContenedorBandeja = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripCabecera = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelNombre = new System.Windows.Forms.ToolStripLabel();
            this.tableLayoutPanelMensajes = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelContenedorBandeja.SuspendLayout();
            this.toolStripCabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelContenedorBandeja
            // 
            this.tableLayoutPanelContenedorBandeja.ColumnCount = 1;
            this.tableLayoutPanelContenedorBandeja.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelContenedorBandeja.Controls.Add(this.toolStripCabecera, 0, 0);
            this.tableLayoutPanelContenedorBandeja.Controls.Add(this.tableLayoutPanelMensajes, 0, 1);
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
            this.toolStripCabecera.BackColor = System.Drawing.Color.LightSkyBlue;
            this.toolStripCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripCabecera.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripCabecera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelNombre});
            this.toolStripCabecera.Location = new System.Drawing.Point(0, 0);
            this.toolStripCabecera.Name = "toolStripCabecera";
            this.toolStripCabecera.Size = new System.Drawing.Size(200, 25);
            this.toolStripCabecera.TabIndex = 0;
            this.toolStripCabecera.Text = "toolStrip1";
            // 
            // toolStripLabelNombre
            // 
            this.toolStripLabelNombre.Name = "toolStripLabelNombre";
            this.toolStripLabelNombre.Size = new System.Drawing.Size(92, 22);
            this.toolStripLabelNombre.Text = "Nombre Cuenta";
            // 
            // tableLayoutPanelMensajes
            // 
            this.tableLayoutPanelMensajes.AutoScroll = true;
            this.tableLayoutPanelMensajes.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanelMensajes.ColumnCount = 1;
            this.tableLayoutPanelMensajes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelMensajes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMensajes.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanelMensajes.Name = "tableLayoutPanelMensajes";
            this.tableLayoutPanelMensajes.RowCount = 1;
            this.tableLayoutPanelMensajes.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelMensajes.Size = new System.Drawing.Size(194, 129);
            this.tableLayoutPanelMensajes.TabIndex = 1;
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
        private System.Windows.Forms.ToolStripLabel toolStripLabelNombre;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMensajes;
    }
}
