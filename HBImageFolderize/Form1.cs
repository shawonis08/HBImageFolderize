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
        public string FolderName = "Folder";
        public string FolderPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                FolderPath = folderBrowserDialog.SelectedPath;
                System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(FolderPath);
                int count = dir.GetFiles().Length;
                MessageBox.Show(count.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.DirectoryInfo dir = new System.IO.DirectoryInfo(FolderPath);
            int FolderNumber = Convert.ToInt32(numericUpDown1.Value);
            for (int i = 1; i <= FolderNumber; i++)
            {
                string pathString = System.IO.Path.Combine(FolderPath, FolderName + Convert.ToString(i));
                System.IO.Directory.CreateDirectory(pathString);
            }
            MessageBox.Show(FolderNumber.ToString());


        }
    }
}
