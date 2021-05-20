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
    public partial class AddNewUser1 : Form
    {
        public AddNewUser1()
        {
            InitializeComponent();

            this.pass_new.AutoSize = false;
            this.pass_new.Size = new Size(this.pass_new.Size.Width, 52);

            textBox1.Text = "Введите ФИО";
            textBox1.ForeColor = Color.Gray;

            pass_new.Text = "Введите пароль";
            pass_new.ForeColor = Color.Gray;

            login_new.Text = "Введите логин";
            login_new.ForeColor = Color.Gray;

        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_new_Enter(object sender, EventArgs e)
        {
            if (login_new.Text == "Введите логин")
            {
                login_new.Text = "";
                login_new.ForeColor = Color.Black;
            }
        }

        private void login_new_Leave(object sender, EventArgs e)
        {
            if (login_new.Text == "")
            {
                login_new.Text = "Введите логин";
                login_new.ForeColor = Color.Gray;
            }
        }

        private void pass_new_Enter(object sender, EventArgs e)
        {
            if (pass_new.Text == "Введите пароль")
            {
                pass_new.Text = "";
                pass_new.ForeColor = Color.Black;
            }
        }

        private void pass_new_Leave(object sender, EventArgs e)
        {
            if (pass_new.Text == "")
            {
                pass_new.Text = "Введите пароль";
                pass_new.ForeColor = Color.Gray;
            }
        }

        Point lastPoint;
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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void closebutton_MouseEnter(object sender, EventArgs e)
        {
            closebutton.ForeColor = Color.White;
        }

        private void closebutton_MouseLeave(object sender, EventArgs e)
        {
            closebutton.ForeColor = Color.Gold;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu win = new AdminMenu();
            win.Show();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите ФИО")
            {
                MessageBox.Show("Ведите ФИО");
                return;
            }

            if (login_new.Text == "Введите логин")
            {
                MessageBox.Show("Ведите логин");
                return;
            }

            if (pass_new.Text == "" && pass_new.Text == "Введите пароль")
            {
                MessageBox.Show("Ведите пароль");
                return;
            }

            if (isUserExists())
                return;

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `UsersDB` (`FIO`,`Login`, `Password`) VALUES (@fio ,@login, @pass)", db.getConnection());
            command.Parameters.Add("@fio", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login_new.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass_new.Text;


            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Аккаунт был создан");
            else
                MessageBox.Show("Аккаунт не был создан");
            this.Hide();
            AdminMenu adm = new AdminMenu();
            adm.Show();
            db.closeConnection();
        }

        public Boolean isUserExists()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `UsersDB` WHERE `Login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login_new.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже есть, введите другой");
                return true;
            }

            else
                return false;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Введите ФИО")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Введите ФИО";
                textBox1.ForeColor = Color.Gray;
            }
        }
    }
}
