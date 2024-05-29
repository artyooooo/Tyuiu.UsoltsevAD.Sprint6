using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.UsoltsevAD.Sprint6.Task1.V30.Lib;

namespace Tyuiu.UsoltsevAD.Sprint6.Task1.V30
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

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_UAD.Text = "";
                textBoxResult_UAD.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_UAD.AppendText("|    X     |   f(x)   |" + Environment.NewLine);
                textBoxResult_UAD.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++, startStep++)
                {
                    strLine = String.Format("|{0,5:d}     | {1, 6:f2}   |", startStep, valueArray[i]);
                    textBoxResult_UAD.AppendText(strLine + Environment.NewLine);
                }

                textBoxResult_UAD.AppendText("+----------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonHelp_UAD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы АСОиУб-23-2 Усольцев Артём Денисович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
