using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.UsoltsevAD.Sprint6.Task0.V10.Lib;

namespace Tyuiu.UsoltsevAD.Sprint6.Task0.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void ButtonDone_UAD_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                TextBoxResult_UAD.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(TextBoxVarX_UAD.Text)));

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxVarX_UAD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void ButtonInfo_UAD_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнила студент группы АСОиУб-23-2 Усольцев Артём Денисович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
