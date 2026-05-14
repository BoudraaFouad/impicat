using System.Reflection.Emit;
using System.Windows.Forms;

namespace impicat
{
    public partial class Form1 : Form
    {
        Random rn = new Random();
        string riga;
        int num = 0;
        string parolaSegreta = "";
        char[] lettereIndovinate;
       
        private string estrai(string nomeF)
        {
            using (StreamReader sr = new StreamReader(nomeF))
            {
                riga = sr.ReadLine();
            }
            string[] par = riga.Split(",");
            num = rn.Next(0, par.Length);
            return par[num];
        }
        void nasc()
        {
            btnCor.Hide();
            btnCor.Enabled = false;
            btnSer.Hide();
            btnSer.Enabled = false;
            btnCit.Hide();
            btnCit.Enabled = false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        


        private void btnSer_Click(object sender, EventArgs e)
        {
            List<string> sT = new List<string>(File.ReadAllLines("serie_tv.csv"));
            sT.RemoveAt(0);

            num = rn.Next(1, sT.Count);
            riga = sT[num];
            nasc();
            string parola=estrai("serie_tv.csv");
            lblP.Text = generaTrattini(parola);
            
        }

        private void btnCit_Click(object sender, EventArgs e)
        {
            List<string> cit = new List<string>(File.ReadAllLines("citta.csv"));
            cit.RemoveAt(0);

            num = rn.Next(1, cit.Count);
            riga = cit[num];
            nasc();
            string parola=estrai("citta.csv");
            lblP.Text = generaTrattini(parola);
           
        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            List<string> corp = new List<string>(File.ReadAllLines("corpo_umano.csv"));
            corp.RemoveAt(0);

            num = rn.Next(1, corp.Count);
            riga = corp[num];
            nasc();
            string parola=estrai("corpo_umano.csv");
            lblP.Text = generaTrattini(parola);
           


        }
        private string generaTrattini(string parola)
        {
            string trattini = "";
            foreach (char c in parola)
            {
                if (c == ' ')
                {
                    trattini += "  ";
                }
                else
                {
                    trattini += "_ ";
                }
            }
            return trattini.TrimEnd();
        }
    }
}
