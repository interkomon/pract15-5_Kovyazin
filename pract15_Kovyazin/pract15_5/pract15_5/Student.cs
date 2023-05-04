using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace pract15_5
{
    internal class Student
    {

        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }

        public string PhoneNumber { get; set; }

        public string Address {get; set; }


        public Student(string fullName, DateTime birthDay, string phoneNumber, string address)
        {

            Regex regex = new Regex("^[а-яА-Я]+$");
            Regex regex1 = new Regex(@"^\+7\d{10}$");

            if(fullName == "" || phoneNumber == "" || address == "")
            {
                MessageBox.Show("Поля тне должны быть пустыми", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
            else

            if(!regex.IsMatch(fullName))
            {
                MessageBox.Show("Имя состоит из букв","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


            else if(!regex1.IsMatch(phoneNumber))
            {
                MessageBox.Show("Номер должен состоять из 11 цифр начиная с +7", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            FullName = fullName;
            BirthDay = birthDay;
            PhoneNumber = phoneNumber;
            Address = address;



        }

        public Student()
        {

        }







    }
}
