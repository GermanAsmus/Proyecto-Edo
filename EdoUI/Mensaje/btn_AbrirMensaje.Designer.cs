﻿namespace EdoUI.Mensaje
{
    partial class btn_AbrirMensaje
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
            this.btn_Cuenta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Cuenta
            // 
            this.btn_Cuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Cuenta.Location = new System.Drawing.Point(0, 0);
            this.btn_Cuenta.Name = "btn_Cuenta";
            this.btn_Cuenta.Size = new System.Drawing.Size(200, 50);
            this.btn_Cuenta.TabIndex = 0;
            this.btn_Cuenta.Text = "Nombre Cuenta";
            this.btn_Cuenta.UseVisualStyleBackColor = true;
            // 
            // btn_AbrirCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Cuenta);
            this.Name = "btn_AbrirCuenta";
            this.Size = new System.Drawing.Size(200, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Cuenta;
    }
}