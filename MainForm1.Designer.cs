﻿
namespace _1
{
    partial class MainForm1
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
            this.redact_stat = new System.Windows.Forms.Button();
            this.addstat = new System.Windows.Forms.Button();
            this.delstat = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Temper = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.panel1.Controls.Add(this.redact_stat);
            this.panel1.Controls.Add(this.addstat);
            this.panel1.Controls.Add(this.delstat);
            this.panel1.Controls.Add(this.list);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 677);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // redact_stat
            // 
            this.redact_stat.BackColor = System.Drawing.Color.Brown;
            this.redact_stat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.redact_stat.FlatAppearance.BorderSize = 2;
            this.redact_stat.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gold;
            this.redact_stat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.redact_stat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.redact_stat.ForeColor = System.Drawing.Color.Gold;
            this.redact_stat.Location = new System.Drawing.Point(914, 214);
            this.redact_stat.Name = "redact_stat";
            this.redact_stat.Size = new System.Drawing.Size(142, 41);
            this.redact_stat.TabIndex = 4;
            this.redact_stat.Text = "Редактировать данные";
            this.redact_stat.UseVisualStyleBackColor = false;
            this.redact_stat.Click += new System.EventHandler(this.redact_stat_Click);
            // 
            // addstat
            // 
            this.addstat.BackColor = System.Drawing.Color.Brown;
            this.addstat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.addstat.FlatAppearance.BorderSize = 2;
            this.addstat.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gold;
            this.addstat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.addstat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addstat.ForeColor = System.Drawing.Color.Gold;
            this.addstat.Location = new System.Drawing.Point(914, 153);
            this.addstat.Name = "addstat";
            this.addstat.Size = new System.Drawing.Size(142, 41);
            this.addstat.TabIndex = 3;
            this.addstat.Text = "Добавить данные";
            this.addstat.UseVisualStyleBackColor = false;
            this.addstat.Click += new System.EventHandler(this.addstat_Click);
            // 
            // delstat
            // 
            this.delstat.BackColor = System.Drawing.Color.Brown;
            this.delstat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.delstat.FlatAppearance.BorderSize = 2;
            this.delstat.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gold;
            this.delstat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.delstat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delstat.ForeColor = System.Drawing.Color.Gold;
            this.delstat.Location = new System.Drawing.Point(914, 276);
            this.delstat.Name = "delstat";
            this.delstat.Size = new System.Drawing.Size(142, 41);
            this.delstat.TabIndex = 2;
            this.delstat.Text = "Удалить данные";
            this.delstat.UseVisualStyleBackColor = false;
            this.delstat.Click += new System.EventHandler(this.delstat_Click);
            // 
            // list
            // 
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.FI,
            this.Temper,
            this.Data,
            this.Status});
            this.list.GridLines = true;
            this.list.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(28, 139);
            this.list.Margin = new System.Windows.Forms.Padding(0);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(867, 514);
            this.list.TabIndex = 1;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // id
            // 
            this.id.Text = "№";
            this.id.Width = 30;
            // 
            // FI
            // 
            this.FI.Text = "ФИО";
            this.FI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FI.Width = 400;
            // 
            // Temper
            // 
            this.Temper.Text = "Температура";
            this.Temper.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Temper.Width = 100;
            // 
            // Data
            // 
            this.Data.Text = "Дата";
            this.Data.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Data.Width = 100;
            // 
            // Status
            // 
            this.Status.Text = "Статус";
            this.Status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Status.Width = 233;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.closebutton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 100);
            this.panel2.TabIndex = 0;
            // 
            // closebutton
            // 
            this.closebutton.AutoSize = true;
            this.closebutton.BackColor = System.Drawing.Color.Red;
            this.closebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closebutton.ForeColor = System.Drawing.Color.Gold;
            this.closebutton.Location = new System.Drawing.Point(1043, 0);
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
            this.label1.Size = new System.Drawing.Size(1070, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Главный экран";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // MainForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 676);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader FI;
        private System.Windows.Forms.ColumnHeader Temper;
        private System.Windows.Forms.ColumnHeader Data;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.Button addstat;
        private System.Windows.Forms.Button delstat;
        public System.Windows.Forms.ListView list;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Button redact_stat;
    }
}