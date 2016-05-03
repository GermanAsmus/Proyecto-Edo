namespace EdoUI
{
    partial class ControlMensaje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlMensaje));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelMensaje = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelBandeja = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxAsunto = new System.Windows.Forms.TextBox();
            this.textBoxDestinatario = new System.Windows.Forms.TextBox();
            this.labelDestinatario = new System.Windows.Forms.Label();
            this.listBoxDestinatarios = new System.Windows.Forms.ListBox();
            this.labelAsunto = new System.Windows.Forms.Label();
            this.controlAdjuntos1 = new EdoUI.ControlAdjuntos();
            this.tableLayoutPanelRedactor = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripEnviar = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonEnviar = new System.Windows.Forms.ToolStripButton();
            this.richTextBoxContenido = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButtonCancelar = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelMensaje.SuspendLayout();
            this.tableLayoutPanelBandeja.SuspendLayout();
            this.tableLayoutPanelRedactor.SuspendLayout();
            this.toolStripEnviar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelMensaje, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.698276F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.30173F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(393, 464);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanelMensaje
            // 
            this.tableLayoutPanelMensaje.ColumnCount = 2;
            this.tableLayoutPanelMensaje.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMensaje.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMensaje.Controls.Add(this.tableLayoutPanelBandeja, 0, 0);
            this.tableLayoutPanelMensaje.Controls.Add(this.tableLayoutPanelRedactor, 1, 0);
            this.tableLayoutPanelMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMensaje.Location = new System.Drawing.Point(3, 47);
            this.tableLayoutPanelMensaje.Name = "tableLayoutPanelMensaje";
            this.tableLayoutPanelMensaje.RowCount = 1;
            this.tableLayoutPanelMensaje.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMensaje.Size = new System.Drawing.Size(387, 414);
            this.tableLayoutPanelMensaje.TabIndex = 1;
            // 
            // tableLayoutPanelBandeja
            // 
            this.tableLayoutPanelBandeja.ColumnCount = 1;
            this.tableLayoutPanelBandeja.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBandeja.Controls.Add(this.textBoxAsunto, 0, 4);
            this.tableLayoutPanelBandeja.Controls.Add(this.textBoxDestinatario, 0, 1);
            this.tableLayoutPanelBandeja.Controls.Add(this.labelDestinatario, 0, 0);
            this.tableLayoutPanelBandeja.Controls.Add(this.listBoxDestinatarios, 0, 2);
            this.tableLayoutPanelBandeja.Controls.Add(this.labelAsunto, 0, 3);
            this.tableLayoutPanelBandeja.Controls.Add(this.controlAdjuntos1, 0, 5);
            this.tableLayoutPanelBandeja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBandeja.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelBandeja.Name = "tableLayoutPanelBandeja";
            this.tableLayoutPanelBandeja.RowCount = 6;
            this.tableLayoutPanelBandeja.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBandeja.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBandeja.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBandeja.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBandeja.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelBandeja.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBandeja.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelBandeja.Size = new System.Drawing.Size(187, 408);
            this.tableLayoutPanelBandeja.TabIndex = 2;
            // 
            // textBoxAsunto
            // 
            this.textBoxAsunto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAsunto.Location = new System.Drawing.Point(3, 157);
            this.textBoxAsunto.Name = "textBoxAsunto";
            this.textBoxAsunto.Size = new System.Drawing.Size(181, 20);
            this.textBoxAsunto.TabIndex = 7;
            // 
            // textBoxDestinatario
            // 
            this.textBoxDestinatario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDestinatario.Location = new System.Drawing.Point(3, 16);
            this.textBoxDestinatario.Name = "textBoxDestinatario";
            this.textBoxDestinatario.Size = new System.Drawing.Size(181, 20);
            this.textBoxDestinatario.TabIndex = 4;
            // 
            // labelDestinatario
            // 
            this.labelDestinatario.AutoSize = true;
            this.labelDestinatario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDestinatario.Location = new System.Drawing.Point(3, 0);
            this.labelDestinatario.Name = "labelDestinatario";
            this.labelDestinatario.Size = new System.Drawing.Size(181, 13);
            this.labelDestinatario.TabIndex = 3;
            this.labelDestinatario.Text = "Destinatario";
            // 
            // listBoxDestinatarios
            // 
            this.listBoxDestinatarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDestinatarios.FormattingEnabled = true;
            this.listBoxDestinatarios.Location = new System.Drawing.Point(3, 42);
            this.listBoxDestinatarios.Name = "listBoxDestinatarios";
            this.listBoxDestinatarios.Size = new System.Drawing.Size(181, 96);
            this.listBoxDestinatarios.TabIndex = 5;
            // 
            // labelAsunto
            // 
            this.labelAsunto.AutoSize = true;
            this.labelAsunto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAsunto.Location = new System.Drawing.Point(3, 141);
            this.labelAsunto.Name = "labelAsunto";
            this.labelAsunto.Size = new System.Drawing.Size(181, 13);
            this.labelAsunto.TabIndex = 6;
            this.labelAsunto.Text = "Asunto";
            // 
            // controlAdjuntos1
            // 
            this.controlAdjuntos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlAdjuntos1.Location = new System.Drawing.Point(3, 183);
            this.controlAdjuntos1.Name = "controlAdjuntos1";
            this.controlAdjuntos1.Size = new System.Drawing.Size(181, 222);
            this.controlAdjuntos1.TabIndex = 8;
            // 
            // tableLayoutPanelRedactor
            // 
            this.tableLayoutPanelRedactor.ColumnCount = 1;
            this.tableLayoutPanelRedactor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelRedactor.Controls.Add(this.toolStripEnviar, 0, 0);
            this.tableLayoutPanelRedactor.Controls.Add(this.richTextBoxContenido, 0, 1);
            this.tableLayoutPanelRedactor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRedactor.Location = new System.Drawing.Point(196, 3);
            this.tableLayoutPanelRedactor.Name = "tableLayoutPanelRedactor";
            this.tableLayoutPanelRedactor.RowCount = 2;
            this.tableLayoutPanelRedactor.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelRedactor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRedactor.Size = new System.Drawing.Size(188, 408);
            this.tableLayoutPanelRedactor.TabIndex = 3;
            // 
            // toolStripEnviar
            // 
            this.toolStripEnviar.BackColor = System.Drawing.Color.SkyBlue;
            this.toolStripEnviar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripEnviar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripEnviar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonEnviar});
            this.toolStripEnviar.Location = new System.Drawing.Point(0, 0);
            this.toolStripEnviar.Name = "toolStripEnviar";
            this.toolStripEnviar.Size = new System.Drawing.Size(191, 25);
            this.toolStripEnviar.TabIndex = 0;
            this.toolStripEnviar.Text = "toolStrip1";
            // 
            // toolStripButtonEnviar
            // 
            this.toolStripButtonEnviar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonEnviar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEnviar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEnviar.Image")));
            this.toolStripButtonEnviar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEnviar.Name = "toolStripButtonEnviar";
            this.toolStripButtonEnviar.Size = new System.Drawing.Size(43, 22);
            this.toolStripButtonEnviar.Text = "Enviar";
            // 
            // richTextBoxContenido
            // 
            this.richTextBoxContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxContenido.Location = new System.Drawing.Point(3, 28);
            this.richTextBoxContenido.Name = "richTextBoxContenido";
            this.richTextBoxContenido.Size = new System.Drawing.Size(185, 377);
            this.richTextBoxContenido.TabIndex = 1;
            this.richTextBoxContenido.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripButtonCancelar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(393, 44);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(102, 41);
            this.toolStripLabel1.Text = "Cuenta Remitente";
            // 
            // toolStripButtonCancelar
            // 
            this.toolStripButtonCancelar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButtonCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancelar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancelar.Image")));
            this.toolStripButtonCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancelar.Name = "toolStripButtonCancelar";
            this.toolStripButtonCancelar.Size = new System.Drawing.Size(57, 41);
            this.toolStripButtonCancelar.Text = "Cancelar";
            this.toolStripButtonCancelar.Click += new System.EventHandler(this.toolStripButtonCancelar_Click);
            // 
            // ControlMensaje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ControlMensaje";
            this.Size = new System.Drawing.Size(393, 464);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanelMensaje.ResumeLayout(false);
            this.tableLayoutPanelBandeja.ResumeLayout(false);
            this.tableLayoutPanelBandeja.PerformLayout();
            this.tableLayoutPanelRedactor.ResumeLayout(false);
            this.tableLayoutPanelRedactor.PerformLayout();
            this.toolStripEnviar.ResumeLayout(false);
            this.toolStripEnviar.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMensaje;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBandeja;
        private System.Windows.Forms.TextBox textBoxAsunto;
        private System.Windows.Forms.TextBox textBoxDestinatario;
        private System.Windows.Forms.Label labelDestinatario;
        private System.Windows.Forms.ListBox listBoxDestinatarios;
        private System.Windows.Forms.Label labelAsunto;
        private ControlAdjuntos controlAdjuntos1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRedactor;
        private System.Windows.Forms.ToolStrip toolStripEnviar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEnviar;
        private System.Windows.Forms.RichTextBox richTextBoxContenido;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancelar;
    }
}
