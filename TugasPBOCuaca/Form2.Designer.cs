namespace TugasPBOCuaca
{
    partial class Form2
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
            this.label6 = new System.Windows.Forms.Label();
            this.btn_delete2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(200, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 29);
            this.label6.TabIndex = 2;
            this.label6.Text = "ID Laptop";
            // 
            // btn_delete2
            // 
            this.btn_delete2.Location = new System.Drawing.Point(224, 156);
            this.btn_delete2.Name = "btn_delete2";
            this.btn_delete2.Size = new System.Drawing.Size(75, 23);
            this.btn_delete2.TabIndex = 4;
            this.btn_delete2.Text = "Delete";
            this.btn_delete2.UseVisualStyleBackColor = true;
            this.btn_delete2.Click += new System.EventHandler(this.btn_delete2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.textBox1.Location = new System.Drawing.Point(137, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 34);
            this.textBox1.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_delete2);
            this.Controls.Add(this.label6);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_delete2;
        private System.Windows.Forms.TextBox textBox1;
    }
}