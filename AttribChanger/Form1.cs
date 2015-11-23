using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
//additional
using System.IO;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttribChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
       

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog filedialog = new OpenFileDialog();

            // Call the ShowDialog method to show the dialog box.
            if (filedialog.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("inside show dialog");

                string strPath;

                strPath = filedialog.FileName;

                tbResults.Text = strPath;
                //lblCreation.Text = "Created: " + File.GetCreationTime(strPath).ToString();
                //lblModified.Text = "Modified: " + File.GetLastWriteTime(strPath).ToString();
                //lblAccessed.Text = "Accessed: " + File.GetLastAccessTime(strPath).ToString();

                RefreshAttribute();


            }

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

            
            FileIOPermission f = new FileIOPermission(PermissionState.None);
            f.AllLocalFiles = FileIOPermissionAccess.AllAccess;
            f.Demand();

            string strPath = tbResults.Text;

            FileAttributes attr = File.GetAttributes(strPath);

            if (attr.HasFlag(FileAttributes.Directory))
            {
                //MessageBox.Show("Its a directory");

                FileInfo fi = new FileInfo(strPath);

                if (checkBoxCreation.Checked == true)
                {
                    Directory.SetCreationTime(strPath, DateTime.Now);

                }



                if (checkBoxAccessed.Checked == true)
                {
                    Directory.SetLastAccessTime(strPath, DateTime.Now);
                }

                try
                {
                    if (checkBoxModified.Checked == true)
                    {
                        Directory.SetLastWriteTime(strPath, DateTime.Now);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                //MessageBox.Show("Its a file");

                if (checkBoxCreation.Checked == true)
                {
                    File.SetCreationTime(strPath, DateTime.Now);

                }

                if (checkBoxModified.Checked == true)
                {
                    File.SetLastWriteTime(strPath, DateTime.Now);
                }

                if (checkBoxAccessed.Checked == true)
                {
                    File.SetLastAccessTime(strPath, DateTime.Now);
                }
            }
            

            

            //refresh after updates
            RefreshAttribute();

            lblStatus.Text = "Values set successfully...";
        }

        private void RefreshAttribute()
        {
            string strPath;

            lblStatus.Text = "";
            strPath = tbResults.Text;
            lblCreation.Text = "Created: " + File.GetCreationTime(strPath).ToString();
            lblModified.Text = "Modified: " + File.GetLastWriteTime(strPath).ToString();
            lblAccessed.Text = "Accessed: " + File.GetLastAccessTime(strPath).ToString();

            //clear checkboxes
            checkBoxCreation.Checked = false;
            checkBoxModified.Checked = false;
            checkBoxAccessed.Checked = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit(); 
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            foreach (string m in files)
            {
                //tbResults.Text = Path.GetFileName(m);
                tbResults.Text = m.ToString();
            }

            RefreshAttribute();
        }

        private void listBox1_DragDrop(object sender, DragEventArgs e)
        {
            
        }

        private void listBox1_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void tbResults_ModifiedChanged(object sender, EventArgs e)
        {
            RefreshAttribute();
        }

        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            string message;

            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            sb.AppendLine("");
            sb.AppendLine("Steps:");
            sb.AppendLine("1. browse or drag/drop for file/folder");
            sb.AppendLine("2. click on OK");
            sb.AppendLine("");
            sb.AppendLine("Copyright 2015 XXX Inc All rights reserved. ");

            MessageBox.Show("Attribute Changer v 0.1 \n" + sb.ToString());
            e.Cancel = true;
        }
    }
}
