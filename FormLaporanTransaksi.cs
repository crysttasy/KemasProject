using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace KemasProject
{
    public partial class FormLaporanTransaksi : Form
    {
        public FormLaporanTransaksi()
        {
            InitializeComponent();
            LoadLaporan();
        }

        private void LoadLaporan()
        {
            DataSetTransaksi dataSet = new DataSetTransaksi();

            string query = @"
                SELECT
                    p.id,
                    p.nomor_surat,
                    s.nama_siswa,
                    p.jenis_izin,
                    p.waktu_izin,
                    p.keperluan,
                    p.status
                FROM perizinan p
                INNER JOIN siswa s ON s.id = p.siswa_id
                ORDER BY p.created_at DESC, p.id DESC";

            try
            {
                if (conn.connec.State != ConnectionState.Open)
                    conn.connec.Open();

                using (MySqlCommand cmd = new MySqlCommand(query, conn.connec))
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable tabel = new DataTable();
                    adapter.Fill(tabel);

                    dataSet.Tables["dtTransaksi"].Clear();

                    int nomor = 1;

                    foreach (DataRow row in tabel.Rows)
                    {
                        dataSet.Tables["dtTransaksi"].Rows.Add(
                            nomor++,
                            Convert.ToInt32(row["id"]),
                            row["nomor_surat"].ToString(),
                            row["nama_siswa"].ToString(),
                            row["jenis_izin"].ToString(),
                            Convert.ToDateTime(row["waktu_izin"]),
                            row["keperluan"].ToString(),
                            row["status"].ToString()
                        );
                    }
                }

                ReportDocument report = new ReportDocument();
                report.Load(Application.StartupPath + @"\LaporanTransaksi.rpt");
                report.SetDataSource(dataSet);
                crViewer.ReportSource = report;
                crViewer.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal memuat laporan: " + ex.Message,
                    "Kesalahan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                if (conn.connec.State == ConnectionState.Open)
                    conn.connec.Close();
            }
        }
    }
}