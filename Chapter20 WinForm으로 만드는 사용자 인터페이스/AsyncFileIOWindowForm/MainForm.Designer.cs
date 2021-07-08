
namespace AsyncFileIOWindowForm
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSource = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtTarget = new System.Windows.Forms.TextBox();
            this.btnFindTarget = new System.Windows.Forms.Button();
            this.btnFindSource = new System.Windows.Forms.Button();
            this.btnAsyncCopy = new System.Windows.Forms.Button();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSyncCopy = new System.Windows.Forms.Button();
            this.pbCopy = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(25, 29);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(51, 15);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Source :";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Location = new System.Drawing.Point(25, 64);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(47, 15);
            this.lblTarget.TabIndex = 1;
            this.lblTarget.Text = "Target :";
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(82, 26);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(233, 23);
            this.txtSource.TabIndex = 2;
            // 
            // txtTarget
            // 
            this.txtTarget.Location = new System.Drawing.Point(82, 61);
            this.txtTarget.Name = "txtTarget";
            this.txtTarget.Size = new System.Drawing.Size(233, 23);
            this.txtTarget.TabIndex = 3;
            // 
            // btnFindTarget
            // 
            this.btnFindTarget.Location = new System.Drawing.Point(321, 61);
            this.btnFindTarget.Name = "btnFindTarget";
            this.btnFindTarget.Size = new System.Drawing.Size(46, 23);
            this.btnFindTarget.TabIndex = 4;
            this.btnFindTarget.Text = "...";
            this.btnFindTarget.UseVisualStyleBackColor = true;
            this.btnFindTarget.Click += new System.EventHandler(this.btnFindTarget_Click);
            // 
            // btnFindSource
            // 
            this.btnFindSource.Location = new System.Drawing.Point(321, 25);
            this.btnFindSource.Name = "btnFindSource";
            this.btnFindSource.Size = new System.Drawing.Size(46, 23);
            this.btnFindSource.TabIndex = 5;
            this.btnFindSource.Text = "...";
            this.btnFindSource.UseVisualStyleBackColor = true;
            this.btnFindSource.Click += new System.EventHandler(this.btnFindSource_Click);
            // 
            // btnAsyncCopy
            // 
            this.btnAsyncCopy.Location = new System.Drawing.Point(25, 100);
            this.btnAsyncCopy.Name = "btnAsyncCopy";
            this.btnAsyncCopy.Size = new System.Drawing.Size(87, 34);
            this.btnAsyncCopy.TabIndex = 6;
            this.btnAsyncCopy.Text = "Async Copy";
            this.btnAsyncCopy.UseVisualStyleBackColor = true;
            this.btnAsyncCopy.Click += new System.EventHandler(this.btnAsyncCopy_Click);
            // 
            // btnCancle
            // 
            this.btnCancle.Location = new System.Drawing.Point(280, 100);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(87, 34);
            this.btnCancle.TabIndex = 7;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSyncCopy
            // 
            this.btnSyncCopy.Location = new System.Drawing.Point(154, 100);
            this.btnSyncCopy.Name = "btnSyncCopy";
            this.btnSyncCopy.Size = new System.Drawing.Size(87, 34);
            this.btnSyncCopy.TabIndex = 8;
            this.btnSyncCopy.Text = "Sync Copy";
            this.btnSyncCopy.UseVisualStyleBackColor = true;
            this.btnSyncCopy.Click += new System.EventHandler(this.btnSyncCopy_Click);
            // 
            // pbCopy
            // 
            this.pbCopy.Location = new System.Drawing.Point(25, 140);
            this.pbCopy.Name = "pbCopy";
            this.pbCopy.Size = new System.Drawing.Size(342, 37);
            this.pbCopy.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 200);
            this.Controls.Add(this.pbCopy);
            this.Controls.Add(this.btnSyncCopy);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnAsyncCopy);
            this.Controls.Add(this.btnFindSource);
            this.Controls.Add(this.btnFindTarget);
            this.Controls.Add(this.txtTarget);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblSource);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtTarget;
        private System.Windows.Forms.Button btnFindTarget;
        private System.Windows.Forms.Button btnFindSource;
        private System.Windows.Forms.Button btnAsyncCopy;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSyncCopy;
        private System.Windows.Forms.ProgressBar pbCopy;
    }
}

