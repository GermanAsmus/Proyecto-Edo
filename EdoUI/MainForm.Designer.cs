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
            this.bandejaCuenta1 = new EdoUI.Cuenta.BandejaCuenta();
            this.SuspendLayout();
            // 
            // bandejaCuenta1
            // 
            this.bandejaCuenta1.AutoSize = true;
            this.bandejaCuenta1.BackColor = System.Drawing.SystemColors.Control;
            this.bandejaCuenta1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bandejaCuenta1.Location = new System.Drawing.Point(0, 0);
            this.bandejaCuenta1.Margin = new System.Windows.Forms.Padding(5);
            this.bandejaCuenta1.MinimumSize = new System.Drawing.Size(200, 400);
            this.bandejaCuenta1.Name = "bandejaCuenta1";
            this.bandejaCuenta1.Size = new System.Drawing.Size(544, 601);
            this.bandejaCuenta1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 601);
            this.Controls.Add(this.bandejaCuenta1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(500, 600);
            this.Name = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Cuenta.BandejaCuenta bandejaCuenta1;
    }
}

