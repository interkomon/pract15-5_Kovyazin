namespace pract15_5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.birthdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addresstextBox5 = new System.Windows.Forms.TextBox();
            this.numberphonetextBox4 = new System.Windows.Forms.TextBox();
            this.fullnametextBox2 = new System.Windows.Forms.TextBox();
            this.addbutton2 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.kolvostudentlabel5 = new System.Windows.Forms.Label();
            this.uznatkolvostudbutton1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.poiskdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.delbutton3 = new System.Windows.Forms.Button();
            this.poiskbutton1 = new System.Windows.Forms.Button();
            this.poisktextBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 438);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Cyan;
            this.tabPage1.Controls.Add(this.birthdateTimePicker1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.addresstextBox5);
            this.tabPage1.Controls.Add(this.numberphonetextBox4);
            this.tabPage1.Controls.Add(this.fullnametextBox2);
            this.tabPage1.Controls.Add(this.addbutton2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(781, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // birthdateTimePicker1
            // 
            this.birthdateTimePicker1.Location = new System.Drawing.Point(146, 71);
            this.birthdateTimePicker1.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.birthdateTimePicker1.Name = "birthdateTimePicker1";
            this.birthdateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.birthdateTimePicker1.TabIndex = 21;
            this.birthdateTimePicker1.Value = new System.DateTime(1900, 5, 3, 10, 32, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Номер телефона";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Дата рождения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ФИО";
            // 
            // addresstextBox5
            // 
            this.addresstextBox5.Location = new System.Drawing.Point(146, 158);
            this.addresstextBox5.Name = "addresstextBox5";
            this.addresstextBox5.Size = new System.Drawing.Size(100, 20);
            this.addresstextBox5.TabIndex = 16;
            // 
            // numberphonetextBox4
            // 
            this.numberphonetextBox4.Location = new System.Drawing.Point(146, 112);
            this.numberphonetextBox4.Name = "numberphonetextBox4";
            this.numberphonetextBox4.Size = new System.Drawing.Size(100, 20);
            this.numberphonetextBox4.TabIndex = 15;
            this.numberphonetextBox4.Text = "+7";
            // 
            // fullnametextBox2
            // 
            this.fullnametextBox2.Location = new System.Drawing.Point(146, 36);
            this.fullnametextBox2.Name = "fullnametextBox2";
            this.fullnametextBox2.Size = new System.Drawing.Size(100, 20);
            this.fullnametextBox2.TabIndex = 14;
            // 
            // addbutton2
            // 
            this.addbutton2.Location = new System.Drawing.Point(146, 226);
            this.addbutton2.Name = "addbutton2";
            this.addbutton2.Size = new System.Drawing.Size(75, 23);
            this.addbutton2.TabIndex = 13;
            this.addbutton2.Text = "добавить";
            this.addbutton2.UseVisualStyleBackColor = true;
            this.addbutton2.Click += new System.EventHandler(this.addbutton2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Cyan;
            this.tabPage2.Controls.Add(this.kolvostudentlabel5);
            this.tabPage2.Controls.Add(this.uznatkolvostudbutton1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.poiskdateTimePicker1);
            this.tabPage2.Controls.Add(this.delbutton3);
            this.tabPage2.Controls.Add(this.poiskbutton1);
            this.tabPage2.Controls.Add(this.poisktextBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(781, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // kolvostudentlabel5
            // 
            this.kolvostudentlabel5.AutoSize = true;
            this.kolvostudentlabel5.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kolvostudentlabel5.Location = new System.Drawing.Point(463, 84);
            this.kolvostudentlabel5.Name = "kolvostudentlabel5";
            this.kolvostudentlabel5.Size = new System.Drawing.Size(0, 22);
            this.kolvostudentlabel5.TabIndex = 29;
            // 
            // uznatkolvostudbutton1
            // 
            this.uznatkolvostudbutton1.Location = new System.Drawing.Point(230, 371);
            this.uznatkolvostudbutton1.Name = "uznatkolvostudbutton1";
            this.uznatkolvostudbutton1.Size = new System.Drawing.Size(233, 23);
            this.uznatkolvostudbutton1.TabIndex = 28;
            this.uznatkolvostudbutton1.Text = "Узнать количетсво студентов";
            this.uznatkolvostudbutton1.UseVisualStyleBackColor = true;
            this.uznatkolvostudbutton1.Click += new System.EventHandler(this.uznatkolvostudbutton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(57, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(682, 214);
            this.dataGridView1.TabIndex = 27;
            // 
            // poiskdateTimePicker1
            // 
            this.poiskdateTimePicker1.Location = new System.Drawing.Point(57, 86);
            this.poiskdateTimePicker1.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.poiskdateTimePicker1.Name = "poiskdateTimePicker1";
            this.poiskdateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.poiskdateTimePicker1.TabIndex = 26;
            this.poiskdateTimePicker1.Value = new System.DateTime(1900, 5, 3, 10, 49, 0, 0);
            // 
            // delbutton3
            // 
            this.delbutton3.Location = new System.Drawing.Point(52, 371);
            this.delbutton3.Name = "delbutton3";
            this.delbutton3.Size = new System.Drawing.Size(140, 23);
            this.delbutton3.TabIndex = 19;
            this.delbutton3.Text = "удалить";
            this.delbutton3.UseVisualStyleBackColor = true;
            this.delbutton3.Click += new System.EventHandler(this.delbutton3_Click);
            // 
            // poiskbutton1
            // 
            this.poiskbutton1.Font = new System.Drawing.Font("Wingdings", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.poiskbutton1.Location = new System.Drawing.Point(346, 44);
            this.poiskbutton1.Name = "poiskbutton1";
            this.poiskbutton1.Size = new System.Drawing.Size(24, 20);
            this.poiskbutton1.TabIndex = 18;
            this.poiskbutton1.Text = "button1";
            this.poiskbutton1.UseVisualStyleBackColor = true;
            this.poiskbutton1.Click += new System.EventHandler(this.poiskbutton1_Click);
            // 
            // poisktextBox1
            // 
            this.poisktextBox1.Location = new System.Drawing.Point(57, 44);
            this.poisktextBox1.Name = "poisktextBox1";
            this.poisktextBox1.Size = new System.Drawing.Size(283, 20);
            this.poisktextBox1.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 601);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker birthdateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addresstextBox5;
        private System.Windows.Forms.TextBox numberphonetextBox4;
        private System.Windows.Forms.TextBox fullnametextBox2;
        private System.Windows.Forms.Button addbutton2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker poiskdateTimePicker1;
        private System.Windows.Forms.Button delbutton3;
        private System.Windows.Forms.Button poiskbutton1;
        private System.Windows.Forms.TextBox poisktextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label kolvostudentlabel5;
        private System.Windows.Forms.Button uznatkolvostudbutton1;
    }
}

