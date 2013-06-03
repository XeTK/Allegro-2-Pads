namespace PadsConvert
{
    partial class FRM_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRM_Main));
            this.btn_open = new System.Windows.Forms.Button();
            this.lbox_files = new System.Windows.Forms.ListBox();
            this.fbd_open_csv = new System.Windows.Forms.FolderBrowserDialog();
            this.fbd_export = new System.Windows.Forms.FolderBrowserDialog();
            this.fbd_open_pads = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btn_open
            // 
            this.btn_open.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_open.Location = new System.Drawing.Point(12, 276);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(260, 23);
            this.btn_open.TabIndex = 0;
            this.btn_open.Text = "Convert";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // lbox_files
            // 
            this.lbox_files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbox_files.FormattingEnabled = true;
            this.lbox_files.Location = new System.Drawing.Point(12, 12);
            this.lbox_files.Name = "lbox_files";
            this.lbox_files.Size = new System.Drawing.Size(260, 251);
            this.lbox_files.TabIndex = 3;
            // 
            // FRM_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.lbox_files);
            this.Controls.Add(this.btn_open);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 350);
            this.Name = "FRM_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Allegro Converter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.ListBox lbox_files;
        private System.Windows.Forms.FolderBrowserDialog fbd_open_csv;
        private System.Windows.Forms.FolderBrowserDialog fbd_export;
        private System.Windows.Forms.FolderBrowserDialog fbd_open_pads;
    }
}

