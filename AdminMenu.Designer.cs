namespace _1
{
    partial class AdminMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddNewUser = new System.Windows.Forms.Button();
            this.delstat = new System.Windows.Forms.Button();
            this.listadmin = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Login = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Password = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FIO = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.closebutton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.BackgroundImage = global::_1.Properties.Resources._4;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.AddNewUser);
            this.panel1.Controls.Add(this.delstat);
            this.panel1.Controls.Add(this.listadmin);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 627);
            this.panel1.TabIndex = 2;
            // 
            // AddNewUser
            // 
            this.AddNewUser.BackColor = System.Drawing.Color.Brown;
            this.AddNewUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.AddNewUser.FlatAppearance.BorderSize = 2;
            this.AddNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewUser.ForeColor = System.Drawing.Color.Gold;
            this.AddNewUser.Location = new System.Drawing.Point(28, 106);
            this.AddNewUser.Name = "AddNewUser";
            this.AddNewUser.Size = new System.Drawing.Size(142, 41);
            this.AddNewUser.TabIndex = 5;
            this.AddNewUser.Text = "Добавить пользователя";
            this.AddNewUser.UseVisualStyleBackColor = false;
            this.AddNewUser.Click += new System.EventHandler(this.AddNewUser_Click);
            // 
            // delstat
            // 
            this.delstat.BackColor = System.Drawing.Color.Brown;
            this.delstat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.delstat.FlatAppearance.BorderSize = 2;
            this.delstat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delstat.ForeColor = System.Drawing.Color.Gold;
            this.delstat.Location = new System.Drawing.Point(421, 106);
            this.delstat.Name = "delstat";
            this.delstat.Size = new System.Drawing.Size(142, 41);
            this.delstat.TabIndex = 2;
            this.delstat.Text = "Удалить пользователя";
            this.delstat.UseVisualStyleBackColor = false;
            this.delstat.Click += new System.EventHandler(this.delstat_Click);
            // 
            // listadmin
            // 
            this.listadmin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.Login,
            this.Password,
            this.FIO});
            this.listadmin.GridLines = true;
            this.listadmin.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listadmin.HideSelection = false;
            this.listadmin.Location = new System.Drawing.Point(28, 167);
            this.listadmin.Margin = new System.Windows.Forms.Padding(0);
            this.listadmin.Name = "listadmin";
            this.listadmin.Size = new System.Drawing.Size(535, 448);
            this.listadmin.TabIndex = 1;
            this.listadmin.UseCompatibleStateImageBehavior = false;
            this.listadmin.View = System.Windows.Forms.View.Details;
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 30;
            // 
            // Login
            // 
            this.Login.Text = "Логин";
            this.Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Login.Width = 100;
            // 
            // Password
            // 
            this.Password.Text = "Пароль";
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password.Width = 100;
            // 
            // FIO
            // 
            this.FIO.Text = "ФИО";
            this.FIO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FIO.Width = 300;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.closebutton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(582, 100);
            this.panel2.TabIndex = 0;
            // 
            // closebutton
            // 
            this.closebutton.AutoSize = true;
            this.closebutton.BackColor = System.Drawing.Color.Red;
            this.closebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closebutton.ForeColor = System.Drawing.Color.Gold;
            this.closebutton.Location = new System.Drawing.Point(555, 0);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(27, 31);
            this.closebutton.TabIndex = 2;
            this.closebutton.Text = "x";
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Brown;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Админ панель";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 626);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button delstat;
        public System.Windows.Forms.ListView listadmin;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader Login;
        private System.Windows.Forms.ColumnHeader Password;
        private System.Windows.Forms.ColumnHeader FIO;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddNewUser;
        private System.Windows.Forms.Label closebutton;
    }
}