using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class StudentMenu : Form
    {
        void get_Info(ListView List)
        {
            string query = "select People.Temper, People.Data from People;";
            MySqlConnection conn = DB.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3), rd.GetString(4) };
                        var listViewItem = new ListViewItem(row);
                        listtemp.Items.Add(listViewItem);
                    }
                }
                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public StudentMenu()
        {
            InitializeComponent();

            login_poisk.Text = "Введите ФИО";
            login_poisk.ForeColor = Color.Gray;
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void vihod_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm win = new LoginForm();
            win.Show();
        }

        private void closebutton_MouseEnter(object sender, EventArgs e)
        {
            closebutton.ForeColor = Color.White;
        }

        private void closebutton_MouseLeave(object sender, EventArgs e)
        {
            closebutton.ForeColor = Color.Gold;
        }

        Point lastPoint;
        private void StudentMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void StudentMenu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void login_poisk_Enter(object sender, EventArgs e)
        {
            if (login_poisk.Text == "Введите ФИО")
            {
                login_poisk.Text = "";
                login_poisk.ForeColor = Color.Black;
            }
        }

        private void login_poisk_Leave(object sender, EventArgs e)
        {
            if (login_poisk.Text == "")
            {
                login_poisk.Text = "Введите ФИО";
                login_poisk.ForeColor = Color.Gray;
            }
        }

        private void login_search_Click(object sender, EventArgs e)
        {
            string query = "select People.Temper, People.Data from People where FI = '" + login_poisk.Text + "';"; 
            MySqlConnection conn = DB.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            MySqlDataReader rd;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string[] row = { rd.GetString(0), rd.GetString(1) };
                        var listViewItem = new ListViewItem(row);
                        listtemp.Items.Add(listViewItem);
                    }
                }
                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
