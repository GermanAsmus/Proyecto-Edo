namespace EdoUI
{
    partial class ProbarConexion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProbarConexion));
            this.ss_Main = new System.Windows.Forms.StatusStrip();
            this.tlsl_Main_Conexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.ss_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // ss_Main
            // 
            this.ss_Main.AllowMerge = false;
            this.ss_Main.BackColor = System.Drawing.Color.Transparent;
            this.ss_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlsl_Main_Conexion});
            this.ss_Main.Location = new System.Drawing.Point(0, -2);
            this.ss_Main.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.ss_Main.Name = "ss_Main";
            this.ss_Main.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ss_Main.Size = new System.Drawing.Size(400, 22);
            this.ss_Main.SizingGrip = false;
            this.ss_Main.TabIndex = 5;
            this.ss_Main.Text = "statusStrip1";
            // 
            // tlsl_Main_Conexion
            // 
            this.tlsl_Main_Conexion.Image = ((System.Drawing.Image)(resources.GetObject("tlsl_Main_Conexion.Image")));
            this.tlsl_Main_Conexion.Name = "tlsl_Main_Conexion";
            this.tlsl_Main_Conexion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tlsl_Main_Conexion.Size = new System.Drawing.Size(73, 17);
            this.tlsl_Main_Conexion.Text = "Conexion";
            this.tlsl_Main_Conexion.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // Conexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ss_Main);
            this.Name = "Conexion";
            this.Size = new System.Drawing.Size(400, 20);
            this.ss_Main.ResumeLayout(false);
            this.ss_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ss_Main;
        private System.Windows.Forms.ToolStripStatusLabel tlsl_Main_Conexion;
    }
}
