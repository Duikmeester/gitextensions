﻿namespace GitUI
{
    partial class FormSelectMultipleBranches
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
            this.Branches = new System.Windows.Forms.CheckedListBox();
            this.okButton = new System.Windows.Forms.Button();
            this.selectBranchesLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Branches
            // 
            this.Branches.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.Branches.CheckOnClick = true;
            this.Branches.FormattingEnabled = true;
            this.Branches.Location = new System.Drawing.Point(12, 28);
            this.Branches.Name = "Branches";
            this.Branches.Size = new System.Drawing.Size(277, 212);
            this.Branches.TabIndex = 2;
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Location = new System.Drawing.Point(214, 252);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Ok";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // selectBranchesLabel
            // 
            this.selectBranchesLabel.AutoSize = true;
            this.selectBranchesLabel.Location = new System.Drawing.Point(12, 9);
            this.selectBranchesLabel.Name = "selectBranchesLabel";
            this.selectBranchesLabel.Size = new System.Drawing.Size(83, 13);
            this.selectBranchesLabel.TabIndex = 4;
            this.selectBranchesLabel.Text = "Select branches";
            // 
            // FormSelectMultipleBranches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 287);
            this.Controls.Add(this.selectBranchesLabel);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.Branches);
            this.Name = "FormSelectMultipleBranches";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Select multiple branches";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Branches;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label selectBranchesLabel;
    }
}