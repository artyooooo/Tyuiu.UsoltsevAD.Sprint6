using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.UsoltsevAD.Sprint6.Task6.V1.Lib;

namespace Tyuiu.UsoltsevAD.Sprint6.Task6.V1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        string openFilePath;
        DataService ds = new DataService();

        private void buttonOpenFile_UAD_Click(object sender, EventArgs e)
        {
            openFileDialogTask_UAD.ShowDialog();
            openFilePath = openFileDialogTask_UAD.FileName;
            textBoxInPutData_UAD.Text = File.ReadAllText(openFilePath);
            groupBoxOutPutData_UAD.Text = groupBoxOutPutData_UAD.Text + " " + openFileDialogTask_UAD.FileName;
            buttonDone_UAD.Enabled = true;
        }

        private void buttonHelp_UAD_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonDone_UAD_Click(object sender, EventArgs e)
        {
            string str = "";
            textBoxOutPutData_UAD.Text = ds.CollectTextFromFile(openFilePath);
        }
    }
}
