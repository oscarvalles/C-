using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.IO;

namespace File_Merge
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            ckReplaceFieldSep.Visible = false;
            txtFieldSep.Visible = false;
        }

        public void btnSelectFiles_Click(object sender, EventArgs e)
        {
            //new instance of "Open File Dialog"
            OpenFileDialog dlgOpen = new OpenFileDialog();
            //setting the properties for multiple file selection
            dlgOpen.Title = "Select File(s)";
            dlgOpen.ShowReadOnly = true;
            dlgOpen.Multiselect = true;
            
            string[] files;

            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                files = dlgOpen.FileNames;

                foreach(string f in files)
                {
                    txtSelectedFiles.Text += f.ToString() + "\r\n";
                }  
            }
        }

        private void btnMerge_Click(object sender, EventArgs e)
        {
            string input_files = txtSelectedFiles.Text;
            string output_file = txtOutputName.Text;
            bool remove_non_print = ckRmNonPrintAscii.Checked;
            bool replace_field_sep = ckReplaceFieldSep.Checked;
            string replacement_char = txtFieldSep.Text;
            
            lblStatus.Text = "";
            lblStatus.Text = "PROCESSING";

            if (input_files != "" && output_file != "")
            {
                if (ckRmNonPrintAscii.Checked)
                {
                    Program.AppendFiles(input_files, output_file, remove_non_print, replace_field_sep, replacement_char);
                }
                else
                {
                    Program.AppendFiles(input_files, output_file);
                }
                lblStatus.Text = "MERGE COMPLETED";
            }
            else
            {
                MessageBox.Show("Please select input files and an output file");
            }
        }

        private void btnSaveFileTo_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgSaveDir = new SaveFileDialog();
            dlgSaveDir.InitialDirectory = Application.StartupPath;
            dlgSaveDir.OverwritePrompt = false;
            dlgSaveDir.Filter = "Text Files (*.txt)|*.txt |All files (*.*)|*.*";

            if (dlgSaveDir.ShowDialog() == DialogResult.OK)
            {
                txtOutputName.Text = dlgSaveDir.FileName.ToString();
            }
        }

        private void ckRmNonPrintAscii_CheckedChanged(object sender, EventArgs e)
        {
            if (!ckRmNonPrintAscii.Checked)
            {
                ckReplaceFieldSep.Visible = false;
            }
            else
            {
                ckReplaceFieldSep.Visible = true;
            }
        }

        private void ckReplaceFieldSep_CheckedChanged(object sender, EventArgs e)
        {
            if (ckReplaceFieldSep.Checked)
            {
                txtFieldSep.Visible = true;
            }
            else
            {
                txtFieldSep.Visible = false;
            }
        }

        private void btnCountRecords_Click(object sender, EventArgs e)
        {
            if (txtSelectedFiles.Text != "")
            {
                string input_files = txtSelectedFiles.Text;
                string message = Program.CountFileRecords(input_files);
                MessageBox.Show(message, "File counts");
                Clipboard.SetDataObject(message);
            }
            else
            {
                MessageBox.Show("Please select files to count");
            }
        }

    }//end of class
}//end of namespace
