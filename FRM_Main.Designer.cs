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
            this.components = new System.ComponentModel.Container();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_export = new System.Windows.Forms.Button();
            this.cms_main = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbox_files = new System.Windows.Forms.ListBox();
            this.fbd_open_csv = new System.Windows.Forms.FolderBrowserDialog();
            this.fbd_export = new System.Windows.Forms.FolderBrowserDialog();
            this.fbd_open_pads = new System.Windows.Forms.FolderBrowserDialog();
            this.cms_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_open
            // 
            this.btn_open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_open.Location = new System.Drawing.Point(12, 273);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(75, 23);
            this.btn_open.TabIndex = 0;
            this.btn_open.Text = "Open CSV";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_export
            // 
            this.btn_export.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_export.Location = new System.Drawing.Point(197, 273);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 23);
            this.btn_export.TabIndex = 1;
            this.btn_export.Text = "Export .Pads";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // cms_main
            // 
            this.cms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.cms_main.Name = "contextMenuStrip1";
            this.cms_main.Size = new System.Drawing.Size(108, 70);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exitToolStripMenuItem.Text = "Exit";
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
            this.ClientSize = new System.Drawing.Size(284, 308);
            this.Controls.Add(this.lbox_files);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.btn_open);
            this.Name = "FRM_Main";
            this.Text = "PadConvert";
            this.cms_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.ContextMenuStrip cms_main;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ListBox lbox_files;
        private System.Windows.Forms.FolderBrowserDialog fbd_open_csv;
        private System.Windows.Forms.FolderBrowserDialog fbd_export;
        private System.Windows.Forms.FolderBrowserDialog fbd_open_pads;
    }
}

