using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public delegate void MyDelegate(string data);
    public partial class Form1 : Form
    {
        Form2 fr2 = new Form2();
        public Form1()
        {
            InitializeComponent();
        }
        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fr2.ShowDialog();
            if (HelpClass.Remember != null) listBox1.Items.Add(HelpClass.Remember);
            HelpClass.Remember = null;
        }

        private void редактироватьToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int iSd = listBox1.SelectedIndex;
            string s5 = listBox1.Items[iSd].ToString();
            string[] st1 = s5.Split('|');
            string name = st1[0];
            string color = st1[1];
            string year = st1[2];
            string date = st1[3];
            string sum = st1[4];
            fr2.textBox1.Text = st1[0];
            fr2.comboBox1.Text = st1[1];
            fr2.comboBox2.Text = st1[2];
            string data = st1[3].ToString();
            string[] data1 = data.Split('.');
            fr2.dateTimePicker2.Value = new DateTime(Convert.ToInt32(data1[2]), Convert.ToInt32(data1[1]), Convert.ToInt32(data1[0]));
            fr2.textBox2.Text = st1[4];
            fr2.ShowDialog();
            if (HelpClass.Remember != null) listBox1.Items[iSd] = HelpClass.Remember;
            HelpClass.Remember = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string st = "";
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Файлы txt|*.txt";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                st = OPF.FileName;
            }
            StreamReader sr = new StreamReader(st);
            List<string> ls = new List<string>();
            while (!sr.EndOfStream)
            {
                string s;
                s = sr.ReadLine();
                ls.Add(s);
            }
            for (int i = 0; i < ls.Count; i++)
                listBox1.Items.Add(ls[i]);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void удалитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int iSd = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(iSd);
        }

        private void сохранитьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Итоговые данные.txt");
            for (int i = 0; i < listBox1.Items.Count; i++)
                sw.WriteLine(listBox1.Items[i]);
            sw.Close();
        }

        
    }
}
