namespace EdoUI
{
    partial class ControlAdjuntos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlAdjuntos));
            this.tableLayoutPanelAdjuntos = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripHerramientas = new System.Windows.Forms.ToolStrip();
            this.toolStripLabelNombre = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonImportar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEliminar = new System.Windows.Forms.ToolStripButton();
            this.checkedListBoxAdjuntos = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanelAdjuntos.SuspendLayout();
            this.toolStripHerramientas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelAdjuntos
            // 
            this.tableLayoutPanelAdjuntos.ColumnCount = 1;
            this.tableLayoutPanelAdjuntos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelAdjuntos.Controls.Add(this.toolStripHerramientas, 0, 0);
            this.tableLayoutPanelAdjuntos.Controls.Add(this.checkedListBoxAdjuntos, 0, 1);
            this.tableLayoutPanelAdjuntos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAdjuntos.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelAdjuntos.Name = "tableLayoutPanelAdjuntos";
            this.tableLayoutPanelAdjuntos.RowCount = 2;
            this.tableLayoutPanelAdjuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAdjuntos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAdjuntos.Size = new System.Drawing.Size(250, 250);
            this.tableLayoutPanelAdjuntos.TabIndex = 0;
            // 
            // toolStripHerramientas
            // 
            this.toolStripHerramientas.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.toolStripHerramientas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripHerramientas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripHerramientas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelNombre,
            this.toolStripSeparator,
            this.toolStripButtonImportar,
            this.toolStripButtonEliminar});
            this.toolStripHerramientas.Location = new System.Drawing.Point(0, 0);
            this.toolStripHerramientas.Name = "toolStripHerramientas";
            this.toolStripHerramientas.Size = new System.Drawing.Size(250, 25);
            this.toolStripHerramientas.TabIndex = 10;
            this.toolStripHerramientas.Text = "toolStrip1";
            // 
            // toolStripLabelNombre
            // 
            this.toolStripLabelNombre.Name = "toolStripLabelNombre";
            this.toolStripLabelNombre.Size = new System.Drawing.Size(55, 22);
            this.toolStripLabelNombre.Text = "Adjuntos";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonImportar
            // 
            this.toolStripButtonImportar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonImportar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonImportar.Image")));
            this.toolStripButtonImportar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonImportar.Name = "toolStripButtonImportar";
            this.toolStripButtonImportar.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonImportar.Text = "Importar";
            // 
            // toolStripButtonEliminar
            // 
            this.toolStripButtonEliminar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEliminar.Image")));
            this.toolStripButtonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEliminar.Name = "toolStripButtonEliminar";
            this.toolStripButtonEliminar.Size = new System.Drawing.Size(54, 22);
            this.toolStripButtonEliminar.Text = "Eliminar";
            // 
            // checkedListBoxAdjuntos
            // 
            this.checkedListBoxAdjuntos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxAdjuntos.FormattingEnabled = true;
            this.checkedListBoxAdjuntos.Location = new System.Drawing.Point(5, 30);
            this.checkedListBoxAdjuntos.Margin = new System.Windows.Forms.Padding(5);
            this.checkedListBoxAdjuntos.Name = "checkedListBoxAdjuntos";
            this.checkedListBoxAdjuntos.Size = new System.Drawing.Size(240, 219);
            this.checkedListBoxAdjuntos.TabIndex = 11;
            // 
            // ControlAdjuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelAdjuntos);
            this.Name = "ControlAdjuntos";
            this.Size = new System.Drawing.Size(250, 250);
            this.tableLayoutPanelAdjuntos.ResumeLayout(false);
            this.tableLayoutPanelAdjuntos.PerformLayout();
            this.toolStripHerramientas.ResumeLayout(false);
            this.toolStripHerramientas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAdjuntos;
        private System.Windows.Forms.ToolStrip toolStripHerramientas;
        private System.Windows.Forms.ToolStripLabel toolStripLabelNombre;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton toolStripButtonImportar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminar;
        private System.Windows.Forms.CheckedListBox checkedListBoxAdjuntos;
    }
}
