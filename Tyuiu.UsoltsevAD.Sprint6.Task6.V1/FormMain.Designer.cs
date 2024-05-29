
namespace Tyuiu.UsoltsevAD.Sprint6.Task6.V1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.openFileDialogTask_UAD = new System.Windows.Forms.OpenFileDialog();
            this.toolTip_UAD = new System.Windows.Forms.ToolTip(this.components);
            this.buttonOpenFile_UAD = new System.Windows.Forms.Button();
            this.buttonDone_UAD = new System.Windows.Forms.Button();
            this.buttonHelp_UAD = new System.Windows.Forms.Button();
            this.panelTop_UAD = new System.Windows.Forms.Panel();
            this.panelLeft_UAD = new System.Windows.Forms.Panel();
            this.groupBoxInPutData_UAD = new System.Windows.Forms.GroupBox();
            this.textBoxInPutData_UAD = new System.Windows.Forms.TextBox();
            this.panelRight_UAD = new System.Windows.Forms.Panel();
            this.splitterMain_UAD = new System.Windows.Forms.Splitter();
            this.groupBoxOutPutData_UAD = new System.Windows.Forms.GroupBox();
            this.textBoxOutPutData_UAD = new System.Windows.Forms.TextBox();
            this.groupBoxTask_UAD = new System.Windows.Forms.GroupBox();
            this.textBoxTask_UAD = new System.Windows.Forms.TextBox();
            this.panelTop_UAD.SuspendLayout();
            this.panelLeft_UAD.SuspendLayout();
            this.groupBoxInPutData_UAD.SuspendLayout();
            this.panelRight_UAD.SuspendLayout();
            this.groupBoxOutPutData_UAD.SuspendLayout();
            this.groupBoxTask_UAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialogTask_UAD
            // 
            this.openFileDialogTask_UAD.FileName = "openFileDialog1";
            // 
            // toolTip_UAD
            // 
            this.toolTip_UAD.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip_UAD.ToolTipTitle = "Подсказка";
            // 
            // buttonOpenFile_UAD
            // 
            this.buttonOpenFile_UAD.Image = ((System.Drawing.Image)(resources.GetObject("buttonOpenFile_UAD.Image")));
            this.buttonOpenFile_UAD.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_UAD.Name = "buttonOpenFile_UAD";
            this.buttonOpenFile_UAD.Size = new System.Drawing.Size(75, 63);
            this.buttonOpenFile_UAD.TabIndex = 0;
            this.toolTip_UAD.SetToolTip(this.buttonOpenFile_UAD, "Открыть файл\r\nВыбрать нужный файл для обработки");
            this.buttonOpenFile_UAD.UseVisualStyleBackColor = true;
            this.buttonOpenFile_UAD.Click += new System.EventHandler(this.buttonOpenFile_UAD_Click);
            // 
            // buttonDone_UAD
            // 
            this.buttonDone_UAD.Enabled = false;
            this.buttonDone_UAD.Image = ((System.Drawing.Image)(resources.GetObject("buttonDone_UAD.Image")));
            this.buttonDone_UAD.Location = new System.Drawing.Point(93, 12);
            this.buttonDone_UAD.Name = "buttonDone_UAD";
            this.buttonDone_UAD.Size = new System.Drawing.Size(75, 63);
            this.buttonDone_UAD.TabIndex = 0;
            this.toolTip_UAD.SetToolTip(this.buttonDone_UAD, "Вывести первое слово каждой строки в результирующею строку.");
            this.buttonDone_UAD.UseVisualStyleBackColor = true;
            this.buttonDone_UAD.Click += new System.EventHandler(this.buttonDone_UAD_Click);
            // 
            // buttonHelp_UAD
            // 
            this.buttonHelp_UAD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_UAD.Image = ((System.Drawing.Image)(resources.GetObject("buttonHelp_UAD.Image")));
            this.buttonHelp_UAD.Location = new System.Drawing.Point(991, 12);
            this.buttonHelp_UAD.Name = "buttonHelp_UAD";
            this.buttonHelp_UAD.Size = new System.Drawing.Size(75, 63);
            this.buttonHelp_UAD.TabIndex = 0;
            this.toolTip_UAD.SetToolTip(this.buttonHelp_UAD, "Сведения о программе");
            this.buttonHelp_UAD.UseVisualStyleBackColor = true;
            this.buttonHelp_UAD.Click += new System.EventHandler(this.buttonHelp_UAD_Click);
            // 
            // panelTop_UAD
            // 
            this.panelTop_UAD.Controls.Add(this.buttonHelp_UAD);
            this.panelTop_UAD.Controls.Add(this.buttonDone_UAD);
            this.panelTop_UAD.Controls.Add(this.buttonOpenFile_UAD);
            this.panelTop_UAD.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop_UAD.Location = new System.Drawing.Point(0, 0);
            this.panelTop_UAD.Name = "panelTop_UAD";
            this.panelTop_UAD.Size = new System.Drawing.Size(1078, 207);
            this.panelTop_UAD.TabIndex = 1;
            // 
            // panelLeft_UAD
            // 
            this.panelLeft_UAD.Controls.Add(this.groupBoxInPutData_UAD);
            this.panelLeft_UAD.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft_UAD.Location = new System.Drawing.Point(0, 207);
            this.panelLeft_UAD.Name = "panelLeft_UAD";
            this.panelLeft_UAD.Size = new System.Drawing.Size(526, 437);
            this.panelLeft_UAD.TabIndex = 2;
            // 
            // groupBoxInPutData_UAD
            // 
            this.groupBoxInPutData_UAD.Controls.Add(this.textBoxInPutData_UAD);
            this.groupBoxInPutData_UAD.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxInPutData_UAD.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInPutData_UAD.Name = "groupBoxInPutData_UAD";
            this.groupBoxInPutData_UAD.Size = new System.Drawing.Size(516, 437);
            this.groupBoxInPutData_UAD.TabIndex = 5;
            this.groupBoxInPutData_UAD.TabStop = false;
            this.groupBoxInPutData_UAD.Text = "Ввод данных:";
            // 
            // textBoxInPutData_UAD
            // 
            this.textBoxInPutData_UAD.Location = new System.Drawing.Point(7, 66);
            this.textBoxInPutData_UAD.Multiline = true;
            this.textBoxInPutData_UAD.Name = "textBoxInPutData_UAD";
            this.textBoxInPutData_UAD.ReadOnly = true;
            this.textBoxInPutData_UAD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInPutData_UAD.Size = new System.Drawing.Size(503, 329);
            this.textBoxInPutData_UAD.TabIndex = 0;
            // 
            // panelRight_UAD
            // 
            this.panelRight_UAD.Controls.Add(this.splitterMain_UAD);
            this.panelRight_UAD.Controls.Add(this.groupBoxOutPutData_UAD);
            this.panelRight_UAD.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight_UAD.Location = new System.Drawing.Point(526, 207);
            this.panelRight_UAD.Name = "panelRight_UAD";
            this.panelRight_UAD.Size = new System.Drawing.Size(552, 437);
            this.panelRight_UAD.TabIndex = 4;
            // 
            // splitterMain_UAD
            // 
            this.splitterMain_UAD.Location = new System.Drawing.Point(0, 0);
            this.splitterMain_UAD.Name = "splitterMain_UAD";
            this.splitterMain_UAD.Size = new System.Drawing.Size(3, 437);
            this.splitterMain_UAD.TabIndex = 6;
            this.splitterMain_UAD.TabStop = false;
            // 
            // groupBoxOutPutData_UAD
            // 
            this.groupBoxOutPutData_UAD.Controls.Add(this.textBoxOutPutData_UAD);
            this.groupBoxOutPutData_UAD.Location = new System.Drawing.Point(6, 0);
            this.groupBoxOutPutData_UAD.Name = "groupBoxOutPutData_UAD";
            this.groupBoxOutPutData_UAD.Size = new System.Drawing.Size(516, 401);
            this.groupBoxOutPutData_UAD.TabIndex = 5;
            this.groupBoxOutPutData_UAD.TabStop = false;
            this.groupBoxOutPutData_UAD.Text = "Вывод данных:";
            // 
            // textBoxOutPutData_UAD
            // 
            this.textBoxOutPutData_UAD.Location = new System.Drawing.Point(6, 66);
            this.textBoxOutPutData_UAD.Multiline = true;
            this.textBoxOutPutData_UAD.Name = "textBoxOutPutData_UAD";
            this.textBoxOutPutData_UAD.ReadOnly = true;
            this.textBoxOutPutData_UAD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxOutPutData_UAD.Size = new System.Drawing.Size(503, 329);
            this.textBoxOutPutData_UAD.TabIndex = 0;
            // 
            // groupBoxTask_UAD
            // 
            this.groupBoxTask_UAD.Controls.Add(this.textBoxTask_UAD);
            this.groupBoxTask_UAD.Location = new System.Drawing.Point(0, 107);
            this.groupBoxTask_UAD.Name = "groupBoxTask_UAD";
            this.groupBoxTask_UAD.Size = new System.Drawing.Size(1048, 100);
            this.groupBoxTask_UAD.TabIndex = 3;
            this.groupBoxTask_UAD.TabStop = false;
            this.groupBoxTask_UAD.Text = "Условие:";
            // 
            // textBoxTask_UAD
            // 
            this.textBoxTask_UAD.Location = new System.Drawing.Point(7, 26);
            this.textBoxTask_UAD.Multiline = true;
            this.textBoxTask_UAD.Name = "textBoxTask_UAD";
            this.textBoxTask_UAD.ReadOnly = true;
            this.textBoxTask_UAD.Size = new System.Drawing.Size(1034, 68);
            this.textBoxTask_UAD.TabIndex = 0;
            this.textBoxTask_UAD.Text = "Дан файл InPutFileTask6V1.txt. Загрузить файл в textBoxIn через openFileDialog. В" +
    "ывести первое слово каждой строки в результирующею строку и вывести ее в textBox" +
    "Out.";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 644);
            this.Controls.Add(this.panelRight_UAD);
            this.Controls.Add(this.groupBoxTask_UAD);
            this.Controls.Add(this.panelLeft_UAD);
            this.Controls.Add(this.panelTop_UAD);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 6 | Вариант 1 | Мальсагов Умар Асланович";
            this.panelTop_UAD.ResumeLayout(false);
            this.panelLeft_UAD.ResumeLayout(false);
            this.groupBoxInPutData_UAD.ResumeLayout(false);
            this.groupBoxInPutData_UAD.PerformLayout();
            this.panelRight_UAD.ResumeLayout(false);
            this.groupBoxOutPutData_UAD.ResumeLayout(false);
            this.groupBoxOutPutData_UAD.PerformLayout();
            this.groupBoxTask_UAD.ResumeLayout(false);
            this.groupBoxTask_UAD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogTask_UAD;
        private System.Windows.Forms.ToolTip toolTip_UAD;
        private System.Windows.Forms.Button buttonOpenFile_UAD;
        private System.Windows.Forms.Button buttonDone_UAD;
        private System.Windows.Forms.Button buttonHelp_UAD;
        private System.Windows.Forms.Panel panelTop_UAD;
        private System.Windows.Forms.Panel panelLeft_UAD;
        private System.Windows.Forms.Panel panelRight_UAD;
        private System.Windows.Forms.GroupBox groupBoxTask_UAD;
        private System.Windows.Forms.GroupBox groupBoxInPutData_UAD;
        private System.Windows.Forms.TextBox textBoxInPutData_UAD;
        private System.Windows.Forms.TextBox textBoxTask_UAD;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_UAD;
        private System.Windows.Forms.TextBox textBoxOutPutData_UAD;
        private System.Windows.Forms.Splitter splitterMain_UAD;
    }
}

