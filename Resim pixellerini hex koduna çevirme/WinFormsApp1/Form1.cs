using System.Collections;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WinFormsApp1;


    public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        int x, y;
        Color renk;
        Bitmap bmp = new Bitmap(pictureBox1.Image);

        for (x = 0; x <= bmp.Width - 1; x++)
        {
            for (y = 0; y <= bmp.Height - 1; y++)
            {
                renk = bmp.GetPixel(x, y);
                int kirmizi = renk.R;
                int yesil = renk.G;
                int mavi = renk.B;

                string hexValue = kirmizi.ToString("X2")+yesil.ToString("X2")+ mavi.ToString("X2");
               
                listBox1.Items.Add(hexValue);
            }


        }
    }
}
