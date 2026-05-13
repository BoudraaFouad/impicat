namespace impicat
{
    public partial class Form1 : Form
    {
        Random rn = new Random();
        string riga;
        int num = 0;
        private void nascM()
        {

        }
        public Form1()
        {
            InitializeComponent();


        }

        private void titolbl_Click(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {

        }

        private void button30_Click(object sender, EventArgs e)
        {

        }

        private void cor(object sender, EventArgs e)
        {
            List<string> corp = new List<string>(File.ReadAllLines("corpo.csv"));
            corp.RemoveAt(0);

            num = rn.Next(0, corp.Count);
            riga = corp[num];

            btnCor.Visible = true;
        }
    }
}
