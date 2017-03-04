namespace EdoUI.Mensaje
{
    partial class BandejaMensaje
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
            this.dgv_BandejaMensaje_Bandeja = new System.Windows.Forms.DataGridView();
            this.btn_BandejaMensaje_NuevoMensaje = new System.Windows.Forms.Button();
            this.tlp_BandejaMensaje = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BandejaMensaje_Bandeja)).BeginInit();
            this.tlp_BandejaMensaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_BandejaMensaje_Bandeja
            // 
            this.dgv_BandejaMensaje_Bandeja.AllowUserToAddRows = false;
            this.dgv_BandejaMensaje_Bandeja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BandejaMensaje_Bandeja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_BandejaMensaje_Bandeja.Location = new System.Drawing.Point(3, 32);
            this.dgv_BandejaMensaje_Bandeja.Name = "dgv_BandejaMensaje_Bandeja";
            this.dgv_BandejaMensaje_Bandeja.ReadOnly = true;
            this.dgv_BandejaMensaje_Bandeja.Size = new System.Drawing.Size(194, 365);
            this.dgv_BandejaMensaje_Bandeja.TabIndex = 4;
            // 
            // btn_BandejaMensaje_NuevoMensaje
            // 
            this.btn_BandejaMensaje_NuevoMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_BandejaMensaje_NuevoMensaje.FlatAppearance.BorderSize = 0;
            this.btn_BandejaMensaje_NuevoMensaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BandejaMensaje_NuevoMensaje.Location = new System.Drawing.Point(3, 3);
            this.btn_BandejaMensaje_NuevoMensaje.Name = "btn_BandejaMensaje_NuevoMensaje";
            this.btn_BandejaMensaje_NuevoMensaje.Size = new System.Drawing.Size(194, 23);
            this.btn_BandejaMensaje_NuevoMensaje.TabIndex = 2;
            this.btn_BandejaMensaje_NuevoMensaje.Text = "Nuevo Mensaje";
            this.btn_BandejaMensaje_NuevoMensaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_BandejaMensaje_NuevoMensaje.UseVisualStyleBackColor = true;
            this.btn_BandejaMensaje_NuevoMensaje.Click += new System.EventHandler(this.btn_BandejaMensaje_NuevoMensaje_Click);
            // 
            // tlp_BandejaMensaje
            // 
            this.tlp_BandejaMensaje.AutoSize = true;
            this.tlp_BandejaMensaje.ColumnCount = 1;
            this.tlp_BandejaMensaje.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_BandejaMensaje.Controls.Add(this.btn_BandejaMensaje_NuevoMensaje, 0, 0);
            this.tlp_BandejaMensaje.Controls.Add(this.dgv_BandejaMensaje_Bandeja, 0, 1);
            this.tlp_BandejaMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_BandejaMensaje.Location = new System.Drawing.Point(0, 0);
            this.tlp_BandejaMensaje.Name = "tlp_BandejaMensaje";
            this.tlp_BandejaMensaje.RowCount = 2;
            this.tlp_BandejaMensaje.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_BandejaMensaje.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_BandejaMensaje.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_BandejaMensaje.Size = new System.Drawing.Size(200, 400);
            this.tlp_BandejaMensaje.TabIndex = 0;
            // 
            // BandejaMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_BandejaMensaje);
            this.Name = "BandejaMensaje";
            this.Size = new System.Drawing.Size(200, 400);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BandejaMensaje_Bandeja)).EndInit();
            this.tlp_BandejaMensaje.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_BandejaMensaje_Bandeja;
        private System.Windows.Forms.Button btn_BandejaMensaje_NuevoMensaje;
        private System.Windows.Forms.TableLayoutPanel tlp_BandejaMensaje;
    }
}
