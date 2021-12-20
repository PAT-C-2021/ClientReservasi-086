using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientReservasi_086
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();

        public void TampilData()
        {
            var List = service.Pemesanan1();
            dtPemesanan.DataSource = List;
        }

        public void Clear()
        {
            textBoxID.Clear();
            textBoxIDLokasi.Clear();
            textBoxJumlah.Clear();
            textBoxNama.Clear();
            textBoxNoTlf.Clear();

            textBoxJumlah.Enabled = true;
            textBoxIDLokasi.Enabled = true;

            btSimpan.Enabled = true;
            btUpdate.Enabled = false;
            btHapus.Enabled = false;

            textBoxID.Enabled = true;
        }

        public Form1()
        {
            InitializeComponent();

            TampilData();
            btUpdate.Enabled = false;
            btHapus.Enabled = false;
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            String IDPemesanan = textBoxID.Text;
            String NamaCustomer = textBoxNama.Text;
            String NoTelpon = textBoxNoTlf.Text;
            int JumlahPemesanan = int.Parse(textBoxJumlah.Text);
            String IDLokasi = textBoxIDLokasi.Text;

            var a = service.pemesanan(IDPemesanan, NamaCustomer, NoTelpon, JumlahPemesanan, IDLokasi);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            String IDPemesanan = textBoxID.Text;
            String NamaCustomer = textBoxNama.Text;
            String NoTelpon = textBoxNoTlf.Text;

            var a = service.editPemesanan(IDPemesanan, NamaCustomer, NoTelpon);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            String IDPemesanan = textBoxID.Text;

            var a = service.deletePemesanan(IDPemesanan);
            MessageBox.Show(a);
            TampilData();
            Clear();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dtPemesanan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[0].Value);
            textBoxNama.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[3].Value);
            textBoxNoTlf.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[4].Value);
            textBoxJumlah.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[1].Value);
            textBoxIDLokasi.Text = Convert.ToString(dtPemesanan.Rows[e.RowIndex].Cells[2].Value);

            textBoxJumlah.Enabled = false;
            textBoxIDLokasi.Enabled = false;

            btSimpan.Enabled = false;
            btUpdate.Enabled = true;
            btHapus.Enabled = true;

            textBoxID.Enabled = false;
        }
    }
}
