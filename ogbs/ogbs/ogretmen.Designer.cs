namespace ogbs
{
    partial class ogretmen
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
            this.btnonayla = new System.Windows.Forms.Button();
            this.btnreddet = new System.Windows.Forms.Button();
            this.textbasvuruid = new System.Windows.Forms.TextBox();
            this.textogrenciid = new System.Windows.Forms.TextBox();
            this.textdurumu = new System.Windows.Forms.TextBox();
            this.textdersid = new System.Windows.Forms.TextBox();
            this.basvurutablosu = new System.Windows.Forms.DataGridView();
            this.ogrenciBilgiSistemiDataSet = new ogbs.OgrenciBilgiSistemiDataSet();
            this.basvuruBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.basvuruTableAdapter = new ogbs.OgrenciBilgiSistemiDataSetTableAdapters.BasvuruTableAdapter();
            this.basvuruIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrenciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dersIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıstekTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.basvurutablosu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBilgiSistemiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.basvuruBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ders ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Durumu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Başvuru ID";
            // 
            // btnonayla
            // 
            this.btnonayla.Location = new System.Drawing.Point(112, 245);
            this.btnonayla.Name = "btnonayla";
            this.btnonayla.Size = new System.Drawing.Size(96, 36);
            this.btnonayla.TabIndex = 4;
            this.btnonayla.Text = "Onayla";
            this.btnonayla.UseVisualStyleBackColor = true;
            this.btnonayla.Click += new System.EventHandler(this.btnonayla_Click);
            // 
            // btnreddet
            // 
            this.btnreddet.Location = new System.Drawing.Point(231, 245);
            this.btnreddet.Name = "btnreddet";
            this.btnreddet.Size = new System.Drawing.Size(96, 36);
            this.btnreddet.TabIndex = 5;
            this.btnreddet.Text = "Reddet";
            this.btnreddet.UseVisualStyleBackColor = true;
            this.btnreddet.Click += new System.EventHandler(this.btnreddet_Click);
            // 
            // textbasvuruid
            // 
            this.textbasvuruid.Location = new System.Drawing.Point(144, 343);
            this.textbasvuruid.Name = "textbasvuruid";
            this.textbasvuruid.Size = new System.Drawing.Size(100, 22);
            this.textbasvuruid.TabIndex = 6;
            this.textbasvuruid.TextChanged += new System.EventHandler(this.textbasvuruid_TextChanged);
            // 
            // textogrenciid
            // 
            this.textogrenciid.Location = new System.Drawing.Point(162, 106);
            this.textogrenciid.Name = "textogrenciid";
            this.textogrenciid.Size = new System.Drawing.Size(100, 22);
            this.textogrenciid.TabIndex = 7;
            this.textogrenciid.TextChanged += new System.EventHandler(this.textogrenciid_TextChanged);
            // 
            // textdurumu
            // 
            this.textdurumu.Location = new System.Drawing.Point(162, 197);
            this.textdurumu.Name = "textdurumu";
            this.textdurumu.Size = new System.Drawing.Size(100, 22);
            this.textdurumu.TabIndex = 8;
            this.textdurumu.TextChanged += new System.EventHandler(this.textdurumu_TextChanged);
            // 
            // textdersid
            // 
            this.textdersid.Location = new System.Drawing.Point(162, 153);
            this.textdersid.Name = "textdersid";
            this.textdersid.Size = new System.Drawing.Size(100, 22);
            this.textdersid.TabIndex = 9;
            this.textdersid.TextChanged += new System.EventHandler(this.textdersid_TextChanged);
            // 
            // basvurutablosu
            // 
            this.basvurutablosu.AutoGenerateColumns = false;
            this.basvurutablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.basvurutablosu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.basvuruIDDataGridViewTextBoxColumn,
            this.ogrenciIDDataGridViewTextBoxColumn,
            this.dersIDDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn,
            this.ıstekTuruDataGridViewTextBoxColumn});
            this.basvurutablosu.DataSource = this.basvuruBindingSource;
            this.basvurutablosu.Location = new System.Drawing.Point(333, 62);
            this.basvurutablosu.Name = "basvurutablosu";
            this.basvurutablosu.RowHeadersWidth = 51;
            this.basvurutablosu.RowTemplate.Height = 24;
            this.basvurutablosu.Size = new System.Drawing.Size(676, 345);
            this.basvurutablosu.TabIndex = 10;
            this.basvurutablosu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.basvurutablosu_CellContentClick);
            // 
            // ogrenciBilgiSistemiDataSet
            // 
            this.ogrenciBilgiSistemiDataSet.DataSetName = "OgrenciBilgiSistemiDataSet";
            this.ogrenciBilgiSistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // basvuruBindingSource
            // 
            this.basvuruBindingSource.DataMember = "Basvuru";
            this.basvuruBindingSource.DataSource = this.ogrenciBilgiSistemiDataSet;
            // 
            // basvuruTableAdapter
            // 
            this.basvuruTableAdapter.ClearBeforeFill = true;
            // 
            // basvuruIDDataGridViewTextBoxColumn
            // 
            this.basvuruIDDataGridViewTextBoxColumn.DataPropertyName = "BasvuruID";
            this.basvuruIDDataGridViewTextBoxColumn.HeaderText = "BasvuruID";
            this.basvuruIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.basvuruIDDataGridViewTextBoxColumn.Name = "basvuruIDDataGridViewTextBoxColumn";
            this.basvuruIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.basvuruIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrenciIDDataGridViewTextBoxColumn
            // 
            this.ogrenciIDDataGridViewTextBoxColumn.DataPropertyName = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.HeaderText = "OgrenciID";
            this.ogrenciIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrenciIDDataGridViewTextBoxColumn.Name = "ogrenciIDDataGridViewTextBoxColumn";
            this.ogrenciIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // dersIDDataGridViewTextBoxColumn
            // 
            this.dersIDDataGridViewTextBoxColumn.DataPropertyName = "DersID";
            this.dersIDDataGridViewTextBoxColumn.HeaderText = "DersID";
            this.dersIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dersIDDataGridViewTextBoxColumn.Name = "dersIDDataGridViewTextBoxColumn";
            this.dersIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "Durum";
            this.durumDataGridViewTextBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            this.durumDataGridViewTextBoxColumn.Width = 125;
            // 
            // ıstekTuruDataGridViewTextBoxColumn
            // 
            this.ıstekTuruDataGridViewTextBoxColumn.DataPropertyName = "IstekTuru";
            this.ıstekTuruDataGridViewTextBoxColumn.HeaderText = "IstekTuru";
            this.ıstekTuruDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıstekTuruDataGridViewTextBoxColumn.Name = "ıstekTuruDataGridViewTextBoxColumn";
            this.ıstekTuruDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 477);
            this.Controls.Add(this.basvurutablosu);
            this.Controls.Add(this.textdersid);
            this.Controls.Add(this.textdurumu);
            this.Controls.Add(this.textogrenciid);
            this.Controls.Add(this.textbasvuruid);
            this.Controls.Add(this.btnreddet);
            this.Controls.Add(this.btnonayla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ogretmen";
            this.Text = "ogretmen";
            this.Load += new System.EventHandler(this.ogretmen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.basvurutablosu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciBilgiSistemiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.basvuruBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnonayla;
        private System.Windows.Forms.Button btnreddet;
        private System.Windows.Forms.TextBox textbasvuruid;
        private System.Windows.Forms.TextBox textogrenciid;
        private System.Windows.Forms.TextBox textdurumu;
        private System.Windows.Forms.TextBox textdersid;
        private System.Windows.Forms.DataGridView basvurutablosu;
        private OgrenciBilgiSistemiDataSet ogrenciBilgiSistemiDataSet;
        private System.Windows.Forms.BindingSource basvuruBindingSource;
        private OgrenciBilgiSistemiDataSetTableAdapters.BasvuruTableAdapter basvuruTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn basvuruIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrenciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dersIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıstekTuruDataGridViewTextBoxColumn;
    }
}