namespace modul2_1302223062
{
    public partial class Form1 : Form
    {
        int num1 = 0;
        int num2 = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            string namaPraktikan = label2.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "1";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "5";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "2";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "4";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "6";
        }
        private void button10_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "=";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "0";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "+";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "8";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            label2.Text = label2.Text + "9";

        }
    }
}
