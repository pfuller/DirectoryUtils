namespace DirectoryUtility
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
            this.lblDirLabel = new System.Windows.Forms.Label();
            this.lblDir = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.lblLog = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDirLabel
            // 
            this.lblDirLabel.AutoSize = true;
            this.lblDirLabel.Location = new System.Drawing.Point(15, 18);
            this.lblDirLabel.Name = "lblDirLabel";
            this.lblDirLabel.Size = new System.Drawing.Size(104, 25);
            this.lblDirLabel.TabIndex = 0;
            this.lblDirLabel.Text = "Directory:";
            // 
            // lblDir
            // 
            this.lblDir.AutoSize = true;
            this.lblDir.Location = new System.Drawing.Point(125, 18);
            this.lblDir.Name = "lblDir";
            this.lblDir.Size = new System.Drawing.Size(70, 25);
            this.lblDir.TabIndex = 1;
            this.lblDir.Text = "label2";
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(1215, 12);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(172, 45);
            this.btnAction.TabIndex = 2;
            this.btnAction.Text = "Do Something";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(20, 109);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(1367, 605);
            this.txtLog.TabIndex = 3;
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(15, 70);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(54, 25);
            this.lblLog.TabIndex = 4;
            this.lblLog.Text = "Log:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 761);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1413, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1413, 783);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.lblDir);
            this.Controls.Add(this.lblDirLabel);
            this.Name = "Form1";
            this.Text = "Directory Utility";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDirLabel;
        private System.Windows.Forms.Label lblDir;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

