using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixFinal
{
    public  class transpose : Form1
    {
        public transpose()
        {
            InitializeComponent();
        }
        TextBox[] array = new TextBox[9];
        array[0] = textBox1;
            array[1] = textBox2;
            array[2] = textBox3;
            array[3] = textBox4;
            array[4] = textBox5;
            array[5] = textBox6;
            array[6] = textBox7;
            array[7] = textBox8;
            array[8] = textBox9;
            if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "")
            {
                textBox10.Text = textBox1.Text.ToString();
                textBox17.Text = textBox2.Text.ToString();
                textBox18.Text = textBox3.Text.ToString();

                textBox11.Text = textBox4.Text.ToString();
                textBox16.Text = textBox5.Text.ToString();
                textBox15.Text = textBox6.Text.ToString();

                textBox12.Text = textBox9.Text.ToString();
                textBox13.Text = textBox8.Text.ToString();
                textBox14.Text = textBox7.Text.ToString();
            }
            else
            {
                label1.Text = "Fill all the boxes";

            }
    }
}
