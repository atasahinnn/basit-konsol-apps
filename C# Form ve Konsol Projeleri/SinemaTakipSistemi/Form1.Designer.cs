
namespace SinemaTakipSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BiletOlusturBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BiletIptalBtn = new System.Windows.Forms.Button();
            this.BiletSatBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BosKoltukBtn = new System.Windows.Forms.Button();
            this.BakiyeBtn = new System.Windows.Forms.Button();
            this.BilgiLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Salon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Koltuk Sayısı:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 23);
            this.textBox2.TabIndex = 3;
            // 
            // BiletOlusturBtn
            // 
            this.BiletOlusturBtn.Location = new System.Drawing.Point(261, 12);
            this.BiletOlusturBtn.Name = "BiletOlusturBtn";
            this.BiletOlusturBtn.Size = new System.Drawing.Size(230, 55);
            this.BiletOlusturBtn.TabIndex = 4;
            this.BiletOlusturBtn.Text = "SALON OLUŞTUR";
            this.BiletOlusturBtn.UseVisualStyleBackColor = true;
            this.BiletOlusturBtn.Click += new System.EventHandler(this.BiletOlusturBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.BiletIptalBtn);
            this.groupBox1.Controls.Add(this.BiletSatBtn);
            this.groupBox1.Location = new System.Drawing.Point(20, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 107);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SATIŞ - İPTAL";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 80);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(187, 19);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = " İNDİRİMLİ BİLET İÇİN SEÇİNİZ!";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // BiletIptalBtn
            // 
            this.BiletIptalBtn.Location = new System.Drawing.Point(105, 22);
            this.BiletIptalBtn.Name = "BiletIptalBtn";
            this.BiletIptalBtn.Size = new System.Drawing.Size(93, 52);
            this.BiletIptalBtn.TabIndex = 8;
            this.BiletIptalBtn.Text = "BİLET İPTAL";
            this.BiletIptalBtn.UseVisualStyleBackColor = true;
            this.BiletIptalBtn.Click += new System.EventHandler(this.BiletIptalBtn_Click);
            // 
            // BiletSatBtn
            // 
            this.BiletSatBtn.Location = new System.Drawing.Point(6, 22);
            this.BiletSatBtn.Name = "BiletSatBtn";
            this.BiletSatBtn.Size = new System.Drawing.Size(93, 52);
            this.BiletSatBtn.TabIndex = 7;
            this.BiletSatBtn.Text = "BİLET SAT";
            this.BiletSatBtn.UseVisualStyleBackColor = true;
            this.BiletSatBtn.Click += new System.EventHandler(this.BiletSatBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BosKoltukBtn);
            this.groupBox2.Controls.Add(this.BakiyeBtn);
            this.groupBox2.Location = new System.Drawing.Point(261, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 107);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RAPOR";
            // 
            // BosKoltukBtn
            // 
            this.BosKoltukBtn.Location = new System.Drawing.Point(121, 22);
            this.BosKoltukBtn.Name = "BosKoltukBtn";
            this.BosKoltukBtn.Size = new System.Drawing.Size(98, 52);
            this.BosKoltukBtn.TabIndex = 9;
            this.BosKoltukBtn.Text = "BOŞ KOLTUK";
            this.BosKoltukBtn.UseVisualStyleBackColor = true;
            this.BosKoltukBtn.Click += new System.EventHandler(this.BosKoltukBtn_Click);
            // 
            // BakiyeBtn
            // 
            this.BakiyeBtn.Location = new System.Drawing.Point(17, 22);
            this.BakiyeBtn.Name = "BakiyeBtn";
            this.BakiyeBtn.Size = new System.Drawing.Size(98, 52);
            this.BakiyeBtn.TabIndex = 9;
            this.BakiyeBtn.Text = "BAKİYE";
            this.BakiyeBtn.UseVisualStyleBackColor = true;
            this.BakiyeBtn.Click += new System.EventHandler(this.BakiyeBtn_Click);
            // 
            // BilgiLabel
            // 
            this.BilgiLabel.AutoSize = true;
            this.BilgiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BilgiLabel.Location = new System.Drawing.Point(20, 201);
            this.BilgiLabel.Name = "BilgiLabel";
            this.BilgiLabel.Size = new System.Drawing.Size(156, 20);
            this.BilgiLabel.TabIndex = 7;
            this.BilgiLabel.Text = "Bilgilendirme Alanı";
            this.BilgiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 233);
            this.Controls.Add(this.BilgiLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BiletOlusturBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sinema Salonu C#";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BiletOlusturBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BiletIptalBtn;
        private System.Windows.Forms.Button BiletSatBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BosKoltukBtn;
        private System.Windows.Forms.Button BakiyeBtn;
        private System.Windows.Forms.Label BilgiLabel;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

