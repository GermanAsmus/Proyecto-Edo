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
            this.tlp_Mensaje = new System.Windows.Forms.TableLayoutPanel();
            this.btn_ModificarCuenta = new System.Windows.Forms.Button();
            this.btn_NuevoMensaje = new System.Windows.Forms.Button();
            this.rtb_informacion = new System.Windows.Forms.RichTextBox();
            this.flp_Mensaje = new System.Windows.Forms.FlowLayoutPanel();
            this.tlp_Mensaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Mensaje
            // 
            this.tlp_Mensaje.ColumnCount = 1;
            this.tlp_Mensaje.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Mensaje.Controls.Add(this.btn_ModificarCuenta, 0, 1);
            this.tlp_Mensaje.Controls.Add(this.btn_NuevoMensaje, 0, 2);
            this.tlp_Mensaje.Controls.Add(this.rtb_informacion, 0, 0);
            this.tlp_Mensaje.Controls.Add(this.flp_Mensaje, 0, 3);
            this.tlp_Mensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Mensaje.Location = new System.Drawing.Point(0, 0);
            this.tlp_Mensaje.Name = "tlp_Mensaje";
            this.tlp_Mensaje.RowCount = 4;
            this.tlp_Mensaje.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Mensaje.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Mensaje.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Mensaje.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlp_Mensaje.Size = new System.Drawing.Size(200, 400);
            this.tlp_Mensaje.TabIndex = 0;
            // 
            // btn_ModificarCuenta
            // 
            this.btn_ModificarCuenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ModificarCuenta.Location = new System.Drawing.Point(3, 105);
            this.btn_ModificarCuenta.Name = "btn_ModificarCuenta";
            this.btn_ModificarCuenta.Size = new System.Drawing.Size(194, 23);
            this.btn_ModificarCuenta.TabIndex = 1;
            this.btn_ModificarCuenta.Text = "Modificar Cuenta";
            this.btn_ModificarCuenta.UseVisualStyleBackColor = true;
            // 
            // btn_NuevoMensaje
            // 
            this.btn_NuevoMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_NuevoMensaje.Location = new System.Drawing.Point(3, 134);
            this.btn_NuevoMensaje.Name = "btn_NuevoMensaje";
            this.btn_NuevoMensaje.Size = new System.Drawing.Size(194, 23);
            this.btn_NuevoMensaje.TabIndex = 2;
            this.btn_NuevoMensaje.Text = "Nuevo Mensaje";
            this.btn_NuevoMensaje.UseVisualStyleBackColor = true;
            // 
            // rtb_informacion
            // 
            this.rtb_informacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_informacion.Location = new System.Drawing.Point(3, 3);
            this.rtb_informacion.Name = "rtb_informacion";
            this.rtb_informacion.ReadOnly = true;
            this.rtb_informacion.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtb_informacion.ShowSelectionMargin = true;
            this.rtb_informacion.Size = new System.Drawing.Size(194, 96);
            this.rtb_informacion.TabIndex = 3;
            this.rtb_informacion.Text = "Información de la cuenta";
            // 
            // flp_Mensaje
            // 
            this.flp_Mensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_Mensaje.Location = new System.Drawing.Point(3, 163);
            this.flp_Mensaje.MaximumSize = new System.Drawing.Size(194, 234);
            this.flp_Mensaje.MinimumSize = new System.Drawing.Size(194, 234);
            this.flp_Mensaje.Name = "flp_Mensaje";
            this.flp_Mensaje.Size = new System.Drawing.Size(194, 234);
            this.flp_Mensaje.TabIndex = 4;
            // 
            // BandejaCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp_Mensaje);
            this.Name = "BandejaCuenta";
            this.Size = new System.Drawing.Size(200, 400);
            this.tlp_Mensaje.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Mensaje;
        private System.Windows.Forms.Button btn_ModificarCuenta;
        private System.Windows.Forms.Button btn_NuevoMensaje;
        private System.Windows.Forms.RichTextBox rtb_informacion;
        private System.Windows.Forms.FlowLayoutPanel flp_Mensaje;
    }
}
