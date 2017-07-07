using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace DirectoryUtility
{
    public partial class Form1 : Form
    {
        private string _folderPath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AllowDrop = true;
            this.DragEnter += Form1_DragEnter;
            this.DragDrop += Form1_DragDrop;

            toolStripStatusLabel1.Text = "Ready.";
            lblDir.Text = "";
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] filePaths = (string[])(e.Data.GetData(DataFormats.FileDrop));

                DirectoryInfo di = new DirectoryInfo(filePaths.Last());

                // Is this a file or directory
                if (di.Exists)
                {
                    // Directory, use it
                    _folderPath = Path.GetDirectoryName(filePaths.Last());
                    lblDir.Text = _folderPath;
                }
                else
                {
                    // File, show message box
                    var result = MessageBox.Show("You must drop a folder to configure it",
                                                "Error - Object Dropped was not a Folder",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            txtLog.Text = $"{DateTime.Now.ToString()}: Performing utility on {_folderPath}";
            toolStripStatusLabel1.Text = "Processing Finished.";
        }
    }
}