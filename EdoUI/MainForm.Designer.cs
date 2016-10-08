namespace EdoUI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TablaPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.PanelRaiz = new System.Windows.Forms.Panel();
            this.statusStripConexion = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.TablaPrincipal.SuspendLayout();
            this.statusStripConexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablaPrincipal
            // 
            this.TablaPrincipal.ColumnCount = 1;
            this.TablaPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TablaPrincipal.Controls.Add(this.statusStripConexion, 0, 1);
            this.TablaPrincipal.Controls.Add(this.PanelRaiz, 0, 0);
            this.TablaPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TablaPrincipal.Location = new System.Drawing.Point(0, 0);
            this.TablaPrincipal.Name = "TablaPrincipal";
            this.TablaPrincipal.RowCount = 2;
            this.TablaPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.374384F));
            this.TablaPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TablaPrincipal.Size = new System.Drawing.Size(1046, 630);
            this.TablaPrincipal.TabIndex = 0;
            // 
            // PanelRaiz
            // 
            this.PanelRaiz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelRaiz.Location = new System.Drawing.Point(0, 0);
            this.PanelRaiz.Margin = new System.Windows.Forms.Padding(0);
            this.PanelRaiz.Name = "PanelRaiz";
            this.PanelRaiz.Size = new System.Drawing.Size(1046, 610);
            this.PanelRaiz.TabIndex = 0;
            // 
            // statusStripConexion
            // 
            this.statusStripConexion.AllowMerge = false;
            this.statusStripConexion.BackColor = System.Drawing.Color.Transparent;
            this.statusStripConexion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelConexion});
            this.statusStripConexion.Location = new System.Drawing.Point(3, 610);
            this.statusStripConexion.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.statusStripConexion.Name = "statusStripConexion";
            this.statusStripConexion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStripConexion.Size = new System.Drawing.Size(1040, 20);
            this.statusStripConexion.SizingGrip = false;
            this.statusStripConexion.TabIndex = 4;
            this.statusStripConexion.Text = "statusStrip1";
            // 
            // toolStripStatusLabelConexion
            // 
            this.toolStripStatusLabelConexion.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStatusLabelConexion.Image")));
            this.toolStripStatusLabelConexion.Name = "toolStripStatusLabelConexion";
            this.toolStripStatusLabelConexion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabelConexion.Size = new System.Drawing.Size(73, 15);
            this.toolStripStatusLabelConexion.Text = "Conexion";
            this.toolStripStatusLabelConexion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 630);
            this.Controls.Add(this.TablaPrincipal);
            this.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.TablaPrincipal.ResumeLayout(false);
            this.TablaPrincipal.PerformLayout();
            this.statusStripConexion.ResumeLayout(false);
            this.statusStripConexion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TablaPrincipal;
        private System.Windows.Forms.StatusStrip statusStripConexion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConexion;
        private System.Windows.Forms.Panel PanelRaiz;
    }
}

