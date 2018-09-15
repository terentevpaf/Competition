using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Competitionspace;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private Competition _competition;
        public Form1()
        {
            InitializeComponent();
            _competition = new Competition();
        }

        private void button2_Click(object sender, EventArgs e)
        {
// Нужно доделать проврку на отсутствие лишник пробелов
            if(textBox1.Text == "")
            {
                MessageBox.Show("Введите название конкурса");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Введите количество участников");
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("Введите количество призовых мест");
            }
            else
            {
                _competition.SetNameCompetition(textBox1.Text);
                _competition.SetCountUsers(Int32.Parse(textBox2.Text));
                _competition.SetCountWinners(Int32.Parse(textBox6.Text));
                MessageBox.Show(_competition.Mess());
            }
        }
        // Регистрация участника
        private void button9_Click(object sender, EventArgs e)
        {
            _competition.AddUser(textBox4.Text);
            MessageBox.Show(_competition.AllUsers());
        }
    }
}
