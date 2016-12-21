namespace EdoUI
{
    partial class Bloque<T> where T : class
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
            this.bloqueTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonModificar = new System.Windows.Forms.Button();
            this.botonNuevoMensaje = new System.Windows.Forms.Button();
            this.Sincronizar = new System.Windows.Forms.Button();
            this.bloqueTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bloqueTablePanel
            // 
            this.bloqueTablePanel.AutoSize = true;
            this.bloqueTablePanel.ColumnCount = 4;
            this.bloqueTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.bloqueTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.bloqueTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.bloqueTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.bloqueTablePanel.Controls.Add(this.botonNuevoMensaje, 2, 0);
            this.bloqueTablePanel.Controls.Add(this.botonEliminar, 0, 0);
            this.bloqueTablePanel.Controls.Add(this.Sincronizar, 3, 0);
            this.bloqueTablePanel.Controls.Add(this.botonModificar, 1, 0);
            this.bloqueTablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bloqueTablePanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.bloqueTablePanel.Location = new System.Drawing.Point(0, 0);
            this.bloqueTablePanel.Name = "bloqueTablePanel";
            this.bloqueTablePanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bloqueTablePanel.RowCount = 1;
            this.bloqueTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bloqueTablePanel.Size = new System.Drawing.Size(803, 26);
            this.bloqueTablePanel.TabIndex = 0;
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(780, 3);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(20, 20);
            this.botonEliminar.TabIndex = 4;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            // 
            // botonModificar
            // 
            this.botonModificar.Location = new System.Drawing.Point(754, 3);
            this.botonModificar.Name = "botonModificar";
            this.botonModificar.Size = new System.Drawing.Size(20, 20);
            this.botonModificar.TabIndex = 5;
            this.botonModificar.Text = "Modificar";
            this.botonModificar.UseVisualStyleBackColor = true;
            // 
            // botonNuevoMensaje
            // 
            this.botonNuevoMensaje.Location = new System.Drawing.Point(728, 3);
            this.botonNuevoMensaje.Name = "botonNuevoMensaje";
            this.botonNuevoMensaje.Size = new System.Drawing.Size(20, 20);
            this.botonNuevoMensaje.TabIndex = 6;
            this.botonNuevoMensaje.Text = "Nuevo Mensaje";
            this.botonNuevoMensaje.UseVisualStyleBackColor = true;
            // 
            // Sincronizar
            // 
            this.Sincronizar.Location = new System.Drawing.Point(702, 3);
            this.Sincronizar.Name = "Sincronizar";
            this.Sincronizar.Size = new System.Drawing.Size(20, 20);
            this.Sincronizar.TabIndex = 7;
            this.Sincronizar.Text = "Sincronizar";
            this.Sincronizar.UseVisualStyleBackColor = true;
            // 
            // Bloque
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.bloqueTablePanel);
            this.Name = "Bloque";
            this.Size = new System.Drawing.Size(803, 32);
            this.bloqueTablePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel bloqueTablePanel;
        private System.Windows.Forms.Button botonNuevoMensaje;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button Sincronizar;
        private System.Windows.Forms.Button botonModificar;
    }
}
