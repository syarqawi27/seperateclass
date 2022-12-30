using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixFinal
{
    class Addition
    {
        TextBox[] array = new TextBox[18];
        array[0] = textBox19;
            array[1] = textBox20;
            array[2] = textBox21;
            array[3] = textBox22;
            array[4] = textBox23;
            array[5] = textBox24;
            array[6] = textBox25;
            array[7] = textBox26;
            array[8] = textBox27;

            array[9] = textBox29;
            array[10] = textBox30;
            array[11] = textBox31;
            array[12] = textBox32;
            array[13] = textBox33;
            array[14] = textBox34;
            array[15] = textBox35;
            array[16] = textBox36;
            array[17] = textBox37;
            if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "" && array[9].Text != "" && array[10].Text != "" && array[11].Text != "" && array[12].Text != "" && array[13].Text != "" && array[14].Text != "" && array[15].Text != "" && array[16].Text != "" && array[17].Text != "")
            {
                Int64 a = Int64.Parse(textBox19.Text) + Int64.Parse(textBox29.Text);
        Int64 b = Int64.Parse(textBox20.Text) + Int64.Parse(textBox30.Text);
        Int64 c = Int64.Parse(textBox21.Text) + Int64.Parse(textBox31.Text);

        Int64 d = Int64.Parse(textBox22.Text) + Int64.Parse(textBox32.Text);
        Int64 ee = Int64.Parse(textBox23.Text) + Int64.Parse(textBox33.Text);
        Int64 f = Int64.Parse(textBox24.Text) + Int64.Parse(textBox34.Text);
        Int64 g = Int64.Parse(textBox25.Text) + Int64.Parse(textBox35.Text);
        Int64 h = Int64.Parse(textBox26.Text) + Int64.Parse(textBox36.Text);
        Int64 i = Int64.Parse(textBox27.Text) + Int64.Parse(textBox37.Text);
        //Int64 b = Int64.Parse(textBox440.Text);
        //Int64 c = a + b;
        textBox39.Text = a.ToString();
                textBox40.Text = b.ToString();
                textBox41.Text = c.ToString();
                textBox42.Text = d.ToString();
                textBox43.Text = ee.ToString();
                textBox44.Text = f.ToString();
                textBox45.Text = g.ToString();
                textBox46.Text = h.ToString();
                textBox47.Text = i.ToString();
            }
            else
            {
                label2.Text = "Fill ALL the boxes";
            }
    }
}
