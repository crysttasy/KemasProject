
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace KemasProject
{
    public partial class SignIn : Form
    {
        private bool isLoggingIn = false;
        private bool isPasswordVisible = false;

        public SignIn()
        {
            InitializeComponent();
            InitializeLoginForm();
        }

        // =========================================
        // INITIALIZE LOGIN FORM
        // =========================================

        private void InitializeLoginForm()
        {
            this.Load += SignIn_Load;
            this.FormClosing += SignIn_FormClosing;

            btnShowPassword.Click += btnShowPassword_Click;

            txtUsername.KeyDown += txtUsername_KeyDown;
            txtPassword.KeyDown += txtPassword_KeyDown;

            txtUsername.Focus();
        }

        // =========================================
        // FORM LOAD
        // =========================================

        private void SignIn_Load(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();

            txtPassword.UseSystemPasswordChar = true;

            isPasswordVisible = false;
            isLoggingIn = false;

            txtUsername.Focus();
        }

        // =========================================
        // LOGIN BUTTON
        // =========================================

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isLoggingIn)
                return;

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Validasi input
            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show(
                    "Username tidak boleh kosong.",
                    "Validasi Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Password tidak boleh kosong.",
                    "Validasi Login",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                txtPassword.Focus();
                return;
            }

            isLoggingIn = true;
            btnLogin.Enabled = false;

            try
            {
                // Pastikan koneksi tersedia
                if (conn.connec == null)
                {
                    throw new Exception("Koneksi database belum tersedia.");
                }

                if (conn.connec.State != System.Data.ConnectionState.Open)
                {
                    conn.connec.Open();
                }

                // Query login tanpa kolom role
                string query = @"
                    SELECT
                        id,
                        nama,
                        username,
                        password,
                        status
                    FROM users
                    WHERE username = @username
                    LIMIT 1;
                ";

                int userId = 0;
                string nama = "";
                string dbUsername = "";
                string dbPassword = "";
                string status = "";

                using (MySqlCommand cmd = new MySqlCommand(query, conn.connec))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userId = Convert.ToInt32(reader["id"]);
                            nama = reader["nama"].ToString();
                            dbUsername = reader["username"].ToString();
                            dbPassword = reader["password"].ToString();
                            status = reader["status"].ToString();
                        }
                    }
                }

                // Periksa keberadaan akun
                if (userId <= 0)
                {
                    MessageBox.Show(
                        "Username atau password yang dimasukkan salah.",
                        "Login Gagal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtPassword.Clear();
                    txtUsername.Focus();
                    return;
                }

                // Periksa status akun
                if (!status.Equals("Aktif", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "Akun Anda tidak aktif. Silakan hubungi administrator.",
                        "Akun Tidak Aktif",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtPassword.Clear();
                    txtUsername.Focus();
                    return;
                }

                // Verifikasi password SHA256
                string hashedPassword = HashPassword(password);

                if (!hashedPassword.Equals(
                    dbPassword,
                    StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "Username atau password yang dimasukkan salah.",
                        "Login Gagal",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }

                // Simpan sesi pengguna tanpa role
                Session.StartSession(
                    userId,
                    nama,
                    dbUsername,
                    status
                );

                MessageBox.Show(
                    "Login berhasil. Selamat datang, " + nama + "!",
                    "Login Berhasil",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Buka halaman utama
                OpenTransaksi();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(
                    "Gagal mengakses database.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Terjadi kesalahan saat login.\n\n" + ex.Message,
                    "Login Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                if (conn.connec != null &&
                    conn.connec.State == System.Data.ConnectionState.Open)
                {
                    conn.connec.Close();
                }

                isLoggingIn = false;

                if (!this.IsDisposed)
                {
                    btnLogin.Enabled = true;
                }
            }
        }

        // =========================================
        // HASH PASSWORD SHA256
        // =========================================

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder result = new StringBuilder();

                foreach (byte b in hash)
                {
                    result.Append(b.ToString("x2"));
                }

                return result.ToString();
            }
        }

        // =========================================
        // SHOW / HIDE PASSWORD
        // =========================================

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            txtPassword.UseSystemPasswordChar = !isPasswordVisible;

            btnShowPassword.Text = isPasswordVisible ? "◉" : "●";

            txtPassword.Focus();

            txtPassword.SelectionStart = txtPassword.Text.Length;
        }

        // =========================================
        // ENTER KEY LOGIN
        // =========================================

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnLogin.PerformClick();
            }
        }

        // =========================================
        // OPEN FORM TRANSAKSI
        // =========================================

        private void OpenTransaksi()
        {
            try
            {
                this.Hide();

                using (FormTransaksi form = new FormTransaksi())
                {
                    form.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Gagal membuka halaman utama.\n\n" + ex.Message,
                    "Form Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            finally
            {
                Session.ClearSession();

                if (!this.IsDisposed)
                {
                    this.Show();
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
            }
        }

        // =========================================
        // FORM CLOSING
        // =========================================

        private void SignIn_FormClosing(
            object sender,
            FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show(
                    "Apakah Anda yakin ingin keluar dari aplikasi?",
                    "Konfirmasi Keluar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
