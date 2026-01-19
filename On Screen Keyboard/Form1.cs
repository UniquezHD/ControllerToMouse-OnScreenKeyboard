using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace On_Screen_Keyboard
{
    public partial class Form1 : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x08000000;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public Form1()
        {
            InitializeComponent();

            RePaint();

            this.TopMost = true;
        }

        private void button59_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("~");
        }

        private void button58_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("|");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("Q");
            }
            else
            {
                SendKeys.SendWait("q");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("W");
            }
            else
            {
                SendKeys.SendWait("w");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("E");
            }
            else
            {
                SendKeys.SendWait("e");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("R");
            }
            else
            {
                SendKeys.SendWait("r");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("T");
            }
            else
            {
                SendKeys.SendWait("t");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("Y");
            }
            else
            {
                SendKeys.SendWait("y");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("U");
            }
            else
            {
                SendKeys.SendWait("u");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("I");
            }
            else
            {
                SendKeys.SendWait("i");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("O");
            }
            else
            {
                SendKeys.SendWait("o");
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("P");
            }
            else
            {
                SendKeys.SendWait("p");
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("Å");
            }
            else
            {
                SendKeys.SendWait("å");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }

        protected void RePaint()
        {
            GraphicsPath graphicpath = new GraphicsPath();
            graphicpath.StartFigure();
            graphicpath.AddArc(0, 0, 25, 25, 180, 90);
            graphicpath.AddLine(25, 0, this.Width - 25, 0);
            graphicpath.AddArc(this.Width - 25, 0, 25, 25, 270, 90);
            graphicpath.AddLine(this.Width, 25, this.Width, this.Height - 25);
            graphicpath.AddArc(this.Width - 25, this.Height - 25, 25, 25, 0, 90);
            graphicpath.AddLine(this.Width - 25, this.Height, 25, this.Height);
            graphicpath.AddArc(0, this.Height - 25, 25, 25, 90, 90);
            graphicpath.CloseFigure();
            this.Region = new Region(graphicpath);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
        }

        private void button82_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DOWN}");
        }

        private void button81_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{LEFT}");
        }

        private void button77_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{UP}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }

        private void button80_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SendKeys.SendWait("!");
            }
            else
            {
                SendKeys.SendWait("1");
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked)
            {
                foreach (var button in this.Controls.OfType<Button>())
                {
                    button.Text = button.Text.ToUpper();
                }

                checkBox1.Text = checkBox1.Text.ToUpper();
                checkBox2.Text = checkBox2.Text.ToUpper();

                button5.Text = "§";
                button6.Text = "!";
                button7.Text = "\"";
                button9.Text = "#";
                button8.Text = "¤";
                button13.Text = "%";
                button12.Text = "&";
                button11.Text = "/";
                button10.Text = "(";
                button14.Text = ")";
                button15.Text = "=";
                button16.Text = "?";
                button17.Text = "`";
                button60.Text = "^";
                button31.Text = "*";
                button54.Text = ">";
                button46.Text = ";";
                button45.Text = ":";
                button44.Text = "_";
            } 
            else
            {
                foreach (var button in this.Controls.OfType<Button>())
                {
                    button.Text = button.Text.ToLower();
                }

                checkBox1.Text = checkBox1.Text.ToLower();
                checkBox2.Text = checkBox2.Text.ToLower();

                button5.Text = "½";
                button6.Text = "1";
                button7.Text = "2";
                button9.Text = "3";
                button8.Text = "4";
                button13.Text = "5";
                button12.Text = "6";
                button11.Text = "7";
                button10.Text = "8";
                button14.Text = "9";
                button15.Text = "0";
                button16.Text = "+";
                button17.Text = "´";
                button60.Text = "\\";
                button31.Text = "'";
                button54.Text = "<";
                button46.Text = ",";
                button45.Text = ".";
                button44.Text = "-";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SendKeys.SendWait("\"");
            }
            else
            {
                SendKeys.SendWait("2");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SendKeys.SendWait("§");
            }
            else
            {
                SendKeys.SendWait("½");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SendKeys.SendWait("#");
            }
            else
            {
                SendKeys.SendWait("3");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SendKeys.SendWait("¤");
            }
            else
            {
                SendKeys.SendWait("4");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SendKeys.SendWait("%");
            }
            else
            {
                SendKeys.SendWait("5");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SendKeys.SendWait("&");
            }
            else
            {
                SendKeys.SendWait("6");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SendKeys.SendWait("/");
            }
            else
            {
                SendKeys.SendWait("7");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SendKeys.SendWait("(");
            }
            else
            {
                SendKeys.SendWait("8");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SendKeys.SendWait(")");
            }
            else
            {
                SendKeys.SendWait("9");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SendKeys.SendWait("=");
            }
            else
            {
                SendKeys.SendWait("0");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SendKeys.SendWait("?");
            }
            else
            {
                SendKeys.SendWait("+");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SendKeys.SendWait("`");
            }
            else
            {
                SendKeys.SendWait("´");
            }
        }

        private void button60_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SendKeys.SendWait("^");
            }
            else
            {
                SendKeys.SendWait("\\");
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SendKeys.SendWait("*");
            }
            else
            {
                SendKeys.SendWait("'");
            }
        }

        private void button54_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SendKeys.SendWait(">");
            }
            else
            {
                SendKeys.SendWait("<");
            }
        }

        private void button46_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SendKeys.SendWait(";");
            }
            else
            {
                SendKeys.SendWait(",");
            }
        }

        private void button45_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SendKeys.SendWait(":");
            }
            else
            {
                SendKeys.SendWait(".");
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                SendKeys.SendWait("_");
            }
            else
            {
                SendKeys.SendWait("-");
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("A");
            }
            else
            {
                SendKeys.SendWait("a");
            }
        }

        private void button41_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("S");
            }
            else
            {
                SendKeys.SendWait("s");
            }
        }

        private void button40_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("D");
            }
            else
            {
                SendKeys.SendWait("d");
            }
        }

        private void button39_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("F");
            }
            else
            {
                SendKeys.SendWait("f");
            }
        }

        private void button38_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("G");
            }
            else
            {
                SendKeys.SendWait("g");
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("H");
            }
            else
            {
                SendKeys.SendWait("h");
            }
        }

        private void button36_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("J");
            }
            else
            {
                SendKeys.SendWait("j");
            }
        }

        private void button35_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("K");
            }
            else
            {
                SendKeys.SendWait("k");
            }
        }

        private void button34_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("L");
            }
            else
            {
                SendKeys.SendWait("l");
            }
        }

        private void button33_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("Æ");
            }
            else
            {
                SendKeys.SendWait("æ");
            }
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("Ø");
            }
            else
            {
                SendKeys.SendWait("ø");
            }
        }

        private void button53_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("Z");
            }
            else
            {
                SendKeys.SendWait("z");
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("X");
            }
            else
            {
                SendKeys.SendWait("x");
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("C");
            }
            else
            {
                SendKeys.SendWait("c");
            }
        }

        private void button50_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("V");
            }
            else
            {
                SendKeys.SendWait("v");
            }
        }

        private void button49_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("B");
            }
            else
            {
                SendKeys.SendWait("b");
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("N");
            }
            else
            {
                SendKeys.SendWait("n");
            }
        }

        private void button47_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked | checkBox2.Checked)
            {
                SendKeys.SendWait("M");
            }
            else
            {
                SendKeys.SendWait("m");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("[");
        }

        private void button56_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("]");
        }

        private void button67_Click(object sender, EventArgs e)
        {
            SendKeys.Send("µ");
        }

        private void button65_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("{");
        }

        private void button66_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("}");
        }

        private void button61_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait(" ");
        }

        private void button55_Click(object sender, EventArgs e)
        {
            SendKeys.SendWait("@");
        }

        private void button71_Click(object sender, EventArgs e)
        {
            Process.Start("browser.exe", "-incognito " + "https://www.google.com/");
        }

        private void button70_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\cecilie\\AppData\\Local\\Discord\\app-1.0.9037\\discord.exe");
        }

        private void button73_Click(object sender, EventArgs e)
        {
            Process.Start("client.bat");
            Process.Start("server.bat");
        }
    }
}
