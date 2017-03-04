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
            this.gbx_Mensaje_Destinatario = new System.Windows.Forms.GroupBox();
            this.cbx_Mensaje_Destinatario = new System.Windows.Forms.ComboBox();
            this.tlp_Mensaje = new System.Windows.Forms.TableLayoutPanel();
            this.gbx_Mensaje_Asunto = new System.Windows.Forms.GroupBox();
            this.tbx_Mensaje_Asunto = new System.Windows.Forms.TextBox();
            this.gbx_Mensaje_Contenido = new System.Windows.Forms.GroupBox();
            this.rtbx_Mensaje_Contenido = new System.Windows.Forms.RichTextBox();
            this.ts_Mensaje = new System.Windows.Forms.ToolStrip();
            this.tsb_Mensaje_Enviar = new System.Windows.Forms.ToolStripButton();
            this.gbx_Mensaje_Destinatario.SuspendLayout();
            this.tlp_Mensaje.SuspendLayout();
            this.gbx_Mensaje_Asunto.SuspendLayout();
            this.gbx_Mensaje_Contenido.SuspendLayout();
            this.ts_Mensaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_Mensaje_Destinatario
            // 
            this.gbx_Mensaje_Destinatario.Controls.Add(this.cbx_Mensaje_Destinatario);
            this.gbx_Mensaje_Destinatario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbx_Mensaje_Destinatario.Location = new System.Drawing.Point(0, 0);
            this.gbx_Mensaje_Destinatario.Margin = new System.Windows.Forms.Padding(0);
            this.gbx_Mensaje_Destinatario.Name = "gbx_Mensaje_Destinatario";
            this.gbx_Mensaje_Destinatario.Size = new System.Drawing.Size(384, 88);
            this.gbx_Mensaje_Destinatario.TabIndex = 4;
            this.gbx_Mensaje_Destinatario.TabStop = false;
            this.gbx_Mensaje_Destinatario.Text = "Destinatarios";
            // 
            // cbx_Mensaje_Destinatario
            // 
            this.cbx_Mensaje_Destinatario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbx_Mensaje_Destinatario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbx_Mensaje_Destinatario.FormattingEnabled = true;
            this.cbx_Mensaje_Destinatario.Location = new System.Drawing.Point(3, 16);
            this.cbx_Mensaje_Destinatario.MaxDropDownItems = 4;
            this.cbx_Mensaje_Destinatario.Name = "cbx_Mensaje_Destinatario";
            this.cbx_Mensaje_Destinatario.Size = new System.Drawing.Size(378, 69);
            this.cbx_Mensaje_Destinatario.TabIndex = 0;
            this.cbx_Mensaje_Destinatario.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.cbx_Mensaje_Destinatario_PreviewKeyDown);
            // 
            // tlp_Mensaje
            // 
            this.tlp_Mensaje.ColumnCount = 1;
            this.tlp_Mensaje.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Mensaje.Controls.Add(this.ts_Mensaje, 0, 3);
            this.tlp_Mensaje.Controls.Add(this.gbx_Mensaje_Contenido, 0, 2);
            this.tlp_Mensaje.Controls.Add(this.gbx_Mensaje_Asunto, 0, 1);
            this.tlp_Mensaje.Controls.Add(this.gbx_Mensaje_Destinatario, 0, 0);
            this.tlp_Mensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlp_Mensaje.Location = new System.Drawing.Point(0, 0);
            this.tlp_Mensaje.Name = "tlp_Mensaje";
            this.tlp_Mensaje.RowCount = 4;
            this.tlp_Mensaje.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp_Mensaje.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_Mensaje.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlp_Mensaje.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlp_Mensaje.Size = new System.Drawing.Size(384, 441);
            this.tlp_Mensaje.TabIndex = 0;
            // 
            // gbx_Mensaje_Asunto
            // 
            this.gbx_Mensaje_Asunto.Controls.Add(this.tbx_Mensaje_Asunto);
            this.gbx_Mensaje_Asunto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbx_Mensaje_Asunto.Location = new System.Drawing.Point(0, 88);
            this.gbx_Mensaje_Asunto.Margin = new System.Windows.Forms.Padding(0);
            this.gbx_Mensaje_Asunto.Name = "gbx_Mensaje_Asunto";
            this.gbx_Mensaje_Asunto.Size = new System.Drawing.Size(384, 44);
            this.gbx_Mensaje_Asunto.TabIndex = 5;
            this.gbx_Mensaje_Asunto.TabStop = false;
            this.gbx_Mensaje_Asunto.Text = "Asunto";
            // 
            // tbx_Mensaje_Asunto
            // 
            this.tbx_Mensaje_Asunto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbx_Mensaje_Asunto.Location = new System.Drawing.Point(3, 16);
            this.tbx_Mensaje_Asunto.Name = "tbx_Mensaje_Asunto";
            this.tbx_Mensaje_Asunto.Size = new System.Drawing.Size(378, 20);
            this.tbx_Mensaje_Asunto.TabIndex = 0;
            this.tbx_Mensaje_Asunto.TextChanged += new System.EventHandler(this.tbx_Mensaje_Asunto_TextChanged);
            // 
            // gbx_Mensaje_Contenido
            // 
            this.gbx_Mensaje_Contenido.Controls.Add(this.rtbx_Mensaje_Contenido);
            this.gbx_Mensaje_Contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbx_Mensaje_Contenido.Location = new System.Drawing.Point(3, 135);
            this.gbx_Mensaje_Contenido.Name = "gbx_Mensaje_Contenido";
            this.gbx_Mensaje_Contenido.Size = new System.Drawing.Size(378, 258);
            this.gbx_Mensaje_Contenido.TabIndex = 6;
            this.gbx_Mensaje_Contenido.TabStop = false;
            this.gbx_Mensaje_Contenido.Text = "Mensaje";
            // 
            // rtbx_Mensaje_Contenido
            // 
            this.rtbx_Mensaje_Contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbx_Mensaje_Contenido.Location = new System.Drawing.Point(3, 16);
            this.rtbx_Mensaje_Contenido.Name = "rtbx_Mensaje_Contenido";
            this.rtbx_Mensaje_Contenido.Size = new System.Drawing.Size(372, 239);
            this.rtbx_Mensaje_Contenido.TabIndex = 0;
            this.rtbx_Mensaje_Contenido.Text = "";
            this.rtbx_Mensaje_Contenido.TextChanged += new System.EventHandler(this.rtbx_Mensaje_Contenido_TextChanged);
            // 
            // ts_Mensaje
            // 
            this.ts_Mensaje.CanOverflow = false;
            this.ts_Mensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ts_Mensaje.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts_Mensaje.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_Mensaje_Enviar});
            this.ts_Mensaje.Location = new System.Drawing.Point(5, 401);
            this.ts_Mensaje.Margin = new System.Windows.Forms.Padding(5);
            this.ts_Mensaje.Name = "ts_Mensaje";
            this.ts_Mensaje.Size = new System.Drawing.Size(374, 35);
            this.ts_Mensaje.TabIndex = 8;
            this.ts_Mensaje.Text = "toolStrip1";
            // 
            // tsb_Mensaje_Enviar
            // 
            this.tsb_Mensaje_Enviar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsb_Mensaje_Enviar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsb_Mensaje_Enviar.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Mensaje_Enviar.Image")));
            this.tsb_Mensaje_Enviar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Mensaje_Enviar.Name = "tsb_Mensaje_Enviar";
            this.tsb_Mensaje_Enviar.Size = new System.Drawing.Size(43, 32);
            this.tsb_Mensaje_Enviar.Text = "Enviar";
            this.tsb_Mensaje_Enviar.Click += new System.EventHandler(this.tsb_Mensaje_Enviar_Click);
            // 
            // FormMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 441);
            this.Controls.Add(this.tlp_Mensaje);
            this.MaximizeBox = false;
            this.Name = "FormMensaje";
            this.Text = "Nuevo Mensaje";
            this.gbx_Mensaje_Destinatario.ResumeLayout(false);
            this.tlp_Mensaje.ResumeLayout(false);
            this.tlp_Mensaje.PerformLayout();
            this.gbx_Mensaje_Asunto.ResumeLayout(false);
            this.gbx_Mensaje_Asunto.PerformLayout();
            this.gbx_Mensaje_Contenido.ResumeLayout(false);
            this.ts_Mensaje.ResumeLayout(false);
            this.ts_Mensaje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_Mensaje_Destinatario;
        private System.Windows.Forms.ComboBox cbx_Mensaje_Destinatario;
        private System.Windows.Forms.TableLayoutPanel tlp_Mensaje;
        private System.Windows.Forms.ToolStrip ts_Mensaje;
        private System.Windows.Forms.ToolStripButton tsb_Mensaje_Enviar;
        private System.Windows.Forms.GroupBox gbx_Mensaje_Contenido;
        private System.Windows.Forms.RichTextBox rtbx_Mensaje_Contenido;
        private System.Windows.Forms.GroupBox gbx_Mensaje_Asunto;
        private System.Windows.Forms.TextBox tbx_Mensaje_Asunto;
    }
}