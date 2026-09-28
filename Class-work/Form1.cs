namespace Class_work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool click;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.Text.Contains("."))
            {
                richTextBox1.Text += ".";
            }
        }
        char operand;
        double a;
        private void button20_Click(object sender, EventArgs e)
        {
            switch (operand)
            {
                case '+':
                    richTextBox1.Text =
                        (a + Convert.ToDouble(richTextBox1.Text)).ToString();
                    break;

                case '-':
                    richTextBox1.Text =
                        (a - Convert.ToDouble(richTextBox1.Text)).ToString();
                    break;

                case '*':
                    richTextBox1.Text =
                        (a * Convert.ToDouble(richTextBox1.Text)).ToString();
                    break;

                case '/':
                    if (Convert.ToDouble(richTextBox1.Text) == 0)
                    {
                        richTextBox1.Text = "Divide by zero error";
                    }
                    else
                    {
                        richTextBox1.Text =
                            (a / Convert.ToDouble(richTextBox1.Text)).ToString();
                    }
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;

            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;

            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;

            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;

            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;

            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;

            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;

            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;

            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;

            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (click)
            {
                richTextBox1.Text = "";
                click = false;

            }
            if (richTextBox1.Text == "0")
            {
                richTextBox1.Text = "";
            }
            richTextBox1.Text += "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Math.Sqrt(a).ToString();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            

            if (richTextBox1.Text.Length > 1)
            {
                richTextBox1.Text = richTextBox1.Text.Substring(
                    0,
                    richTextBox1.Text.Length - 1
                );
            }
            else
            {
                richTextBox1.Text = "0";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == string.Empty)
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                operand = '+';
                click = true;
                a = Convert.ToDouble(richTextBox1.Text);
                richTextBox1.Text += " +";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == string.Empty)
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                operand = '-';  
                click = true;
                a = Convert.ToDouble(richTextBox1.Text);
                richTextBox1.Text += " -";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == string.Empty)
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                operand = '*';
                click = true;
                a = Convert.ToDouble(richTextBox1.Text);
                richTextBox1.Text += " *";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == string.Empty)
            {
                richTextBox1.Text = "Invalid value";
            }
            else
            {
                operand = '/';
                click = true;
                a = Convert.ToDouble(richTextBox1.Text);
                richTextBox1.Text += " /";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = (Convert.ToDouble(richTextBox1.Text) / 100).ToString();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }
    }
}
