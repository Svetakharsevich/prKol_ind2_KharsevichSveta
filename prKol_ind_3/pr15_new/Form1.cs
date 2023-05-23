using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr15
{
    public partial class Form1 : Form
    {
        ArrayList ms1=new ArrayList();
        ArrayList ms2 = new ArrayList();
        int Length = 0;
        string text;
        int[] array_text;
        int count = 0;
        Array mas1=new Array();
        Array mas2=new Array();
        int[] mas4;
        int[] mas3;
        int value;
        int index;
        public Form1()
        {
            InitializeComponent();
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
        public int[] ParseString(string text)
        {
            return text.Split(' ').Select(x => int.Parse(x)).ToArray();
        }
        private int counts = 2;
        private void button1_Click(object sender, EventArgs e)
        {
            if (counts <= 0)
                return;
            else
                counts--;
            listBox1.Items.Clear();
            Length = (int)numericUpDown1.Value;
            text = textBox1.Text;
            if (text == "") MessageBox.Show("Введите значения", "Ошибка");
            if (textBox1.Text != "")
            {
                array_text = ParseString(text);
                mas3 = ParseString(text);
                if (Length > array_text.Length) MessageBox.Show("Вы вели мало чисел", "Ошибка");
                else if (Length < array_text.Length) MessageBox.Show("Вы вели много чисел", "Ошибка");
                else
                {

                    listBox1.Items.Add($"Массив{count + 1}");
                    for (int i = 0; i < array_text.Length; i++)
                    {
                        listBox1.Items.Add(array_text[i]);
                        mas1.CreateArray(Length, text);
                        ms1.Add(mas1);
                        
                    }
                }
                count = count + 1;

            }
            else MessageBox.Show("Введите значения", "Ошибка");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCountry = listBox1.SelectedItem.ToString();
            textBox2.Text=selectedCountry;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            Length = 0;
            textBox1.Text = "";
            button4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (counts <= 0)
                return;
            else
                counts--;
            Length = (int)numericUpDown1.Value;
            text = textBox1.Text;
            if (numericUpDown1.Value != 0 && textBox1.Text != "")
            {
                if (text == "") MessageBox.Show("Введите значения","Ошибка");
                array_text = ParseString(text);
                mas4 = ParseString(text);
                if (Length > array_text.Length) MessageBox.Show("Вы вели мало чисел", "Ошибка");
                else if (Length < array_text.Length) MessageBox.Show("Вы вели много чисел", "Ошибка");
                else
                {
                   
                    listBox1.Items.Add($"Массив{count+1}");
                    for (int i = 0; i < array_text.Length; i++)
                    {
                        listBox1.Items.Add(array_text[i]);
                        mas2.CreateArray(Length, text);
                        ms2.Add(ms2);
                    }
                }
                groupBox3.Visible = true;
            }
            else MessageBox.Show("Введите значения", "Ошибка");
            count++;
            groupBox3.Visible = true;
            groupBox4.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Length != 0)
            {
                if (mas3.Length == mas4.Length) MessageBox.Show($"Сумма массивов={mas1.SumArr(mas3, mas4)}", "Сумма");
                else MessageBox.Show("Длина массивов не одинаковая", "Ошибка");
            }
            else MessageBox.Show("Длина равна 0");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Length != 0)
            {
                if (mas3.Length == mas4.Length) MessageBox.Show($"Вычитание массивов={mas1.SustractArr(mas3, mas4)}", "Вычитание");
                else MessageBox.Show("Длина массивов не одинаковая", "Ошибка");
            }
            else MessageBox.Show("Длина равна 0");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            value = (int)numericUpDown2.Value;
            if (Length != 0)
            {
                if (mas3.Length == mas4.Length)
                {
                    if(radioButton1.Checked)
                    MessageBox.Show($"Умножение массива={mas1.Multiply(mas3, value)}", "Умножение");
                    if(radioButton2.Checked) 
                        MessageBox.Show($"Умножение массива={mas1.Multiply(mas4, value)}", "Умножение");
                }
                else MessageBox.Show("Длина массивов не одинаковая", "Ошибка");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            index= (int)numericUpDown3.Value;
            if (Length != 0)
            {
                if (radioButton1.Checked)
                    MessageBox.Show($"{mas1.Skip(mas3, index)}", "");
                if (radioButton2.Checked)
                    MessageBox.Show($"{mas1.Skip(mas4, index)}", "");
            }
        }
    }
}
