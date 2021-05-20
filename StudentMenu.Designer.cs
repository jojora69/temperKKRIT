
namespace _1
{
    partial class StudentMenu
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
            this.listtemp = new System.Windows.Forms.ListView();
            this.temper = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.closebutton = new System.Windows.Forms.Label();
            this.vihod = new System.Windows.Forms.Button();
            this.login_search = new System.Windows.Forms.Button();
            this.login_poisk = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listtemp
            // 
            this.listtemp.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.temper,
            this.data});
            this.listtemp.HideSelection = false;
            this.listtemp.Location = new System.Drawing.Point(19, 115);
            this.listtemp.Name = "listtemp";
            this.listtemp.Size = new System.Drawing.Size(170, 529);
            this.listtemp.TabIndex = 3;
            this.listtemp.UseCompatibleStateImageBehavior = false;
            this.listtemp.View = System.Windows.Forms.View.Details;
            // 
            // temper
            // 
            this.temper.Text = "Температура";
            this.temper.Width = 100;
            // 
            // data
            // 
            this.data.Text = "Дата";
            this.data.Width = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Brown;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(360, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Динамика температуры";
            // 
            // closebutton
            // 
            this.closebutton.AutoSize = true;
            this.closebutton.BackColor = System.Drawing.Color.Red;
            this.closebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closebutton.ForeColor = System.Drawing.Color.Gold;
            this.closebutton.Location = new System.Drawing.Point(363, -1);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(27, 31);
            this.closebutton.TabIndex = 5;
            this.closebutton.Text = "x";
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            this.closebutton.MouseEnter += new System.EventHandler(this.closebutton_MouseEnter);
            this.closebutton.MouseLeave += new System.EventHandler(this.closebutton_MouseLeave);
            // 
            // vihod
            // 
            this.vihod.BackColor = System.Drawing.Color.Brown;
            this.vihod.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.vihod.FlatAppearance.BorderSize = 2;
            this.vihod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vihod.ForeColor = System.Drawing.Color.Gold;
            this.vihod.Location = new System.Drawing.Point(209, 605);
            this.vihod.Name = "vihod";
            this.vihod.Size = new System.Drawing.Size(169, 39);
            this.vihod.TabIndex = 6;
            this.vihod.Text = "Выйти из аккаунта";
            this.vihod.UseVisualStyleBackColor = false;
            this.vihod.Click += new System.EventHandler(this.vihod_Click);
            // 
            // login_search
            // 
            this.login_search.BackColor = System.Drawing.Color.Brown;
            this.login_search.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.login_search.FlatAppearance.BorderSize = 2;
            this.login_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_search.ForeColor = System.Drawing.Color.Gold;
            this.login_search.Location = new System.Drawing.Point(203, 158);
            this.login_search.Name = "login_search";
            this.login_search.Size = new System.Drawing.Size(169, 39);
            this.login_search.TabIndex = 7;
            this.login_search.Text = "Получить данные";
            this.login_search.UseVisualStyleBackColor = false;
            this.login_search.Click += new System.EventHandler(this.login_search_Click);
            // 
            // login_poisk
            // 
            this.login_poisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_poisk.Location = new System.Drawing.Point(203, 115);
            this.login_poisk.Multiline = true;
            this.login_poisk.Name = "login_poisk";
            this.login_poisk.Size = new System.Drawing.Size(169, 37);
            this.login_poisk.TabIndex = 8;
            this.login_poisk.Enter += new System.EventHandler(this.login_poisk_Enter);
            this.login_poisk.Leave += new System.EventHandler(this.login_poisk_Leave);
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.BackgroundImage = global::_1.Properties.Resources._4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(390, 656);
            this.Controls.Add(this.login_poisk);
            this.Controls.Add(this.login_search);
            this.Controls.Add(this.vihod);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listtemp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentMenu";
            this.Text = "StudentMenu";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StudentMenu_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StudentMenu_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listtemp;
        private System.Windows.Forms.ColumnHeader temper;
        private System.Windows.Forms.ColumnHeader data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label closebutton;
        private System.Windows.Forms.Button vihod;
        private System.Windows.Forms.Button login_search;
        private System.Windows.Forms.TextBox login_poisk;
    }
}