
namespace Tyuiu.UsoltsevAD.Sprint6.Task6.V1
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAbout_UAD = new System.Windows.Forms.PictureBox();
            this.buttonOK_UAD = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout_UAD)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAbout_UAD
            // 
            this.pictureBoxAbout_UAD.ErrorImage = null;
            this.pictureBoxAbout_UAD.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAbout_UAD.Image")));
            this.pictureBoxAbout_UAD.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAbout_UAD.Name = "pictureBoxAbout_UAD";
            this.pictureBoxAbout_UAD.Size = new System.Drawing.Size(263, 348);
            this.pictureBoxAbout_UAD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAbout_UAD.TabIndex = 0;
            this.pictureBoxAbout_UAD.TabStop = false;
            // 
            // buttonOK_UAD
            // 
            this.buttonOK_UAD.Location = new System.Drawing.Point(687, 394);
            this.buttonOK_UAD.Name = "buttonOK_UAD";
            this.buttonOK_UAD.Size = new System.Drawing.Size(101, 44);
            this.buttonOK_UAD.TabIndex = 2;
            this.buttonOK_UAD.Text = "ОК";
            this.buttonOK_UAD.UseVisualStyleBackColor = true;
            this.buttonOK_UAD.Click += new System.EventHandler(this.buttonOK_UAD_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(282, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(506, 348);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonOK_UAD);
            this.Controls.Add(this.pictureBoxAbout_UAD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(822, 506);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(822, 506);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сведения о разработчике";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout_UAD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAbout_UAD;
        private System.Windows.Forms.Button buttonOK_UAD;
        private System.Windows.Forms.TextBox textBox1;
    }
}