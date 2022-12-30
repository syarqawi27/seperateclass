using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixFinal
{
    class Substraction
    {
        TextBox[] array = new TextBox[18];
        array[0] = textBox76;
            array[1] = textBox75;
            array[2] = textBox74;
            array[3] = textBox73;
            array[4] = textBox72;
            array[5] = textBox71;
            array[6] = textBox70;
            array[7] = textBox69;
            array[8] = textBox68;

            array[9] = textBox66;
            array[10] = textBox65;
            array[11] = textBox64;
            array[12] = textBox63;
            array[13] = textBox62;
            array[14] = textBox61;
            array[15] = textBox60;
            array[16] = textBox59;
            array[17] = textBox58;
            if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "" && array[9].Text != "" && array[10].Text != "" && array[11].Text != "" && array[12].Text != "" && array[13].Text != "" && array[14].Text != "" && array[15].Text != "" && array[16].Text != "" && array[17].Text != "")
            {
                Int64 a = Int64.Parse(textBox76.Text) - Int64.Parse(textBox66.Text);
        Int64 b = Int64.Parse(textBox75.Text) - Int64.Parse(textBox65.Text);
        Int64 c = Int64.Parse(textBox74.Text) - Int64.Parse(textBox64.Text);

        Int64 d = Int64.Parse(textBox73.Text) - Int64.Parse(textBox63.Text);
        Int64 ee = Int64.Parse(textBox72.Text) - Int64.Parse(textBox62.Text);
        Int64 f = Int64.Parse(textBox71.Text) - Int64.Parse(textBox61.Text);
        Int64 g = Int64.Parse(textBox70.Text) - Int64.Parse(textBox60.Text);
        Int64 h = Int64.Parse(textBox69.Text) - Int64.Parse(textBox59.Text);
        Int64 i = Int64.Parse(textBox68.Text) - Int64.Parse(textBox58.Text);
        //Int64 b = Int64.Parse(textBox440.Text);
        //Int64 c = a + b;
        textBox56.Text = a.ToString();
                textBox55.Text = b.ToString();
                textBox54.Text = c.ToString();
                textBox53.Text = d.ToString();
                textBox52.Text = ee.ToString();
                textBox51.Text = f.ToString();
                textBox50.Text = g.ToString();
                textBox49.Text = h.ToString();
                textBox48.Text = i.ToString();
            }
            else
            {
                label3.Text = "Fill ALL the boxes";
            }
    }
}
