namespace Calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string caltol;
        int num1;
        int num2;
        String option;
        int result;

        private void txtdp_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtdp.Text = txtdp.Text + "1";
        }
        private void butt2_Click(object sender, EventArgs e)
        {
            txtdp.Text = txtdp.Text + "2";
        }

        private void butt3_Click(object sender, EventArgs e)
        {
            txtdp.Text = txtdp.Text + "3";
        }

        private void butt4_Click(object sender, EventArgs e)
        {
            txtdp.Text = txtdp.Text + "4";
        }

        private void butt5_Click(object sender, EventArgs e)
        {
            txtdp.Text = txtdp.Text + "5";
        }

        private void butt6_Click(object sender, EventArgs e)
        {
            txtdp.Text = txtdp.Text + "6";
        }

        private void butt7_Click(object sender, EventArgs e)
        {
            txtdp.Text = txtdp.Text + "7";
        }

        private void butt8_Click(object sender, EventArgs e)
        {
            txtdp.Text = txtdp.Text + "8";
        }

        private void butt9_Click(object sender, EventArgs e)
        {
            txtdp.Text = txtdp.Text + "9";
        }

        private void butt0_Click(object sender, EventArgs e)
        {
            txtdp.Text = txtdp.Text + "0";
        }

        private void buttpls_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(txtdp.Text);
            txtdp.Clear();
        }

        private void buttmin_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(txtdp.Text);
            txtdp.Clear();
        }

        private void buttmul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(txtdp.Text);
            txtdp.Clear();
        }

        private void buttdiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(txtdp.Text);
            txtdp.Clear();
        }

        private void buttclr_Click(object sender, EventArgs e)
        {
            txtdp.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }

        private void butteq_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(txtdp.Text);
            if (option.Equals("+"))
            {
                result = num1 + num2;
            }
            if (option.Equals("-"))
            {
                result = num1 - num2;
            }
            if (option.Equals("*"))
            {
                result = num1 * num2;
            }
            if (option.Equals("/"))
            {
                result = num1 / num2;
            }
            txtdp.Text = result + "";
        }
    }
}