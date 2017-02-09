namespace EdoUI.Mensaje
{
    partial class FormMensaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMensaje));
            this.tlp_Mensaje = new System.Windows.Forms.TableLayoutPanel();
            this.ts_Mensaje = new System.Windows.Forms.ToolStrip();
            this.tsb_Mensaje_Adjunto = new System.Windows.Forms.ToolStripButton();
            this.tsb_Mensaje_Responder = new System.Windows.Forms.ToolStripButton();
            this.tsb_Mensaje_Reenviar = new System.Windows.Forms.ToolStripButton();
            this.tsb_Mensaje_Enviar = new System.Windows.Forms.ToolStripButton();
            this.tsb_Mensaje_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.controlMensaje1 = new EdoUI.Mensaje.ControlMensaje();
            this.tlp_Mensaje.SuspendLayout();
            this.ts_Mensaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Mensaje
            // 
            this.tlp_Mensaje.ColumnCount = 1;
            this.tlp_Mensaje.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Mensaje.Controls.Add(this.ts_Mensaje, 0, 1);
            this.tlp_Mensaje.Controls.Add(this.controlMensaje1, 0, 0);
            this.tlp_Mensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Mensaje.Location = new System.Drawing.Point(0, 0);
            this.tlp_Mensaje.Name = "tlp_Mensaje";
            this.tlp_Mensaje.RowCount = 2;
            this.tlp_Mensaje.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.53846F));
            this.tlp_Mensaje.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.46154F));
            this.tlp_Mensaje.Size = new System.Drawing.Size(384, 361);
            this.tlp_Mensaje.TabIndex = 0;
            // 
            // ts_Mensaje
            // 
            this.ts_Mensaje.CanOverflow = false;
            this.ts_Mensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ts_Mensaje.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_Mensaje.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Mensaje_Adjunto,
            this.tsb_Mensaje_Responder,
            this.tsb_Mensaje_Reenviar,
            this.tsb_Mensaje_Enviar,
            this.tsb_Mensaje_Eliminar});
            this.ts_Mensaje.Location = new System.Drawing.Point(5, 317);
            this.ts_Mensaje.Margin = new System.Windows.Forms.Padding(5);
            this.ts_Mensaje.Name = "ts_Mensaje";
            this.ts_Mensaje.Size = new System.Drawing.Size(374, 39);
            this.ts_Mensaje.TabIndex = 2;
            this.ts_Mensaje.Text = "toolStrip1";
            // 
            // tsb_Mensaje_Adjunto
            // 
            this.tsb_Mensaje_Adjunto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Mensaje_Adjunto.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Mensaje_Adjunto.Image")));
            this.tsb_Mensaje_Adjunto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Mensaje_Adjunto.Name = "tsb_Mensaje_Adjunto";
            this.tsb_Mensaje_Adjunto.Size = new System.Drawing.Size(62, 36);
            this.tsb_Mensaje_Adjunto.Text = "+Adjunto";
            // 
            // tsb_Mensaje_Responder
            // 
            this.tsb_Mensaje_Responder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Mensaje_Responder.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Mensaje_Responder.Image")));
            this.tsb_Mensaje_Responder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Mensaje_Responder.Name = "tsb_Mensaje_Responder";
            this.tsb_Mensaje_Responder.Size = new System.Drawing.Size(67, 36);
            this.tsb_Mensaje_Responder.Text = "Responder";
            // 
            // tsb_Mensaje_Reenviar
            // 
            this.tsb_Mensaje_Reenviar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Mensaje_Reenviar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Mensaje_Reenviar.Image")));
            this.tsb_Mensaje_Reenviar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Mensaje_Reenviar.Name = "tsb_Mensaje_Reenviar";
            this.tsb_Mensaje_Reenviar.Size = new System.Drawing.Size(56, 36);
            this.tsb_Mensaje_Reenviar.Text = "Reenviar";
            // 
            // tsb_Mensaje_Enviar
            // 
            this.tsb_Mensaje_Enviar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Mensaje_Enviar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Mensaje_Enviar.Image")));
            this.tsb_Mensaje_Enviar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Mensaje_Enviar.Name = "tsb_Mensaje_Enviar";
            this.tsb_Mensaje_Enviar.Size = new System.Drawing.Size(43, 36);
            this.tsb_Mensaje_Enviar.Text = "Enviar";
            // 
            // tsb_Mensaje_Eliminar
            // 
            this.tsb_Mensaje_Eliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Mensaje_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Mensaje_Eliminar.Image")));
            this.tsb_Mensaje_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Mensaje_Eliminar.Name = "tsb_Mensaje_Eliminar";
            this.tsb_Mensaje_Eliminar.Size = new System.Drawing.Size(54, 36);
            this.tsb_Mensaje_Eliminar.Text = "Eliminar";
            // 
            // controlMensaje1
            // 
            this.controlMensaje1.Adjuntos = null;
            this.controlMensaje1.Asunto = null;
            this.controlMensaje1.Contenido = null;
            this.controlMensaje1.Destinatarios = null;
            this.controlMensaje1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlMensaje1.Location = new System.Drawing.Point(3, 3);
            this.controlMensaje1.Name = "controlMensaje1";
            this.controlMensaje1.Size = new System.Drawing.Size(378, 306);
            this.controlMensaje1.TabIndex = 3;
            this.controlMensaje1.Text = "";
            // 
            // FormMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.tlp_Mensaje);
            this.Name = "FormMensaje";
            this.Text = "FormMensaje";
            this.tlp_Mensaje.ResumeLayout(false);
            this.tlp_Mensaje.PerformLayout();
            this.ts_Mensaje.ResumeLayout(false);
            this.ts_Mensaje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Mensaje;
        private System.Windows.Forms.ToolStrip ts_Mensaje;
        private System.Windows.Forms.ToolStripButton tsb_Mensaje_Enviar;
        private System.Windows.Forms.ToolStripButton tsb_Mensaje_Reenviar;
        private System.Windows.Forms.ToolStripButton tsb_Mensaje_Responder;
        private System.Windows.Forms.ToolStripButton tsb_Mensaje_Eliminar;
        private System.Windows.Forms.ToolStripButton tsb_Mensaje_Adjunto;
        private ControlMensaje controlMensaje1;
    }
}