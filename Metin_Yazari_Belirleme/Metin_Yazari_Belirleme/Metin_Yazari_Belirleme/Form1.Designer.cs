namespace Metin_Yazari_Belirleme
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
            this.metinYukleBtn = new System.Windows.Forms.Button();
            this.stackeOkuBtn = new System.Windows.Forms.Button();
            this.cumleLb = new System.Windows.Forms.ListBox();
            this.dosyaYoluTxt = new System.Windows.Forms.TextBox();
            this.agacaAktarBtn = new System.Windows.Forms.Button();
            this.KelimeleriGetirBtn = new System.Windows.Forms.Button();
            this.kelimeLb = new System.Windows.Forms.ListBox();
            this.hashBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // metinYukleBtn
            // 
            this.metinYukleBtn.Location = new System.Drawing.Point(12, 143);
            this.metinYukleBtn.Name = "metinYukleBtn";
            this.metinYukleBtn.Size = new System.Drawing.Size(175, 29);
            this.metinYukleBtn.TabIndex = 0;
            this.metinYukleBtn.Text = "Metin Yükle";
            this.metinYukleBtn.UseVisualStyleBackColor = true;
            this.metinYukleBtn.Click += new System.EventHandler(this.metinYukleBtn_Click);
            // 
            // stackeOkuBtn
            // 
            this.stackeOkuBtn.Location = new System.Drawing.Point(524, 142);
            this.stackeOkuBtn.Name = "stackeOkuBtn";
            this.stackeOkuBtn.Size = new System.Drawing.Size(175, 29);
            this.stackeOkuBtn.TabIndex = 1;
            this.stackeOkuBtn.Text = "Stack’e Oku";
            this.stackeOkuBtn.UseVisualStyleBackColor = true;
            this.stackeOkuBtn.Click += new System.EventHandler(this.stackeOkuBtn_Click);
            // 
            // cumleLb
            // 
            this.cumleLb.ColumnWidth = 25;
            this.cumleLb.FormattingEnabled = true;
            this.cumleLb.HorizontalScrollbar = true;
            this.cumleLb.ItemHeight = 20;
            this.cumleLb.Location = new System.Drawing.Point(12, 12);
            this.cumleLb.Name = "cumleLb";
            this.cumleLb.Size = new System.Drawing.Size(687, 124);
            this.cumleLb.TabIndex = 2;
            // 
            // dosyaYoluTxt
            // 
            this.dosyaYoluTxt.Location = new System.Drawing.Point(193, 144);
            this.dosyaYoluTxt.Name = "dosyaYoluTxt";
            this.dosyaYoluTxt.PlaceholderText = "Dosya Yolu";
            this.dosyaYoluTxt.Size = new System.Drawing.Size(325, 27);
            this.dosyaYoluTxt.TabIndex = 3;
            // 
            // agacaAktarBtn
            // 
            this.agacaAktarBtn.Location = new System.Drawing.Point(12, 229);
            this.agacaAktarBtn.Name = "agacaAktarBtn";
            this.agacaAktarBtn.Size = new System.Drawing.Size(175, 29);
            this.agacaAktarBtn.TabIndex = 4;
            this.agacaAktarBtn.Text = "Ağaca Aktar";
            this.agacaAktarBtn.UseVisualStyleBackColor = true;
            this.agacaAktarBtn.Click += new System.EventHandler(this.agacaAktarBtn_Click);
            // 
            // KelimeleriGetirBtn
            // 
            this.KelimeleriGetirBtn.Location = new System.Drawing.Point(193, 229);
            this.KelimeleriGetirBtn.Name = "KelimeleriGetirBtn";
            this.KelimeleriGetirBtn.Size = new System.Drawing.Size(325, 29);
            this.KelimeleriGetirBtn.TabIndex = 5;
            this.KelimeleriGetirBtn.Text = "En Sık Kullanılan Kelimeleri Getir";
            this.KelimeleriGetirBtn.UseVisualStyleBackColor = true;
            this.KelimeleriGetirBtn.Click += new System.EventHandler(this.KelimeleriGetirBtn_Click);
            // 
            // kelimeLb
            // 
            this.kelimeLb.ColumnWidth = 25;
            this.kelimeLb.FormattingEnabled = true;
            this.kelimeLb.HorizontalScrollbar = true;
            this.kelimeLb.ItemHeight = 20;
            this.kelimeLb.Location = new System.Drawing.Point(193, 275);
            this.kelimeLb.Name = "kelimeLb";
            this.kelimeLb.Size = new System.Drawing.Size(325, 124);
            this.kelimeLb.TabIndex = 6;
            // 
            // hashBtn
            // 
            this.hashBtn.Location = new System.Drawing.Point(524, 229);
            this.hashBtn.Name = "hashBtn";
            this.hashBtn.Size = new System.Drawing.Size(175, 29);
            this.hashBtn.TabIndex = 7;
            this.hashBtn.Text = "Hash Tablo Oluştur";
            this.hashBtn.UseVisualStyleBackColor = true;
            this.hashBtn.Click += new System.EventHandler(this.hashBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 484);
            this.Controls.Add(this.hashBtn);
            this.Controls.Add(this.kelimeLb);
            this.Controls.Add(this.KelimeleriGetirBtn);
            this.Controls.Add(this.agacaAktarBtn);
            this.Controls.Add(this.dosyaYoluTxt);
            this.Controls.Add(this.cumleLb);
            this.Controls.Add(this.stackeOkuBtn);
            this.Controls.Add(this.metinYukleBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button metinYukleBtn;
        private System.Windows.Forms.Button stackeOkuBtn;
        private System.Windows.Forms.ListBox cumleLb;
        private System.Windows.Forms.TextBox dosyaYoluTxt;
        private System.Windows.Forms.Button agacaAktarBtn;
        private System.Windows.Forms.Button KelimeleriGetirBtn;
        private System.Windows.Forms.ListBox kelimeLb;
        private System.Windows.Forms.Button hashBtn;
    }
}
