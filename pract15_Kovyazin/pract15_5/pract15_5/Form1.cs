using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static pract15_5.Student;

namespace pract15_5
{
    public partial class Form1 : Form
    {
        private Student student = new Student();



        public Form1()
        {
            InitializeComponent();
        }

        private void addbutton2_Click(object sender, EventArgs e)
        {
            student.FullName = fullnametextBox2.Text;
            student.BirthDay = birthdateTimePicker1.Value.Date;
            student.PhoneNumber = numberphonetextBox4.Text;
            student.Address = addresstextBox5.Text;

            new Student(student.FullName, student.BirthDay, student.PhoneNumber, student.Address);

            dataGridView1.Rows.Add(student.FullName, student.BirthDay, student.PhoneNumber, student.Address);
            dataGridView1.Update();
            dataGridView1.Refresh();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            kolvostudentlabel5.Visible = false;
            dataGridView1.Columns.Add("Полное имя - ФИО", "Полное имя - ФИО");
            dataGridView1.Columns.Add("Дата рождения", "Дата рождения");
            dataGridView1.Columns.Add("Номер телефона", "Номер телефона");
            dataGridView1.Columns.Add("Адрес", "Адрес");
            
        }

        private void delbutton3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void uznatkolvostudbutton1_Click(object sender, EventArgs e)
        {
            kolvostudentlabel5.Visible = true;

            int kolvo = dataGridView1.Rows.Count-1;

            
            kolvostudentlabel5.Text = kolvo.ToString();
        }

        private void poiskbutton1_Click(object sender, EventArgs e)
        {

            string search = poisktextBox1.Text;

            if (search == "")
            {
                MessageBox.Show("Ввод в поиск не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().Contains(search))
                    {
                        row.Selected = true;
                        break;
                    }
                }
            }

            dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.SelectedRows[0].Index;

        }
    }
}
