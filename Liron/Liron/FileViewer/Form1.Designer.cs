namespace FileViewer
{
    partial class Form1
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
            this.tvFiles = new System.Windows.Forms.TreeView();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.pgInfo = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // tvFiles
            // 
            this.tvFiles.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvFiles.Location = new System.Drawing.Point(0, 0);
            this.tvFiles.Name = "tvFiles";
            this.tvFiles.Size = new System.Drawing.Size(250, 450);
            this.tvFiles.TabIndex = 0;
            // 
            // txtContent
            // 
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtContent.Location = new System.Drawing.Point(250, 168);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(550, 282);
            this.txtContent.TabIndex = 1;
            // 
            // pgInfo
            // 
            this.pgInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgInfo.Location = new System.Drawing.Point(250, 0);
            this.pgInfo.Name = "pgInfo";
            this.pgInfo.Size = new System.Drawing.Size(550, 168);
            this.pgInfo.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pgInfo);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.tvFiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvFiles;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.PropertyGrid pgInfo;
    }
}

