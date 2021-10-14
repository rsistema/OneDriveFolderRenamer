
namespace OneDrive_Folder_Rename
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbDefaultName = new System.Windows.Forms.ComboBox();
            this.labelDefaultName = new System.Windows.Forms.Label();
            this.labelAliasName = new System.Windows.Forms.Label();
            this.tbAliasName = new System.Windows.Forms.TextBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbDefaultName
            // 
            this.cbDefaultName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDefaultName.FormattingEnabled = true;
            this.cbDefaultName.Location = new System.Drawing.Point(15, 25);
            this.cbDefaultName.Name = "cbDefaultName";
            this.cbDefaultName.Size = new System.Drawing.Size(150, 21);
            this.cbDefaultName.TabIndex = 0;
            this.cbDefaultName.SelectedIndexChanged += new System.EventHandler(this.cbDefaultName_SelectedIndexChanged);
            // 
            // labelDefaultName
            // 
            this.labelDefaultName.AutoSize = true;
            this.labelDefaultName.Location = new System.Drawing.Point(12, 9);
            this.labelDefaultName.Name = "labelDefaultName";
            this.labelDefaultName.Size = new System.Drawing.Size(72, 13);
            this.labelDefaultName.TabIndex = 1;
            this.labelDefaultName.Text = "Default Name";
            // 
            // labelAliasName
            // 
            this.labelAliasName.AutoSize = true;
            this.labelAliasName.Location = new System.Drawing.Point(168, 9);
            this.labelAliasName.Name = "labelAliasName";
            this.labelAliasName.Size = new System.Drawing.Size(60, 13);
            this.labelAliasName.TabIndex = 2;
            this.labelAliasName.Text = "Alias Name";
            // 
            // tbAliasName
            // 
            this.tbAliasName.Location = new System.Drawing.Point(171, 25);
            this.tbAliasName.Name = "tbAliasName";
            this.tbAliasName.Size = new System.Drawing.Size(150, 20);
            this.tbAliasName.TabIndex = 3;
            this.tbAliasName.Tag = "";
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(327, 24);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 20);
            this.btUpdate.TabIndex = 4;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 58);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.tbAliasName);
            this.Controls.Add(this.labelAliasName);
            this.Controls.Add(this.labelDefaultName);
            this.Controls.Add(this.cbDefaultName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OneDrive Folder Renamer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDefaultName;
        private System.Windows.Forms.Label labelDefaultName;
        private System.Windows.Forms.Label labelAliasName;
        private System.Windows.Forms.TextBox tbAliasName;
        private System.Windows.Forms.Button btUpdate;
    }
}

