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
    public partial class FormLogin : Form
    {
        string koneksi = "server=localhost;password=;database=db_apotek_petugas;username=root";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(koneksi);
            string Username = txtUsername.Text;
            string password = txtPassword.Text;
            try
            {
                if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("username dan password tidakboleh kosong");
                    txtUsername.Focus();
                }
               
                    con.Open();
                    string query = "SELECT @username,@password, FORM tb_apoteker";
                    MySqlCommand komando = new MySqlCommand(query, con);
                    MySqlDataReader hasil = komando.ExecuteReader();
                    if (hasil.Read())
                    {
                        if (password == hasil["password"].ToString())
                        {
                            FormDashboard FormDashboard = new FormDashboard();
                            FormDashboard.Show();

                        }

                    }
                

            }
            catch
            {
                MessageBox.Show("gagal login");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister FormRegister = new FormRegister();
            FormRegister.Show();
            this.Hide();
        }
    }
}
