using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.UsoltsevAD.Sprint6.Task3.V5.Lib;

namespace Tyuiu.UsoltsevAD.Sprint6.Task3.V5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] array = new int[5, 5] { {  30, -20, 7, -8, 9 },
                                       { 32, 17, -14, -7, 33 },
                                       { 19, -19, -13, 14, -20 },
                                       { 11, 30, -1, 26, 6 },
                                       { 30, -15, -20, -5, 15 } };

        private void buttonHelp_UAD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы АСОиУб-23-2 Усольцев Артём Денисович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            dataGridViewInPutData_UAD.ColumnCount = columns;
            dataGridViewInPutData_UAD.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPutData_UAD.Columns[i].Width = 45;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInPutData_UAD.Rows[i].Cells[j].Value = Convert.ToString(array[i, j]);
                }
            }
        }

        private void buttonDone_UAD_Click(object sender, EventArgs e)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int[,] res_array = ds.Calculate(array);
            dataGridViewOutPutData_UAD.ColumnCount = columns;
            dataGridViewOutPutData_UAD.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewOutPutData_UAD.Columns[i].Width = 50;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewOutPutData_UAD.Rows[i].Cells[j].Value = Convert.ToString(res_array[i, j]);
                }
            }
        }
    }
}
