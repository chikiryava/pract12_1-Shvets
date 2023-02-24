using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Student
    {
        private double weight = 75;
        public double height;
        public string name;
        public double GetEat()
        { return weight; }
        
        public double Check(string variable)
        {
            if (variable == string.Empty)
            {
                MessageBox.Show("Поле не может быть пустым");
                return -1;
            }
            if(!double.TryParse(variable, out double test))
            {
                MessageBox.Show("Вы ввели не число");
                return -1;
            }
            else
            {
                double value = double.Parse(variable);
                if (value <= 0) 
                {
                    MessageBox.Show("Значение не может быть меньше или равным 0");
                    return -1;
                } 
                else
                {
                    return value;
                }


            }
        }
        
        public string CheckName(string studentName)
        {
            bool testname = false;
            if (studentName.Length == 0)  
                testname = true;            
            for(int i = 0; i < studentName.Length; i++)
            {
                if (!char.IsLetter(studentName[i]) || studentName[i] == ' ')
                {
                    testname = true;
                }
            }
            if (testname == true)
            {
                MessageBox.Show("В имени могут содержаться только буквы и это поле не может быть пустым");
                return null;
            }
            else
                return name;
        }
        public void SetEat(double food)
        {
            if(food<5)
                weight += food-1.8;
            else if(food>5 && food < 10)
            {
                weight += (food - 1.8)*0.7;
                height -= 1;
            }
            else
            {
                weight += (food - 1.8) * 0.5;
                height -= 2;
            }
            MessageBox.Show($"Студент {name}\nРост {height}\nВес{weight}");
                
        } 

    }
}
