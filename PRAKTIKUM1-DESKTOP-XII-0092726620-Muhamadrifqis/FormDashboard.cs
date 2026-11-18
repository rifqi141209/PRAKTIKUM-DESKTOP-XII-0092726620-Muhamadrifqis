using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PRAKTIKUM1_DESKTOP_XII_0092726620_Muhamadrifqis
{
    public partial class FormDashboard : Form
    {
        string koneksi = "server=localhost;password=;database=db_apotek_petugas;username=root";
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MySqlConnection c = new MySqlConnection(koneksi);
            try
            {
                string query = "SELECT @id_petugas,@nama_petugas @shif FROM tb_apoteker ";
                MySqlCommand komando = new MySqlCommand(query, c);
                dataGridView1.
                
            }
            catch
            {

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            MySqlConnection c = new MySqlConnection(koneksi);
            string query = "SELECT * FROM tb_apoteker";
            MySqlCommand komando = new MySqlCommand(query, c);
        }
    }
}
