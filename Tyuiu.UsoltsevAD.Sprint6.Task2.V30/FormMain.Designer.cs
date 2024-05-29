
namespace Tyuiu.UsoltsevAD.Sprint6.Task2.V30
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxTask_UAD = new System.Windows.Forms.GroupBox();
            this.textBoxTask_UAD = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_UAD = new System.Windows.Forms.GroupBox();
            this.labelStopStep_UAD = new System.Windows.Forms.Label();
            this.labelStartStep_UAD = new System.Windows.Forms.Label();
            this.textBoxStopStep_UAD = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_UAD = new System.Windows.Forms.TextBox();
            this.buttonHelp_UAD = new System.Windows.Forms.Button();
            this.buttonDone_UAD = new System.Windows.Forms.Button();
            this.dataGridViewFunction_UAD = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_UAD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxTask_UAD.SuspendLayout();
            this.groupBoxInPutData_UAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_UAD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_UAD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_UAD
            // 
            this.groupBoxTask_UAD.Controls.Add(this.textBoxTask_UAD);
            this.groupBoxTask_UAD.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_UAD.Name = "groupBoxTask_UAD";
            this.groupBoxTask_UAD.Size = new System.Drawing.Size(552, 290);
            this.groupBoxTask_UAD.TabIndex = 0;
            this.groupBoxTask_UAD.TabStop = false;
            this.groupBoxTask_UAD.Text = "Условие";
            // 
            // textBoxTask_UAD
            // 
            this.textBoxTask_UAD.Location = new System.Drawing.Point(7, 26);
            this.textBoxTask_UAD.Multiline = true;
            this.textBoxTask_UAD.Name = "textBoxTask_UAD";
            this.textBoxTask_UAD.ReadOnly = true;
            this.textBoxTask_UAD.Size = new System.Drawing.Size(539, 258);
            this.textBoxTask_UAD.TabIndex = 0;
            this.textBoxTask_UAD.Text = "Протабулировать функцию f(x) на заданном диапазоне.\r\nРезультат вывести в DataGrid" +
    "View и построить график функции.";
            // 
            // groupBoxInPutData_UAD
            // 
            this.groupBoxInPutData_UAD.Controls.Add(this.labelStopStep_UAD);
            this.groupBoxInPutData_UAD.Controls.Add(this.labelStartStep_UAD);
            this.groupBoxInPutData_UAD.Controls.Add(this.textBoxStopStep_UAD);
            this.groupBoxInPutData_UAD.Controls.Add(this.textBoxStartStep_UAD);
            this.groupBoxInPutData_UAD.Location = new System.Drawing.Point(20, 310);
            this.groupBoxInPutData_UAD.Name = "groupBoxInPutData_UAD";
            this.groupBoxInPutData_UAD.Size = new System.Drawing.Size(308, 100);
            this.groupBoxInPutData_UAD.TabIndex = 1;
            this.groupBoxInPutData_UAD.TabStop = false;
            this.groupBoxInPutData_UAD.Text = "Ввод данных";
            // 
            // labelStopStep_UAD
            // 
            this.labelStopStep_UAD.AutoSize = true;
            this.labelStopStep_UAD.Location = new System.Drawing.Point(153, 36);
            this.labelStopStep_UAD.Name = "labelStopStep_UAD";
            this.labelStopStep_UAD.Size = new System.Drawing.Size(101, 20);
            this.labelStopStep_UAD.TabIndex = 1;
            this.labelStopStep_UAD.Text = "Конец шага:";
            // 
            // labelStartStep_UAD
            // 
            this.labelStartStep_UAD.AutoSize = true;
            this.labelStartStep_UAD.Location = new System.Drawing.Point(6, 36);
            this.labelStartStep_UAD.Name = "labelStartStep_UAD";
            this.labelStartStep_UAD.Size = new System.Drawing.Size(102, 20);
            this.labelStartStep_UAD.TabIndex = 1;
            this.labelStartStep_UAD.Text = "Старт шага:";
            // 
            // textBoxStopStep_UAD
            // 
            this.textBoxStopStep_UAD.Location = new System.Drawing.Point(157, 68);
            this.textBoxStopStep_UAD.Name = "textBoxStopStep_UAD";
            this.textBoxStopStep_UAD.Size = new System.Drawing.Size(144, 26);
            this.textBoxStopStep_UAD.TabIndex = 0;
            this.textBoxStopStep_UAD.Text = "5";
            this.textBoxStopStep_UAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_UAD_KeyPress);
            // 
            // textBoxStartStep_UAD
            // 
            this.textBoxStartStep_UAD.Location = new System.Drawing.Point(6, 68);
            this.textBoxStartStep_UAD.Name = "textBoxStartStep_UAD";
            this.textBoxStartStep_UAD.Size = new System.Drawing.Size(144, 26);
            this.textBoxStartStep_UAD.TabIndex = 0;
            this.textBoxStartStep_UAD.Text = "-5";
            this.textBoxStartStep_UAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_UAD_KeyPress);
            // 
            // buttonHelp_UAD
            // 
            this.buttonHelp_UAD.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_UAD.Location = new System.Drawing.Point(335, 310);
            this.buttonHelp_UAD.Name = "buttonHelp_UAD";
            this.buttonHelp_UAD.Size = new System.Drawing.Size(97, 100);
            this.buttonHelp_UAD.TabIndex = 2;
            this.buttonHelp_UAD.Text = "Справка";
            this.buttonHelp_UAD.UseVisualStyleBackColor = false;
            this.buttonHelp_UAD.Click += new System.EventHandler(this.buttonHelp_UAD_Click);
            // 
            // buttonDone_UAD
            // 
            this.buttonDone_UAD.BackColor = System.Drawing.Color.Green;
            this.buttonDone_UAD.Location = new System.Drawing.Point(438, 310);
            this.buttonDone_UAD.Name = "buttonDone_UAD";
            this.buttonDone_UAD.Size = new System.Drawing.Size(121, 100);
            this.buttonDone_UAD.TabIndex = 2;
            this.buttonDone_UAD.Text = "Выполнить";
            this.buttonDone_UAD.UseVisualStyleBackColor = false;
            this.buttonDone_UAD.Click += new System.EventHandler(this.buttonDone_UAD_Click);
            this.buttonDone_UAD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_UAD_MouseDown);
            this.buttonDone_UAD.MouseEnter += new System.EventHandler(this.buttonDone_UAD_MouseEnter);
            this.buttonDone_UAD.MouseLeave += new System.EventHandler(this.buttonDone_UAD_MouseLeave);
            // 
            // dataGridViewFunction_UAD
            // 
            this.dataGridViewFunction_UAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_UAD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
            this.dataGridViewFunction_UAD.Location = new System.Drawing.Point(597, 23);
            this.dataGridViewFunction_UAD.Name = "dataGridViewFunction_UAD";
            this.dataGridViewFunction_UAD.ReadOnly = true;
            this.dataGridViewFunction_UAD.RowHeadersVisible = false;
            this.dataGridViewFunction_UAD.RowHeadersWidth = 62;
            this.dataGridViewFunction_UAD.RowTemplate.Height = 28;
            this.dataGridViewFunction_UAD.Size = new System.Drawing.Size(181, 381);
            this.dataGridViewFunction_UAD.TabIndex = 3;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 8;
            this.X.Name = "X";
            this.X.ReadOnly = true;
            this.X.Width = 50;
            // 
            // Y
            // 
            this.Y.HeaderText = "F(X)";
            this.Y.MinimumWidth = 8;
            this.Y.Name = "Y";
            this.Y.ReadOnly = true;
            this.Y.Width = 50;
            // 
            // chartFunction_UAD
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunction_UAD.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFunction_UAD.Legends.Add(legend1);
            this.chartFunction_UAD.Location = new System.Drawing.Point(784, 23);
            this.chartFunction_UAD.Name = "chartFunction_UAD";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartFunction_UAD.Series.Add(series1);
            this.chartFunction_UAD.Size = new System.Drawing.Size(428, 381);
            this.chartFunction_UAD.TabIndex = 4;
            this.chartFunction_UAD.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 450);
            this.Controls.Add(this.chartFunction_UAD);
            this.Controls.Add(this.dataGridViewFunction_UAD);
            this.Controls.Add(this.buttonDone_UAD);
            this.Controls.Add(this.buttonHelp_UAD);
            this.Controls.Add(this.groupBoxInPutData_UAD);
            this.Controls.Add(this.groupBoxTask_UAD);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 30 | Усольцев А.Д.";
            this.groupBoxTask_UAD.ResumeLayout(false);
            this.groupBoxTask_UAD.PerformLayout();
            this.groupBoxInPutData_UAD.ResumeLayout(false);
            this.groupBoxInPutData_UAD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_UAD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_UAD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_UAD;
        private System.Windows.Forms.TextBox textBoxTask_UAD;
        private System.Windows.Forms.GroupBox groupBoxInPutData_UAD;
        private System.Windows.Forms.TextBox textBoxStartStep_UAD;
        private System.Windows.Forms.Label labelStartStep_UAD;
        private System.Windows.Forms.Label labelStopStep_UAD;
        private System.Windows.Forms.TextBox textBoxStopStep_UAD;
        private System.Windows.Forms.Button buttonHelp_UAD;
        private System.Windows.Forms.Button buttonDone_UAD;
        private System.Windows.Forms.DataGridView dataGridViewFunction_UAD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_UAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    }
}