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
    public partial class FormTambahData : Form
    {
        public FormTambahData()
        {
            InitializeComponent();
        }


        public void BtnLihatData_Click(object sender, EventArgs e)
        {

            FormShowData bukaForm2 = new FormShowData(dataOrang);
            bukaForm2.Show();
            this.Hide();
        }

        public DataTable dataOrang = new DataTable();

        public void Form1_Load(object sender, EventArgs e)
        {
            dataOrang.Columns.Add("Nama");
            dataOrang.Columns.Add("Alamat");
            dataOrang.Columns.Add("No. Hp");
        }


        public void BtnSimpan_Click(object sender, EventArgs e)
        {
            if (dataOrang.Rows.Count >= 10)
            {
                MessageBox.Show("Data Sudah Penuh", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (TBoxNoHp.Text.All(char.IsLetter))
            {
                MessageBox.Show("Data Harus Lengkap dan No Hp Harus Angka", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataOrang.Rows.Add(TBoxNama.Text, TBoxAlamat.Text, TBoxNoHp.Text);
                TBoxNama.Clear();
                TBoxAlamat.Clear();
                TBoxNoHp.Clear();
            }


        }

    }
}
