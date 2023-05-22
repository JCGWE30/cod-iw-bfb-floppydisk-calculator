using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BFBFloppyDiskSolver
{
    public partial class Form : System.Windows.Forms.Form
    {
        Image unkimg;
        public Form()
        {
            InitializeComponent();
        }
        private void click(Image img, string numb)
        {
            unkimg = button16.Image;
            if (button13.Text == "")
            {
                button13.Image = img;
                button13.Text = numb;
            }
            else if (button14.Text == "")
            {
                button14.Image = img;
                button14.Text = numb;
            }
            else if (button15.Text == "")
            {
                button15.Image = img;
                button15.Text = numb;
            }
            else if (button16.Text == "")
            {
                button16.Image = img;
                button16.Text = numb;

                Button[] buttons = new Button[4];
                buttons[0] = button13;
                buttons[1] = button14;
                buttons[2] = button15;
                buttons[3] = button16;
                Button[] symbolbuttons = new Button[13];
                symbolbuttons[1] = button1;
                symbolbuttons[2] = button3;
                symbolbuttons[3] = button2;
                symbolbuttons[4] = button12;
                symbolbuttons[5] = button4;
                symbolbuttons[6] = button6;
                symbolbuttons[7] = button9;
                symbolbuttons[8] = button8;
                symbolbuttons[9] = button10;
                symbolbuttons[10] = button7;
                symbolbuttons[11] = button5;
                symbolbuttons[12] = button11;
                int[][] combos = new int[6][];
                combos[0] = new int[] { 1, 4, 8, 5, 11, 9 };
                combos[1] = new int[] { 2, 9, 12, 3, 10, 1 };
                combos[2] = new int[] { 3, 7, 10, 12, 2, 1 };
                combos[3] = new int[] { 3, 5, 8, 11, 9, 4 };
                combos[4] = new int[] { 1, 6, 8, 4, 11, 9 };
                combos[5] = new int[] { 5, 6, 11, 4, 9, 12 };
                int[] symbols;
                for (int i = 0; i < 6; i++)
                {
                    symbols = new int[4];
                    bool match = true;
                    for (int j = 0; j < 4; j++)
                    {
                        if (!combos[i].Contains(int.Parse(buttons[j].Text)))
                        {
                            match = false;
                        }
                        else
                        {
                            symbols[j] = int.Parse(buttons[j].Text);

                        }

                    }
                    if (match == true)
                    {
                        int[] combo = combos[i];
                        for (int j = 0; j < 6; j++)
                        {
                            if (symbols.Contains(combo[j]))
                            {
                                if (button17.Text == "")
                                {
                                    button17.Text = " ";
                                    button17.Image = symbolbuttons[combo[j]].Image;
                                }
                                else if (button18.Text == "")
                                {
                                    button18.Text = " ";
                                    button18.Image = symbolbuttons[combo[j]].Image;
                                }
                                else if (button19.Text == "")
                                {
                                    button19.Text = " ";
                                    button19.Image = symbolbuttons[combo[j]].Image;
                                }
                                else if (button20.Text == "")
                                {
                                    button20.Text = " ";
                                    button20.Image = symbolbuttons[combo[j]].Image;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            click(button3.Image, "2");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            click(button1.Image, "1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            click(button2.Image, "3");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            click(button12.Image, "4");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            click(button4.Image, "5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            click(button6.Image, "6");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            click(button9.Image, "7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            click(button8.Image, "8");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            click(button10.Image, "9");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            click(button7.Image, "10");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            click(button5.Image, "11");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            click(button11.Image, "12");
        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (unkimg != null)
            {
                button13.Image = unkimg;
                button14.Image = unkimg;
                button15.Image = unkimg;
                button16.Image = unkimg;
                button17.Image = unkimg;
                button18.Image = unkimg;
                button19.Image = unkimg;
                button20.Image = unkimg;

                button13.Text = "";
                button14.Text = "";
                button15.Text = "";
                button16.Text = "";
                button17.Text = "";
                button18.Text = "";
                button19.Text = "";
                button20.Text = "";
            }
        }
    }
}
