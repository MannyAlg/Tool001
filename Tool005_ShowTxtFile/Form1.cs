using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool001
{
    public partial class Form1 : Form
    {
         public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set up ListView columns
            ListView1.Columns.Add("Name", 250);
            ListView1.Columns.Add("Size", 100);
            ListView1.Columns.Add("Date Modified", 150);

            // Get files from drive C:
            string[] files = Directory.GetFiles(@"D:\Old SSB 512G\Development_USA\Classes Folder");
            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                ListViewItem item = new ListViewItem(fileInfo.Name);
                item.SubItems.Add(fileInfo.Length.ToString());
                item.SubItems.Add(fileInfo.LastWriteTime.ToString());
                ListView1.Items.Add(item);
            }
        }

        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
             if (ListView1.SelectedItems.Count > 0)
            {
                string selectedFile = Path.Combine(@"D:\Old SSB 512G\Development_USA\Classes Folder", ListView1.SelectedItems[0].Text);
                OpenFile(selectedFile);
            }
            else
            {
                MessageBox.Show("Please select a file first.");
            }
        }
        private void OpenFile(string filePath)
        {
            try
            {
                System.Diagnostics.Process.Start(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening file: {ex.Message}");
            }
        }
    }
}

