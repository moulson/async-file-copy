using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileCopy;

namespace FileCopyUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {
            
        }

        private void chooseSourceButton_Click(object sender, EventArgs e)
        {
            if (chooseSourceFolderDialog.ShowDialog() == DialogResult.OK)
            {
                chooseSourceTextBox.Text = chooseSourceFolderDialog.SelectedPath;
            }
        }
        
        private void chooseTargetButton_Click(object sender, EventArgs e)
        {
            if(chooseTargetFolderDialog.ShowDialog() == DialogResult.OK)
            {
                chooseTargetTextBox.Text = chooseTargetFolderDialog.SelectedPath;
            }
        }

        private void chooseSourceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private async void buttonStartCopy_Click(object sender, EventArgs e)
        {
            //Get the source and target directories
            string source = chooseSourceTextBox.Text;
            string target = chooseTargetTextBox.Text;

            if (!Directory.Exists(source))
            {
                MessageBox.Show("Source Directory is invalid!");
                return;
            }
            ReportProgress(0);

            var progressIndicator = new Progress<int>(ReportProgress);
            var currentFileIndicator = new Progress<string>(ReportCurrentFile);


            bool result = await FileCopy.FileCopy.CopyDirectoryAsync(source, target, progressIndicator, currentFileIndicator);

            //Finished.
            fileProgressText.Text = result ? "Copying Finished" : "Error";
            copyProgress.Value = 100;
            MessageBox.Show(result ? "Files copied" : "There was an error copying your files");


        }
        
        void ReportProgress(int value)
        {
            
            copyProgress.Value = value;
        }

        void ReportCurrentFile(string fileName) 
        {
            fileProgressText.Text = "Copying: " + fileName; 
        }


        private void copyProgress_Click(object sender, EventArgs e)
        {

        }
    }
}
