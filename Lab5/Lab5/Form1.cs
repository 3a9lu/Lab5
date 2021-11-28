using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;  // Вывод формы по центру экрана
        }

        // Блокировка лишнних символов в TextBox
        #region
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int length = textBox1.Text.Length;
            if (length == 0 && ch == ',' && ch == '-')
            {
                e.Handled = true;
            }
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || textBox1.Text.Contains(",")) && ((ch != '-' || textBox1.Text.Contains("-")))) // Если число, BACKSPACE запятая или минус, то вводим
            {
                e.Handled = true;
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int length = textBox1.Text.Length;
            if (length == 0 && ch == ',' && ch == '-')
            {
                e.Handled = true;
            }
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || textBox1.Text.Contains(",")) && ((ch != '-' || textBox1.Text.Contains("-")))) // Если число, BACKSPACE запятая или минус, то вводим
            {
                e.Handled = true;
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            int length = textBox1.Text.Length;
            if (length == 0 && ch == ',' && ch == '-')
            {
                e.Handled = true;
            }
            if (!Char.IsDigit(ch) && ch != 8 && (ch != ',' || textBox1.Text.Contains(",")) && ((ch != '-' || textBox1.Text.Contains("-")))) // Если число, BACKSPACE запятая или минус, то вводим
            {
                e.Handled = true;
            }
        }
        #endregion
        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e) // Кнопка выхода
        {
            Close();
        }
        void Clear()
        {
            textBox1.Text = "";
            
            chart1.Series[0].Points.Clear();
            chart2.Series[0].Points.Clear();
            chart3.Series[0].Points.Clear();
        }
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e) // Кнопка очистить
        {
            Clear();
        }
        private void расчитатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Заполните все поля.", "Ошибка!");
                return;
            }

            if (Convert.ToDouble(textBox2.Text) >= Convert.ToDouble(textBox3.Text))
            {
                MessageBox.Show("Граница A не может быть равна границе B или быть больше.", "Ошибка!");
                return;
            }

            if (Convert.ToDouble(textBox4.Text) <= 0)
            {
                MessageBox.Show("Точность не может быть равна нулю или быть меньше.", "Ошибка!");
                return;
            }

            else
            {

            }
        }
    }
}
