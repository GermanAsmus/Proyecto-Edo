namespace EdoUI.UICuenta
{
    partial class FormCuenta
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
            this.l_NuevaCuenta_Nombre = new System.Windows.Forms.Label();
            this.txbx_NuevaCuenta_Nombre = new System.Windows.Forms.TextBox();
            this.txbx_NuevaCuenta_Direccion = new System.Windows.Forms.TextBox();
            this.l_NuevaCuenta_Direccion = new System.Windows.Forms.Label();
            this.txbx_NuevaCuenta_Contrasenia = new System.Windows.Forms.TextBox();
            this.l_NuevaCuenta_Contrasenia = new System.Windows.Forms.Label();
            this.btn_NuevaCuenta_Crear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_NuevaCuenta_Nombre
            // 
            this.l_NuevaCuenta_Nombre.AutoSize = true;
            this.l_NuevaCuenta_Nombre.Location = new System.Drawing.Point(65, 9);
            this.l_NuevaCuenta_Nombre.Name = "l_NuevaCuenta_Nombre";
            this.l_NuevaCuenta_Nombre.Size = new System.Drawing.Size(44, 13);
            this.l_NuevaCuenta_Nombre.TabIndex = 0;
            this.l_NuevaCuenta_Nombre.Text = "Nombre";
            // 
            // txbx_NuevaCuenta_Nombre
            // 
            this.txbx_NuevaCuenta_Nombre.Location = new System.Drawing.Point(12, 36);
            this.txbx_NuevaCuenta_Nombre.Name = "txbx_NuevaCuenta_Nombre";
            this.txbx_NuevaCuenta_Nombre.Size = new System.Drawing.Size(150, 20);
            this.txbx_NuevaCuenta_Nombre.TabIndex = 1;
            this.txbx_NuevaCuenta_Nombre.TextChanged += new System.EventHandler(this.txbx_NuevaCuenta_Nombre_TextChanged);
            // 
            // txbx_NuevaCuenta_Direccion
            // 
            this.txbx_NuevaCuenta_Direccion.Location = new System.Drawing.Point(12, 97);
            this.txbx_NuevaCuenta_Direccion.Name = "txbx_NuevaCuenta_Direccion";
            this.txbx_NuevaCuenta_Direccion.Size = new System.Drawing.Size(150, 20);
            this.txbx_NuevaCuenta_Direccion.TabIndex = 3;
            this.txbx_NuevaCuenta_Direccion.TextChanged += new System.EventHandler(this.txbx_NuevaCuenta_Direccion_TextChanged);
            // 
            // l_NuevaCuenta_Direccion
            // 
            this.l_NuevaCuenta_Direccion.AutoSize = true;
            this.l_NuevaCuenta_Direccion.Location = new System.Drawing.Point(37, 70);
            this.l_NuevaCuenta_Direccion.Name = "l_NuevaCuenta_Direccion";
            this.l_NuevaCuenta_Direccion.Size = new System.Drawing.Size(100, 13);
            this.l_NuevaCuenta_Direccion.TabIndex = 2;
            this.l_NuevaCuenta_Direccion.Text = "Direccion de correo";
            // 
            // txbx_NuevaCuenta_Contrasenia
            // 
            this.txbx_NuevaCuenta_Contrasenia.Location = new System.Drawing.Point(12, 158);
            this.txbx_NuevaCuenta_Contrasenia.Name = "txbx_NuevaCuenta_Contrasenia";
            this.txbx_NuevaCuenta_Contrasenia.Size = new System.Drawing.Size(150, 20);
            this.txbx_NuevaCuenta_Contrasenia.TabIndex = 5;
            this.txbx_NuevaCuenta_Contrasenia.TextChanged += new System.EventHandler(this.txbx_NuevaCuenta_Contrasenia_TextChanged);
            // 
            // l_NuevaCuenta_Contrasenia
            // 
            this.l_NuevaCuenta_Contrasenia.AutoSize = true;
            this.l_NuevaCuenta_Contrasenia.Location = new System.Drawing.Point(57, 131);
            this.l_NuevaCuenta_Contrasenia.Name = "l_NuevaCuenta_Contrasenia";
            this.l_NuevaCuenta_Contrasenia.Size = new System.Drawing.Size(61, 13);
            this.l_NuevaCuenta_Contrasenia.TabIndex = 4;
            this.l_NuevaCuenta_Contrasenia.Text = "Contraseña";
            // 
            // btn_NuevaCuenta_Crear
            // 
            this.btn_NuevaCuenta_Crear.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_NuevaCuenta_Crear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NuevaCuenta_Crear.Location = new System.Drawing.Point(50, 212);
            this.btn_NuevaCuenta_Crear.Name = "btn_NuevaCuenta_Crear";
            this.btn_NuevaCuenta_Crear.Size = new System.Drawing.Size(75, 23);
            this.btn_NuevaCuenta_Crear.TabIndex = 6;
            this.btn_NuevaCuenta_Crear.Text = "¡Crear!";
            this.btn_NuevaCuenta_Crear.UseVisualStyleBackColor = true;
            this.btn_NuevaCuenta_Crear.Click += new System.EventHandler(this.btn_NuevaCuenta_Crear_Click);
            // 
            // FormCuenta
            // 
            this.AcceptButton = this.btn_NuevaCuenta_Crear;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 250);
            this.Controls.Add(this.btn_NuevaCuenta_Crear);
            this.Controls.Add(this.txbx_NuevaCuenta_Contrasenia);
            this.Controls.Add(this.l_NuevaCuenta_Contrasenia);
            this.Controls.Add(this.txbx_NuevaCuenta_Direccion);
            this.Controls.Add(this.l_NuevaCuenta_Direccion);
            this.Controls.Add(this.txbx_NuevaCuenta_Nombre);
            this.Controls.Add(this.l_NuevaCuenta_Nombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCuenta";
            this.ShowIcon = false;
            this.Text = "FormCuenta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_NuevaCuenta_Nombre;
        private System.Windows.Forms.TextBox txbx_NuevaCuenta_Nombre;
        private System.Windows.Forms.TextBox txbx_NuevaCuenta_Direccion;
        private System.Windows.Forms.Label l_NuevaCuenta_Direccion;
        private System.Windows.Forms.TextBox txbx_NuevaCuenta_Contrasenia;
        private System.Windows.Forms.Label l_NuevaCuenta_Contrasenia;
        private System.Windows.Forms.Button btn_NuevaCuenta_Crear;
    }
}