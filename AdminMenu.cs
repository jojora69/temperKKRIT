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
    public partial class AdminMenu : Form
    {
        void get_Info(ListView List)
        {
            string query = " select UsersDB.Id_UsersDB, UsersDB.Login, UsersDB.Password,UsersDB.FIO from UsersDB;";
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
                        string[] row = { rd.GetString(0), rd.GetString(1), rd.GetString(2), rd.GetString(3) };
                        var listViewItem = new ListViewItem(row);
                        listadmin.Items.Add(listViewItem);
                    }
                }
                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public AdminMenu()
        {
            InitializeComponent();
            get_Info(listadmin);
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AddNewUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNewUser1 win = new AddNewUser1();
            win.Show();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void delstat_Click(object sender, EventArgs e)
        {
            string query = "delete from UsersDB where Id_UsersDB = " + listadmin.Items[listadmin.SelectedIndices[0]].Text + ";";
            MySqlConnection conn = DB.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                MySqlDataReader rd = cmDB.ExecuteReader();
                conn.Close();
                this.listadmin.Items.Clear();
                get_Info(listadmin);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
