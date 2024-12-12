namespace ogbs
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
            this.btnogrenci = new System.Windows.Forms.Button();
            this.btnogretmen = new System.Windows.Forms.Button();
            this.btnmemur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnogrenci
            // 
            this.btnogrenci.Location = new System.Drawing.Point(352, 102);
            this.btnogrenci.Name = "btnogrenci";
            this.btnogrenci.Size = new System.Drawing.Size(111, 39);
            this.btnogrenci.TabIndex = 0;
            this.btnogrenci.Text = "Öğrenci";
            this.btnogrenci.UseVisualStyleBackColor = true;
            this.btnogrenci.Click += new System.EventHandler(this.btnogrenci_Click);
            // 
            // btnogretmen
            // 
            this.btnogretmen.Location = new System.Drawing.Point(352, 185);
            this.btnogretmen.Name = "btnogretmen";
            this.btnogretmen.Size = new System.Drawing.Size(111, 39);
            this.btnogretmen.TabIndex = 1;
            this.btnogretmen.Text = "Öğretmen";
            this.btnogretmen.UseVisualStyleBackColor = true;
            this.btnogretmen.Click += new System.EventHandler(this.btnogretmen_Click);
            // 
            // btnmemur
            // 
            this.btnmemur.Location = new System.Drawing.Point(352, 268);
            this.btnmemur.Name = "btnmemur";
            this.btnmemur.Size = new System.Drawing.Size(111, 39);
            this.btnmemur.TabIndex = 2;
            this.btnmemur.Text = "Memur";
            this.btnmemur.UseVisualStyleBackColor = true;
            this.btnmemur.Click += new System.EventHandler(this.btnmemur_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnmemur);
            this.Controls.Add(this.btnogretmen);
            this.Controls.Add(this.btnogrenci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnogrenci;
        private System.Windows.Forms.Button btnogretmen;
        private System.Windows.Forms.Button btnmemur;
    }
}

