
namespace FileCopyUI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fileProgressText = new System.Windows.Forms.Label();
            this.copyProgress = new System.Windows.Forms.ProgressBar();
            this.buttonStartCopy = new System.Windows.Forms.Button();
            this.chooseTargetButton = new System.Windows.Forms.Button();
            this.chooseTargetTextBox = new System.Windows.Forms.TextBox();
            this.chooseSourceButton = new System.Windows.Forms.Button();
            this.chooseSourceTextBox = new System.Windows.Forms.TextBox();
            this.chooseSourceFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.chooseTargetFolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Copier";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fileProgressText);
            this.panel1.Controls.Add(this.copyProgress);
            this.panel1.Controls.Add(this.buttonStartCopy);
            this.panel1.Controls.Add(this.chooseTargetButton);
            this.panel1.Controls.Add(this.chooseTargetTextBox);
            this.panel1.Controls.Add(this.chooseSourceButton);
            this.panel1.Controls.Add(this.chooseSourceTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 338);
            this.panel1.TabIndex = 1;
            // 
            // fileProgressText
            // 
            this.fileProgressText.AutoSize = true;
            this.fileProgressText.Location = new System.Drawing.Point(1, 275);
            this.fileProgressText.Name = "fileProgressText";
            this.fileProgressText.Size = new System.Drawing.Size(0, 15);
            this.fileProgressText.TabIndex = 6;
            // 
            // copyProgress
            // 
            this.copyProgress.Location = new System.Drawing.Point(1, 296);
            this.copyProgress.Name = "copyProgress";
            this.copyProgress.Size = new System.Drawing.Size(442, 23);
            this.copyProgress.TabIndex = 5;
            this.copyProgress.Click += new System.EventHandler(this.copyProgress_Click);
            // 
            // buttonStartCopy
            // 
            this.buttonStartCopy.Location = new System.Drawing.Point(141, 195);
            this.buttonStartCopy.Name = "buttonStartCopy";
            this.buttonStartCopy.Size = new System.Drawing.Size(165, 67);
            this.buttonStartCopy.TabIndex = 4;
            this.buttonStartCopy.Text = "Copy!";
            this.buttonStartCopy.UseVisualStyleBackColor = true;
            this.buttonStartCopy.Click += new System.EventHandler(this.buttonStartCopy_Click);
            // 
            // chooseTargetButton
            // 
            this.chooseTargetButton.Location = new System.Drawing.Point(312, 120);
            this.chooseTargetButton.Name = "chooseTargetButton";
            this.chooseTargetButton.Size = new System.Drawing.Size(130, 23);
            this.chooseTargetButton.TabIndex = 3;
            this.chooseTargetButton.Text = "Select Target";
            this.chooseTargetButton.UseVisualStyleBackColor = true;
            this.chooseTargetButton.Click += new System.EventHandler(this.chooseTargetButton_Click);
            // 
            // chooseTargetTextBox
            // 
            this.chooseTargetTextBox.Location = new System.Drawing.Point(0, 121);
            this.chooseTargetTextBox.Name = "chooseTargetTextBox";
            this.chooseTargetTextBox.Size = new System.Drawing.Size(306, 23);
            this.chooseTargetTextBox.TabIndex = 2;
            // 
            // chooseSourceButton
            // 
            this.chooseSourceButton.Location = new System.Drawing.Point(312, 68);
            this.chooseSourceButton.Name = "chooseSourceButton";
            this.chooseSourceButton.Size = new System.Drawing.Size(130, 23);
            this.chooseSourceButton.TabIndex = 1;
            this.chooseSourceButton.Text = "Select Source";
            this.chooseSourceButton.UseVisualStyleBackColor = true;
            this.chooseSourceButton.Click += new System.EventHandler(this.chooseSourceButton_Click);
            // 
            // chooseSourceTextBox
            // 
            this.chooseSourceTextBox.Location = new System.Drawing.Point(0, 68);
            this.chooseSourceTextBox.Name = "chooseSourceTextBox";
            this.chooseSourceTextBox.Size = new System.Drawing.Size(306, 23);
            this.chooseSourceTextBox.TabIndex = 0;
            this.chooseSourceTextBox.TextChanged += new System.EventHandler(this.chooseSourceTextBox_TextChanged);
            // 
            // chooseSourceFolderDialog
            // 
            this.chooseSourceFolderDialog.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 414);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button chooseSourceButton;
        private System.Windows.Forms.TextBox chooseSourceTextBox;
        private System.Windows.Forms.FolderBrowserDialog chooseSourceFolderDialog;
        private System.Windows.Forms.Button buttonStartCopy;
        private System.Windows.Forms.Button chooseTargetButton;
        private System.Windows.Forms.TextBox chooseTargetTextBox;
        private System.Windows.Forms.FolderBrowserDialog chooseTargetFolderDialog;
        private System.Windows.Forms.ProgressBar copyProgress;
        private System.Windows.Forms.Label fileProgressText;
    }
}

