
namespace Tyuiu.UsoltsevAD.Sprint6.Task0.V10
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
        private void InitializeComponent()
        {
            this.groupBoxTask_UAD = new System.Windows.Forms.GroupBox();
            this.textBoxTask_UAD = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_UAD = new System.Windows.Forms.GroupBox();
            this.labelVarX_UAD = new System.Windows.Forms.Label();
            this.textBoxVarX_UAD = new System.Windows.Forms.TextBox();
            this.groupBoxOutPutData_UAD = new System.Windows.Forms.GroupBox();
            this.labelResult_UAD = new System.Windows.Forms.Label();
            this.textBoxResult_UAD = new System.Windows.Forms.TextBox();
            this.buttonHelp_UAD = new System.Windows.Forms.Button();
            this.buttonDone_UAD = new System.Windows.Forms.Button();
            this.groupBoxTask_UAD.SuspendLayout();
            this.groupBoxInPutData_UAD.SuspendLayout();
            this.groupBoxOutPutData_UAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_UAD
            // 
            this.groupBoxTask_UAD.Controls.Add(this.textBoxTask_UAD);
            this.groupBoxTask_UAD.Location = new System.Drawing.Point(38, 34);
            this.groupBoxTask_UAD.Name = "groupBoxTask_UAD";
            this.groupBoxTask_UAD.Size = new System.Drawing.Size(750, 225);
            this.groupBoxTask_UAD.TabIndex = 0;
            this.groupBoxTask_UAD.TabStop = false;
            this.groupBoxTask_UAD.Text = "Условие";
            // 
            // textBoxTask_UAD
            // 
            this.textBoxTask_UAD.Location = new System.Drawing.Point(10, 25);
            this.textBoxTask_UAD.Multiline = true;
            this.textBoxTask_UAD.Name = "textBoxTask_UAD";
            this.textBoxTask_UAD.ReadOnly = true;
            this.textBoxTask_UAD.Size = new System.Drawing.Size(728, 194);
            this.textBoxTask_UAD.TabIndex = 2;
            this.textBoxTask_UAD.Text = "Вычислить значение выражения по формуле";
            // 
            // groupBoxInPutData_UAD
            // 
            this.groupBoxInPutData_UAD.Controls.Add(this.labelVarX_UAD);
            this.groupBoxInPutData_UAD.Controls.Add(this.textBoxVarX_UAD);
            this.groupBoxInPutData_UAD.Location = new System.Drawing.Point(38, 265);
            this.groupBoxInPutData_UAD.Name = "groupBoxInPutData_UAD";
            this.groupBoxInPutData_UAD.Size = new System.Drawing.Size(455, 124);
            this.groupBoxInPutData_UAD.TabIndex = 1;
            this.groupBoxInPutData_UAD.TabStop = false;
            this.groupBoxInPutData_UAD.Text = "Ввод данных";
            // 
            // labelVarX_UAD
            // 
            this.labelVarX_UAD.AutoSize = true;
            this.labelVarX_UAD.Location = new System.Drawing.Point(6, 34);
            this.labelVarX_UAD.Name = "labelVarX_UAD";
            this.labelVarX_UAD.Size = new System.Drawing.Size(123, 20);
            this.labelVarX_UAD.TabIndex = 1;
            this.labelVarX_UAD.Text = "Переменная X:";
            // 
            // textBoxVarX_UAD
            // 
            this.textBoxVarX_UAD.Location = new System.Drawing.Point(6, 57);
            this.textBoxVarX_UAD.Name = "textBoxVarX_UAD";
            this.textBoxVarX_UAD.Size = new System.Drawing.Size(443, 26);
            this.textBoxVarX_UAD.TabIndex = 0;
            this.textBoxVarX_UAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_UAD_KeyPress);
            // 
            // groupBoxOutPutData_UAD
            // 
            this.groupBoxOutPutData_UAD.Controls.Add(this.labelResult_UAD);
            this.groupBoxOutPutData_UAD.Controls.Add(this.textBoxResult_UAD);
            this.groupBoxOutPutData_UAD.Location = new System.Drawing.Point(499, 265);
            this.groupBoxOutPutData_UAD.Name = "groupBoxOutPutData_UAD";
            this.groupBoxOutPutData_UAD.Size = new System.Drawing.Size(283, 124);
            this.groupBoxOutPutData_UAD.TabIndex = 2;
            this.groupBoxOutPutData_UAD.TabStop = false;
            this.groupBoxOutPutData_UAD.Text = "Вывод данных";
            // 
            // labelResult_UAD
            // 
            this.labelResult_UAD.AutoSize = true;
            this.labelResult_UAD.Location = new System.Drawing.Point(6, 34);
            this.labelResult_UAD.Name = "labelResult_UAD";
            this.labelResult_UAD.Size = new System.Drawing.Size(93, 20);
            this.labelResult_UAD.TabIndex = 1;
            this.labelResult_UAD.Text = "Результат:";
            // 
            // textBoxResult_UAD
            // 
            this.textBoxResult_UAD.Location = new System.Drawing.Point(6, 57);
            this.textBoxResult_UAD.Name = "textBoxResult_UAD";
            this.textBoxResult_UAD.ReadOnly = true;
            this.textBoxResult_UAD.Size = new System.Drawing.Size(271, 26);
            this.textBoxResult_UAD.TabIndex = 0;
            // 
            // buttonHelp_UAD
            // 
            this.buttonHelp_UAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_UAD.Location = new System.Drawing.Point(588, 395);
            this.buttonHelp_UAD.Name = "buttonHelp_UAD";
            this.buttonHelp_UAD.Size = new System.Drawing.Size(52, 42);
            this.buttonHelp_UAD.TabIndex = 3;
            this.buttonHelp_UAD.Text = "?";
            this.buttonHelp_UAD.UseVisualStyleBackColor = true;
            this.buttonHelp_UAD.Click += new System.EventHandler(this.buttonHelp_UAD_Click);
            // 
            // buttonDone_UAD
            // 
            this.buttonDone_UAD.Location = new System.Drawing.Point(646, 395);
            this.buttonDone_UAD.Name = "buttonDone_UAD";
            this.buttonDone_UAD.Size = new System.Drawing.Size(136, 42);
            this.buttonDone_UAD.TabIndex = 4;
            this.buttonDone_UAD.Text = "Выполнить";
            this.buttonDone_UAD.UseVisualStyleBackColor = true;
            this.buttonDone_UAD.Click += new System.EventHandler(this.buttonDone_UAD_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDone_UAD);
            this.Controls.Add(this.buttonHelp_UAD);
            this.Controls.Add(this.groupBoxOutPutData_UAD);
            this.Controls.Add(this.groupBoxInPutData_UAD);
            this.Controls.Add(this.groupBoxTask_UAD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 10 | Усольцев А.Д.";
            this.groupBoxTask_UAD.ResumeLayout(false);
            this.groupBoxTask_UAD.PerformLayout();
            this.groupBoxInPutData_UAD.ResumeLayout(false);
            this.groupBoxInPutData_UAD.PerformLayout();
            this.groupBoxOutPutData_UAD.ResumeLayout(false);
            this.groupBoxOutPutData_UAD.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox groupBoxTask_UAD;
        private System.Windows.Forms.GroupBox groupBoxInPutData_UAD;
        private System.Windows.Forms.GroupBox groupBoxOutPutData_UAD;
        private System.Windows.Forms.Button buttonHelp_UAD;
        private System.Windows.Forms.Button buttonDone_UAD;
        private System.Windows.Forms.TextBox textBoxResult_UAD;
        private System.Windows.Forms.Label labelResult_UAD;
        private System.Windows.Forms.Label labelVarX_UAD;
        private System.Windows.Forms.TextBox textBoxVarX_UAD;
        private System.Windows.Forms.TextBox textBoxTask_UAD;
    }
}

