namespace ogbs
{
    partial class ogrenci
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btngiris = new System.Windows.Forms.Button();
            this.btndersibul = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textogrenciid = new System.Windows.Forms.TextBox();
            this.textdersid = new System.Windows.Forms.TextBox();
            this.textad = new System.Windows.Forms.TextBox();
            this.textsoyad = new System.Windows.Forms.TextBox();
            this.textdersadı = new System.Windows.Forms.TextBox();
            this.textderskodu = new System.Windows.Forms.TextBox();
            this.textderskredisi = new System.Windows.Forms.TextBox();
            this.textderskontenjanı = new System.Windows.Forms.TextBox();
            this.btnekle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textgano = new System.Windows.Forms.TextBox();
            this.ogrencitablosu = new System.Windows.Forms.DataGridView();
            this.ogrenciBilgiSistemiDataSet = new ogbs.OgrenciBilgiSistemiDataSet();
            this.dersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dersTableAdapter = new ogbs.OgrenciBilgiSistemiDataSetTableAdapters.DersTableAdapter();
            this.dersIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.krediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontenjanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencitablosu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBilgiSistemiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ders Id";
            // 
            // btngiris
            // 
            this.btngiris.Location = new System.Drawing.Point(250, 54);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(75, 23);
            this.btngiris.TabIndex = 2;
            this.btngiris.Text = "Giriş";
            this.btngiris.UseVisualStyleBackColor = true;
            this.btngiris.Click += new System.EventHandler(this.btngiris_Click);
            // 
            // btndersibul
            // 
            this.btndersibul.Location = new System.Drawing.Point(250, 97);
            this.btndersibul.Name = "btndersibul";
            this.btndersibul.Size = new System.Drawing.Size(75, 23);
            this.btndersibul.TabIndex = 3;
            this.btndersibul.Text = "Dersi Bul";
            this.btndersibul.UseVisualStyleBackColor = true;
            this.btndersibul.Click += new System.EventHandler(this.btndersibul_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "AD:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "SOYAD:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "DERS ADI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "DERS KODU:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "DERS KREDİSİ:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "DERS KONTENJANI:";
            // 
            // textogrenciid
            // 
            this.textogrenciid.Location = new System.Drawing.Point(144, 55);
            this.textogrenciid.Name = "textogrenciid";
            this.textogrenciid.Size = new System.Drawing.Size(100, 22);
            this.textogrenciid.TabIndex = 10;
            this.textogrenciid.TextChanged += new System.EventHandler(this.textogrenciid_TextChanged);
            // 
            // textdersid
            // 
            this.textdersid.Location = new System.Drawing.Point(144, 100);
            this.textdersid.Name = "textdersid";
            this.textdersid.Size = new System.Drawing.Size(100, 22);
            this.textdersid.TabIndex = 11;
            this.textdersid.TextChanged += new System.EventHandler(this.textdersid_TextChanged);
            // 
            // textad
            // 
            this.textad.Location = new System.Drawing.Point(225, 159);
            this.textad.Name = "textad";
            this.textad.Size = new System.Drawing.Size(100, 22);
            this.textad.TabIndex = 12;
            // 
            // textsoyad
            // 
            this.textsoyad.Location = new System.Drawing.Point(225, 195);
            this.textsoyad.Name = "textsoyad";
            this.textsoyad.Size = new System.Drawing.Size(100, 22);
            this.textsoyad.TabIndex = 13;
            // 
            // textdersadı
            // 
            this.textdersadı.Location = new System.Drawing.Point(225, 226);
            this.textdersadı.Name = "textdersadı";
            this.textdersadı.Size = new System.Drawing.Size(100, 22);
            this.textdersadı.TabIndex = 14;
            // 
            // textderskodu
            // 
            this.textderskodu.Location = new System.Drawing.Point(225, 257);
            this.textderskodu.Name = "textderskodu";
            this.textderskodu.Size = new System.Drawing.Size(100, 22);
            this.textderskodu.TabIndex = 15;
            // 
            // textderskredisi
            // 
            this.textderskredisi.Location = new System.Drawing.Point(225, 287);
            this.textderskredisi.Name = "textderskredisi";
            this.textderskredisi.Size = new System.Drawing.Size(100, 22);
            this.textderskredisi.TabIndex = 16;
            // 
            // textderskontenjanı
            // 
            this.textderskontenjanı.Location = new System.Drawing.Point(225, 318);
            this.textderskontenjanı.Name = "textderskontenjanı";
            this.textderskontenjanı.Size = new System.Drawing.Size(100, 22);
            this.textderskontenjanı.TabIndex = 17;
            // 
            // btnekle
            // 
            this.btnekle.Location = new System.Drawing.Point(168, 363);
            this.btnekle.Name = "btnekle";
            this.btnekle.Size = new System.Drawing.Size(97, 37);
            this.btnekle.TabIndex = 18;
            this.btnekle.Text = "Ekle";
            this.btnekle.UseVisualStyleBackColor = true;
            this.btnekle.Click += new System.EventHandler(this.btnekle_Click);
            // 
            // btnsil
            // 
            this.btnsil.Location = new System.Drawing.Point(281, 363);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(97, 37);
            this.btnsil.TabIndex = 19;
            this.btnsil.Text = "Sil";
            this.btnsil.UseVisualStyleBackColor = true;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "GANO:";
            // 
            // textgano
            // 
            this.textgano.Location = new System.Drawing.Point(68, 416);
            this.textgano.Name = "textgano";
            this.textgano.Size = new System.Drawing.Size(100, 22);
            this.textgano.TabIndex = 21;
            this.textgano.TextChanged += new System.EventHandler(this.textgano_TextChanged);
            // 
            // ogrencitablosu
            // 
            this.ogrencitablosu.AutoGenerateColumns = false;
            this.ogrencitablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrencitablosu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dersIDDataGridViewTextBoxColumn,
            this.dersAdiDataGridViewTextBoxColumn,
            this.dersKoduDataGridViewTextBoxColumn,
            this.krediDataGridViewTextBoxColumn,
            this.kontenjanDataGridViewTextBoxColumn});
            this.ogrencitablosu.DataSource = this.dersBindingSource;
            this.ogrencitablosu.Location = new System.Drawing.Point(409, 61);
            this.ogrencitablosu.Name = "ogrencitablosu";
            this.ogrencitablosu.RowHeadersWidth = 51;
            this.ogrencitablosu.RowTemplate.Height = 24;
            this.ogrencitablosu.Size = new System.Drawing.Size(675, 225);
            this.ogrencitablosu.TabIndex = 22;
            this.ogrencitablosu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ogrencitablosu_CellContentClick);
            // 
            // ogrenciBilgiSistemiDataSet
            // 
            this.ogrenciBilgiSistemiDataSet.DataSetName = "OgrenciBilgiSistemiDataSet";
            this.ogrenciBilgiSistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dersBindingSource
            // 
            this.dersBindingSource.DataMember = "Ders";
            this.dersBindingSource.DataSource = this.ogrenciBilgiSistemiDataSet;
            // 
            // dersTableAdapter
            // 
            this.dersTableAdapter.ClearBeforeFill = true;
            // 
            // dersIDDataGridViewTextBoxColumn
            // 
            this.dersIDDataGridViewTextBoxColumn.DataPropertyName = "DersID";
            this.dersIDDataGridViewTextBoxColumn.HeaderText = "DersID";
            this.dersIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersIDDataGridViewTextBoxColumn.Name = "dersIDDataGridViewTextBoxColumn";
            this.dersIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.dersIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dersAdiDataGridViewTextBoxColumn
            // 
            this.dersAdiDataGridViewTextBoxColumn.DataPropertyName = "DersAdi";
            this.dersAdiDataGridViewTextBoxColumn.HeaderText = "DersAdi";
            this.dersAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersAdiDataGridViewTextBoxColumn.Name = "dersAdiDataGridViewTextBoxColumn";
            this.dersAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // dersKoduDataGridViewTextBoxColumn
            // 
            this.dersKoduDataGridViewTextBoxColumn.DataPropertyName = "DersKodu";
            this.dersKoduDataGridViewTextBoxColumn.HeaderText = "DersKodu";
            this.dersKoduDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersKoduDataGridViewTextBoxColumn.Name = "dersKoduDataGridViewTextBoxColumn";
            this.dersKoduDataGridViewTextBoxColumn.Width = 125;
            // 
            // krediDataGridViewTextBoxColumn
            // 
            this.krediDataGridViewTextBoxColumn.DataPropertyName = "Kredi";
            this.krediDataGridViewTextBoxColumn.HeaderText = "Kredi";
            this.krediDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.krediDataGridViewTextBoxColumn.Name = "krediDataGridViewTextBoxColumn";
            this.krediDataGridViewTextBoxColumn.Width = 125;
            // 
            // kontenjanDataGridViewTextBoxColumn
            // 
            this.kontenjanDataGridViewTextBoxColumn.DataPropertyName = "Kontenjan";
            this.kontenjanDataGridViewTextBoxColumn.HeaderText = "Kontenjan";
            this.kontenjanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kontenjanDataGridViewTextBoxColumn.Name = "kontenjanDataGridViewTextBoxColumn";
            this.kontenjanDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 450);
            this.Controls.Add(this.ogrencitablosu);
            this.Controls.Add(this.textgano);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnsil);
            this.Controls.Add(this.btnekle);
            this.Controls.Add(this.textderskontenjanı);
            this.Controls.Add(this.textderskredisi);
            this.Controls.Add(this.textderskodu);
            this.Controls.Add(this.textdersadı);
            this.Controls.Add(this.textsoyad);
            this.Controls.Add(this.textad);
            this.Controls.Add(this.textdersid);
            this.Controls.Add(this.textogrenciid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btndersibul);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ogrenci";
            this.Text = "ogrenci";
            this.Load += new System.EventHandler(this.ogrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ogrencitablosu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBilgiSistemiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.Button btndersibul;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textogrenciid;
        private System.Windows.Forms.TextBox textdersid;
        private System.Windows.Forms.TextBox textad;
        private System.Windows.Forms.TextBox textsoyad;
        private System.Windows.Forms.TextBox textdersadı;
        private System.Windows.Forms.TextBox textderskodu;
        private System.Windows.Forms.TextBox textderskredisi;
        private System.Windows.Forms.TextBox textderskontenjanı;
        private System.Windows.Forms.Button btnekle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textgano;
        private System.Windows.Forms.DataGridView ogrencitablosu;
        private OgrenciBilgiSistemiDataSet ogrenciBilgiSistemiDataSet;
        private System.Windows.Forms.BindingSource dersBindingSource;
        private OgrenciBilgiSistemiDataSetTableAdapters.DersTableAdapter dersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn krediDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontenjanDataGridViewTextBoxColumn;
    }
}