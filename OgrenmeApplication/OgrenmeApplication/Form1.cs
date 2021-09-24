using FuzzyLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenmeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float x = float.Parse(textBox1.Text);

            float y = float.Parse(textBox2.Text);

            float z = float.Parse(textBox3.Text);

            object c;

           

            Success s = new Success();

            c = s.FindFuzzySucces(x, y, z);

           

            textBox4.Text = c.ToString();
                
        }
    }
}
