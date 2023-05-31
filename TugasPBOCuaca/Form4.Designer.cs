namespace TugasPBOCuaca
{
    partial class Input
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
            this.btn_iya = new System.Windows.Forms.Button();
            this.btn_tidak = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_iya
            // 
            this.btn_iya.Location = new System.Drawing.Point(117, 158);
            this.btn_iya.Name = "btn_iya";
            this.btn_iya.Size = new System.Drawing.Size(75, 32);
            this.btn_iya.TabIndex = 0;
            this.btn_iya.Text = "Iya";
            this.btn_iya.UseVisualStyleBackColor = true;
            this.btn_iya.Click += new System.EventHandler(this.btn_iya_Click);
            // 
            // btn_tidak
            // 
            this.btn_tidak.Location = new System.Drawing.Point(260, 158);
            this.btn_tidak.Name = "btn_tidak";
            this.btn_tidak.Size = new System.Drawing.Size(75, 32);
            this.btn_tidak.TabIndex = 1;
            this.btn_tidak.Text = "Tidak";
            this.btn_tidak.UseVisualStyleBackColor = true;
            this.btn_tidak.Click += new System.EventHandler(this.btn_tidak_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingin memasukkan barang lain?";
            // 
            // Input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 263);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_tidak);
            this.Controls.Add(this.btn_iya);
            this.Name = "Input";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_iya;
        private System.Windows.Forms.Button btn_tidak;
        private System.Windows.Forms.Label label1;
    }
}