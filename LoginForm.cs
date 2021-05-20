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
    
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 64);
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

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }


        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text;
            String passUser = passField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `UsersDB` WHERE `Login` = @uL AND `Password` = @uP", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0 && loginField.Text == "Admin" && passField.Text == "Admin")
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            else
            {
                this.Hide();
                StudentMenu win = new StudentMenu();
                win.Show();
            }
            
    }

        
private void registerLable_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void registerLable_MouseEnter(object sender, EventArgs e)
        {
            registerLable.ForeColor = Color.Cornsilk;
        }

        private void registerLable_MouseLeave(object sender, EventArgs e)
        {
            registerLable.ForeColor = Color.Gold;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Count = 0;
            String query = "select count(*) from UsersDB where Login = '" + loginField.Text + "' and Password = '" + passField.Text + "';";
            MySqlConnection conn = DB.GetDBConnection();
            MySqlCommand cmDB = new MySqlCommand(query, conn);
            cmDB.CommandTimeout = 60;
            try
            {
                conn.Open();
                Count = Convert.ToInt32(cmDB.ExecuteScalar());
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Это просто буква А, ничего подозрительного");
            }

            if (Count > 0 && loginField.Text == "Admin" && passField.Text == "Admin")
            {
                AdminMenu win = new AdminMenu();
                win.Show();
                this.Hide();
            }
            else
            {
                if (Count > 0 && loginField.Text == "Security" && passField.Text == "123Lock")
                {
                    MainForm1 win = new MainForm1();
                    win.Show();
                    this.Hide();
                }
            }
        }
    }
}
