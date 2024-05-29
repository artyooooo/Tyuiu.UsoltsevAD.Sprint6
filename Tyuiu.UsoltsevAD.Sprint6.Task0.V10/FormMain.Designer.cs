
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
            this.GroupBoxCond_UAD = new System.Windows.Forms.GroupBox();
            this.PictureBoxFormula_UAD = new System.Windows.Forms.PictureBox();
            this.TextBoxTask_UAD = new System.Windows.Forms.TextBox();
            this.GroupBoxInput_UAD = new System.Windows.Forms.GroupBox();
            this.TextBoxVarX_UAD = new System.Windows.Forms.TextBox();
            this.LabelVarX_UAD = new System.Windows.Forms.Label();
            this.GroupBoxOutput_UAD = new System.Windows.Forms.GroupBox();
            this.TextBoxResult_UAD = new System.Windows.Forms.TextBox();
            this.LabelResult_UAD = new System.Windows.Forms.Label();
            this.ButtonDone_UAD = new System.Windows.Forms.Button();
            this.ButtonInfo_UAD = new System.Windows.Forms.Button();
            this.GroupBoxCond_UAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFormula_UAD)).BeginInit();
            this.GroupBoxInput_UAD.SuspendLayout();
            this.GroupBoxOutput_UAD.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxCond_UAD
            // 
            this.GroupBoxCond_UAD.Controls.Add(this.PictureBoxFormula_UAD);
            this.GroupBoxCond_UAD.Controls.Add(this.TextBoxTask_UAD);
            this.GroupBoxCond_UAD.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxCond_UAD.Location = new System.Drawing.Point(6, 12);
            this.GroupBoxCond_UAD.Name = "GroupBoxCond_UAD";
            this.GroupBoxCond_UAD.Size = new System.Drawing.Size(782, 191);
            this.GroupBoxCond_UAD.TabIndex = 0;
            this.GroupBoxCond_UAD.TabStop = false;
            this.GroupBoxCond_UAD.Text = "Условие";
            // 
            // PictureBoxFormula_UAD
            // 
            this.PictureBoxFormula_UAD.Location = new System.Drawing.Point(347, 27);
            this.PictureBoxFormula_UAD.Name = "PictureBoxFormula_UAD";
            this.PictureBoxFormula_UAD.Size = new System.Drawing.Size(429, 44);
            this.PictureBoxFormula_UAD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxFormula_UAD.TabIndex = 1;
            this.PictureBoxFormula_UAD.TabStop = false;
            // 
            // TextBoxTask_UAD
            // 
            this.TextBoxTask_UAD.BackColor = System.Drawing.SystemColors.Control;
            this.TextBoxTask_UAD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxTask_UAD.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBoxTask_UAD.Location = new System.Drawing.Point(17, 34);
            this.TextBoxTask_UAD.Multiline = true;
            this.TextBoxTask_UAD.Name = "TextBoxTask_UAD";
            this.TextBoxTask_UAD.ReadOnly = true;
            this.TextBoxTask_UAD.Size = new System.Drawing.Size(324, 135);
            this.TextBoxTask_UAD.TabIndex = 0;
            this.TextBoxTask_UAD.TabStop = false;
            this.TextBoxTask_UAD.Text = "Вычислить выражение по формуле";
            // 
            // GroupBoxInput_UAD
            // 
            this.GroupBoxInput_UAD.Controls.Add(this.TextBoxVarX_UAD);
            this.GroupBoxInput_UAD.Controls.Add(this.LabelVarX_UAD);
            this.GroupBoxInput_UAD.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxInput_UAD.Location = new System.Drawing.Point(6, 209);
            this.GroupBoxInput_UAD.Name = "GroupBoxInput_UAD";
            this.GroupBoxInput_UAD.Size = new System.Drawing.Size(507, 169);
            this.GroupBoxInput_UAD.TabIndex = 1;
            this.GroupBoxInput_UAD.TabStop = false;
            this.GroupBoxInput_UAD.Text = "Ввод данных";
            // 
            // TextBoxVarX_UAD
            // 
            this.TextBoxVarX_UAD.Location = new System.Drawing.Point(40, 112);
            this.TextBoxVarX_UAD.Name = "TextBoxVarX_UAD";
            this.TextBoxVarX_UAD.Size = new System.Drawing.Size(213, 50);
            this.TextBoxVarX_UAD.TabIndex = 1;
            this.TextBoxVarX_UAD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxVarX_UAD_KeyPress);
            // 
            // LabelVarX_UAD
            // 
            this.LabelVarX_UAD.AutoSize = true;
            this.LabelVarX_UAD.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelVarX_UAD.Location = new System.Drawing.Point(36, 76);
            this.LabelVarX_UAD.Name = "LabelVarX_UAD";
            this.LabelVarX_UAD.Size = new System.Drawing.Size(223, 34);
            this.LabelVarX_UAD.TabIndex = 0;
            this.LabelVarX_UAD.Text = "Переменная X:";
            // 
            // GroupBoxOutput_UAD
            // 
            this.GroupBoxOutput_UAD.Controls.Add(this.TextBoxResult_UAD);
            this.GroupBoxOutput_UAD.Controls.Add(this.LabelResult_UAD);
            this.GroupBoxOutput_UAD.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupBoxOutput_UAD.Location = new System.Drawing.Point(532, 209);
            this.GroupBoxOutput_UAD.Name = "GroupBoxOutput_UAD";
            this.GroupBoxOutput_UAD.Size = new System.Drawing.Size(256, 169);
            this.GroupBoxOutput_UAD.TabIndex = 2;
            this.GroupBoxOutput_UAD.TabStop = false;
            this.GroupBoxOutput_UAD.Text = "Вывод данных";
            // 
            // TextBoxResult_UAD
            // 
            this.TextBoxResult_UAD.Location = new System.Drawing.Point(10, 112);
            this.TextBoxResult_UAD.Name = "TextBoxResult_UAD";
            this.TextBoxResult_UAD.ReadOnly = true;
            this.TextBoxResult_UAD.Size = new System.Drawing.Size(219, 50);
            this.TextBoxResult_UAD.TabIndex = 2;
            // 
            // LabelResult_UAD
            // 
            this.LabelResult_UAD.AutoSize = true;
            this.LabelResult_UAD.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelResult_UAD.Location = new System.Drawing.Point(6, 76);
            this.LabelResult_UAD.Name = "LabelResult_UAD";
            this.LabelResult_UAD.Size = new System.Drawing.Size(175, 34);
            this.LabelResult_UAD.TabIndex = 1;
            this.LabelResult_UAD.Text = "Результат:";
            // 
            // ButtonDone_UAD
            // 
            this.ButtonDone_UAD.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonDone_UAD.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonDone_UAD.Location = new System.Drawing.Point(607, 384);
            this.ButtonDone_UAD.Name = "ButtonDone_UAD";
            this.ButtonDone_UAD.Size = new System.Drawing.Size(181, 54);
            this.ButtonDone_UAD.TabIndex = 4;
            this.ButtonDone_UAD.Text = "Выполнить";
            this.ButtonDone_UAD.UseVisualStyleBackColor = false;
            this.ButtonDone_UAD.Click += new System.EventHandler(this.ButtonDone_UAD_Click);
            // 
            // ButtonInfo_UAD
            // 
            this.ButtonInfo_UAD.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ButtonInfo_UAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonInfo_UAD.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonInfo_UAD.Location = new System.Drawing.Point(532, 384);
            this.ButtonInfo_UAD.Name = "ButtonInfo_UAD";
            this.ButtonInfo_UAD.Size = new System.Drawing.Size(69, 54);
            this.ButtonInfo_UAD.TabIndex = 5;
            this.ButtonInfo_UAD.Text = "?";
            this.ButtonInfo_UAD.UseVisualStyleBackColor = false;
            this.ButtonInfo_UAD.Click += new System.EventHandler(this.ButtonInfo_UAD_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonInfo_UAD);
            this.Controls.Add(this.ButtonDone_UAD);
            this.Controls.Add(this.GroupBoxOutput_UAD);
            this.Controls.Add(this.GroupBoxInput_UAD);
            this.Controls.Add(this.GroupBoxCond_UAD);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 10 | Усольцев А.Д.";
            this.GroupBoxCond_UAD.ResumeLayout(false);
            this.GroupBoxCond_UAD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFormula_UAD)).EndInit();
            this.GroupBoxInput_UAD.ResumeLayout(false);
            this.GroupBoxInput_UAD.PerformLayout();
            this.GroupBoxOutput_UAD.ResumeLayout(false);
            this.GroupBoxOutput_UAD.PerformLayout();
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.GroupBox GroupBoxCond_UAD;
        private System.Windows.Forms.TextBox TextBoxTask_UAD;
        private System.Windows.Forms.GroupBox GroupBoxInput_UAD;
        private System.Windows.Forms.GroupBox GroupBoxOutput_UAD;
        private System.Windows.Forms.PictureBox PictureBoxFormula_UAD;
        private System.Windows.Forms.TextBox TextBoxVarX_UAD;
        private System.Windows.Forms.Label LabelVarX_UAD;
        private System.Windows.Forms.Label LabelResult_UAD;
        private System.Windows.Forms.TextBox TextBoxResult_UAD;
        private System.Windows.Forms.Button ButtonDone_UAD;
        private System.Windows.Forms.Button ButtonInfo_UAD;
    }
}

