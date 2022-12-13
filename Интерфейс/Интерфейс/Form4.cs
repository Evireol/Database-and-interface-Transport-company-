using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Интерфейс
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if ((textBox1.Text != null) && (textBox2.Text != null))
            //{ }
            MyClass.Dostup = 1;
            Form Form3 = new Form3();
            Form3.Show();

            this.Hide();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyClass.Dostup = 2;
            Form Form3 = new Form3();
            Form3.Show();

            this.Hide();
        }
    }
}
