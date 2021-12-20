
namespace ClientReservasi_086
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
            this.components = new System.ComponentModel.Container();
            this.dtPemesanan = new System.Windows.Forms.DataGridView();
            this.iDPemesananDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahPemesananDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lokasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaCustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTelponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pemesananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxNoTlf = new System.Windows.Forms.TextBox();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.textBoxIDLokasi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btHapus = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtPemesanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesananBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPemesanan
            // 
            this.dtPemesanan.AutoGenerateColumns = false;
            this.dtPemesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPemesanan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDPemesananDataGridViewTextBoxColumn,
            this.jumlahPemesananDataGridViewTextBoxColumn,
            this.lokasiDataGridViewTextBoxColumn,
            this.namaCustomerDataGridViewTextBoxColumn,
            this.noTelponDataGridViewTextBoxColumn});
            this.dtPemesanan.DataSource = this.pemesananBindingSource;
            this.dtPemesanan.Location = new System.Drawing.Point(12, 253);
            this.dtPemesanan.Name = "dtPemesanan";
            this.dtPemesanan.RowHeadersWidth = 51;
            this.dtPemesanan.RowTemplate.Height = 24;
            this.dtPemesanan.Size = new System.Drawing.Size(776, 185);
            this.dtPemesanan.TabIndex = 0;
            this.dtPemesanan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPemesanan_CellClick);
            // 
            // iDPemesananDataGridViewTextBoxColumn
            // 
            this.iDPemesananDataGridViewTextBoxColumn.DataPropertyName = "IDPemesanan";
            this.iDPemesananDataGridViewTextBoxColumn.HeaderText = "IDPemesanan";
            this.iDPemesananDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDPemesananDataGridViewTextBoxColumn.Name = "iDPemesananDataGridViewTextBoxColumn";
            this.iDPemesananDataGridViewTextBoxColumn.Width = 125;
            // 
            // jumlahPemesananDataGridViewTextBoxColumn
            // 
            this.jumlahPemesananDataGridViewTextBoxColumn.DataPropertyName = "JumlahPemesanan";
            this.jumlahPemesananDataGridViewTextBoxColumn.HeaderText = "JumlahPemesanan";
            this.jumlahPemesananDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jumlahPemesananDataGridViewTextBoxColumn.Name = "jumlahPemesananDataGridViewTextBoxColumn";
            this.jumlahPemesananDataGridViewTextBoxColumn.Width = 125;
            // 
            // lokasiDataGridViewTextBoxColumn
            // 
            this.lokasiDataGridViewTextBoxColumn.DataPropertyName = "Lokasi";
            this.lokasiDataGridViewTextBoxColumn.HeaderText = "Lokasi";
            this.lokasiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lokasiDataGridViewTextBoxColumn.Name = "lokasiDataGridViewTextBoxColumn";
            this.lokasiDataGridViewTextBoxColumn.Width = 125;
            // 
            // namaCustomerDataGridViewTextBoxColumn
            // 
            this.namaCustomerDataGridViewTextBoxColumn.DataPropertyName = "NamaCustomer";
            this.namaCustomerDataGridViewTextBoxColumn.HeaderText = "NamaCustomer";
            this.namaCustomerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.namaCustomerDataGridViewTextBoxColumn.Name = "namaCustomerDataGridViewTextBoxColumn";
            this.namaCustomerDataGridViewTextBoxColumn.Width = 125;
            // 
            // noTelponDataGridViewTextBoxColumn
            // 
            this.noTelponDataGridViewTextBoxColumn.DataPropertyName = "NoTelpon";
            this.noTelponDataGridViewTextBoxColumn.HeaderText = "NoTelpon";
            this.noTelponDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noTelponDataGridViewTextBoxColumn.Name = "noTelponDataGridViewTextBoxColumn";
            this.noTelponDataGridViewTextBoxColumn.Width = 125;
            // 
            // pemesananBindingSource
            // 
            this.pemesananBindingSource.DataSource = typeof(ClientReservasi_086.ServiceReference1.Pemesanan);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(176, 31);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(358, 22);
            this.textBoxID.TabIndex = 1;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(176, 75);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(358, 22);
            this.textBoxNama.TabIndex = 2;
            // 
            // textBoxNoTlf
            // 
            this.textBoxNoTlf.Location = new System.Drawing.Point(176, 117);
            this.textBoxNoTlf.Name = "textBoxNoTlf";
            this.textBoxNoTlf.Size = new System.Drawing.Size(358, 22);
            this.textBoxNoTlf.TabIndex = 3;
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.Location = new System.Drawing.Point(176, 161);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(358, 22);
            this.textBoxJumlah.TabIndex = 4;
            // 
            // textBoxIDLokasi
            // 
            this.textBoxIDLokasi.Location = new System.Drawing.Point(176, 203);
            this.textBoxIDLokasi.Name = "textBoxIDLokasi";
            this.textBoxIDLokasi.Size = new System.Drawing.Size(358, 22);
            this.textBoxIDLokasi.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID Reservasi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "No. Telfon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Jumlah Pemesanan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID Lokasi";
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(627, 35);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(75, 31);
            this.btSimpan.TabIndex = 11;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(627, 80);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 31);
            this.btUpdate.TabIndex = 12;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(627, 122);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(75, 31);
            this.btHapus.TabIndex = 13;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = true;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(627, 166);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 31);
            this.btClear.TabIndex = 14;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxIDLokasi);
            this.Controls.Add(this.textBoxJumlah);
            this.Controls.Add(this.textBoxNoTlf);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.dtPemesanan);
            this.Name = "Form1";
            this.Text = "Reservasi";
            ((System.ComponentModel.ISupportInitialize)(this.dtPemesanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesananBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtPemesanan;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDPemesananDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahPemesananDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lokasiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaCustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTelponDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource pemesananBindingSource;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxNoTlf;
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.TextBox textBoxIDLokasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btClear;
    }
}

