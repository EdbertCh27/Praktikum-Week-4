
namespace Praktikum_Week_4
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
            this.LblNamaTampilan = new System.Windows.Forms.Label();
            this.LblAlamatTampilan = new System.Windows.Forms.Label();
            this.LblTelpTampilan = new System.Windows.Forms.Label();
            this.BtnKembali = new System.Windows.Forms.Button();
            this.BtnPrevData = new System.Windows.Forms.Button();
            this.BtnNextData = new System.Windows.Forms.Button();
            this.TBoxNamaTampilan = new System.Windows.Forms.TextBox();
            this.TBoxAlamatTampilan = new System.Windows.Forms.TextBox();
            this.TBoxNoHpTampilan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblNamaTampilan
            // 
            this.LblNamaTampilan.AutoSize = true;
            this.LblNamaTampilan.Location = new System.Drawing.Point(53, 51);
            this.LblNamaTampilan.Name = "LblNamaTampilan";
            this.LblNamaTampilan.Size = new System.Drawing.Size(56, 20);
            this.LblNamaTampilan.TabIndex = 0;
            this.LblNamaTampilan.Text = "Nama :";
            // 
            // LblAlamatTampilan
            // 
            this.LblAlamatTampilan.AutoSize = true;
            this.LblAlamatTampilan.Location = new System.Drawing.Point(53, 119);
            this.LblAlamatTampilan.Name = "LblAlamatTampilan";
            this.LblAlamatTampilan.Size = new System.Drawing.Size(64, 20);
            this.LblAlamatTampilan.TabIndex = 1;
            this.LblAlamatTampilan.Text = "Alamat :";
            // 
            // LblTelpTampilan
            // 
            this.LblTelpTampilan.AutoSize = true;
            this.LblTelpTampilan.Location = new System.Drawing.Point(53, 193);
            this.LblTelpTampilan.Name = "LblTelpTampilan";
            this.LblTelpTampilan.Size = new System.Drawing.Size(63, 20);
            this.LblTelpTampilan.TabIndex = 2;
            this.LblTelpTampilan.Text = "No. Hp :";
            // 
            // BtnKembali
            // 
            this.BtnKembali.Location = new System.Drawing.Point(53, 262);
            this.BtnKembali.Name = "BtnKembali";
            this.BtnKembali.Size = new System.Drawing.Size(94, 29);
            this.BtnKembali.TabIndex = 3;
            this.BtnKembali.Text = "Kembali";
            this.BtnKembali.UseVisualStyleBackColor = true;
            this.BtnKembali.Click += new System.EventHandler(this.BtnKembali_Click);
            // 
            // BtnPrevData
            // 
            this.BtnPrevData.Location = new System.Drawing.Point(197, 262);
            this.BtnPrevData.Name = "BtnPrevData";
            this.BtnPrevData.Size = new System.Drawing.Size(94, 29);
            this.BtnPrevData.TabIndex = 4;
            this.BtnPrevData.Text = "Prev Data";
            this.BtnPrevData.UseVisualStyleBackColor = true;
            this.BtnPrevData.Click += new System.EventHandler(this.BtnPrevData_Click);
            // 
            // BtnNextData
            // 
            this.BtnNextData.Location = new System.Drawing.Point(340, 262);
            this.BtnNextData.Name = "BtnNextData";
            this.BtnNextData.Size = new System.Drawing.Size(94, 29);
            this.BtnNextData.TabIndex = 5;
            this.BtnNextData.Text = "Next Data";
            this.BtnNextData.UseVisualStyleBackColor = true;
            this.BtnNextData.Click += new System.EventHandler(this.BtnNextData_Click);
            // 
            // TBoxNamaTampilan
            // 
            this.TBoxNamaTampilan.Location = new System.Drawing.Point(142, 51);
            this.TBoxNamaTampilan.Name = "TBoxNamaTampilan";
            this.TBoxNamaTampilan.Size = new System.Drawing.Size(429, 27);
            this.TBoxNamaTampilan.TabIndex = 6;
            this.TBoxNamaTampilan.TextChanged += new System.EventHandler(this.TBoxNamaTampilan_TextChanged);
            // 
            // TBoxAlamatTampilan
            // 
            this.TBoxAlamatTampilan.Location = new System.Drawing.Point(142, 116);
            this.TBoxAlamatTampilan.Name = "TBoxAlamatTampilan";
            this.TBoxAlamatTampilan.Size = new System.Drawing.Size(429, 27);
            this.TBoxAlamatTampilan.TabIndex = 7;
            // 
            // TBoxNoHpTampilan
            // 
            this.TBoxNoHpTampilan.Location = new System.Drawing.Point(142, 190);
            this.TBoxNoHpTampilan.Name = "TBoxNoHpTampilan";
            this.TBoxNoHpTampilan.Size = new System.Drawing.Size(429, 27);
            this.TBoxNoHpTampilan.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBoxNoHpTampilan);
            this.Controls.Add(this.TBoxAlamatTampilan);
            this.Controls.Add(this.TBoxNamaTampilan);
            this.Controls.Add(this.BtnNextData);
            this.Controls.Add(this.BtnPrevData);
            this.Controls.Add(this.BtnKembali);
            this.Controls.Add(this.LblTelpTampilan);
            this.Controls.Add(this.LblAlamatTampilan);
            this.Controls.Add(this.LblNamaTampilan);
            this.Name = "Form2";
            this.Text = "Form Tampilan Data";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNamaTampilan;
        private System.Windows.Forms.Label LblAlamatTampilan;
        private System.Windows.Forms.Label LblTelpTampilan;
        private System.Windows.Forms.Button BtnKembali;
        private System.Windows.Forms.Button BtnPrevData;
        private System.Windows.Forms.Button BtnNextData;
        private System.Windows.Forms.TextBox TBoxNamaTampilan;
        private System.Windows.Forms.TextBox TBoxAlamatTampilan;
        private System.Windows.Forms.TextBox TBoxNoHpTampilan;
    }
}