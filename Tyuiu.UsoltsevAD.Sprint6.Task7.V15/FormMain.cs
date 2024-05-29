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
using Tyuiu.UsoltsevAD.Sprint6.Task7.V15.Lib;

namespace Tyuiu.UsoltsevAD.Sprint6.Task7.V15
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_UAD.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
            saveFileDialog_UAD.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Всефайлы(*.*)|*.*";
        }
        static string openFile;
        static int rows;
        static int columns;
        DataService ds = new DataService();
        public int[,] LoadFromData(string path)
        {
            string file = File.ReadAllText(path);
            file = file.Replace('\n', '\r');
            string[] lines = file.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] array = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = Convert.ToInt32(line_mas[j]);
                }
            }
            return array;
        }

        private void buttonOpenFile_UAD_Click(object sender, EventArgs e)
        {
            openFileDialog_UAD.ShowDialog();
            openFile = openFileDialog_UAD.FileName;

            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromData(openFile);

            dataGridViewInPutData_UAD.RowCount = rows;
            dataGridViewInPutData_UAD.ColumnCount = columns;
            dataGridViewOutPutData_UAD.RowCount = rows;
            dataGridViewOutPutData_UAD.ColumnCount = columns;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewInPutData_UAD.Columns[i].Width = 50;
                dataGridViewOutPutData_UAD.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewInPutData_UAD.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            arrayValues = ds.GetMatrix(openFile);
            buttonDone_UAD.Enabled = true;
        }

        private void buttonOpenFile_UAD_MouseEnter(object sender, EventArgs e)
        {
            toolTip_UAD.ToolTipTitle = "Открыть файл";
        }

        private void buttonDone_UAD_MouseEnter(object sender, EventArgs e)
        {
            toolTip_UAD.ToolTipTitle = "Выполнить";
        }

        private void buttonSave_UAD_MouseEnter(object sender, EventArgs e)
        {
            toolTip_UAD.ToolTipTitle = "Сохранить файл";
        }

        private void buttonHelp_UAD_MouseEnter(object sender, EventArgs e)
        {
            toolTip_UAD.ToolTipTitle = "Справка";
        }

        private void buttonHelp_UAD_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }

        private void buttonSave_UAD_Click(object sender, EventArgs e)
        {
            saveFileDialog_UAD.FileName = "OutPutFileTask7.csv";
            saveFileDialog_UAD.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_UAD.ShowDialog();

            string path = saveFileDialog_UAD.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewOutPutData_UAD.RowCount;
            int columns = dataGridViewOutPutData_UAD.ColumnCount;
            string str = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str += dataGridViewInPutData_UAD.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewInPutData_UAD.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridViewInPutData_UAD.RowCount = 50;
            dataGridViewOutPutData_UAD.RowCount = 50;

            dataGridViewInPutData_UAD.ColumnCount = 50;
            dataGridViewOutPutData_UAD.ColumnCount = 50;

            panelLeft_UAD.Width = this.Width / 2;

            for (int i = 0; i < 50; i++)
            {
                dataGridViewInPutData_UAD.Columns[i].Width = 25;
                dataGridViewOutPutData_UAD.Columns[i].Width = 25;
            }
        }

        private void buttonDone_UAD_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(openFile);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewOutPutData_UAD.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            buttonSave_UAD.Enabled = true;
        }
    }
}
