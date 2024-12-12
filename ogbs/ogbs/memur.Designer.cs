namespace ogbs
{
    partial class memur
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.derstablosu = new System.Windows.Forms.DataGridView();
            this.ogrencitablosu = new System.Windows.Forms.DataGridView();
            this.textogrenciadi = new System.Windows.Forms.TextBox();
            this.textogrencisoyadi = new System.Windows.Forms.TextBox();
            this.textgano = new System.Windows.Forms.TextBox();
            this.textdersadi = new System.Windows.Forms.TextBox();
            this.textderskodu = new System.Windows.Forms.TextBox();
            this.textderskredisi = new System.Windows.Forms.TextBox();
            this.btnogrencikaydet = new System.Windows.Forms.Button();
            this.btnderskaydet = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textkontenjan = new System.Windows.Forms.TextBox();
            this.ogrenciBilgiSistemiDataSet = new ogbs.OgrenciBilgiSistemiDataSet();
            this.ogrenciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciTableAdapter = new ogbs.OgrenciBilgiSistemiDataSetTableAdapters.OgrenciTableAdapter();
            this.ogrenciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ganoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aldigiDerslerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toplamKrediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dersTableAdapter = new ogbs.OgrenciBilgiSistemiDataSetTableAdapters.DersTableAdapter();
            this.dersIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.krediDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kontenjanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.derstablosu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencitablosu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBilgiSistemiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 379);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Ekleme";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ders Ekeleme";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ADI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 481);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "SOYADI";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 533);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "GANO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "ADI";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "KODU";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "KREDİSİ";
            // 
            // derstablosu
            // 
            this.derstablosu.AutoGenerateColumns = false;
            this.derstablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.derstablosu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dersIDDataGridViewTextBoxColumn,
            this.dersAdiDataGridViewTextBoxColumn,
            this.dersKoduDataGridViewTextBoxColumn,
            this.krediDataGridViewTextBoxColumn,
            this.kontenjanDataGridViewTextBoxColumn});
            this.derstablosu.DataSource = this.dersBindingSource;
            this.derstablosu.Location = new System.Drawing.Point(362, 86);
            this.derstablosu.Name = "derstablosu";
            this.derstablosu.RowHeadersWidth = 51;
            this.derstablosu.RowTemplate.Height = 24;
            this.derstablosu.Size = new System.Drawing.Size(678, 215);
            this.derstablosu.TabIndex = 8;
            this.derstablosu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.derstablosu_CellContentClick);
            // 
            // ogrencitablosu
            // 
            this.ogrencitablosu.AutoGenerateColumns = false;
            this.ogrencitablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogrencitablosu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogrenciIDDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.ganoDataGridViewTextBoxColumn,
            this.aldigiDerslerDataGridViewTextBoxColumn,
            this.toplamKrediDataGridViewTextBoxColumn});
            this.ogrencitablosu.DataSource = this.ogrenciBindingSource;
            this.ogrencitablosu.Location = new System.Drawing.Point(332, 379);
            this.ogrencitablosu.Name = "ogrencitablosu";
            this.ogrencitablosu.RowHeadersWidth = 51;
            this.ogrencitablosu.RowTemplate.Height = 24;
            this.ogrencitablosu.Size = new System.Drawing.Size(803, 215);
            this.ogrencitablosu.TabIndex = 9;
            this.ogrencitablosu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ogrencitablosu_CellContentClick);
            // 
            // textogrenciadi
            // 
            this.textogrenciadi.Location = new System.Drawing.Point(122, 435);
            this.textogrenciadi.Name = "textogrenciadi";
            this.textogrenciadi.Size = new System.Drawing.Size(100, 22);
            this.textogrenciadi.TabIndex = 10;
            this.textogrenciadi.TextChanged += new System.EventHandler(this.textogrenciadi_TextChanged);
            // 
            // textogrencisoyadi
            // 
            this.textogrencisoyadi.Location = new System.Drawing.Point(122, 478);
            this.textogrencisoyadi.Name = "textogrencisoyadi";
            this.textogrencisoyadi.Size = new System.Drawing.Size(100, 22);
            this.textogrencisoyadi.TabIndex = 11;
            this.textogrencisoyadi.TextChanged += new System.EventHandler(this.textogrencisoyadi_TextChanged);
            // 
            // textgano
            // 
            this.textgano.Location = new System.Drawing.Point(122, 527);
            this.textgano.Name = "textgano";
            this.textgano.Size = new System.Drawing.Size(100, 22);
            this.textgano.TabIndex = 12;
            this.textgano.TextChanged += new System.EventHandler(this.textgano_TextChanged);
            // 
            // textdersadi
            // 
            this.textdersadi.Location = new System.Drawing.Point(155, 124);
            this.textdersadi.Name = "textdersadi";
            this.textdersadi.Size = new System.Drawing.Size(100, 22);
            this.textdersadi.TabIndex = 13;
            this.textdersadi.TextChanged += new System.EventHandler(this.textdersadi_TextChanged);
            // 
            // textderskodu
            // 
            this.textderskodu.Location = new System.Drawing.Point(155, 166);
            this.textderskodu.Name = "textderskodu";
            this.textderskodu.Size = new System.Drawing.Size(100, 22);
            this.textderskodu.TabIndex = 14;
            this.textderskodu.TextChanged += new System.EventHandler(this.textderskodu_TextChanged);
            // 
            // textderskredisi
            // 
            this.textderskredisi.Location = new System.Drawing.Point(155, 209);
            this.textderskredisi.Name = "textderskredisi";
            this.textderskredisi.Size = new System.Drawing.Size(100, 22);
            this.textderskredisi.TabIndex = 15;
            this.textderskredisi.TextChanged += new System.EventHandler(this.textderskredisi_TextChanged);
            // 
            // btnogrencikaydet
            // 
            this.btnogrencikaydet.Location = new System.Drawing.Point(112, 572);
            this.btnogrencikaydet.Name = "btnogrencikaydet";
            this.btnogrencikaydet.Size = new System.Drawing.Size(110, 42);
            this.btnogrencikaydet.TabIndex = 16;
            this.btnogrencikaydet.Text = "Kaydet";
            this.btnogrencikaydet.UseVisualStyleBackColor = true;
            this.btnogrencikaydet.Click += new System.EventHandler(this.btnogrencikaydet_Click);
            // 
            // btnderskaydet
            // 
            this.btnderskaydet.Location = new System.Drawing.Point(145, 292);
            this.btnderskaydet.Name = "btnderskaydet";
            this.btnderskaydet.Size = new System.Drawing.Size(110, 42);
            this.btnderskaydet.TabIndex = 17;
            this.btnderskaydet.Text = "Kaydet";
            this.btnderskaydet.UseVisualStyleBackColor = true;
            this.btnderskaydet.Click += new System.EventHandler(this.btnderskaydet_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "KONTENJAN";
            // 
            // textkontenjan
            // 
            this.textkontenjan.Location = new System.Drawing.Point(155, 252);
            this.textkontenjan.Name = "textkontenjan";
            this.textkontenjan.Size = new System.Drawing.Size(100, 22);
            this.textkontenjan.TabIndex = 19;
            this.textkontenjan.TextChanged += new System.EventHandler(this.textkontenjan_TextChanged);
            // 
            // ogrenciBilgiSistemiDataSet
            // 
            this.ogrenciBilgiSistemiDataSet.DataSetName = "OgrenciBilgiSistemiDataSet";
            this.ogrenciBilgiSistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciBindingSource
            // 
            this.ogrenciBindingSource.DataMember = "Ogrenci";
            this.ogrenciBindingSource.DataSource = this.ogrenciBilgiSistemiDataSet;
            // 
            // ogrenciTableAdapter
            // 
            this.ogrenciTableAdapter.ClearBeforeFill = true;
            // 
            // ogrenciIDDataGridViewTextBoxColumn
            // 
            this.ogrenciIDDataGridViewTextBoxColumn.DataPropertyName = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.HeaderText = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciIDDataGridViewTextBoxColumn.Name = "ogrenciIDDataGridViewTextBoxColumn";
            this.ogrenciIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogrenciIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // ganoDataGridViewTextBoxColumn
            // 
            this.ganoDataGridViewTextBoxColumn.DataPropertyName = "Gano";
            this.ganoDataGridViewTextBoxColumn.HeaderText = "Gano";
            this.ganoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ganoDataGridViewTextBoxColumn.Name = "ganoDataGridViewTextBoxColumn";
            this.ganoDataGridViewTextBoxColumn.Width = 125;
            // 
            // aldigiDerslerDataGridViewTextBoxColumn
            // 
            this.aldigiDerslerDataGridViewTextBoxColumn.DataPropertyName = "AldigiDersler";
            this.aldigiDerslerDataGridViewTextBoxColumn.HeaderText = "AldigiDersler";
            this.aldigiDerslerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aldigiDerslerDataGridViewTextBoxColumn.Name = "aldigiDerslerDataGridViewTextBoxColumn";
            this.aldigiDerslerDataGridViewTextBoxColumn.Width = 125;
            // 
            // toplamKrediDataGridViewTextBoxColumn
            // 
            this.toplamKrediDataGridViewTextBoxColumn.DataPropertyName = "ToplamKredi";
            this.toplamKrediDataGridViewTextBoxColumn.HeaderText = "ToplamKredi";
            this.toplamKrediDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.toplamKrediDataGridViewTextBoxColumn.Name = "toplamKrediDataGridViewTextBoxColumn";
            this.toplamKrediDataGridViewTextBoxColumn.Width = 125;
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
            // memur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 626);
            this.Controls.Add(this.textkontenjan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnderskaydet);
            this.Controls.Add(this.btnogrencikaydet);
            this.Controls.Add(this.textderskredisi);
            this.Controls.Add(this.textderskodu);
            this.Controls.Add(this.textdersadi);
            this.Controls.Add(this.textgano);
            this.Controls.Add(this.textogrencisoyadi);
            this.Controls.Add(this.textogrenciadi);
            this.Controls.Add(this.ogrencitablosu);
            this.Controls.Add(this.derstablosu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "memur";
            this.Text = "memur";
            this.Load += new System.EventHandler(this.memur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.derstablosu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencitablosu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBilgiSistemiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView derstablosu;
        private System.Windows.Forms.DataGridView ogrencitablosu;
        private System.Windows.Forms.TextBox textogrenciadi;
        private System.Windows.Forms.TextBox textogrencisoyadi;
        private System.Windows.Forms.TextBox textgano;
        private System.Windows.Forms.TextBox textdersadi;
        private System.Windows.Forms.TextBox textderskodu;
        private System.Windows.Forms.TextBox textderskredisi;
        private System.Windows.Forms.Button btnogrencikaydet;
        private System.Windows.Forms.Button btnderskaydet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textkontenjan;
        private OgrenciBilgiSistemiDataSet ogrenciBilgiSistemiDataSet;
        private System.Windows.Forms.BindingSource ogrenciBindingSource;
        private OgrenciBilgiSistemiDataSetTableAdapters.OgrenciTableAdapter ogrenciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ganoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aldigiDerslerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn toplamKrediDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dersBindingSource;
        private OgrenciBilgiSistemiDataSetTableAdapters.DersTableAdapter dersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn krediDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kontenjanDataGridViewTextBoxColumn;
    }
}