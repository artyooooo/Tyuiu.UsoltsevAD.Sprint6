
namespace Tyuiu.UsoltsevAD.Sprint6.Task3.V5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.groupBoxTask_UAD = new System.Windows.Forms.GroupBox();
            this.dataGridViewInPutData_UAD = new System.Windows.Forms.DataGridView();
            this.textBoxTask_UAD = new System.Windows.Forms.TextBox();
            this.buttonDone_UAD = new System.Windows.Forms.Button();
            this.buttonHelp_UAD = new System.Windows.Forms.Button();
            this.groupBoxResult_UAD = new System.Windows.Forms.GroupBox();
            this.dataGridViewOutPutData_UAD = new System.Windows.Forms.DataGridView();
            this.labelResult_UAD = new System.Windows.Forms.Label();
            this.groupBoxTask_UAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutData_UAD)).BeginInit();
            this.groupBoxResult_UAD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutData_UAD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxTask_UAD
            // 
            this.groupBoxTask_UAD.Controls.Add(this.dataGridViewInPutData_UAD);
            this.groupBoxTask_UAD.Controls.Add(this.textBoxTask_UAD);
            this.groupBoxTask_UAD.Location = new System.Drawing.Point(13, 13);
            this.groupBoxTask_UAD.Name = "groupBoxTask_UAD";
            this.groupBoxTask_UAD.Size = new System.Drawing.Size(681, 425);
            this.groupBoxTask_UAD.TabIndex = 0;
            this.groupBoxTask_UAD.TabStop = false;
            this.groupBoxTask_UAD.Text = "Условие";
            // 
            // dataGridViewInPutData_UAD
            // 
            this.dataGridViewInPutData_UAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInPutData_UAD.Location = new System.Drawing.Point(331, 26);
            this.dataGridViewInPutData_UAD.Name = "dataGridViewInPutData_UAD";
            this.dataGridViewInPutData_UAD.ReadOnly = true;
            this.dataGridViewInPutData_UAD.RowHeadersVisible = false;
            this.dataGridViewInPutData_UAD.RowHeadersWidth = 62;
            this.dataGridViewInPutData_UAD.RowTemplate.Height = 28;
            this.dataGridViewInPutData_UAD.Size = new System.Drawing.Size(344, 393);
            this.dataGridViewInPutData_UAD.TabIndex = 1;
            // 
            // textBoxTask_UAD
            // 
            this.textBoxTask_UAD.Location = new System.Drawing.Point(7, 26);
            this.textBoxTask_UAD.Multiline = true;
            this.textBoxTask_UAD.Name = "textBoxTask_UAD";
            this.textBoxTask_UAD.ReadOnly = true;
            this.textBoxTask_UAD.Size = new System.Drawing.Size(317, 393);
            this.textBoxTask_UAD.TabIndex = 0;
            this.textBoxTask_UAD.Text = resources.GetString("textBoxTask_UAD.Text");
            // 
            // buttonDone_UAD
            // 
            this.buttonDone_UAD.Location = new System.Drawing.Point(861, 402);
            this.buttonDone_UAD.Name = "buttonDone_UAD";
            this.buttonDone_UAD.Size = new System.Drawing.Size(175, 36);
            this.buttonDone_UAD.TabIndex = 1;
            this.buttonDone_UAD.Text = "Выполнить";
            this.buttonDone_UAD.UseVisualStyleBackColor = true;
            this.buttonDone_UAD.Click += new System.EventHandler(this.buttonDone_UAD_Click);
            // 
            // buttonHelp_UAD
            // 
            this.buttonHelp_UAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp_UAD.Location = new System.Drawing.Point(766, 402);
            this.buttonHelp_UAD.Name = "buttonHelp_UAD";
            this.buttonHelp_UAD.Size = new System.Drawing.Size(89, 36);
            this.buttonHelp_UAD.TabIndex = 2;
            this.buttonHelp_UAD.Text = "?";
            this.buttonHelp_UAD.UseVisualStyleBackColor = true;
            this.buttonHelp_UAD.Click += new System.EventHandler(this.buttonHelp_UAD_Click);
            // 
            // groupBoxResult_UAD
            // 
            this.groupBoxResult_UAD.Controls.Add(this.dataGridViewOutPutData_UAD);
            this.groupBoxResult_UAD.Controls.Add(this.labelResult_UAD);
            this.groupBoxResult_UAD.Location = new System.Drawing.Point(694, 22);
            this.groupBoxResult_UAD.Name = "groupBoxResult_UAD";
            this.groupBoxResult_UAD.Size = new System.Drawing.Size(392, 374);
            this.groupBoxResult_UAD.TabIndex = 3;
            this.groupBoxResult_UAD.TabStop = false;
            this.groupBoxResult_UAD.Text = "Вывод данных";
            // 
            // dataGridViewOutPutData_UAD
            // 
            this.dataGridViewOutPutData_UAD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOutPutData_UAD.Location = new System.Drawing.Point(7, 46);
            this.dataGridViewOutPutData_UAD.Name = "dataGridViewOutPutData_UAD";
            this.dataGridViewOutPutData_UAD.RowHeadersVisible = false;
            this.dataGridViewOutPutData_UAD.RowHeadersWidth = 62;
            this.dataGridViewOutPutData_UAD.RowTemplate.Height = 28;
            this.dataGridViewOutPutData_UAD.Size = new System.Drawing.Size(379, 322);
            this.dataGridViewOutPutData_UAD.TabIndex = 1;
            // 
            // labelResult_UAD
            // 
            this.labelResult_UAD.AutoSize = true;
            this.labelResult_UAD.Location = new System.Drawing.Point(6, 22);
            this.labelResult_UAD.Name = "labelResult_UAD";
            this.labelResult_UAD.Size = new System.Drawing.Size(93, 20);
            this.labelResult_UAD.TabIndex = 0;
            this.labelResult_UAD.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 450);
            this.Controls.Add(this.groupBoxResult_UAD);
            this.Controls.Add(this.buttonHelp_UAD);
            this.Controls.Add(this.buttonDone_UAD);
            this.Controls.Add(this.groupBoxTask_UAD);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 5 | Усольцев А.Д.";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_UAD.ResumeLayout(false);
            this.groupBoxTask_UAD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInPutData_UAD)).EndInit();
            this.groupBoxResult_UAD.ResumeLayout(false);
            this.groupBoxResult_UAD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutPutData_UAD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_UAD;
        private System.Windows.Forms.TextBox textBoxTask_UAD;
        private System.Windows.Forms.Button buttonDone_UAD;
        private System.Windows.Forms.Button buttonHelp_UAD;
        private System.Windows.Forms.GroupBox groupBoxResult_UAD;
        private System.Windows.Forms.Label labelResult_UAD;
        private System.Windows.Forms.DataGridView dataGridViewInPutData_UAD;
        private System.Windows.Forms.DataGridView dataGridViewOutPutData_UAD;
    }
}

