
namespace Tyuiu.UsoltsevAD.Sprint6.Task1.V30
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
            this.groupBoxOutPutData_UAD = new System.Windows.Forms.GroupBox();
            this.textBoxResult_UAD = new System.Windows.Forms.TextBox();
            this.labelResult_UAD = new System.Windows.Forms.Label();
            this.groupBoxTask_UAD = new System.Windows.Forms.GroupBox();
            this.textBoxTask_UAD = new System.Windows.Forms.TextBox();
            this.groupBoxInPutData_UAD = new System.Windows.Forms.GroupBox();
            this.textBoxStopStep_UAD = new System.Windows.Forms.TextBox();
            this.textBoxStartStep_UAD = new System.Windows.Forms.TextBox();
            this.labelStopIndex_UAD = new System.Windows.Forms.Label();
            this.labelStartIndex_UAD = new System.Windows.Forms.Label();
            this.buttonHelp_UAD = new System.Windows.Forms.Button();
            this.buttonDone_UAD = new System.Windows.Forms.Button();
            this.groupBoxOutPutData_UAD.SuspendLayout();
            this.groupBoxTask_UAD.SuspendLayout();
            this.groupBoxInPutData_UAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOutPutData_UAD
            // 
            this.groupBoxOutPutData_UAD.Controls.Add(this.textBoxResult_UAD);
            this.groupBoxOutPutData_UAD.Controls.Add(this.labelResult_UAD);
            this.groupBoxOutPutData_UAD.Location = new System.Drawing.Point(583, 12);
            this.groupBoxOutPutData_UAD.Name = "groupBoxOutPutData_UAD";
            this.groupBoxOutPutData_UAD.Size = new System.Drawing.Size(309, 426);
            this.groupBoxOutPutData_UAD.TabIndex = 0;
            this.groupBoxOutPutData_UAD.TabStop = false;
            this.groupBoxOutPutData_UAD.Text = "Вывод данных";
            // 
            // textBoxResult_UAD
            // 
            this.textBoxResult_UAD.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_UAD.Location = new System.Drawing.Point(11, 50);
            this.textBoxResult_UAD.Multiline = true;
            this.textBoxResult_UAD.Name = "textBoxResult_UAD";
            this.textBoxResult_UAD.ReadOnly = true;
            this.textBoxResult_UAD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_UAD.Size = new System.Drawing.Size(292, 370);
            this.textBoxResult_UAD.TabIndex = 1;
            // 
            // labelResult_UAD
            // 
            this.labelResult_UAD.AutoSize = true;
            this.labelResult_UAD.Location = new System.Drawing.Point(7, 26);
            this.labelResult_UAD.Name = "labelResult_UAD";
            this.labelResult_UAD.Size = new System.Drawing.Size(93, 20);
            this.labelResult_UAD.TabIndex = 0;
            this.labelResult_UAD.Text = "Результат:";
            // 
            // groupBoxTask_UAD
            // 
            this.groupBoxTask_UAD.Controls.Add(this.textBoxTask_UAD);
            this.groupBoxTask_UAD.Location = new System.Drawing.Point(13, 12);
            this.groupBoxTask_UAD.Name = "groupBoxTask_UAD";
            this.groupBoxTask_UAD.Size = new System.Drawing.Size(564, 328);
            this.groupBoxTask_UAD.TabIndex = 1;
            this.groupBoxTask_UAD.TabStop = false;
            this.groupBoxTask_UAD.Text = "Условие";
            // 
            // textBoxTask_UAD
            // 
            this.textBoxTask_UAD.Location = new System.Drawing.Point(7, 26);
            this.textBoxTask_UAD.Multiline = true;
            this.textBoxTask_UAD.Name = "textBoxTask_UAD";
            this.textBoxTask_UAD.ReadOnly = true;
            this.textBoxTask_UAD.Size = new System.Drawing.Size(551, 296);
            this.textBoxTask_UAD.TabIndex = 0;
            this.textBoxTask_UAD.Text = "Протабулировать функцию f(x) на заданном диапазоне.\r\nРезультат вывести в виде таб" +
    "лицы.";
            // 
            // groupBoxInPutData_UAD
            // 
            this.groupBoxInPutData_UAD.Controls.Add(this.textBoxStopStep_UAD);
            this.groupBoxInPutData_UAD.Controls.Add(this.textBoxStartStep_UAD);
            this.groupBoxInPutData_UAD.Controls.Add(this.labelStopIndex_UAD);
            this.groupBoxInPutData_UAD.Controls.Add(this.labelStartIndex_UAD);
            this.groupBoxInPutData_UAD.Location = new System.Drawing.Point(13, 347);
            this.groupBoxInPutData_UAD.Name = "groupBoxInPutData_UAD";
            this.groupBoxInPutData_UAD.Size = new System.Drawing.Size(328, 100);
            this.groupBoxInPutData_UAD.TabIndex = 2;
            this.groupBoxInPutData_UAD.TabStop = false;
            this.groupBoxInPutData_UAD.Text = "Ввод данных";
            // 
            // textBoxStopStep_UAD
            // 
            this.textBoxStopStep_UAD.Location = new System.Drawing.Point(190, 59);
            this.textBoxStopStep_UAD.Name = "textBoxStopStep_UAD";
            this.textBoxStopStep_UAD.Size = new System.Drawing.Size(121, 26);
            this.textBoxStopStep_UAD.TabIndex = 3;
            this.textBoxStopStep_UAD.Text = "5";
            this.textBoxStopStep_UAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_UAD_KeyPress);
            // 
            // textBoxStartStep_UAD
            // 
            this.textBoxStartStep_UAD.Location = new System.Drawing.Point(11, 58);
            this.textBoxStartStep_UAD.Name = "textBoxStartStep_UAD";
            this.textBoxStartStep_UAD.Size = new System.Drawing.Size(121, 26);
            this.textBoxStartStep_UAD.TabIndex = 2;
            this.textBoxStartStep_UAD.Text = "-5";
            this.textBoxStartStep_UAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxStartStep_UAD_KeyPress);
            // 
            // labelStopIndex_UAD
            // 
            this.labelStopIndex_UAD.AutoSize = true;
            this.labelStopIndex_UAD.Location = new System.Drawing.Point(186, 26);
            this.labelStopIndex_UAD.Name = "labelStopIndex_UAD";
            this.labelStopIndex_UAD.Size = new System.Drawing.Size(101, 20);
            this.labelStopIndex_UAD.TabIndex = 1;
            this.labelStopIndex_UAD.Text = "Конец шага:";
            // 
            // labelStartIndex_UAD
            // 
            this.labelStartIndex_UAD.AutoSize = true;
            this.labelStartIndex_UAD.Location = new System.Drawing.Point(7, 26);
            this.labelStartIndex_UAD.Name = "labelStartIndex_UAD";
            this.labelStartIndex_UAD.Size = new System.Drawing.Size(113, 20);
            this.labelStartIndex_UAD.TabIndex = 0;
            this.labelStartIndex_UAD.Text = "Начало шага:";
            // 
            // buttonHelp_UAD
            // 
            this.buttonHelp_UAD.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonHelp_UAD.Location = new System.Drawing.Point(347, 356);
            this.buttonHelp_UAD.Name = "buttonHelp_UAD";
            this.buttonHelp_UAD.Size = new System.Drawing.Size(98, 82);
            this.buttonHelp_UAD.TabIndex = 3;
            this.buttonHelp_UAD.Text = "Справка";
            this.buttonHelp_UAD.UseVisualStyleBackColor = false;
            this.buttonHelp_UAD.Click += new System.EventHandler(this.buttonHelp_UAD_Click);
            // 
            // buttonDone_UAD
            // 
            this.buttonDone_UAD.BackColor = System.Drawing.Color.Green;
            this.buttonDone_UAD.Location = new System.Drawing.Point(451, 356);
            this.buttonDone_UAD.Name = "buttonDone_UAD";
            this.buttonDone_UAD.Size = new System.Drawing.Size(120, 82);
            this.buttonDone_UAD.TabIndex = 4;
            this.buttonDone_UAD.Text = "Выполнить";
            this.buttonDone_UAD.UseVisualStyleBackColor = false;
            this.buttonDone_UAD.Click += new System.EventHandler(this.buttonDone_UAD_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 450);
            this.Controls.Add(this.buttonDone_UAD);
            this.Controls.Add(this.buttonHelp_UAD);
            this.Controls.Add(this.groupBoxInPutData_UAD);
            this.Controls.Add(this.groupBoxTask_UAD);
            this.Controls.Add(this.groupBoxOutPutData_UAD);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 1 | Вариант 30 | Усольцев А.Д.";
            this.groupBoxOutPutData_UAD.ResumeLayout(false);
            this.groupBoxOutPutData_UAD.PerformLayout();
            this.groupBoxTask_UAD.ResumeLayout(false);
            this.groupBoxTask_UAD.PerformLayout();
            this.groupBoxInPutData_UAD.ResumeLayout(false);
            this.groupBoxInPutData_UAD.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox groupBoxOutPutData_UAD;
        private System.Windows.Forms.Label labelResult_UAD;
        private System.Windows.Forms.TextBox textBoxResult_UAD;
        private System.Windows.Forms.GroupBox groupBoxTask_UAD;
        private System.Windows.Forms.GroupBox groupBoxInPutData_UAD;
        private System.Windows.Forms.TextBox textBoxStopStep_UAD;
        private System.Windows.Forms.TextBox textBoxStartStep_UAD;
        private System.Windows.Forms.Label labelStopIndex_UAD;
        private System.Windows.Forms.Label labelStartIndex_UAD;
        private System.Windows.Forms.Button buttonHelp_UAD;
        private System.Windows.Forms.Button buttonDone_UAD;
        private System.Windows.Forms.TextBox textBoxTask_UAD;
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>

        #endregion
}

