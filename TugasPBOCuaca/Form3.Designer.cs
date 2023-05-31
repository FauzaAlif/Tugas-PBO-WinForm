namespace TugasPBOCuaca
{
    partial class DetailTransaksi
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
            this.label13 = new System.Windows.Forms.Label();
            this.tb_Jumlah = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_IDlaptop2 = new System.Windows.Forms.TextBox();
            this.btn_insertTransaksi2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_IDTransaksi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(27, 96);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 16);
            this.label13.TabIndex = 22;
            this.label13.Text = "Jumlah";
            // 
            // tb_Jumlah
            // 
            this.tb_Jumlah.Location = new System.Drawing.Point(133, 96);
            this.tb_Jumlah.Name = "tb_Jumlah";
            this.tb_Jumlah.Size = new System.Drawing.Size(215, 22);
            this.tb_Jumlah.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 16);
            this.label11.TabIndex = 20;
            this.label11.Text = "ID Laptop";
            // 
            // tb_IDlaptop2
            // 
            this.tb_IDlaptop2.Location = new System.Drawing.Point(133, 59);
            this.tb_IDlaptop2.Name = "tb_IDlaptop2";
            this.tb_IDlaptop2.Size = new System.Drawing.Size(215, 22);
            this.tb_IDlaptop2.TabIndex = 1;
            // 
            // btn_insertTransaksi2
            // 
            this.btn_insertTransaksi2.Location = new System.Drawing.Point(191, 158);
            this.btn_insertTransaksi2.Name = "btn_insertTransaksi2";
            this.btn_insertTransaksi2.Size = new System.Drawing.Size(93, 39);
            this.btn_insertTransaksi2.TabIndex = 23;
            this.btn_insertTransaksi2.Text = "Insert";
            this.btn_insertTransaksi2.UseVisualStyleBackColor = true;
            this.btn_insertTransaksi2.Click += new System.EventHandler(this.btn_insertTransaksi2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID Transaksi";
            // 
            // tb_IDTransaksi
            // 
            this.tb_IDTransaksi.Location = new System.Drawing.Point(133, 21);
            this.tb_IDTransaksi.Name = "tb_IDTransaksi";
            this.tb_IDTransaksi.Size = new System.Drawing.Size(215, 22);
            this.tb_IDTransaksi.TabIndex = 2;
            // 
            // DetailTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 254);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_IDTransaksi);
            this.Controls.Add(this.btn_insertTransaksi2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tb_Jumlah);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb_IDlaptop2);
            this.Name = "DetailTransaksi";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tb_Jumlah;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_IDlaptop2;
        private System.Windows.Forms.Button btn_insertTransaksi2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_IDTransaksi;
    }
}