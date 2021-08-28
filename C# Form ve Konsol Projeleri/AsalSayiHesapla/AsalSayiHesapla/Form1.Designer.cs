
namespace AsalSayiHesapla
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.asalTxtB = new System.Windows.Forms.TextBox();
            this.bulBtn = new System.Windows.Forms.Button();
            this.asalSayiLstB = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Girilen Değere En Yakın Asal Sayıyı Bul:";
            // 
            // asalTxtB
            // 
            this.asalTxtB.Location = new System.Drawing.Point(209, 9);
            this.asalTxtB.Name = "asalTxtB";
            this.asalTxtB.Size = new System.Drawing.Size(191, 20);
            this.asalTxtB.TabIndex = 1;
            // 
            // bulBtn
            // 
            this.bulBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bulBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bulBtn.Location = new System.Drawing.Point(209, 35);
            this.bulBtn.Name = "bulBtn";
            this.bulBtn.Size = new System.Drawing.Size(191, 56);
            this.bulBtn.TabIndex = 3;
            this.bulBtn.Text = "Asal Sayıyı Bul";
            this.bulBtn.UseVisualStyleBackColor = true;
            this.bulBtn.Click += new System.EventHandler(this.bulBtn_Click);
            // 
            // asalSayiLstB
            // 
            this.asalSayiLstB.FormattingEnabled = true;
            this.asalSayiLstB.Location = new System.Drawing.Point(12, 35);
            this.asalSayiLstB.Name = "asalSayiLstB";
            this.asalSayiLstB.Size = new System.Drawing.Size(191, 56);
            this.asalSayiLstB.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 101);
            this.Controls.Add(this.asalSayiLstB);
            this.Controls.Add(this.bulBtn);
            this.Controls.Add(this.asalTxtB);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Girilen Asal Sayı Farkı -";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox asalTxtB;
        private System.Windows.Forms.Button bulBtn;
        private System.Windows.Forms.ListBox asalSayiLstB;
    }
}

