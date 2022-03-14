using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_Week_4
{
    public partial class Form2 : Form
    {
        DataTable dataOrang = new DataTable();
        public Form2(DataTable table)
        {
            InitializeComponent();
            dataOrang = table;
        }
       
        private void BtnKembali_Click(object sender, EventArgs e)
        {
            Form1 bukaForm1 = new Form1();
            bukaForm1.Show();
            this.Hide();
        }

        private void TBoxNamaTampilan_TextChanged(object sender, EventArgs e)
        {

        }

        public void Form2_Load(object sender, EventArgs e)
        {
            if(dataOrang.Rows.Count == 0)
            {
                TBoxNamaTampilan.Text = "<Data Kosong>";
                TBoxAlamatTampilan.Text = "<Data Kosong>";
                TBoxNoHpTampilan.Text = "<Data Kosong>";
            }
            else
            {
                TBoxNamaTampilan.Text = dataOrang.Rows[0][0].ToString();
                TBoxAlamatTampilan.Text = dataOrang.Rows[0][1].ToString();
                TBoxNoHpTampilan.Text = dataOrang.Rows[0][2].ToString();
            }
            
        }


        int noBaris = 0;
        private void BtnPrevData_Click(object sender, EventArgs e)
        {
            if(noBaris ==  0)
            {
                MessageBox.Show("Data Paling Pertama", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                noBaris--;
                TBoxNamaTampilan.Text = dataOrang.Rows[noBaris][0].ToString();
                TBoxAlamatTampilan.Text = dataOrang.Rows[noBaris][1].ToString();
                TBoxNoHpTampilan.Text = dataOrang.Rows[noBaris][2].ToString();
            }
        }

        private void BtnNextData_Click(object sender, EventArgs e)
        {
            if (noBaris == dataOrang.Rows.Count - 1)
            {
                MessageBox.Show("Data Paling Terakhir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                noBaris++;
                TBoxNamaTampilan.Text = dataOrang.Rows[noBaris][0].ToString();
                TBoxAlamatTampilan.Text = dataOrang.Rows[noBaris][1].ToString();
                TBoxNoHpTampilan.Text = dataOrang.Rows[noBaris][2].ToString();

            }
        }

    }
}
