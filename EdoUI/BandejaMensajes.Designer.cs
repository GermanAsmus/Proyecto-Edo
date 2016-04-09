namespace EdoUI
{
    partial class BandejaMensajes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BandejaMensajes));
            this.tableLayoutPanelBandeja = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripCabecera = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonDesplegar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabelFecha = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSplitButtonSeleccionar = new System.Windows.Forms.ToolStripSplitButton();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noLeidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanelMensajes = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanelBandeja.SuspendLayout();
            this.toolStripCabecera.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelBandeja
            // 
            this.tableLayoutPanelBandeja.ColumnCount = 1;
            this.tableLayoutPanelBandeja.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBandeja.Controls.Add(this.toolStripCabecera, 0, 0);
            this.tableLayoutPanelBandeja.Controls.Add(this.flowLayoutPanelMensajes, 0, 1);
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
            this.toolStripCabecera.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.toolStripCabecera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripCabecera.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripCabecera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonDesplegar,
            this.toolStripLabelFecha,
            this.toolStripSplitButtonSeleccionar});
            this.toolStripCabecera.Location = new System.Drawing.Point(0, 0);
            this.toolStripCabecera.Name = "toolStripCabecera";
            this.toolStripCabecera.Size = new System.Drawing.Size(168, 25);
            this.toolStripCabecera.TabIndex = 0;
            this.toolStripCabecera.Text = "toolStrip1";
            // 
            // toolStripButtonDesplegar
            // 
            this.toolStripButtonDesplegar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonDesplegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDesplegar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDesplegar.Name = "toolStripButtonDesplegar";
            this.toolStripButtonDesplegar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonDesplegar.Text = "+";
            this.toolStripButtonDesplegar.Click += new System.EventHandler(this.toolStripButtonDesplegar_Click);
            // 
            // toolStripLabelFecha
            // 
            this.toolStripLabelFecha.Name = "toolStripLabelFecha";
            this.toolStripLabelFecha.Size = new System.Drawing.Size(38, 22);
            this.toolStripLabelFecha.Text = "Fecha";
            // 
            // toolStripSplitButtonSeleccionar
            // 
            this.toolStripSplitButtonSeleccionar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButtonSeleccionar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosToolStripMenuItem,
            this.leidosToolStripMenuItem,
            this.noLeidoToolStripMenuItem});
            this.toolStripSplitButtonSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButtonSeleccionar.Image")));
            this.toolStripSplitButtonSeleccionar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButtonSeleccionar.Name = "toolStripSplitButtonSeleccionar";
            this.toolStripSplitButtonSeleccionar.Size = new System.Drawing.Size(83, 22);
            this.toolStripSplitButtonSeleccionar.Text = "Seleccionar";
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.todosToolStripMenuItem.Text = "Todos";
            this.todosToolStripMenuItem.Click += new System.EventHandler(this.todosToolStripMenuItem_Click);
            // 
            // leidosToolStripMenuItem
            // 
            this.leidosToolStripMenuItem.Name = "leidosToolStripMenuItem";
            this.leidosToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.leidosToolStripMenuItem.Text = "Leidos";
            this.leidosToolStripMenuItem.Click += new System.EventHandler(this.leidosToolStripMenuItem_Click);
            // 
            // noLeidoToolStripMenuItem
            // 
            this.noLeidoToolStripMenuItem.Name = "noLeidoToolStripMenuItem";
            this.noLeidoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.noLeidoToolStripMenuItem.Text = "No Leidos";
            this.noLeidoToolStripMenuItem.Click += new System.EventHandler(this.noLeidoToolStripMenuItem_Click);
            // 
            // flowLayoutPanelMensajes
            // 
            this.flowLayoutPanelMensajes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMensajes.Location = new System.Drawing.Point(3, 28);
            this.flowLayoutPanelMensajes.Name = "flowLayoutPanelMensajes";
            this.flowLayoutPanelMensajes.Size = new System.Drawing.Size(162, 67);
            this.flowLayoutPanelMensajes.TabIndex = 1;
            // 
            // UserControlBandeja
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanelBandeja);
            this.Name = "UserControlBandeja";
            this.Size = new System.Drawing.Size(168, 98);
            this.tableLayoutPanelBandeja.ResumeLayout(false);
            this.tableLayoutPanelBandeja.PerformLayout();
            this.toolStripCabecera.ResumeLayout(false);
            this.toolStripCabecera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBandeja;
        private System.Windows.Forms.ToolStrip toolStripCabecera;
        private System.Windows.Forms.ToolStripButton toolStripButtonDesplegar;
        private System.Windows.Forms.ToolStripLabel toolStripLabelFecha;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButtonSeleccionar;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noLeidoToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMensajes;
    }
}
