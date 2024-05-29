
namespace Tyuiu.UsoltsevAD.Sprint6.Task5.V4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop_UAD = new System.Windows.Forms.Panel();
            this.buttonHelp_UAD = new System.Windows.Forms.Button();
            this.buttonOpen_UAD = new System.Windows.Forms.Button();
            this.buttonDone_UAD = new System.Windows.Forms.Button();
            this.groupBoxTask_UAD = new System.Windows.Forms.GroupBox();
            this.textBoxTask_UAD = new System.Windows.Forms.TextBox();
            this.panelLeft_UAD = new System.Windows.Forms.Panel();
            this.dataGridViewResult_UAD = new System.Windows.Forms.DataGridView();
            this.splitterLeft_UAD = new System.Windows.Forms.Splitter();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelMid_UAD = new System.Windows.Forms.Panel();
            this.chartFunction_UAD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop_UAD.SuspendLayout();
            this.groupBoxTask_UAD.SuspendLayout();
            this.panelLeft_UAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_UAD)).BeginInit();
            this.panelMid_UAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_UAD)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop_UAD
            // 
            this.panelTop_UAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelTop_UAD.Controls.Add(this.buttonHelp_UAD);
            this.panelTop_UAD.Controls.Add(this.buttonOpen_UAD);
            this.panelTop_UAD.Controls.Add(this.buttonDone_UAD);
            this.panelTop_UAD.Controls.Add(this.groupBoxTask_UAD);
            this.panelTop_UAD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_UAD.Location = new System.Drawing.Point(0, 0);
            this.panelTop_UAD.Name = "panelTop_UAD";
            this.panelTop_UAD.Size = new System.Drawing.Size(978, 119);
            this.panelTop_UAD.TabIndex = 0;
            // 
            // buttonHelp_UAD
            // 
            this.buttonHelp_UAD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_UAD.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonHelp_UAD.Location = new System.Drawing.Point(861, 12);
            this.buttonHelp_UAD.Name = "buttonHelp_UAD";
            this.buttonHelp_UAD.Size = new System.Drawing.Size(105, 101);
            this.buttonHelp_UAD.TabIndex = 1;
            this.buttonHelp_UAD.Text = "Справка";
            this.buttonHelp_UAD.UseVisualStyleBackColor = false;
            this.buttonHelp_UAD.Click += new System.EventHandler(this.buttonHelp_UAD_Click);
            // 
            // buttonOpen_UAD
            // 
            this.buttonOpen_UAD.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonOpen_UAD.Location = new System.Drawing.Point(726, 12);
            this.buttonOpen_UAD.Name = "buttonOpen_UAD";
            this.buttonOpen_UAD.Size = new System.Drawing.Size(120, 101);
            this.buttonOpen_UAD.TabIndex = 1;
            this.buttonOpen_UAD.Text = "Открыть файл";
            this.buttonOpen_UAD.UseVisualStyleBackColor = false;
            this.buttonOpen_UAD.Click += new System.EventHandler(this.buttonOpen_UAD_Click);
            // 
            // buttonDone_UAD
            // 
            this.buttonDone_UAD.BackColor = System.Drawing.Color.Green;
            this.buttonDone_UAD.Location = new System.Drawing.Point(601, 12);
            this.buttonDone_UAD.Name = "buttonDone_UAD";
            this.buttonDone_UAD.Size = new System.Drawing.Size(120, 101);
            this.buttonDone_UAD.TabIndex = 1;
            this.buttonDone_UAD.Text = "Выполнить";
            this.buttonDone_UAD.UseVisualStyleBackColor = false;
            this.buttonDone_UAD.Click += new System.EventHandler(this.buttonDone_UAD_Click);
            // 
            // groupBoxTask_UAD
            // 
            this.groupBoxTask_UAD.Controls.Add(this.textBoxTask_UAD);
            this.groupBoxTask_UAD.Location = new System.Drawing.Point(4, 4);
            this.groupBoxTask_UAD.Name = "groupBoxTask_UAD";
            this.groupBoxTask_UAD.Size = new System.Drawing.Size(591, 109);
            this.groupBoxTask_UAD.TabIndex = 0;
            this.groupBoxTask_UAD.TabStop = false;
            this.groupBoxTask_UAD.Text = "Условие:";
            // 
            // textBoxTask_UAD
            // 
            this.textBoxTask_UAD.Location = new System.Drawing.Point(9, 26);
            this.textBoxTask_UAD.Multiline = true;
            this.textBoxTask_UAD.Name = "textBoxTask_UAD";
            this.textBoxTask_UAD.ReadOnly = true;
            this.textBoxTask_UAD.Size = new System.Drawing.Size(576, 77);
            this.textBoxTask_UAD.TabIndex = 0;
            this.textBoxTask_UAD.Text = "Прочитать данные из файла InPutFileTask5V4.txt. Вывести в dataGridView. Вывести в" +
    "се целые числа. Построить диаграмму по этим значениям.";
            // 
            // panelLeft_UAD
            // 
            this.panelLeft_UAD.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panelLeft_UAD.Controls.Add(this.dataGridViewResult_UAD);
            this.panelLeft_UAD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_UAD.Location = new System.Drawing.Point(0, 119);
            this.panelLeft_UAD.Name = "panelLeft_UAD";
            this.panelLeft_UAD.Size = new System.Drawing.Size(247, 375);
            this.panelLeft_UAD.TabIndex = 1;
            // 
            // dataGridViewResult_UAD
            // 
            this.dataGridViewResult_UAD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewResult_UAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_UAD.Location = new System.Drawing.Point(4, 4);
            this.dataGridViewResult_UAD.Name = "dataGridViewResult_UAD";
            this.dataGridViewResult_UAD.ReadOnly = true;
            this.dataGridViewResult_UAD.RowHeadersVisible = false;
            this.dataGridViewResult_UAD.RowHeadersWidth = 62;
            this.dataGridViewResult_UAD.RowTemplate.Height = 28;
            this.dataGridViewResult_UAD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewResult_UAD.Size = new System.Drawing.Size(240, 359);
            this.dataGridViewResult_UAD.TabIndex = 0;
            // 
            // splitterLeft_UAD
            // 
            this.splitterLeft_UAD.Location = new System.Drawing.Point(247, 119);
            this.splitterLeft_UAD.Name = "splitterLeft_UAD";
            this.splitterLeft_UAD.Size = new System.Drawing.Size(3, 375);
            this.splitterLeft_UAD.TabIndex = 2;
            this.splitterLeft_UAD.TabStop = false;
            // 
            // panelMid_UAD
            // 
            this.panelMid_UAD.BackColor = System.Drawing.Color.Red;
            this.panelMid_UAD.Controls.Add(this.chartFunction_UAD);
            this.panelMid_UAD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMid_UAD.Location = new System.Drawing.Point(250, 119);
            this.panelMid_UAD.Name = "panelMid_UAD";
            this.panelMid_UAD.Size = new System.Drawing.Size(728, 375);
            this.panelMid_UAD.TabIndex = 3;
            // 
            // chartFunction_UAD
            // 
            this.chartFunction_UAD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartFunction_UAD.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartFunction_UAD.Legends.Add(legend2);
            this.chartFunction_UAD.Location = new System.Drawing.Point(7, 7);
            this.chartFunction_UAD.Name = "chartFunction_UAD";
            series2.BorderColor = System.Drawing.Color.White;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.IsVisibleInLegend = false;
            series2.LabelBackColor = System.Drawing.Color.White;
            series2.LabelBorderColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartFunction_UAD.Series.Add(series2);
            this.chartFunction_UAD.Size = new System.Drawing.Size(709, 356);
            this.chartFunction_UAD.TabIndex = 0;
            this.chartFunction_UAD.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 494);
            this.Controls.Add(this.panelMid_UAD);
            this.Controls.Add(this.splitterLeft_UAD);
            this.Controls.Add(this.panelLeft_UAD);
            this.Controls.Add(this.panelTop_UAD);
            this.MinimumSize = new System.Drawing.Size(1000, 550);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 5 | Вариант 4 | Усольцев А.Д.";
            this.panelTop_UAD.ResumeLayout(false);
            this.groupBoxTask_UAD.ResumeLayout(false);
            this.groupBoxTask_UAD.PerformLayout();
            this.panelLeft_UAD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_UAD)).EndInit();
            this.panelMid_UAD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_UAD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop_UAD;
        private System.Windows.Forms.Panel panelLeft_UAD;
        private System.Windows.Forms.Splitter splitterLeft_UAD;
        private System.Windows.Forms.GroupBox groupBoxTask_UAD;
        private System.Windows.Forms.TextBox textBoxTask_UAD;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panelMid_UAD;
        private System.Windows.Forms.Button buttonDone_UAD;
        private System.Windows.Forms.Button buttonHelp_UAD;
        private System.Windows.Forms.Button buttonOpen_UAD;
        private System.Windows.Forms.DataGridView dataGridViewResult_UAD;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_UAD;
    }
}

