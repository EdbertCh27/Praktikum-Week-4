
namespace Praktikum_Week_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblNama = new System.Windows.Forms.Label();
            this.LblAlamat = new System.Windows.Forms.Label();
            this.LblNoHp = new System.Windows.Forms.Label();
            this.BtnSimpan = new System.Windows.Forms.Button();
            this.BtnLihatData = new System.Windows.Forms.Button();
            this.TBoxNama = new System.Windows.Forms.TextBox();
            this.TBoxAlamat = new System.Windows.Forms.TextBox();
            this.TBoxNoHp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblNama
            // 
            this.LblNama.AutoSize = true;
            this.LblNama.Location = new System.Drawing.Point(47, 38);
            this.LblNama.Name = "LblNama";
            this.LblNama.Size = new System.Drawing.Size(56, 20);
            this.LblNama.TabIndex = 0;
            this.LblNama.Text = "Nama :";
            // 
            // LblAlamat
            // 
            this.LblAlamat.AutoSize = true;
            this.LblAlamat.Location = new System.Drawing.Point(47, 94);
            this.LblAlamat.Name = "LblAlamat";
            this.LblAlamat.Size = new System.Drawing.Size(64, 20);
            this.LblAlamat.TabIndex = 1;
            this.LblAlamat.Text = "Alamat :";
            // 
            // LblNoHp
            // 
            this.LblNoHp.AutoSize = true;
            this.LblNoHp.Location = new System.Drawing.Point(47, 149);
            this.LblNoHp.Name = "LblNoHp";
            this.LblNoHp.Size = new System.Drawing.Size(63, 20);
            this.LblNoHp.TabIndex = 2;
            this.LblNoHp.Text = "No. Hp :";
            // 
            // BtnSimpan
            // 
            this.BtnSimpan.Location = new System.Drawing.Point(47, 226);
            this.BtnSimpan.Name = "BtnSimpan";
            this.BtnSimpan.Size = new System.Drawing.Size(94, 29);
            this.BtnSimpan.TabIndex = 3;
            this.BtnSimpan.Text = "Simpan";
            this.BtnSimpan.UseVisualStyleBackColor = true;
            this.BtnSimpan.Click += new System.EventHandler(this.BtnSimpan_Click);
            // 
            // BtnLihatData
            // 
            this.BtnLihatData.Location = new System.Drawing.Point(231, 226);
            this.BtnLihatData.Name = "BtnLihatData";
            this.BtnLihatData.Size = new System.Drawing.Size(94, 29);
            this.BtnLihatData.TabIndex = 4;
            this.BtnLihatData.Text = "Lihat Data";
            this.BtnLihatData.UseVisualStyleBackColor = true;
            this.BtnLihatData.Click += new System.EventHandler(this.BtnLihatData_Click);
            // 
            // TBoxNama
            // 
            this.TBoxNama.Location = new System.Drawing.Point(122, 35);
            this.TBoxNama.Name = "TBoxNama";
            this.TBoxNama.Size = new System.Drawing.Size(406, 27);
            this.TBoxNama.TabIndex = 5;
            // 
            // TBoxAlamat
            // 
            this.TBoxAlamat.Location = new System.Drawing.Point(122, 91);
            this.TBoxAlamat.Name = "TBoxAlamat";
            this.TBoxAlamat.Size = new System.Drawing.Size(406, 27);
            this.TBoxAlamat.TabIndex = 6;
            // 
            // TBoxNoHp
            // 
            this.TBoxNoHp.Location = new System.Drawing.Point(122, 149);
            this.TBoxNoHp.Name = "TBoxNoHp";
            this.TBoxNoHp.Size = new System.Drawing.Size(406, 27);
            this.TBoxNoHp.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TBoxNoHp);
            this.Controls.Add(this.TBoxAlamat);
            this.Controls.Add(this.TBoxNama);
            this.Controls.Add(this.BtnLihatData);
            this.Controls.Add(this.BtnSimpan);
            this.Controls.Add(this.LblNoHp);
            this.Controls.Add(this.LblAlamat);
            this.Controls.Add(this.LblNama);
            this.Name = "Form1";
            this.Text = "Form Penambahan Data";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNama;
        private System.Windows.Forms.Label LblAlamat;
        private System.Windows.Forms.Label LblNoHp;
        private System.Windows.Forms.Button BtnSimpan;
        private System.Windows.Forms.Button BtnLihatData;
        private System.Windows.Forms.TextBox TBoxNama;
        private System.Windows.Forms.TextBox TBoxAlamat;
        private System.Windows.Forms.TextBox TBoxNoHp;
    }
}

