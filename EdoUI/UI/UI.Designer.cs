namespace EdoUI.UI
{
    partial class UI
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
            this.AccountMenu = new System.Windows.Forms.MenuStrip();
            this.NewAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountsContainer = new System.Windows.Forms.TableLayoutPanel();
            this.AccountsDataGrid = new System.Windows.Forms.DataGridView();
            this.AccountMenu.SuspendLayout();
            this.AccountsContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.AccountMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewAccount});
            this.AccountMenu.Location = new System.Drawing.Point(0, 0);
            this.AccountMenu.Name = "Menu";
            this.AccountMenu.Size = new System.Drawing.Size(584, 24);
            this.AccountMenu.TabIndex = 0;
            this.AccountMenu.Text = "menuStrip1";
            // 
            // NewAccount
            // 
            this.NewAccount.Name = "NewAccount";
            this.NewAccount.Size = new System.Drawing.Size(94, 20);
            this.NewAccount.Text = "Nueva Cuenta";
            this.NewAccount.Click += new System.EventHandler(this.CreateNewAccount);
            // 
            // AccountsContainer
            // 
            this.AccountsContainer.BackColor = System.Drawing.Color.Transparent;
            this.AccountsContainer.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.AccountsContainer.ColumnCount = 1;
            this.AccountsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AccountsContainer.Controls.Add(this.AccountsDataGrid, 0, 0);
            this.AccountsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AccountsContainer.Location = new System.Drawing.Point(0, 24);
            this.AccountsContainer.Name = "AccountsContainer";
            this.AccountsContainer.Padding = new System.Windows.Forms.Padding(5);
            this.AccountsContainer.RowCount = 1;
            this.AccountsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.AccountsContainer.Size = new System.Drawing.Size(584, 337);
            this.AccountsContainer.TabIndex = 2;
            // 
            // AccountsDataGrid
            // 
            this.AccountsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AccountsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountsDataGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.AccountsDataGrid.Location = new System.Drawing.Point(273, 11);
            this.AccountsDataGrid.Name = "AccountsDataGrid";
            this.AccountsDataGrid.Size = new System.Drawing.Size(300, 315);
            this.AccountsDataGrid.TabIndex = 0;
            this.AccountsDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.AccountsDataGrid_CellContentClick);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EdoUI.Properties.Resources.paven;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.AccountsContainer);
            this.Controls.Add(this.AccountMenu);
            this.MainMenuStrip = this.AccountMenu;
            this.MaximizeBox = false;
            this.Name = "UI";
            this.Text = "EDO";
            this.AccountMenu.ResumeLayout(false);
            this.AccountMenu.PerformLayout();
            this.AccountsContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AccountsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AccountMenu;
        private System.Windows.Forms.ToolStripMenuItem NewAccount;
        private System.Windows.Forms.TableLayoutPanel AccountsContainer;
        private System.Windows.Forms.DataGridView AccountsDataGrid;
    }
}