namespace WFA_SinemaOtomasyonu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbBay = new System.Windows.Forms.RadioButton();
            this.rbBayan = new System.Windows.Forms.RadioButton();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.txtTCNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKoltukNo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rezervasyon Ekranı";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ad Soyad :";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(77, 99);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(129, 20);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "T.C. No :";
            // 
            // rbBay
            // 
            this.rbBay.AutoSize = true;
            this.rbBay.Location = new System.Drawing.Point(212, 100);
            this.rbBay.Name = "rbBay";
            this.rbBay.Size = new System.Drawing.Size(43, 17);
            this.rbBay.TabIndex = 5;
            this.rbBay.TabStop = true;
            this.rbBay.Text = "Bay";
            this.rbBay.UseVisualStyleBackColor = true;
            // 
            // rbBayan
            // 
            this.rbBayan.AutoSize = true;
            this.rbBayan.Location = new System.Drawing.Point(212, 126);
            this.rbBayan.Name = "rbBayan";
            this.rbBayan.Size = new System.Drawing.Size(55, 17);
            this.rbBayan.TabIndex = 5;
            this.rbBayan.TabStop = true;
            this.rbBayan.Text = "Bayan";
            this.rbBayan.UseVisualStyleBackColor = true;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(192, 156);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(75, 23);
            this.btnOnayla.TabIndex = 6;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.BtnOnayla_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(111, 156);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(75, 23);
            this.btnIptal.TabIndex = 6;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.BtnIptal_Click);
            // 
            // txtTCNo
            // 
            this.txtTCNo.Location = new System.Drawing.Point(77, 125);
            this.txtTCNo.MaxLength = 11;
            this.txtTCNo.Name = "txtTCNo";
            this.txtTCNo.Size = new System.Drawing.Size(129, 20);
            this.txtTCNo.TabIndex = 3;
            this.txtTCNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Koltuk No :";
            // 
            // txtKoltukNo
            // 
            this.txtKoltukNo.Enabled = false;
            this.txtKoltukNo.Location = new System.Drawing.Point(77, 70);
            this.txtKoltukNo.Name = "txtKoltukNo";
            this.txtKoltukNo.Size = new System.Drawing.Size(129, 20);
            this.txtKoltukNo.TabIndex = 3;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 191);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.rbBayan);
            this.Controls.Add(this.rbBay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTCNo);
            this.Controls.Add(this.txtKoltukNo);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rezervasyon Ekranı";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbBay;
        private System.Windows.Forms.RadioButton rbBayan;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.TextBox txtTCNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKoltukNo;
    }
}