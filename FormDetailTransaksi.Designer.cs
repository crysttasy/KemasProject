
namespace KemasProject
{
    partial class FormDetailTransaksi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetailTransaksi));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnSelesai = new System.Windows.Forms.Button();
            this.btnTolak = new System.Windows.Forms.Button();
            this.btnSetujui = new System.Windows.Forms.Button();
            this.btnTutup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDataProses = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAlasan = new System.Windows.Forms.Label();
            this.lblAlasanTitle = new System.Windows.Forms.Label();
            this.lblWaktuProses = new System.Windows.Forms.Label();
            this.lblWaktuProsesTitle = new System.Windows.Forms.Label();
            this.lblPetugas = new System.Windows.Forms.Label();
            this.lblPetugasTitle = new System.Windows.Forms.Label();
            this.lblSectionProses = new System.Windows.Forms.Label();
            this.pnlDataIzin = new System.Windows.Forms.Panel();
            this.lblKeterangan = new System.Windows.Forms.Label();
            this.lblKeteranganTitle = new System.Windows.Forms.Label();
            this.lblKeperluan = new System.Windows.Forms.Label();
            this.lblKeperluanTitle = new System.Windows.Forms.Label();
            this.lblKembali = new System.Windows.Forms.Label();
            this.lblKembaliTitle = new System.Windows.Forms.Label();
            this.lblWaktu = new System.Windows.Forms.Label();
            this.lblWaktuTitle = new System.Windows.Forms.Label();
            this.lblJenis = new System.Windows.Forms.Label();
            this.lblJenisTitle = new System.Windows.Forms.Label();
            this.lblSectionIIzin = new System.Windows.Forms.Label();
            this.pnlDataSiswa = new System.Windows.Forms.Panel();
            this.lblKelas = new System.Windows.Forms.Label();
            this.lblKelasTitle = new System.Windows.Forms.Label();
            this.lblNis = new System.Windows.Forms.Label();
            this.lblNisTitle = new System.Windows.Forms.Label();
            this.lblNama = new System.Windows.Forms.Label();
            this.lblNamaTitle = new System.Windows.Forms.Label();
            this.lblSectionSiswa = new System.Windows.Forms.Label();
            this.pnlDataSurat = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblStatusTitle = new System.Windows.Forms.Label();
            this.lblNomorSurat = new System.Windows.Forms.Label();
            this.lblNomorSuratTitle = new System.Windows.Forms.Label();
            this.lblSectionSurat = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlDataProses.SuspendLayout();
            this.pnlDataIzin.SuspendLayout();
            this.pnlDataSiswa.SuspendLayout();
            this.pnlDataSurat.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(884, 82);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSubtitle.Location = new System.Drawing.Point(26, 47);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(275, 13);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Informasi lengkap surat izin masuk dan keluar siswa";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(62)))), ((int)(((byte)(115)))));
            this.lblTitle.Location = new System.Drawing.Point(24, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(162, 28);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Detail Transaksi";
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.Controls.Add(this.pnlFooter);
            this.pnlContent.Controls.Add(this.pnlDataProses);
            this.pnlContent.Controls.Add(this.pnlDataIzin);
            this.pnlContent.Controls.Add(this.pnlDataSiswa);
            this.pnlContent.Controls.Add(this.pnlDataSurat);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 82);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(20, 18, 20, 10);
            this.pnlContent.Size = new System.Drawing.Size(884, 559);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.White;
            this.pnlFooter.Controls.Add(this.btnSelesai);
            this.pnlFooter.Controls.Add(this.btnTolak);
            this.pnlFooter.Controls.Add(this.btnSetujui);
            this.pnlFooter.Controls.Add(this.btnTutup);
            this.pnlFooter.Controls.Add(this.label2);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(20, 588);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(827, 64);
            this.pnlFooter.TabIndex = 4;
            // 
            // btnSelesai
            // 
            this.btnSelesai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.btnSelesai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelesai.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnSelesai.FlatAppearance.BorderSize = 0;
            this.btnSelesai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelesai.ForeColor = System.Drawing.Color.White;
            this.btnSelesai.Location = new System.Drawing.Point(650, 15);
            this.btnSelesai.Name = "btnSelesai";
            this.btnSelesai.Size = new System.Drawing.Size(90, 34);
            this.btnSelesai.TabIndex = 20;
            this.btnSelesai.Text = "Selesai";
            this.btnSelesai.UseVisualStyleBackColor = false;
            this.btnSelesai.Visible = false;
            // 
            // btnTolak
            // 
            this.btnTolak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnTolak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTolak.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnTolak.FlatAppearance.BorderSize = 0;
            this.btnTolak.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTolak.ForeColor = System.Drawing.Color.White;
            this.btnTolak.Location = new System.Drawing.Point(560, 15);
            this.btnTolak.Name = "btnTolak";
            this.btnTolak.Size = new System.Drawing.Size(80, 34);
            this.btnTolak.TabIndex = 19;
            this.btnTolak.Text = "Tolak";
            this.btnTolak.UseVisualStyleBackColor = false;
            // 
            // btnSetujui
            // 
            this.btnSetujui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(128)))), ((int)(((byte)(61)))));
            this.btnSetujui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetujui.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnSetujui.FlatAppearance.BorderSize = 0;
            this.btnSetujui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetujui.ForeColor = System.Drawing.Color.White;
            this.btnSetujui.Location = new System.Drawing.Point(650, 15);
            this.btnSetujui.Name = "btnSetujui";
            this.btnSetujui.Size = new System.Drawing.Size(90, 34);
            this.btnSetujui.TabIndex = 18;
            this.btnSetujui.Text = "Setujui";
            this.btnSetujui.UseVisualStyleBackColor = false;
            // 
            // btnTutup
            // 
            this.btnTutup.BackColor = System.Drawing.Color.White;
            this.btnTutup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTutup.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.btnTutup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTutup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btnTutup.Location = new System.Drawing.Point(750, 15);
            this.btnTutup.Name = "btnTutup";
            this.btnTutup.Size = new System.Drawing.Size(85, 34);
            this.btnTutup.TabIndex = 17;
            this.btnTutup.Text = "Tutup";
            this.btnTutup.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(62)))), ((int)(((byte)(115)))));
            this.label2.Location = new System.Drawing.Point(18, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 0);
            this.label2.TabIndex = 16;
            this.label2.Text = "-";
            // 
            // pnlDataProses
            // 
            this.pnlDataProses.BackColor = System.Drawing.Color.White;
            this.pnlDataProses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDataProses.Controls.Add(this.label1);
            this.pnlDataProses.Controls.Add(this.lblAlasan);
            this.pnlDataProses.Controls.Add(this.lblAlasanTitle);
            this.pnlDataProses.Controls.Add(this.lblWaktuProses);
            this.pnlDataProses.Controls.Add(this.lblWaktuProsesTitle);
            this.pnlDataProses.Controls.Add(this.lblPetugas);
            this.pnlDataProses.Controls.Add(this.lblPetugasTitle);
            this.pnlDataProses.Controls.Add(this.lblSectionProses);
            this.pnlDataProses.Location = new System.Drawing.Point(20, 463);
            this.pnlDataProses.Name = "pnlDataProses";
            this.pnlDataProses.Size = new System.Drawing.Size(840, 135);
            this.pnlDataProses.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(62)))), ((int)(((byte)(115)))));
            this.label1.Location = new System.Drawing.Point(18, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 0);
            this.label1.TabIndex = 16;
            this.label1.Text = "-";
            // 
            // lblAlasan
            // 
            this.lblAlasan.AutoSize = true;
            this.lblAlasan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlasan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblAlasan.Location = new System.Drawing.Point(560, 64);
            this.lblAlasan.Name = "lblAlasan";
            this.lblAlasan.Size = new System.Drawing.Size(12, 15);
            this.lblAlasan.TabIndex = 12;
            this.lblAlasan.Text = "-";
            // 
            // lblAlasanTitle
            // 
            this.lblAlasanTitle.AutoSize = true;
            this.lblAlasanTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlasanTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblAlasanTitle.Location = new System.Drawing.Point(560, 43);
            this.lblAlasanTitle.Name = "lblAlasanTitle";
            this.lblAlasanTitle.Size = new System.Drawing.Size(98, 13);
            this.lblAlasanTitle.TabIndex = 11;
            this.lblAlasanTitle.Text = "Alasan Penolakan";
            // 
            // lblWaktuProses
            // 
            this.lblWaktuProses.AutoSize = true;
            this.lblWaktuProses.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaktuProses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblWaktuProses.Location = new System.Drawing.Point(300, 64);
            this.lblWaktuProses.Name = "lblWaktuProses";
            this.lblWaktuProses.Size = new System.Drawing.Size(12, 15);
            this.lblWaktuProses.TabIndex = 10;
            this.lblWaktuProses.Text = "-";
            // 
            // lblWaktuProsesTitle
            // 
            this.lblWaktuProsesTitle.AutoSize = true;
            this.lblWaktuProsesTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaktuProsesTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblWaktuProsesTitle.Location = new System.Drawing.Point(300, 43);
            this.lblWaktuProsesTitle.Name = "lblWaktuProsesTitle";
            this.lblWaktuProsesTitle.Size = new System.Drawing.Size(77, 13);
            this.lblWaktuProsesTitle.TabIndex = 9;
            this.lblWaktuProsesTitle.Text = "Waktu Proses";
            // 
            // lblPetugas
            // 
            this.lblPetugas.AutoSize = true;
            this.lblPetugas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetugas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(62)))), ((int)(((byte)(115)))));
            this.lblPetugas.Location = new System.Drawing.Point(18, 64);
            this.lblPetugas.Name = "lblPetugas";
            this.lblPetugas.Size = new System.Drawing.Size(12, 15);
            this.lblPetugas.TabIndex = 8;
            this.lblPetugas.Text = "-";
            // 
            // lblPetugasTitle
            // 
            this.lblPetugasTitle.AutoSize = true;
            this.lblPetugasTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPetugasTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblPetugasTitle.Location = new System.Drawing.Point(18, 43);
            this.lblPetugasTitle.Name = "lblPetugasTitle";
            this.lblPetugasTitle.Size = new System.Drawing.Size(48, 13);
            this.lblPetugasTitle.TabIndex = 7;
            this.lblPetugasTitle.Text = "Petugas";
            // 
            // lblSectionProses
            // 
            this.lblSectionProses.AutoSize = true;
            this.lblSectionProses.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionProses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblSectionProses.Location = new System.Drawing.Point(18, 12);
            this.lblSectionProses.Name = "lblSectionProses";
            this.lblSectionProses.Size = new System.Drawing.Size(111, 17);
            this.lblSectionProses.TabIndex = 0;
            this.lblSectionProses.Text = "Informasi Proses";
            // 
            // pnlDataIzin
            // 
            this.pnlDataIzin.BackColor = System.Drawing.Color.White;
            this.pnlDataIzin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDataIzin.Controls.Add(this.lblKeterangan);
            this.pnlDataIzin.Controls.Add(this.lblKeteranganTitle);
            this.pnlDataIzin.Controls.Add(this.lblKeperluan);
            this.pnlDataIzin.Controls.Add(this.lblKeperluanTitle);
            this.pnlDataIzin.Controls.Add(this.lblKembali);
            this.pnlDataIzin.Controls.Add(this.lblKembaliTitle);
            this.pnlDataIzin.Controls.Add(this.lblWaktu);
            this.pnlDataIzin.Controls.Add(this.lblWaktuTitle);
            this.pnlDataIzin.Controls.Add(this.lblJenis);
            this.pnlDataIzin.Controls.Add(this.lblJenisTitle);
            this.pnlDataIzin.Controls.Add(this.lblSectionIIzin);
            this.pnlDataIzin.Location = new System.Drawing.Point(20, 263);
            this.pnlDataIzin.Name = "pnlDataIzin";
            this.pnlDataIzin.Size = new System.Drawing.Size(840, 190);
            this.pnlDataIzin.TabIndex = 2;
            // 
            // lblKeterangan
            // 
            this.lblKeterangan.AutoEllipsis = true;
            this.lblKeterangan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeterangan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(62)))), ((int)(((byte)(115)))));
            this.lblKeterangan.Location = new System.Drawing.Point(18, 160);
            this.lblKeterangan.Name = "lblKeterangan";
            this.lblKeterangan.Size = new System.Drawing.Size(790, 25);
            this.lblKeterangan.TabIndex = 16;
            this.lblKeterangan.Text = "-";
            // 
            // lblKeteranganTitle
            // 
            this.lblKeteranganTitle.AutoSize = true;
            this.lblKeteranganTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeteranganTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblKeteranganTitle.Location = new System.Drawing.Point(18, 140);
            this.lblKeteranganTitle.Name = "lblKeteranganTitle";
            this.lblKeteranganTitle.Size = new System.Drawing.Size(66, 13);
            this.lblKeteranganTitle.TabIndex = 15;
            this.lblKeteranganTitle.Text = "Keterangan";
            // 
            // lblKeperluan
            // 
            this.lblKeperluan.AutoEllipsis = true;
            this.lblKeperluan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeperluan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(62)))), ((int)(((byte)(115)))));
            this.lblKeperluan.Location = new System.Drawing.Point(18, 111);
            this.lblKeperluan.Name = "lblKeperluan";
            this.lblKeperluan.Size = new System.Drawing.Size(790, 25);
            this.lblKeperluan.TabIndex = 14;
            this.lblKeperluan.Text = "-";
            // 
            // lblKeperluanTitle
            // 
            this.lblKeperluanTitle.AutoSize = true;
            this.lblKeperluanTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeperluanTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblKeperluanTitle.Location = new System.Drawing.Point(18, 91);
            this.lblKeperluanTitle.Name = "lblKeperluanTitle";
            this.lblKeperluanTitle.Size = new System.Drawing.Size(59, 13);
            this.lblKeperluanTitle.TabIndex = 13;
            this.lblKeperluanTitle.Text = "Keperluan";
            // 
            // lblKembali
            // 
            this.lblKembali.AutoSize = true;
            this.lblKembali.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKembali.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblKembali.Location = new System.Drawing.Point(560, 64);
            this.lblKembali.Name = "lblKembali";
            this.lblKembali.Size = new System.Drawing.Size(12, 15);
            this.lblKembali.TabIndex = 12;
            this.lblKembali.Text = "-";
            // 
            // lblKembaliTitle
            // 
            this.lblKembaliTitle.AutoSize = true;
            this.lblKembaliTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKembaliTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblKembaliTitle.Location = new System.Drawing.Point(560, 43);
            this.lblKembaliTitle.Name = "lblKembaliTitle";
            this.lblKembaliTitle.Size = new System.Drawing.Size(98, 13);
            this.lblKembaliTitle.TabIndex = 11;
            this.lblKembaliTitle.Text = "Perkiraan Kembali";
            // 
            // lblWaktu
            // 
            this.lblWaktu.AutoSize = true;
            this.lblWaktu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaktu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblWaktu.Location = new System.Drawing.Point(300, 64);
            this.lblWaktu.Name = "lblWaktu";
            this.lblWaktu.Size = new System.Drawing.Size(12, 15);
            this.lblWaktu.TabIndex = 10;
            this.lblWaktu.Text = "-";
            // 
            // lblWaktuTitle
            // 
            this.lblWaktuTitle.AutoSize = true;
            this.lblWaktuTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaktuTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblWaktuTitle.Location = new System.Drawing.Point(300, 43);
            this.lblWaktuTitle.Name = "lblWaktuTitle";
            this.lblWaktuTitle.Size = new System.Drawing.Size(62, 13);
            this.lblWaktuTitle.TabIndex = 9;
            this.lblWaktuTitle.Text = "Waktu Izin";
            // 
            // lblJenis
            // 
            this.lblJenis.AutoSize = true;
            this.lblJenis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJenis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(62)))), ((int)(((byte)(115)))));
            this.lblJenis.Location = new System.Drawing.Point(18, 64);
            this.lblJenis.Name = "lblJenis";
            this.lblJenis.Size = new System.Drawing.Size(12, 15);
            this.lblJenis.TabIndex = 8;
            this.lblJenis.Text = "-";
            // 
            // lblJenisTitle
            // 
            this.lblJenisTitle.AutoSize = true;
            this.lblJenisTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJenisTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblJenisTitle.Location = new System.Drawing.Point(18, 43);
            this.lblJenisTitle.Name = "lblJenisTitle";
            this.lblJenisTitle.Size = new System.Drawing.Size(53, 13);
            this.lblJenisTitle.TabIndex = 7;
            this.lblJenisTitle.Text = "Jenis Izin";
            // 
            // lblSectionIIzin
            // 
            this.lblSectionIIzin.AutoSize = true;
            this.lblSectionIIzin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionIIzin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblSectionIIzin.Location = new System.Drawing.Point(18, 12);
            this.lblSectionIIzin.Name = "lblSectionIIzin";
            this.lblSectionIIzin.Size = new System.Drawing.Size(106, 17);
            this.lblSectionIIzin.TabIndex = 0;
            this.lblSectionIIzin.Text = "Detail Perizinan";
            // 
            // pnlDataSiswa
            // 
            this.pnlDataSiswa.BackColor = System.Drawing.Color.White;
            this.pnlDataSiswa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDataSiswa.Controls.Add(this.lblKelas);
            this.pnlDataSiswa.Controls.Add(this.lblKelasTitle);
            this.pnlDataSiswa.Controls.Add(this.lblNis);
            this.pnlDataSiswa.Controls.Add(this.lblNisTitle);
            this.pnlDataSiswa.Controls.Add(this.lblNama);
            this.pnlDataSiswa.Controls.Add(this.lblNamaTitle);
            this.pnlDataSiswa.Controls.Add(this.lblSectionSiswa);
            this.pnlDataSiswa.Location = new System.Drawing.Point(20, 133);
            this.pnlDataSiswa.Name = "pnlDataSiswa";
            this.pnlDataSiswa.Size = new System.Drawing.Size(840, 105);
            this.pnlDataSiswa.TabIndex = 1;
            // 
            // lblKelas
            // 
            this.lblKelas.AutoSize = true;
            this.lblKelas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblKelas.Location = new System.Drawing.Point(560, 65);
            this.lblKelas.Name = "lblKelas";
            this.lblKelas.Size = new System.Drawing.Size(12, 15);
            this.lblKelas.TabIndex = 6;
            this.lblKelas.Text = "-";
            // 
            // lblKelasTitle
            // 
            this.lblKelasTitle.AutoSize = true;
            this.lblKelasTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelasTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblKelasTitle.Location = new System.Drawing.Point(560, 43);
            this.lblKelasTitle.Name = "lblKelasTitle";
            this.lblKelasTitle.Size = new System.Drawing.Size(33, 13);
            this.lblKelasTitle.TabIndex = 5;
            this.lblKelasTitle.Text = "Kelas";
            // 
            // lblNis
            // 
            this.lblNis.AutoSize = true;
            this.lblNis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblNis.Location = new System.Drawing.Point(300, 65);
            this.lblNis.Name = "lblNis";
            this.lblNis.Size = new System.Drawing.Size(12, 15);
            this.lblNis.TabIndex = 4;
            this.lblNis.Text = "-";
            // 
            // lblNisTitle
            // 
            this.lblNisTitle.AutoSize = true;
            this.lblNisTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNisTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblNisTitle.Location = new System.Drawing.Point(300, 43);
            this.lblNisTitle.Name = "lblNisTitle";
            this.lblNisTitle.Size = new System.Drawing.Size(24, 13);
            this.lblNisTitle.TabIndex = 3;
            this.lblNisTitle.Text = "NIS";
            // 
            // lblNama
            // 
            this.lblNama.AutoSize = true;
            this.lblNama.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(62)))), ((int)(((byte)(115)))));
            this.lblNama.Location = new System.Drawing.Point(18, 65);
            this.lblNama.Name = "lblNama";
            this.lblNama.Size = new System.Drawing.Size(12, 15);
            this.lblNama.TabIndex = 2;
            this.lblNama.Text = "-";
            // 
            // lblNamaTitle
            // 
            this.lblNamaTitle.AutoSize = true;
            this.lblNamaTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamaTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblNamaTitle.Location = new System.Drawing.Point(18, 43);
            this.lblNamaTitle.Name = "lblNamaTitle";
            this.lblNamaTitle.Size = new System.Drawing.Size(68, 13);
            this.lblNamaTitle.TabIndex = 1;
            this.lblNamaTitle.Text = "Nama Siswa";
            // 
            // lblSectionSiswa
            // 
            this.lblSectionSiswa.AutoSize = true;
            this.lblSectionSiswa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionSiswa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblSectionSiswa.Location = new System.Drawing.Point(18, 12);
            this.lblSectionSiswa.Name = "lblSectionSiswa";
            this.lblSectionSiswa.Size = new System.Drawing.Size(75, 17);
            this.lblSectionSiswa.TabIndex = 0;
            this.lblSectionSiswa.Text = "Data Siswa";
            // 
            // pnlDataSurat
            // 
            this.pnlDataSurat.BackColor = System.Drawing.Color.White;
            this.pnlDataSurat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDataSurat.Controls.Add(this.lblStatus);
            this.pnlDataSurat.Controls.Add(this.lblStatusTitle);
            this.pnlDataSurat.Controls.Add(this.lblNomorSurat);
            this.pnlDataSurat.Controls.Add(this.lblNomorSuratTitle);
            this.pnlDataSurat.Controls.Add(this.lblSectionSurat);
            this.pnlDataSurat.Location = new System.Drawing.Point(20, 18);
            this.pnlDataSurat.Name = "pnlDataSurat";
            this.pnlDataSurat.Size = new System.Drawing.Size(840, 105);
            this.pnlDataSurat.TabIndex = 0;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(83)))), ((int)(((byte)(9)))));
            this.lblStatus.Location = new System.Drawing.Point(450, 64);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(12, 15);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "-";
            // 
            // lblStatusTitle
            // 
            this.lblStatusTitle.AutoSize = true;
            this.lblStatusTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblStatusTitle.Location = new System.Drawing.Point(450, 43);
            this.lblStatusTitle.Name = "lblStatusTitle";
            this.lblStatusTitle.Size = new System.Drawing.Size(39, 13);
            this.lblStatusTitle.TabIndex = 3;
            this.lblStatusTitle.Text = "Status";
            // 
            // lblNomorSurat
            // 
            this.lblNomorSurat.AutoSize = true;
            this.lblNomorSurat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomorSurat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(62)))), ((int)(((byte)(115)))));
            this.lblNomorSurat.Location = new System.Drawing.Point(18, 64);
            this.lblNomorSurat.Name = "lblNomorSurat";
            this.lblNomorSurat.Size = new System.Drawing.Size(12, 15);
            this.lblNomorSurat.TabIndex = 2;
            this.lblNomorSurat.Text = "-";
            // 
            // lblNomorSuratTitle
            // 
            this.lblNomorSuratTitle.AutoSize = true;
            this.lblNomorSuratTitle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomorSuratTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblNomorSuratTitle.Location = new System.Drawing.Point(18, 43);
            this.lblNomorSuratTitle.Name = "lblNomorSuratTitle";
            this.lblNomorSuratTitle.Size = new System.Drawing.Size(72, 13);
            this.lblNomorSuratTitle.TabIndex = 1;
            this.lblNomorSuratTitle.Text = "Nomor Surat";
            // 
            // lblSectionSurat
            // 
            this.lblSectionSurat.AutoSize = true;
            this.lblSectionSurat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSectionSurat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.lblSectionSurat.Location = new System.Drawing.Point(18, 12);
            this.lblSectionSurat.Name = "lblSectionSurat";
            this.lblSectionSurat.Size = new System.Drawing.Size(103, 17);
            this.lblSectionSurat.TabIndex = 0;
            this.lblSectionSurat.Text = "Informasi Surat";
            // 
            // FormDetailTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(884, 641);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDetailTransaksi";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detail Transaksi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDetailTransaksi_Load_1);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlDataProses.ResumeLayout(false);
            this.pnlDataProses.PerformLayout();
            this.pnlDataIzin.ResumeLayout(false);
            this.pnlDataIzin.PerformLayout();
            this.pnlDataSiswa.ResumeLayout(false);
            this.pnlDataSiswa.PerformLayout();
            this.pnlDataSurat.ResumeLayout(false);
            this.pnlDataSurat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlDataIzin;
        private System.Windows.Forms.Label lblKembaliTitle;
        private System.Windows.Forms.Label lblWaktu;
        private System.Windows.Forms.Label lblWaktuTitle;
        private System.Windows.Forms.Label lblJenis;
        private System.Windows.Forms.Label lblJenisTitle;
        private System.Windows.Forms.Label lblSectionIIzin;
        private System.Windows.Forms.Panel pnlDataSiswa;
        private System.Windows.Forms.Label lblKelas;
        private System.Windows.Forms.Label lblKelasTitle;
        private System.Windows.Forms.Label lblNis;
        private System.Windows.Forms.Label lblNisTitle;
        private System.Windows.Forms.Label lblNama;
        private System.Windows.Forms.Label lblNamaTitle;
        private System.Windows.Forms.Label lblSectionSiswa;
        private System.Windows.Forms.Panel pnlDataSurat;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblStatusTitle;
        private System.Windows.Forms.Label lblNomorSurat;
        private System.Windows.Forms.Label lblNomorSuratTitle;
        private System.Windows.Forms.Label lblSectionSurat;
        private System.Windows.Forms.Label lblKembali;
        private System.Windows.Forms.Panel pnlDataProses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAlasan;
        private System.Windows.Forms.Label lblAlasanTitle;
        private System.Windows.Forms.Label lblWaktuProses;
        private System.Windows.Forms.Label lblWaktuProsesTitle;
        private System.Windows.Forms.Label lblPetugas;
        private System.Windows.Forms.Label lblPetugasTitle;
        private System.Windows.Forms.Label lblSectionProses;
        private System.Windows.Forms.Label lblKeterangan;
        private System.Windows.Forms.Label lblKeteranganTitle;
        private System.Windows.Forms.Label lblKeperluan;
        private System.Windows.Forms.Label lblKeperluanTitle;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Button btnTolak;
        private System.Windows.Forms.Button btnSetujui;
        private System.Windows.Forms.Button btnTutup;
        private System.Windows.Forms.Label label2;
    }
}