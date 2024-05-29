using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.UsoltsevAD.Sprint6.Task2.V30.Lib;

namespace Tyuiu.UsoltsevAD.Sprint6.Task2.V30
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_UAD_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = int.Parse(textBoxStartStep_UAD.Text);
                int stopStep = int.Parse(textBoxStopStep_UAD.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);

                this.chartFunction_UAD.Titles.Add("График функции f(x)");

                this.chartFunction_UAD.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction_UAD.ChartAreas[0].AxisY.Title = "Ось Y";

                for (int i = 0; i <= len - 1; i++, startStep++)
                {
                    this.dataGridViewFunction_UAD.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

                    this.chartFunction_UAD.Series[0].Points.AddXY(startStep, valueArray[i]);
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_UAD_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_UAD.BackColor = Color.Red;
        }

        private void buttonDone_UAD_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_UAD.BackColor = Color.Green;
        }

        private void buttonDone_UAD_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_UAD.BackColor = Color.Blue;
        }

        private void buttonHelp_UAD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы АСОиУб-23-2 Усольцев Артём Денисович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBoxStartStep_UAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8) && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
    }
}
