using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ChamNet.GUI
{
    public partial class FormKetNoi : Form
    {
        public bool kt;

        public FormKetNoi()
        {
            InitializeComponent();
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtServer.Text))
            {
                MessageBox.Show("Hãy điền tên server!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (cmbDatabase.Text != "QLSV_ninh")
                {
                    MessageBox.Show("Cơ sở dữ liệu không chính xác. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Configuration _config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    _config.AppSettings.Settings["Server"].Value = txtServer.Text;
                    _config.AppSettings.Settings["Database"].Value = cmbDatabase.Text;
                    _config.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");

                    string conn = "Data Source = " + txtServer.Text + ";Initial Catalog=" + cmbDatabase.Text + ";Integrated Security=true;";
                    SqlConnection connect = new SqlConnection(conn);
                    try
                    {
                        connect.Open();
                        MessageBox.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        kt = true;
                        this.Hide();
                    }
                    catch
                    {
                        MessageBox.Show("Kết nối thất bại. Vui lòng kiểm tra lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        kt = false;
                    }
                    finally
                    {
                        connect.Close();
                    }
                }

            }
        }

        private void FormKetNoi_Load(object sender, EventArgs e)
        {
             get_database(txtServer.Text);
            cmbDatabase.Text = "QLSV_ninh";
            txtServer.Focus();
        }
        public void get_database(string server)
        {
            if (String.IsNullOrEmpty(server))
            {
                MessageBox.Show("Hãy điền tên server!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                using (var con = new SqlConnection("Data Source = " + server + ";Integrated Security=True;"))
                {
                    con.Open();
                    DataTable databases = con.GetSchema("databases");

                    if (databases != null)
                    {
                        foreach (DataRow database in databases.Rows)
                        {
                            String database_name = database.Field<String>("database_name");
                            short dbID = database.Field<short>("dbid");
                            cmbDatabase.Items.Add(database_name);
                        }
                    }
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtServer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
                cmbDatabase.Focus();
        }

        private void cmbDatabase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnKetNoi_Click(btnKetNoi, e);
            else if (e.KeyCode == Keys.Up)
                txtServer.Focus();
        }
    }
}
