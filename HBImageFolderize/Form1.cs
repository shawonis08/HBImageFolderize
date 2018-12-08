using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HBImageFolderize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                String name = folderBrowserDialog.SelectedPath;
                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(name);
                int count = dir.GetFiles().Length;
                MessageBox.Show(count.ToString());
            }
        }
    }
}
