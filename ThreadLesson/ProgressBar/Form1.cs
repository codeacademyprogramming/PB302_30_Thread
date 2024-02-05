namespace ProgressBar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(LoadBar1);
            t.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(LoadBar2);
            t.Start();
        }

        private void LoadBar1()
        {
            for (int i = 0; i <= 1000000000; i++)
            {
                progressBar1.Value = i / 10000000;
            }
        }

        private void LoadBar2()
        {
            for (int i = 0; i <= 1000000000; i++)
            {
                progressBar2.Value = i / 10000000;
            }
        }
    }
}