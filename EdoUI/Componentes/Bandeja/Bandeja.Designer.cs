using System.Windows.Forms;

namespace EdoUI
{
    partial class Bandeja<T> : UserControl where T : class
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
            this.tableLayoutPanelBandeja = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripCabecera = new System.Windows.Forms.ToolStrip();
            this.BandejaTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelBandeja.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelBandeja
            // 
            this.tableLayoutPanelBandeja.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanelBandeja.ColumnCount = 1;
            this.tableLayoutPanelBandeja.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBandeja.Controls.Add(this.toolStripCabecera, 0, 0);
            this.tableLayoutPanelBandeja.Controls.Add(this.BandejaTablePanel, 0, 1);
            this.tableLayoutPanelBandeja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBandeja.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelBandeja.Name = "tableLayoutPanelBandeja";
            this.tableLayoutPanelBandeja.RowCount = 2;
            this.tableLayoutPanelBandeja.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBandeja.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBandeja.Size = new System.Drawing.Size(168, 98);
            this.tableLayoutPanelBandeja.TabIndex = 1;
            // 
            // toolStripCabecera
            // 
            this.toolStripCabecera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(102)))), ((int)(((byte)(100)))));
            this.toolStripCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripCabecera.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripCabecera.Location = new System.Drawing.Point(0, 0);
            this.toolStripCabecera.Name = "toolStripCabecera";
            this.toolStripCabecera.Size = new System.Drawing.Size(168, 25);
            this.toolStripCabecera.TabIndex = 0;
            this.toolStripCabecera.Text = "toolStrip1";
            // 
            // BandejaTablePanel
            // 
            this.BandejaTablePanel.ColumnCount = 1;
            this.BandejaTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BandejaTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BandejaTablePanel.Location = new System.Drawing.Point(3, 28);
            this.BandejaTablePanel.Name = "BandejaTablePanel";
            this.BandejaTablePanel.RowCount = 1;
            this.BandejaTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BandejaTablePanel.Size = new System.Drawing.Size(162, 67);
            this.BandejaTablePanel.TabIndex = 1;
            // 
            // Bandeja
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanelBandeja);
            this.Name = "Bandeja";
            this.Size = new System.Drawing.Size(168, 98);
            this.tableLayoutPanelBandeja.ResumeLayout(false);
            this.tableLayoutPanelBandeja.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBandeja;
        private System.Windows.Forms.ToolStrip toolStripCabecera;
        public TableLayoutPanel BandejaTablePanel;
    }
}
