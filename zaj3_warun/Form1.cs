namespace zaj3_warun
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string liczby = textBox1.Text;
            //liczby.Split(' ');
            //label1.Text = liczby;
        }
        int[] Converty(string napis)
        {
            var LiczbyS = napis.Trim().Split(' ');
            var liczby = new int[LiczbyS.Length];
            for(int i = 0; i < LiczbyS.Length; i++)
            {
                liczby[i] = int.Parse(LiczbyS[i]);
            }
            return liczby;
        }
    }
}