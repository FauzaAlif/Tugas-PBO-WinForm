namespace TugasPBOCuaca
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_stok = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_harga = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_namalaptop = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_IDlaptop = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lab_sunrise = new System.Windows.Forms.Label();
            this.lab_sunset = new System.Windows.Forms.Label();
            this.lab_wind = new System.Windows.Forms.Label();
            this.lab_pressue = new System.Windows.Forms.Label();
            this.lab_Condition = new System.Windows.Forms.Label();
            this.lab_detail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TbCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_IDtransaksi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_insertTransaksi = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labTemp = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Location = new System.Drawing.Point(-4, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1190, 666);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.btn_delete);
            this.tabPage2.Controls.Add(this.btn_update);
            this.tabPage2.Controls.Add(this.btn_insert);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.tb_stok);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tb_harga);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tb_namalaptop);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tb_IDlaptop);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1182, 637);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Laptop";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(473, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(706, 637);
            this.dataGridView1.TabIndex = 11;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(346, 579);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(81, 35);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(343, 279);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(84, 35);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(225, 279);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(86, 35);
            this.btn_insert.TabIndex = 8;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Stok";
            // 
            // tb_stok
            // 
            this.tb_stok.Location = new System.Drawing.Point(132, 217);
            this.tb_stok.Name = "tb_stok";
            this.tb_stok.Size = new System.Drawing.Size(295, 22);
            this.tb_stok.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Harga Laptop";
            // 
            // tb_harga
            // 
            this.tb_harga.Location = new System.Drawing.Point(132, 155);
            this.tb_harga.Name = "tb_harga";
            this.tb_harga.Size = new System.Drawing.Size(295, 22);
            this.tb_harga.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nama Laptop";
            // 
            // tb_namalaptop
            // 
            this.tb_namalaptop.Location = new System.Drawing.Point(132, 92);
            this.tb_namalaptop.Name = "tb_namalaptop";
            this.tb_namalaptop.Size = new System.Drawing.Size(295, 22);
            this.tb_namalaptop.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "ID Laptop";
            // 
            // tb_IDlaptop
            // 
            this.tb_IDlaptop.Location = new System.Drawing.Point(132, 28);
            this.tb_IDlaptop.Name = "tb_IDlaptop";
            this.tb_IDlaptop.Size = new System.Drawing.Size(295, 22);
            this.tb_IDlaptop.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.btn_insertTransaksi);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.tb_IDtransaksi);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1182, 637);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Transaksi";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView3);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1182, 637);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Detail";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Silver;
            this.tabPage1.Controls.Add(this.labTemp);
            this.tabPage1.Controls.Add(this.lab_sunrise);
            this.tabPage1.Controls.Add(this.lab_sunset);
            this.tabPage1.Controls.Add(this.lab_wind);
            this.tabPage1.Controls.Add(this.lab_pressue);
            this.tabPage1.Controls.Add(this.lab_Condition);
            this.tabPage1.Controls.Add(this.lab_detail);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btn_search);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.TbCity);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1182, 637);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cuaca";
            // 
            // lab_sunrise
            // 
            this.lab_sunrise.AutoSize = true;
            this.lab_sunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lab_sunrise.Location = new System.Drawing.Point(260, 364);
            this.lab_sunrise.Name = "lab_sunrise";
            this.lab_sunrise.Size = new System.Drawing.Size(46, 25);
            this.lab_sunrise.TabIndex = 27;
            this.lab_sunrise.Text = "N/A";
            // 
            // lab_sunset
            // 
            this.lab_sunset.AutoSize = true;
            this.lab_sunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lab_sunset.Location = new System.Drawing.Point(260, 415);
            this.lab_sunset.Name = "lab_sunset";
            this.lab_sunset.Size = new System.Drawing.Size(46, 25);
            this.lab_sunset.TabIndex = 26;
            this.lab_sunset.Text = "N/A";
            // 
            // lab_wind
            // 
            this.lab_wind.AutoSize = true;
            this.lab_wind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lab_wind.Location = new System.Drawing.Point(611, 240);
            this.lab_wind.Name = "lab_wind";
            this.lab_wind.Size = new System.Drawing.Size(46, 25);
            this.lab_wind.TabIndex = 25;
            this.lab_wind.Text = "N/A";
            // 
            // lab_pressue
            // 
            this.lab_pressue.AutoSize = true;
            this.lab_pressue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lab_pressue.Location = new System.Drawing.Point(611, 281);
            this.lab_pressue.Name = "lab_pressue";
            this.lab_pressue.Size = new System.Drawing.Size(46, 25);
            this.lab_pressue.TabIndex = 24;
            this.lab_pressue.Text = "N/A";
            // 
            // lab_Condition
            // 
            this.lab_Condition.AutoSize = true;
            this.lab_Condition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Condition.Location = new System.Drawing.Point(45, 281);
            this.lab_Condition.Name = "lab_Condition";
            this.lab_Condition.Size = new System.Drawing.Size(77, 25);
            this.lab_Condition.TabIndex = 23;
            this.lab_Condition.Text = "Kondisi";
            // 
            // lab_detail
            // 
            this.lab_detail.AutoSize = true;
            this.lab_detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_detail.Location = new System.Drawing.Point(45, 322);
            this.lab_detail.Name = "lab_detail";
            this.lab_detail.Size = new System.Drawing.Size(61, 25);
            this.lab_detail.TabIndex = 22;
            this.lab_detail.Text = "Detail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(45, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 21;
            this.label5.Text = "Matahari Terbit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(45, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 25);
            this.label4.TabIndex = 20;
            this.label4.Text = "Matahari Terbenam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(388, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Kecepatan Angin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(388, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Tekanan";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(328, 68);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 17;
            this.btn_search.Text = "Cari";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(48, 118);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 90);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // TbCity
            // 
            this.TbCity.Location = new System.Drawing.Point(118, 68);
            this.TbCity.Name = "TbCity";
            this.TbCity.Size = new System.Drawing.Size(193, 22);
            this.TbCity.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(45, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Kota";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID_Laptop";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nama_Laptop";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Harga_Laptop";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Stok";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // tb_IDtransaksi
            // 
            this.tb_IDtransaksi.Location = new System.Drawing.Point(132, 25);
            this.tb_IDtransaksi.Name = "tb_IDtransaksi";
            this.tb_IDtransaksi.Size = new System.Drawing.Size(215, 22);
            this.tb_IDtransaksi.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "ID Transaksi";
            // 
            // btn_insertTransaksi
            // 
            this.btn_insertTransaksi.Location = new System.Drawing.Point(240, 66);
            this.btn_insertTransaksi.Name = "btn_insertTransaksi";
            this.btn_insertTransaksi.Size = new System.Drawing.Size(107, 32);
            this.btn_insertTransaksi.TabIndex = 8;
            this.btn_insertTransaksi.Text = "Upload";
            this.btn_insertTransaksi.UseVisualStyleBackColor = true;
            this.btn_insertTransaksi.Click += new System.EventHandler(this.btn_insertTransaksi_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6});
            this.dataGridView2.Location = new System.Drawing.Point(509, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(673, 631);
            this.dataGridView2.TabIndex = 10;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ID_Transaksi";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tanggal_Transaksi";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridView3.Location = new System.Drawing.Point(12, 16);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1157, 607);
            this.dataGridView3.TabIndex = 0;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "ID_Detail_Transaksi";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ID_Transaksi";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "ID_Laptop";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Stok_Dibeli";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            // 
            // labTemp
            // 
            this.labTemp.AutoSize = true;
            this.labTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTemp.Location = new System.Drawing.Point(45, 240);
            this.labTemp.Name = "labTemp";
            this.labTemp.Size = new System.Drawing.Size(113, 25);
            this.labTemp.TabIndex = 28;
            this.labTemp.Text = "Temperatur";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1182, 658);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lab_sunrise;
        private System.Windows.Forms.Label lab_sunset;
        private System.Windows.Forms.Label lab_wind;
        private System.Windows.Forms.Label lab_pressue;
        private System.Windows.Forms.Label lab_Condition;
        private System.Windows.Forms.Label lab_detail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TbCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_IDlaptop;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_stok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_harga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_namalaptop;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_IDtransaksi;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btn_insertTransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Label labTemp;
    }
}

