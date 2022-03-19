using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Diagnostics;
using System.IO;

namespace FileArranger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                tbFolder.Text = dialog.FileName;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbFolder.Text == "")
            {
                tbOutput.Text = "Please choose a folder.";
            }
            else
            {
                tbOutput.Text = "";
                string pattern = cbType.Text == "All files" ? "*" : cbType.Text;
                string path = tbFolder.Text;
                
                string[] files = cbSub.Checked? Directory.GetFiles(path, pattern, SearchOption.AllDirectories) : Directory.GetFiles(path, pattern);

                foreach (string file in files)
                {
                    FileInfo fi = new FileInfo(file);
                    fi.Refresh();
                    var destPath = path + '\\' + fi.LastWriteTime.Year + '\\' + fi.LastWriteTime.Month;
                    var destFile = System.IO.Path.Combine(destPath, fi.Name);

                    tbOutput.AppendText("Moving " + file + " to " + destFile);
                    tbOutput.AppendText(Environment.NewLine);

                    Directory.CreateDirectory(destPath);
                    File.Move(file, destFile);

                }
                tbOutput.AppendText("Finished.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void txOutput_TextChanged(object sender, EventArgs e){}
        private void checkBox1_CheckedChanged(object sender, EventArgs e){}
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e){}
    }
}
