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
using Tyuiu.UsoltsevAD.Sprint6.Task5.V4.Lib;

namespace Tyuiu.UsoltsevAD.Sprint6.Task5.V4
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();
        string path = @"C:\Users\malsu\source\repos\Tyuiu.UsoltsevAD.Sprint6\Tyuiu.UsoltsevAD.Sprint6.Task5.V4\bin\Debug\InPutFileTask5V4.txt";
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_UAD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы АСОиУБ-23-2 Усольцев Артём Денисович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_UAD_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }

        private void buttonDone_UAD_Click(object sender, EventArgs e)
        {
            dataGridViewResult_UAD.ColumnCount = 2;
            dataGridViewResult_UAD.Columns[0].Width = 20;
            dataGridViewResult_UAD.Columns[1].Width = 50;
            this.chartFunction_UAD.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_UAD.ChartAreas[0].AxisY.Title = "Ось Y";
            chartFunction_UAD.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_UAD.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_UAD.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }
    }
}
