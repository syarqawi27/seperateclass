using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixFinal
{
    class Multiplication
    {
        TextBox[] array = new TextBox[18];
        array[0] = textBox105;
            array[1] = textBox104;
            array[2] = textBox103;
            array[3] = textBox102;
            array[4] = textBox101;
            array[5] = textBox100;
            array[6] = textBox99;
            array[7] = textBox98;
            array[8] = textBox97;

            array[9] = textBox95;
            array[10] = textBox94;
            array[11] = textBox93;
            array[12] = textBox92;
            array[13] = textBox91;
            array[14] = textBox90;
            array[15] = textBox89;
            array[16] = textBox88;
            array[17] = textBox87;
            if (array[0].Text != "" && array[1].Text != "" && array[2].Text != "" && array[3].Text != "" && array[4].Text != "" && array[5].Text != "" && array[6].Text != "" && array[7].Text != "" && array[8].Text != "" && array[9].Text != "" && array[10].Text != "" && array[11].Text != "" && array[12].Text != "" && array[13].Text != "" && array[14].Text != "" && array[15].Text != "" && array[16].Text != "" && array[17].Text != "")
            {
                Int64 a = (Int64.Parse(textBox105.Text) * Int64.Parse(textBox95.Text)) +
                          (Int64.Parse(textBox104.Text) * Int64.Parse(textBox92.Text)) +
                          (Int64.Parse(textBox103.Text) * Int64.Parse(textBox89.Text));

        Int64 b = (Int64.Parse(textBox105.Text) * Int64.Parse(textBox94.Text)) +
                  (Int64.Parse(textBox104.Text) * Int64.Parse(textBox91.Text)) +
                  (Int64.Parse(textBox103.Text) * Int64.Parse(textBox88.Text));

        Int64 c = (Int64.Parse(textBox105.Text) * Int64.Parse(textBox93.Text)) +
                  (Int64.Parse(textBox104.Text) * Int64.Parse(textBox90.Text)) +
                  (Int64.Parse(textBox103.Text) * Int64.Parse(textBox87.Text));

        Int64 d = (Int64.Parse(textBox102.Text) * Int64.Parse(textBox95.Text)) +
                  (Int64.Parse(textBox101.Text) * Int64.Parse(textBox92.Text)) +
                  (Int64.Parse(textBox100.Text) * Int64.Parse(textBox89.Text));

        Int64 ee = (Int64.Parse(textBox102.Text) * Int64.Parse(textBox94.Text)) +
                  (Int64.Parse(textBox101.Text) * Int64.Parse(textBox91.Text)) +
                  (Int64.Parse(textBox100.Text) * Int64.Parse(textBox88.Text));

        Int64 f = (Int64.Parse(textBox102.Text) * Int64.Parse(textBox93.Text)) +
                  (Int64.Parse(textBox101.Text) * Int64.Parse(textBox90.Text)) +
                  (Int64.Parse(textBox100.Text) * Int64.Parse(textBox87.Text));

        Int64 g = (Int64.Parse(textBox99.Text) * Int64.Parse(textBox95.Text)) +
                  (Int64.Parse(textBox98.Text) * Int64.Parse(textBox92.Text)) +
                  (Int64.Parse(textBox97.Text) * Int64.Parse(textBox89.Text));

        Int64 h = (Int64.Parse(textBox99.Text) * Int64.Parse(textBox94.Text)) +
                  (Int64.Parse(textBox98.Text) * Int64.Parse(textBox91.Text)) +
                  (Int64.Parse(textBox97.Text) * Int64.Parse(textBox88.Text));

        Int64 i = (Int64.Parse(textBox99.Text) * Int64.Parse(textBox93.Text)) +
                  (Int64.Parse(textBox98.Text) * Int64.Parse(textBox90.Text)) +
                  (Int64.Parse(textBox97.Text) * Int64.Parse(textBox87.Text));

        //Int64 b = Int64.Parse(textBox440.Text);
        //Int64 c = a + b;
        textBox85.Text = a.ToString();
                textBox84.Text = b.ToString();
                textBox83.Text = c.ToString();
                textBox82.Text = d.ToString();
                textBox81.Text = ee.ToString();
                textBox80.Text = f.ToString();
                textBox79.Text = g.ToString();
                textBox78.Text = h.ToString();
                textBox77.Text = i.ToString();
            }
            else
            {
                label4.Text = "Fill ALL the boxes";
            }
    }
}
