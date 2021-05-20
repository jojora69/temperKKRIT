
namespace _1
{
    partial class AddNewUser1
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
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.pass_new = new System.Windows.Forms.TextBox();
            this.login_new = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closebutton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.BackgroundImage = global::_1.Properties.Resources._4;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Controls.Add(this.pass_new);
            this.panel1.Controls.Add(this.login_new);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 434);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Brown;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Gold;
            this.button1.Location = new System.Drawing.Point(221, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Brown;
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonRegister.FlatAppearance.BorderSize = 2;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.ForeColor = System.Drawing.Color.Gold;
            this.buttonRegister.Location = new System.Drawing.Point(24, 360);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(132, 40);
            this.buttonRegister.TabIndex = 5;
            this.buttonRegister.Text = "Добавить";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // pass_new
            // 
            this.pass_new.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pass_new.Location = new System.Drawing.Point(38, 283);
            this.pass_new.Name = "pass_new";
            this.pass_new.Size = new System.Drawing.Size(289, 48);
            this.pass_new.TabIndex = 4;
            this.pass_new.Enter += new System.EventHandler(this.pass_new_Enter);
            this.pass_new.Leave += new System.EventHandler(this.pass_new_Leave);
            // 
            // login_new
            // 
            this.login_new.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_new.Location = new System.Drawing.Point(38, 203);
            this.login_new.Multiline = true;
            this.login_new.Name = "login_new";
            this.login_new.Size = new System.Drawing.Size(289, 52);
            this.login_new.TabIndex = 2;
            this.login_new.Enter += new System.EventHandler(this.login_new_Enter);
            this.login_new.Leave += new System.EventHandler(this.login_new_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.closebutton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 100);
            this.panel2.TabIndex = 0;
            // 
            // closebutton
            // 
            this.closebutton.AutoSize = true;
            this.closebutton.BackColor = System.Drawing.Color.Red;
            this.closebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closebutton.ForeColor = System.Drawing.Color.Gold;
            this.closebutton.Location = new System.Drawing.Point(336, 0);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(27, 31);
            this.closebutton.TabIndex = 1;
            this.closebutton.Text = "x";
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            this.closebutton.MouseEnter += new System.EventHandler(this.closebutton_MouseEnter);
            this.closebutton.MouseLeave += new System.EventHandler(this.closebutton_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Brown;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавление пользователя";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(38, 123);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(289, 52);
            this.textBox1.TabIndex = 7;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // AddNewUser1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 434);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewUser1";
            this.Text = "AddNewUser1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox pass_new;
        private System.Windows.Forms.TextBox login_new;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
    }
}