using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (c = 0; c < 11; c++)
            {
                x[c] = "";
            }
            c = 0;
        }
        string[] x = new string[11];
        string[] y = new string[10];
        string x1 = "";
        string y1 = "";
        bool r1 = false;
        int m,mas,menos,d,sq,el;
        double re;
        int c = 0;
        int c2 = 0;
        public void button0_Click(object sender, EventArgs e)
        {
            try
            {
                x[c] = "0";
                c++;
                x1 = x1 + x[c2];
                textBox1.Text = x1;
                c2++;
            }
            catch
            {
                textBox1.Text = "Error";
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                x[c] = "1";
                c++;
                x1 = x1 + x[c2];
                textBox1.Text = x1;
                c2++;
            }
            catch
            {
                textBox1.Text = "Error";
            }
        }

        public void button2_Click(object sender, EventArgs e)
        {
            try
            {
                x[c] = "2";
                c++;
                x1 = x1 + x[c2];
                textBox1.Text = x1;
                c2++;
            }
            catch
            {
                textBox1.Text = "Error";
            }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            try
            {
                x[c] = "3";
                c++;
                x1 = x1 + x[c2];
                textBox1.Text = x1;
                c2++;
            }
            catch
            {
                textBox1.Text = "Error";
            }
        }

        public void button4_Click(object sender, EventArgs e)
        {
            try
            {
                x[c] = "4";
                c++;
                x1 = x1 + x[c2];
                textBox1.Text = x1;
                c2++;
            }
            catch
            {
                textBox1.Text = "Error";
            }
        }

        public void button5_Click(object sender, EventArgs e)
        {
            try
            {
                x[c] = "5";
                c++;
                x1 = x1 + x[c2];
                textBox1.Text = x1;
                c2++;
            }
            catch
            {
                textBox1.Text = "Error";
            }
        }

        public void button6_Click(object sender, EventArgs e)
        {
            try
            {
                x[c] = "6";
                c++;
                x1 = x1 + x[c2];
                textBox1.Text = x1;
                c2++;
            }
            catch
            {
                textBox1.Text = "Error";
            }
        }

        public void button7_Click(object sender, EventArgs e)
        {
            try
            {
                x[c] = "7";
                c++;
                x1 = x1 + x[c2];
                textBox1.Text = x1;
                c2++;
            }
            catch
            {
                textBox1.Text = "Error";
            }
        }

        public void button8_Click(object sender, EventArgs e)
        {
            try
            {
                x[c] = "8";
                c++;
                x1 = x1 + x[c2];
                textBox1.Text = x1;
                c2++;
            }
            catch
            {
                textBox1.Text = "Error";
            }
        }

        public void button9_Click(object sender, EventArgs e)
        {
            try
            {
                x[c] = "9";
                c++;
                x1 = x1 + x[c2];
                textBox1.Text = x1;
                c2++;
            }
            catch
            {
                textBox1.Text = "Error";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                x[c] = ",";
                c++;
                x1 = x1 + x[c2];
                textBox1.Text = x1;
                c2++;
            }
            catch
            {
                textBox1.Text = "Error";
            }
        }

        public void button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (d == 1 || m == 1 || mas == 1 || menos == 1 || sq == 1)
                {
                    x1 = "";
                    c = 0;
                    m = 1;
                    mas = 0;
                    menos = 0;
                    d = 0;
                    sq = 0;

                }
                else
                {
                    x1 = "";
                    for (c = 0; c < 11; c++)
                    {
                        x1 = "" + x1 + x[c];
                    }
                    textBox1.Text = "x";
                    if (r1 == false)
                    {
                        y1 = x1;
                        x1 = "";
                    }
                    for (c = 0; c < 11; c++)
                    {
                        x[c] = "";
                    }
                    c = 0;
                    c2 = 0;
                    m = 1;              }
      
            }
            catch 
            {
                textBox1.Text = "Error";
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (d == 1 || m == 1 || mas == 1 || menos == 1 || sq == 1)
                {
                    x1 = "";
                    c = 0;
                    m = 0;
                    mas = 0;
                    menos = 0;
                    d = 1;
                    sq = 0;

                }
                else
                {
                    x1 = "";
                    for (c = 0; c < 11; c++)
                    {
                        x1 = "" + x1 + x[c];
                    }
                    textBox1.Text = "/";
                    if (r1 == false)
                    {
                        y1 = x1;
                        x1 = "";
                    }
                    for (c = 0; c < 11; c++)
                    {
                        x[c] = "";
                    }
                    c = 0;
                    c2 = 0;
                    d = 1;
                }

            }
            catch
            {
                textBox1.Text = "Error";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            r1 = true;

        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (d == 1 || m == 1 || mas == 1 || menos == 1 || sq == 1)
                {
                    x1 = "";
                    c = 0;
                    m = 0;
                    mas = 1;
                    menos = 0;
                    d = 0;
                    sq = 0;

                }
                else
                {
                    x1 = "";
                    for (c = 0; c < 11; c++)
                    {
                        x1 = "" + x1 + x[c];
                    }
                    textBox1.Text = "+";
                    if (r1 == false)
                    {
                        y1 = x1;
                        x1 = "";
                    }
                    for (c = 0; c < 11; c++)
                    {
                        x[c] = "";
                    }
                    c = 0;
                    c2 = 0;
                    mas = 1;
                }

            }
            catch
            {
                textBox1.Text = "Error";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                if (d == 1 || m == 1 || mas == 1 || menos == 1 ||sq == 1)
                {
                    x1 = "";
                    c = 0;
                    m = 0;
                    mas = 0;
                    menos = 0;
                    d = 0;
                    sq = 1;

                }
                else
                {
                    x1 = "";
                    for (c = 0; c < 11; c++)
                    {
                        x1 = "" + x1 + x[c];
                    }
                    textBox1.Text = "√ ";
                    if (r1 == false)
                    {
                        y1 = x1;
                        x1 = "";
                    }
                    for (c = 0; c < 11; c++)
                    {
                        x[c] = "";
                    }
                    c = 0;
                    c2 = 0;
                    sq = 1;
                }

            }
            catch
            {
                textBox1.Text = "Error";
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (d == 1 || m == 1 || mas == 1 || menos == 1 || sq == 1)
                {
                    x1 = "";
                    c = 0;
                    m = 0;
                    mas = 0;
                    menos = 1;
                    d = 0;
                    sq = 0;

                }
                else
                {
                    x1 = "";
                    for (c = 0; c < 11; c++)
                    {
                        x1 = "" + x1 + x[c];
                    }
                    textBox1.Text = "-";
                    if (r1 == false)
                    {
                        y1 = x1;
                        x1 = "";
                    }
                    for (c = 0; c < 11; c++)
                    {
                        x[c] = "";
                    }
                    c = 0;
                    c2 = 0;
                    menos = 1;
                }

            }
            catch
            {
                textBox1.Text = "Error";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            m = 0;
            mas = 0;
            menos = 0;
            d = 0;
            sq = 0;
            el = 0;
            r1 = false;
            c2 = 0;
            re = 0;
            x1 = "";
            y1 = "";
            for (c = 0; c < 11; c++)
            {
                x[c] = "";
            }
            c = 0;
            textBox1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (m == 1)
                {
                    x1 = "";
                    for (c = 0; c < 11; c++)
                    {
                        x1 = "" + x1 + x[c];
                    }
                    re = Convert.ToDouble(y1) * Convert.ToDouble(x1);
                    textBox1.Text = y1 + "x" + x1 + "=" + re;
                    c2 = 0;
                    x1 = "";
                    y1 = Convert.ToString(re);
                    for (c = 0; c < 11; c++)
                    {
                        x[c] = "";
                    }
                    c = 0;

                }
                if (d == 1)
                {
                    x1 = "";
                    for (c = 0; c < 11; c++)
                    {
                        x1 = "" + x1 + x[c];
                    }
                    re = Convert.ToDouble(y1) / Convert.ToDouble(x1);
                    textBox1.Text = y1 + "/" + x1 + "=" + re;
                    c2 = 0;
                    x1 = "";
                    y1 = Convert.ToString(re);
                    for (c = 0; c < 11; c++)
                    {
                        x[c] = "";
                    }
                    c = 0;
                }
                if (mas == 1)
                {
                    x1 = "";
                    for (c = 0; c < 11; c++)
                    {
                        x1 = "" + x1 + x[c];
                    }
                    re = Convert.ToDouble(y1) + Convert.ToDouble(x1);
                    textBox1.Text = y1 + "+" + x1 + "=" + re;
                    c2 = 0;
                    x1 = "";
                    y1 = Convert.ToString(re);
                    for (c = 0; c < 11; c++)
                    {
                        x[c] = "";
                    }
                    c = 0;
                }
                if (menos == 1)
                {
                    x1 = "";
                    for (c = 0; c < 11; c++)
                    {
                        x1 = "" + x1 + x[c];
                    }
                    re = Convert.ToDouble(y1) - Convert.ToDouble(x1);
                    textBox1.Text = y1 + "-" + x1 + "=" + re;
                    c2 = 0;
                    x1 = "";
                    y1 = Convert.ToString(re);
                    for (c = 0; c < 11; c++)
                    {
                        x[c] = "";
                    }
                    c = 0;
                }
                if (sq == 1)
                {
                    x1 = "";
                    for (c = 0; c < 11; c++)
                    {
                        x1 = "" + x1 + x[c];
                    }
                    if (r1 == false)
                    {
                        y1 = x1;
                    }
                    re = Math.Sqrt(Convert.ToDouble(y1));
                    textBox1.Text ="√ " + x1 + "=" + re;
                    c2 = 0;
                    x1 = "";
                    y1 = Convert.ToString(re);
                    for (c = 0; c < 11; c++)
                    {
                        x[c] = "";
                    }
                    r1 = false;
                    c = 0;
                }
            }
            catch
            {
                textBox1.Text = "Error";
            }
        }
    }
}
