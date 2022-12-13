using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

      
        
        private void button1_Click(object sender, EventArgs e)
        {
            /*if (HelpClass.Remember != null)
            {
               /* string name = textBox1.Text;
                int year = dateTimePicker1.Value.Year;
                string date = dateTimePicker2.Text;
                string sum = textBox2.Text;
                string st = "";
                string color = comboBox1.Text;
                st = name + "|" + color + "|" + year + "|" + date + "|" + sum;
                MyClass.sValue = st;*/
                /*s1 = HelpClass.Remember;
                 string[] st1 = s1.Split('|');
                 string name = st1[0];
                 string color = st1[1];
                 string year = st1[2];
                 string date = st1[3];
                 string sum = st1[4];
                 textBox1.Text = st1[0];
                 comboBox1.Text = st1[1];
                 comboBox2.Text = st1[2];
                 textBox2.Text = st1[4];
                 string st = st1[0] + "|" + st1[1] + "|" + st1[2] + "|" + st1[3] + "|" + st1[4];
                // string st = name + "|" + color + "|" + year + "|" + date + "|" + sum;
                 HelpClass.Remember = st;
                string name = textBox1.Text;
                string year = comboBox2.Text;
                string date = dateTimePicker2.Text;
                string sum = textBox2.Text;
                string st = "";
                string color = comboBox1.Text;
                st = name + "|" + color + "|" + year + "|" + date + "|" + sum;
                HelpClass.Remember = st;
                MessageBox.Show("Нажмите 'Закрыть', чтоб увидеть результат", "Уважаемый пользователь", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {*/
                string name = textBox1.Text;
                string year = comboBox2.Text;
                string date = dateTimePicker2.Text;
                string sum = textBox2.Text;
                string st = "";
                string color = comboBox1.Text;
                st = name + "|" + color + "|" + year + "|" + date + "|" + sum;
                HelpClass.Remember = st;
                MessageBox.Show("Нажмите кнопку Закрыть, чтоб увидеть результат", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
