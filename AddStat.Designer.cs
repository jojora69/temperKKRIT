
namespace _1
{
    partial class AddStat
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
            this.backmain = new System.Windows.Forms.Button();
            this.stat = new System.Windows.Forms.TextBox();
            this.tag = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.buttonaddstat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closebutton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Temper = new System.Windows.Forms.Label();
            this.data_tut = new System.Windows.Forms.Label();
            this.status_tut = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Linen;
            this.panel1.BackgroundImage = global::_1.Properties.Resources._4;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.status_tut);
            this.panel1.Controls.Add(this.data_tut);
            this.panel1.Controls.Add(this.Temper);
            this.panel1.Controls.Add(this.backmain);
            this.panel1.Controls.Add(this.stat);
            this.panel1.Controls.Add(this.tag);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.author);
            this.panel1.Controls.Add(this.buttonaddstat);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(416, 500);
            this.panel1.TabIndex = 1;
            // 
            // backmain
            // 
            this.backmain.BackColor = System.Drawing.Color.Brown;
            this.backmain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backmain.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.backmain.FlatAppearance.BorderSize = 2;
            this.backmain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.backmain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.backmain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backmain.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backmain.ForeColor = System.Drawing.Color.Gold;
            this.backmain.Location = new System.Drawing.Point(230, 437);
            this.backmain.Name = "backmain";
            this.backmain.Size = new System.Drawing.Size(159, 42);
            this.backmain.TabIndex = 11;
            this.backmain.Text = "Назад";
            this.backmain.UseVisualStyleBackColor = false;
            this.backmain.Click += new System.EventHandler(this.backmain_Click);
            // 
            // stat
            // 
            this.stat.Font = new System.Drawing.Font("Sitka Banner", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stat.Location = new System.Drawing.Point(278, 325);
            this.stat.Multiline = true;
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(95, 39);
            this.stat.TabIndex = 10;
            // 
            // tag
            // 
            this.tag.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tag.Location = new System.Drawing.Point(278, 259);
            this.tag.Multiline = true;
            this.tag.Name = "tag";
            this.tag.Size = new System.Drawing.Size(95, 39);
            this.tag.TabIndex = 9;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Sitka Banner", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(278, 193);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(95, 39);
            this.name.TabIndex = 8;
            // 
            // author
            // 
            this.author.Font = new System.Drawing.Font("Sitka Banner", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.author.Location = new System.Drawing.Point(39, 128);
            this.author.Multiline = true;
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(334, 39);
            this.author.TabIndex = 7;
            this.author.Enter += new System.EventHandler(this.author_Enter);
            this.author.Leave += new System.EventHandler(this.author_Leave);
            // 
            // buttonaddstat
            // 
            this.buttonaddstat.BackColor = System.Drawing.Color.Brown;
            this.buttonaddstat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonaddstat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonaddstat.FlatAppearance.BorderSize = 2;
            this.buttonaddstat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.buttonaddstat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.buttonaddstat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonaddstat.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonaddstat.ForeColor = System.Drawing.Color.Gold;
            this.buttonaddstat.Location = new System.Drawing.Point(12, 437);
            this.buttonaddstat.Name = "buttonaddstat";
            this.buttonaddstat.Size = new System.Drawing.Size(159, 42);
            this.buttonaddstat.TabIndex = 5;
            this.buttonaddstat.Text = "Добавить";
            this.buttonaddstat.UseVisualStyleBackColor = false;
            this.buttonaddstat.Click += new System.EventHandler(this.buttonaddstat_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.closebutton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 100);
            this.panel2.TabIndex = 0;
            // 
            // closebutton
            // 
            this.closebutton.AutoSize = true;
            this.closebutton.BackColor = System.Drawing.Color.Red;
            this.closebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closebutton.ForeColor = System.Drawing.Color.Gold;
            this.closebutton.Location = new System.Drawing.Point(386, 0);
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
            this.label1.Size = new System.Drawing.Size(416, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добавить данные";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Temper
            // 
            this.Temper.AutoSize = true;
            this.Temper.BackColor = System.Drawing.Color.Brown;
            this.Temper.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Temper.ForeColor = System.Drawing.Color.Gold;
            this.Temper.Location = new System.Drawing.Point(69, 199);
            this.Temper.Name = "Temper";
            this.Temper.Size = new System.Drawing.Size(156, 25);
            this.Temper.TabIndex = 12;
            this.Temper.Text = "Температура";
            // 
            // data_tut
            // 
            this.data_tut.AutoSize = true;
            this.data_tut.BackColor = System.Drawing.Color.Brown;
            this.data_tut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.data_tut.ForeColor = System.Drawing.Color.Gold;
            this.data_tut.Location = new System.Drawing.Point(69, 265);
            this.data_tut.Name = "data_tut";
            this.data_tut.Size = new System.Drawing.Size(66, 25);
            this.data_tut.TabIndex = 13;
            this.data_tut.Text = "Дата";
            // 
            // status_tut
            // 
            this.status_tut.AutoSize = true;
            this.status_tut.BackColor = System.Drawing.Color.Brown;
            this.status_tut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.status_tut.ForeColor = System.Drawing.Color.Gold;
            this.status_tut.Location = new System.Drawing.Point(69, 325);
            this.status_tut.Name = "status_tut";
            this.status_tut.Size = new System.Drawing.Size(87, 25);
            this.status_tut.TabIndex = 14;
            this.status_tut.Text = "Статус";
            // 
            // AddStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 499);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStat";
            this.Text = "AddStat";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonaddstat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.Button backmain;
        private System.Windows.Forms.TextBox stat;
        private System.Windows.Forms.TextBox tag;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label status_tut;
        private System.Windows.Forms.Label data_tut;
        private System.Windows.Forms.Label Temper;
    }
}