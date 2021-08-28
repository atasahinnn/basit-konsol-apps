
namespace MukemmelSayi
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
            this.label2 = new System.Windows.Forms.Label();
            this.hesaplaBtn = new System.Windows.Forms.Button();
            this.listeleBtn = new System.Windows.Forms.Button();
            this.mukemmelSayiList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sayi1TxtB = new System.Windows.Forms.TextBox();
            this.sayi2TxtB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sayi3TxtB = new System.Windows.Forms.RichTextBox();
            this.bulBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Sayıyı Giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(15, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Sayıyı Giriniz:";
            // 
            // hesaplaBtn
            // 
            this.hesaplaBtn.Location = new System.Drawing.Point(12, 78);
            this.hesaplaBtn.Name = "hesaplaBtn";
            this.hesaplaBtn.Size = new System.Drawing.Size(137, 48);
            this.hesaplaBtn.TabIndex = 4;
            this.hesaplaBtn.Text = "Girilen Sayıyı Kontrol Et";
            this.hesaplaBtn.UseVisualStyleBackColor = true;
            this.hesaplaBtn.Click += new System.EventHandler(this.hesaplaBtn_Click);
            // 
            // listeleBtn
            // 
            this.listeleBtn.Location = new System.Drawing.Point(153, 78);
            this.listeleBtn.Name = "listeleBtn";
            this.listeleBtn.Size = new System.Drawing.Size(137, 48);
            this.listeleBtn.TabIndex = 6;
            this.listeleBtn.Text = "Sayıları Listele";
            this.listeleBtn.UseVisualStyleBackColor = true;
            this.listeleBtn.Click += new System.EventHandler(this.listeleBtn_Click);
            // 
            // mukemmelSayiList
            // 
            this.mukemmelSayiList.FormattingEnabled = true;
            this.mukemmelSayiList.Location = new System.Drawing.Point(12, 132);
            this.mukemmelSayiList.Name = "mukemmelSayiList";
            this.mukemmelSayiList.Size = new System.Drawing.Size(278, 95);
            this.mukemmelSayiList.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(36, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "0 adet mükemmel sayı listelenmiştir.";
            // 
            // sayi1TxtB
            // 
            this.sayi1TxtB.Location = new System.Drawing.Point(139, 16);
            this.sayi1TxtB.Name = "sayi1TxtB";
            this.sayi1TxtB.Size = new System.Drawing.Size(151, 20);
            this.sayi1TxtB.TabIndex = 10;
            // 
            // sayi2TxtB
            // 
            this.sayi2TxtB.Location = new System.Drawing.Point(139, 42);
            this.sayi2TxtB.Name = "sayi2TxtB";
            this.sayi2TxtB.Size = new System.Drawing.Size(151, 20);
            this.sayi2TxtB.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(47, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kaçıncı Mükemmel Sayı?";
            // 
            // sayi3TxtB
            // 
            this.sayi3TxtB.Location = new System.Drawing.Point(12, 323);
            this.sayi3TxtB.Name = "sayi3TxtB";
            this.sayi3TxtB.Size = new System.Drawing.Size(278, 29);
            this.sayi3TxtB.TabIndex = 14;
            this.sayi3TxtB.Text = "";
            // 
            // bulBtn
            // 
            this.bulBtn.Location = new System.Drawing.Point(12, 358);
            this.bulBtn.Name = "bulBtn";
            this.bulBtn.Size = new System.Drawing.Size(278, 34);
            this.bulBtn.TabIndex = 15;
            this.bulBtn.Text = "BUL";
            this.bulBtn.UseVisualStyleBackColor = true;
            this.bulBtn.Click += new System.EventHandler(this.bulBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 412);
            this.Controls.Add(this.bulBtn);
            this.Controls.Add(this.sayi3TxtB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sayi2TxtB);
            this.Controls.Add(this.sayi1TxtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mukemmelSayiList);
            this.Controls.Add(this.listeleBtn);
            this.Controls.Add(this.hesaplaBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mükemmel Sayı - 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button hesaplaBtn;
        private System.Windows.Forms.Button listeleBtn;
        private System.Windows.Forms.ListBox mukemmelSayiList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sayi1TxtB;
        private System.Windows.Forms.TextBox sayi2TxtB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox sayi3TxtB;
        private System.Windows.Forms.Button bulBtn;
    }
}

