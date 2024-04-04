using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tool001
{
    public partial class Form1 : Form
    {
        bool dif = false;
        public int oldR1;
        public int oldR2;
        public Font currentFontTR1;
        public Point oldLoc;
 //       public Font currentFontTR2;
          public Form1()
        {
            InitializeComponent();
            this.Resize += Form1_Resize; // Subscribe to Resize event
            oldR1 = rTB1.Width;
            oldR2 = rTB2.Width;
            currentFontTR1=rTB1.Font;
            oldLoc = label2.Location;
         }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rTB2.TextLength == 0)
            {
                label3.Text = "Please type data en Field 2";
                label3.Visible = true;
                return;
            }
            if (rTB1.TextLength >= rTB2.TextLength)
            {
                rTB1 = testDif(rTB1, rTB2);
                if (rTB1.TextLength > rTB2.TextLength)
                {
                    rTB1.Select(rTB2.TextLength, rTB1.TextLength - rTB2.TextLength - 2);
                    rTB1.SelectionColor = Color.Red;
                    dif = true;
                }
            }
            else
            {
                rTB2 = testDif(rTB2, rTB1);
                rTB2.Select(rTB1.TextLength, rTB2.TextLength - rTB1.TextLength);
                rTB2.SelectionColor = Color.Red;
                dif = true;
            }
            b2.Visible = true;
            b3.Visible = true;
            if (dif)
            {
                label3.Text = "Result: Field1 and field 2 has differences, please watch characters on red";
            }
            else
            {
                label3.Text = "Result: Field1 and Field2 has no differences";
            }
            label3.Visible = true;
        }

        private void rTB1_TextChanged(object sender, EventArgs e)
        {
            if (rTB1.Text.Length > 0) { b2.Visible = !Visible; }
        }

        private void rTB2_TextChanged(object sender, EventArgs e)
        {
            if (rTB2.Text.Length > 0) { b3.Visible = !Visible; }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            rTB1.Text = "";
            b1.Visible = false;
            b2.Visible = false;
        }
        private void b3_Click(object sender, EventArgs e)
        {
            rTB2.Text = "";
            b3.Visible = false;
        }

        private void rTB1_Click(object sender, EventArgs e)
        {
            dif = false;
            b2.Visible = true;
        }

        private void rTB2_Click(object sender, EventArgs e)
        {
            dif = false;
            b3.Visible = true;
        }

        private void rTB1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rTB1.Text.Length > 0)
            {
                b2.Visible = true;
                b1.Visible = true;
            }
        }

        private void rTB2_KeyPress(object sender, KeyPressEventArgs e)
        {
            b3.Visible = true;
            label3.Visible = false;
        }
        public RichTextBox testDif(RichTextBox rTB1a, RichTextBox rTB2a)
        {
            for (int i = 0; i < rTB1a.TextLength && i < rTB2a.TextLength; ++i)
            {
                if (rTB1a.Text[i] != rTB2a.Text[i])
                {
                    rTB1a.Select(i, 1);
                    rTB1a.SelectionColor = Color.Red;
                    dif = true;
                }
            }

            return rTB1a;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                rTB1.Width = (int)(rTB1.Width * 1.4);
                rTB1.Height *= 3;
                rTB2.Width = rTB1.Width;
                rTB2.Height = rTB1.Height;
                label5.Location = new Point(3*label5.Location.X,  label5.Location.Y);
                label6.Location = new Point(5 * label6.Location.X, label6.Location.Y);
                // Calculate the new font size (double the current size)
                float newFontSize = currentFontTR1.SizeInPoints * 2;
                // Create a new font with the adjusted size
                Font newFont = new Font(currentFontTR1.FontFamily, newFontSize, currentFontTR1.Style);
                rTB1.Font=newFont;
                rTB2.Font = newFont;
                label2.Location = new Point(25,450);
                rTB2.Location = new Point(25, 480);
                button1_Click(null, null);
             }
            else
            {
                rTB1.Width = oldR1;
                rTB2.Width = oldR2;
                rTB1.Height /= 3;
                rTB2.Height = rTB1.Height;
                // Calculate the new font size (double the current size)
                float newFontSize = currentFontTR1.SizeInPoints;
                // Create a new font with the adjusted size
                Font newFont = new Font(currentFontTR1.FontFamily, newFontSize, currentFontTR1.Style);
                rTB1.Font = newFont;
                rTB2.Font = newFont;
                label5.Location = new Point( label5.Location.X/3, label5.Location.Y);
                label6.Location = new Point(label6.Location.X/5, label6.Location.Y);
                label2.Location = oldLoc;
                rTB2.Location = new Point(25, 205);
                button1_Click(null, null);
            }
        }
    }
}
