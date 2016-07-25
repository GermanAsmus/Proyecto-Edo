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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.statusStripConexion = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelA = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.statusStripConexion.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.statusStripConexion, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1046, 630);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // statusStripConexion
            // 
            this.statusStripConexion.AllowMerge = false;
            this.statusStripConexion.BackColor = System.Drawing.Color.Transparent;
            this.statusStripConexion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelConexion});
            this.statusStripConexion.Location = new System.Drawing.Point(6, 607);
            this.statusStripConexion.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.statusStripConexion.Name = "statusStripConexion";
            this.statusStripConexion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStripConexion.Size = new System.Drawing.Size(1034, 20);
            this.statusStripConexion.SizingGrip = false;
            this.statusStripConexion.TabIndex = 2;
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.69231F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.30769F));
            this.tableLayoutPanel2.Controls.Add(this.panelPrincipal, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelA, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1040, 604);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.Transparent;
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(3, 3);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Padding = new System.Windows.Forms.Padding(3, 50, 3, 0);
            this.panelPrincipal.Size = new System.Drawing.Size(126, 598);
            this.panelPrincipal.TabIndex = 3;
            // 
            // panelA
            // 
            this.panelA.BackColor = System.Drawing.Color.Transparent;
            this.panelA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelA.Location = new System.Drawing.Point(135, 3);
            this.panelA.Name = "panelA";
            this.panelA.Size = new System.Drawing.Size(902, 598);
            this.panelA.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 630);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "EDO";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.statusStripConexion.ResumeLayout(false);
            this.statusStripConexion.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelA;
        private System.Windows.Forms.StatusStrip statusStripConexion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConexion;
    }
}

