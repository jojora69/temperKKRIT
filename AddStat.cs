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
    public partial class AddStat : Form
    {
        public string modeS = "";
        int item;
        void setMode(string mode)
        {
            if (mode == "add")
            {
                buttonaddstat.Text = "Добавить";
            }
            else if (mode == "change")
            {
                label1.Text = "Редактировать данные";
                buttonaddstat.Text = "Изменить";
                string Info = "select FI, Temper, date_format(Data, '%Y-%m-%d'), id_Status from People where Id_People =" + item.ToString() + ";";
                MySqlConnection conn = DB.GetDBConnection();
                MySqlCommand cmInfo = new MySqlCommand(Info, conn);
                MySqlDataReader inRead;
                cmInfo.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    inRead = cmInfo.ExecuteReader();
                    if (inRead.HasRows)
                    {
                        while (inRead.Read())
                        {
                            author.Text = inRead.GetString(0);
                            name.Text = inRead.GetString(1);
                            tag.Text = inRead.GetString(2);
                            stat.Text = inRead.GetString(3);

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

        void getNames(ComboBox Box)
        {
            string query = "select FIO from UsersDB;";
            MySqlConnection conn = DB.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            MySqlDataReader rd;
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                rd = cmDB.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        string row = rd.GetString(0);
                        Box.Items.Add(row);
                    }
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public AddStat()
        {
            
        }

        public AddStat(string mode, int id)
        {
            InitializeComponent();
            author.Text = "Введите ФИО";
            author.ForeColor = Color.Gray;

            modeS = mode;
            item = id;
            setMode(mode);
            
        }

   

        private void author_Enter(object sender, EventArgs e)
        {
            if (author.Text == "Введите ФИО")
            {
                author.Text = "";
                author.ForeColor = Color.Black;
            }
        }

        private void author_Leave(object sender, EventArgs e)
        {
            if (author.Text == "")
            {
                author.Text = "Введите ФИО";
                author.ForeColor = Color.Gray;
            }
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closebutton_MouseEnter(object sender, EventArgs e)
        {
            closebutton.ForeColor = Color.White;
        }

        private void closebutton_MouseLeave(object sender, EventArgs e)
        {
            closebutton.ForeColor = Color.Gold;
        }

        private void backmain_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm1 mainForm1 = new MainForm1();
            mainForm1.Show();
        }

        private void buttonaddstat_Click(object sender, EventArgs e)
        {
            if (author.Text == "Введите ФИО")
            {
                MessageBox.Show("Введите ФИО");
                return;
            }

            if (name.Text == " ")
            {
                MessageBox.Show("Введите температуру");
                return;
            }

            if (tag.Text == " ")
            {
                MessageBox.Show("Введите дату");
                return;
            }

            if (stat.Text == " ")
            {
                MessageBox.Show("Введите статус");
                return;
            }

            if (modeS == "add")
            {
                string query = "insert into People(FI,Temper, Data, id_Status) values('" + author.Text + "', '" + name.Text + "', '" + tag.Text + "', '" + stat.Text + "');";
                MySqlConnection conn = DB.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                cmDB.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    MySqlDataReader rd = cmDB.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Данные успешно добавлены.");
                    this.Hide();
                    MainForm1 mainForm1 = new MainForm1();
                    mainForm1.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось добавить данные.");
                    MessageBox.Show(ex.Message);
                }
            }
            if (modeS == "change")
            {
                string content = stat.Text.ToString();
                string query = "update People set FI ='" + author.Text + "', Temper='" + name.Text + "', Data='" + tag.Text + "', id_Status='" + stat.Text + "' where Id_People = " + item.ToString() + ";";
                MySqlConnection conn = DB.GetDBConnection();
                MySqlCommand cmDB = new MySqlCommand(query, conn);
                cmDB.CommandTimeout = 60;
                try
                {
                    conn.Open();
                    MySqlDataReader rd = cmDB.ExecuteReader();
                    conn.Close();
                    MessageBox.Show("Данные успешно изменены.");
                    this.Hide();
                    MainForm1 mainForm1 = new MainForm1();
                    mainForm1.Show();
                    

                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось изменить данные.");
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
