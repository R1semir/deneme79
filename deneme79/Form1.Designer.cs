namespace deneme79
{
    partial class Form1
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTur = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPuan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtResim = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.dbFilmArsiviDataSet = new deneme79.DbFilmArsiviDataSet();
            this.tblFimlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_FimlerTableAdapter = new deneme79.DbFilmArsiviDataSetTableAdapters.Tbl_FimlerTableAdapter();
            this.filmidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmTurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmPuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmKategoriDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.filmResimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFilmArsiviDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFimlerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(104, 69);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(132, 26);
            this.txtAd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Film Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Türü:";
            // 
            // txtTur
            // 
            this.txtTur.Location = new System.Drawing.Point(104, 105);
            this.txtTur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTur.Name = "txtTur";
            this.txtTur.Size = new System.Drawing.Size(132, 26);
            this.txtTur.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 177);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Kategori:";
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(104, 177);
            this.txtKategori.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(132, 26);
            this.txtKategori.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Puanı:";
            // 
            // txtPuan
            // 
            this.txtPuan.Location = new System.Drawing.Point(104, 141);
            this.txtPuan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPuan.Name = "txtPuan";
            this.txtPuan.Size = new System.Drawing.Size(132, 26);
            this.txtPuan.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Resim:";
            // 
            // txtResim
            // 
            this.txtResim.Location = new System.Drawing.Point(104, 225);
            this.txtResim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResim.Name = "txtResim";
            this.txtResim.Size = new System.Drawing.Size(95, 26);
            this.txtResim.TabIndex = 8;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnKaydet.Location = new System.Drawing.Point(104, 259);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(95, 45);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(206, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 24);
            this.button3.TabIndex = 12;
            this.button3.Text = "...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(272, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmidDataGridViewTextBoxColumn,
            this.filmAdDataGridViewTextBoxColumn,
            this.filmTurDataGridViewTextBoxColumn,
            this.filmPuanDataGridViewTextBoxColumn,
            this.filmKategoriDataGridViewCheckBoxColumn,
            this.filmResimDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblFimlerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 343);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(654, 161);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 17);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Film id:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(104, 14);
            this.txtid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(132, 26);
            this.txtid.TabIndex = 15;
            // 
            // dbFilmArsiviDataSet
            // 
            this.dbFilmArsiviDataSet.DataSetName = "DbFilmArsiviDataSet";
            this.dbFilmArsiviDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblFimlerBindingSource
            // 
            this.tblFimlerBindingSource.DataMember = "Tbl_Fimler";
            this.tblFimlerBindingSource.DataSource = this.dbFilmArsiviDataSet;
            // 
            // tbl_FimlerTableAdapter
            // 
            this.tbl_FimlerTableAdapter.ClearBeforeFill = true;
            // 
            // filmidDataGridViewTextBoxColumn
            // 
            this.filmidDataGridViewTextBoxColumn.DataPropertyName = "Filmid";
            this.filmidDataGridViewTextBoxColumn.HeaderText = "Filmid";
            this.filmidDataGridViewTextBoxColumn.Name = "filmidDataGridViewTextBoxColumn";
            this.filmidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmAdDataGridViewTextBoxColumn
            // 
            this.filmAdDataGridViewTextBoxColumn.DataPropertyName = "FilmAd";
            this.filmAdDataGridViewTextBoxColumn.HeaderText = "FilmAd";
            this.filmAdDataGridViewTextBoxColumn.Name = "filmAdDataGridViewTextBoxColumn";
            // 
            // filmTurDataGridViewTextBoxColumn
            // 
            this.filmTurDataGridViewTextBoxColumn.DataPropertyName = "FilmTur";
            this.filmTurDataGridViewTextBoxColumn.HeaderText = "FilmTur";
            this.filmTurDataGridViewTextBoxColumn.Name = "filmTurDataGridViewTextBoxColumn";
            // 
            // filmPuanDataGridViewTextBoxColumn
            // 
            this.filmPuanDataGridViewTextBoxColumn.DataPropertyName = "FilmPuan";
            this.filmPuanDataGridViewTextBoxColumn.HeaderText = "FilmPuan";
            this.filmPuanDataGridViewTextBoxColumn.Name = "filmPuanDataGridViewTextBoxColumn";
            // 
            // filmKategoriDataGridViewCheckBoxColumn
            // 
            this.filmKategoriDataGridViewCheckBoxColumn.DataPropertyName = "FilmKategori";
            this.filmKategoriDataGridViewCheckBoxColumn.HeaderText = "FilmKategori";
            this.filmKategoriDataGridViewCheckBoxColumn.Name = "filmKategoriDataGridViewCheckBoxColumn";
            // 
            // filmResimDataGridViewTextBoxColumn
            // 
            this.filmResimDataGridViewTextBoxColumn.DataPropertyName = "FilmResim";
            this.filmResimDataGridViewTextBoxColumn.HeaderText = "FilmResim";
            this.filmResimDataGridViewTextBoxColumn.Name = "filmResimDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(678, 516);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtResim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKategori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPuan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAd);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFilmArsiviDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFimlerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPuan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtResim;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtid;
        private DbFilmArsiviDataSet dbFilmArsiviDataSet;
        private System.Windows.Forms.BindingSource tblFimlerBindingSource;
        private DbFilmArsiviDataSetTableAdapters.Tbl_FimlerTableAdapter tbl_FimlerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmTurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmPuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn filmKategoriDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmResimDataGridViewTextBoxColumn;
    }
}

