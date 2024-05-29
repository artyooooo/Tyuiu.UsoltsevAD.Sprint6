
namespace Tyuiu.UsoltsevAD.Sprint6.Task7.V15
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
            this.labelInfo_UAD = new System.Windows.Forms.Label();
            this.buttonOK_UAD = new System.Windows.Forms.Button();
            this.pictureBoxAvatar_UAD = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_UAD)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_UAD
            // 
            this.labelInfo_UAD.AutoSize = true;
            this.labelInfo_UAD.Location = new System.Drawing.Point(204, 14);
            this.labelInfo_UAD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInfo_UAD.Name = "labelInfo_UAD";
            this.labelInfo_UAD.Size = new System.Drawing.Size(0, 20);
            this.labelInfo_UAD.TabIndex = 0;
            // 
            // buttonOK_UAD
            // 
            this.buttonOK_UAD.Location = new System.Drawing.Point(523, 372);
            this.buttonOK_UAD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonOK_UAD.Name = "buttonOK_UAD";
            this.buttonOK_UAD.Size = new System.Drawing.Size(112, 35);
            this.buttonOK_UAD.TabIndex = 1;
            this.buttonOK_UAD.Text = "Ок";
            this.buttonOK_UAD.UseVisualStyleBackColor = true;
            this.buttonOK_UAD.Click += new System.EventHandler(this.buttonOK_UAD_Click);
            // 
            // pictureBoxAvatar_UAD
            // 
            this.pictureBoxAvatar_UAD.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_UAD.Image")));
            this.pictureBoxAvatar_UAD.Location = new System.Drawing.Point(18, 14);
            this.pictureBoxAvatar_UAD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBoxAvatar_UAD.Name = "pictureBoxAvatar_UAD";
            this.pictureBoxAvatar_UAD.Size = new System.Drawing.Size(176, 393);
            this.pictureBoxAvatar_UAD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar_UAD.TabIndex = 2;
            this.pictureBoxAvatar_UAD.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(213, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(201, 14);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(434, 350);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 421);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxAvatar_UAD);
            this.Controls.Add(this.buttonOK_UAD);
            this.Controls.Add(this.labelInfo_UAD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О разработчике";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_UAD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_UAD;
        private System.Windows.Forms.Button buttonOK_UAD;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_UAD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}