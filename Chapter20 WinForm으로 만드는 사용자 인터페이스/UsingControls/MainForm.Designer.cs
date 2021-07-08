﻿
namespace UsingControls
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
            this.grpFont = new System.Windows.Forms.GroupBox();
            this.txtSampleText = new System.Windows.Forms.TextBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.cboFont = new System.Windows.Forms.ComboBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.grpBar = new System.Windows.Forms.GroupBox();
            this.pgDummy = new System.Windows.Forms.ProgressBar();
            this.tbDummy = new System.Windows.Forms.TrackBar();
            this.grpForm = new System.Windows.Forms.GroupBox();
            this.BtnMsgBox = new System.Windows.Forms.Button();
            this.btnModaless = new System.Windows.Forms.Button();
            this.btnModal = new System.Windows.Forms.Button();
            this.grpTreeList = new System.Windows.Forms.GroupBox();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.btnAddRoot = new System.Windows.Forms.Button();
            this.lvDummy = new System.Windows.Forms.ListView();
            this.tvDummy = new System.Windows.Forms.TreeView();
            this.grpFont.SuspendLayout();
            this.grpBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDummy)).BeginInit();
            this.grpForm.SuspendLayout();
            this.grpTreeList.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFont
            // 
            this.grpFont.Controls.Add(this.txtSampleText);
            this.grpFont.Controls.Add(this.chkItalic);
            this.grpFont.Controls.Add(this.chkBold);
            this.grpFont.Controls.Add(this.cboFont);
            this.grpFont.Controls.Add(this.lblFont);
            this.grpFont.Location = new System.Drawing.Point(31, 24);
            this.grpFont.Name = "grpFont";
            this.grpFont.Size = new System.Drawing.Size(371, 145);
            this.grpFont.TabIndex = 0;
            this.grpFont.TabStop = false;
            this.grpFont.Text = "ComboBox, CheckBox, TextBox";
            // 
            // txtSampleText
            // 
            this.txtSampleText.Location = new System.Drawing.Point(17, 78);
            this.txtSampleText.Name = "txtSampleText";
            this.txtSampleText.Size = new System.Drawing.Size(327, 23);
            this.txtSampleText.TabIndex = 4;
            this.txtSampleText.Text = "Hello, C#";
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.chkItalic.Location = new System.Drawing.Point(282, 42);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(62, 19);
            this.chkItalic.TabIndex = 3;
            this.chkItalic.Text = "이탤릭";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkBold.Location = new System.Drawing.Point(217, 42);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(50, 19);
            this.chkBold.TabIndex = 2;
            this.chkBold.Text = "굵게";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // cboFont
            // 
            this.cboFont.FormattingEnabled = true;
            this.cboFont.Location = new System.Drawing.Point(61, 38);
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(121, 23);
            this.cboFont.TabIndex = 1;
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.cboFont_SelectedIndexChanged);
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(17, 41);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(38, 15);
            this.lblFont.TabIndex = 0;
            this.lblFont.Text = "Font :";
            // 
            // grpBar
            // 
            this.grpBar.Controls.Add(this.pgDummy);
            this.grpBar.Controls.Add(this.tbDummy);
            this.grpBar.Location = new System.Drawing.Point(31, 175);
            this.grpBar.Name = "grpBar";
            this.grpBar.Size = new System.Drawing.Size(371, 117);
            this.grpBar.TabIndex = 1;
            this.grpBar.TabStop = false;
            this.grpBar.Text = "TrackBar &&&& ProgressBar";
            // 
            // pgDummy
            // 
            this.pgDummy.Location = new System.Drawing.Point(17, 80);
            this.pgDummy.Maximum = 20;
            this.pgDummy.Name = "pgDummy";
            this.pgDummy.Size = new System.Drawing.Size(327, 23);
            this.pgDummy.TabIndex = 1;
            // 
            // tbDummy
            // 
            this.tbDummy.Location = new System.Drawing.Point(17, 29);
            this.tbDummy.Maximum = 20;
            this.tbDummy.Name = "tbDummy";
            this.tbDummy.Size = new System.Drawing.Size(327, 45);
            this.tbDummy.TabIndex = 0;
            this.tbDummy.Scroll += new System.EventHandler(this.tbDummy_Scroll);
            // 
            // grpForm
            // 
            this.grpForm.Controls.Add(this.BtnMsgBox);
            this.grpForm.Controls.Add(this.btnModaless);
            this.grpForm.Controls.Add(this.btnModal);
            this.grpForm.Location = new System.Drawing.Point(31, 298);
            this.grpForm.Name = "grpForm";
            this.grpForm.Size = new System.Drawing.Size(371, 75);
            this.grpForm.TabIndex = 2;
            this.grpForm.TabStop = false;
            this.grpForm.Text = "Modal && Modaless";
            // 
            // BtnMsgBox
            // 
            this.BtnMsgBox.Location = new System.Drawing.Point(197, 27);
            this.BtnMsgBox.Name = "BtnMsgBox";
            this.BtnMsgBox.Size = new System.Drawing.Size(147, 34);
            this.BtnMsgBox.TabIndex = 2;
            this.BtnMsgBox.Text = "MessageBox";
            this.BtnMsgBox.UseVisualStyleBackColor = true;
            this.BtnMsgBox.Click += new System.EventHandler(this.BtnMsgBox_Click);
            // 
            // btnModaless
            // 
            this.btnModaless.Location = new System.Drawing.Point(107, 27);
            this.btnModaless.Name = "btnModaless";
            this.btnModaless.Size = new System.Drawing.Size(84, 34);
            this.btnModaless.TabIndex = 1;
            this.btnModaless.Text = "Modaless";
            this.btnModaless.UseVisualStyleBackColor = true;
            this.btnModaless.Click += new System.EventHandler(this.btnModaless_Click);
            // 
            // btnModal
            // 
            this.btnModal.Location = new System.Drawing.Point(17, 27);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(84, 34);
            this.btnModal.TabIndex = 0;
            this.btnModal.Text = "Modal";
            this.btnModal.UseVisualStyleBackColor = true;
            this.btnModal.Click += new System.EventHandler(this.btnModal_Click);
            // 
            // grpTreeList
            // 
            this.grpTreeList.Controls.Add(this.btnAddChild);
            this.grpTreeList.Controls.Add(this.btnAddRoot);
            this.grpTreeList.Controls.Add(this.lvDummy);
            this.grpTreeList.Controls.Add(this.tvDummy);
            this.grpTreeList.Location = new System.Drawing.Point(31, 380);
            this.grpTreeList.Name = "grpTreeList";
            this.grpTreeList.Size = new System.Drawing.Size(371, 203);
            this.grpTreeList.TabIndex = 3;
            this.grpTreeList.TabStop = false;
            this.grpTreeList.Text = "groupBox1";
            // 
            // btnAddChild
            // 
            this.btnAddChild.Location = new System.Drawing.Point(97, 163);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(74, 34);
            this.btnAddChild.TabIndex = 4;
            this.btnAddChild.Text = "자식 추가";
            this.btnAddChild.UseVisualStyleBackColor = true;
            this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
            // 
            // btnAddRoot
            // 
            this.btnAddRoot.Location = new System.Drawing.Point(17, 163);
            this.btnAddRoot.Name = "btnAddRoot";
            this.btnAddRoot.Size = new System.Drawing.Size(74, 34);
            this.btnAddRoot.TabIndex = 3;
            this.btnAddRoot.Text = "루트 추가";
            this.btnAddRoot.UseVisualStyleBackColor = true;
            this.btnAddRoot.Click += new System.EventHandler(this.btnAddRoot_Click);
            // 
            // lvDummy
            // 
            this.lvDummy.HideSelection = false;
            this.lvDummy.Location = new System.Drawing.Point(197, 22);
            this.lvDummy.Name = "lvDummy";
            this.lvDummy.Size = new System.Drawing.Size(154, 134);
            this.lvDummy.TabIndex = 1;
            this.lvDummy.UseCompatibleStateImageBehavior = false;
            this.lvDummy.View = System.Windows.Forms.View.Details;
            // 
            // tvDummy
            // 
            this.tvDummy.Location = new System.Drawing.Point(17, 23);
            this.tvDummy.Name = "tvDummy";
            this.tvDummy.Size = new System.Drawing.Size(154, 134);
            this.tvDummy.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 595);
            this.Controls.Add(this.grpTreeList);
            this.Controls.Add(this.grpForm);
            this.Controls.Add(this.grpBar);
            this.Controls.Add(this.grpFont);
            this.Name = "MainForm";
            this.Text = "Control Test";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpFont.ResumeLayout(false);
            this.grpFont.PerformLayout();
            this.grpBar.ResumeLayout(false);
            this.grpBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDummy)).EndInit();
            this.grpForm.ResumeLayout(false);
            this.grpTreeList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFont;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.ComboBox cboFont;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.TextBox txtSampleText;
        private System.Windows.Forms.GroupBox grpBar;
        private System.Windows.Forms.ProgressBar pgDummy;
        private System.Windows.Forms.TrackBar tbDummy;
        private System.Windows.Forms.GroupBox grpForm;
        private System.Windows.Forms.Button btnModaless;
        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.Button BtnMsgBox;
        private System.Windows.Forms.GroupBox grpTreeList;
        private System.Windows.Forms.ListView lvDummy;
        private System.Windows.Forms.TreeView tvDummy;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.Button btnAddRoot;
    }
}

