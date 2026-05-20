using System.Reflection.Emit;
using System.Windows.Forms;

namespace impicat
{
    public partial class Form1 : Form
    {
        Random rn = new Random();
        string riga;
        int num = 0;
        string parola;
        int errori = 0;
        int maxErrori = 6;

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
        private void start()
        {
            errori = 0;
            lblP.Text = generaTrattini(parola);
            lblMess.Text = "";
            lblErr.Text = "errori: 0/" + maxErrori;
            txtLett.Clear();
            txtParolaIntera.Clear();
            txtLettera.Enabled = true;
            txtParolaIntera.Enabled = true;
            btnLett.Enabled = true;
            btnPar.Enabled = true;
        }




        private void btnSer_Click(object sender, EventArgs e)
        {
            List<string> sT = new List<string>(File.ReadAllLines("serie_tv.csv"));
            sT.RemoveAt(0);

            num = rn.Next(1, sT.Count);
            riga = sT[num];
            nasc();
            parola=estrai("serie_tv.csv");
            start();
            
        }

        private void btnCit_Click(object sender, EventArgs e)
        {
            List<string> cit = new List<string>(File.ReadAllLines("citta.csv"));
            cit.RemoveAt(0);

            num = rn.Next(1, cit.Count);
            riga = cit[num];
            nasc();
            parola=estrai("citta.csv");
            start();

        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            List<string> corp = new List<string>(File.ReadAllLines("corpo_umano.csv"));
            corp.RemoveAt(0);

            num = rn.Next(1, corp.Count);
            riga = corp[num];
            nasc();
            parola=estrai("corpo_umano.csv");
            start();



        }
        private string generaTrattini(string parola)
        {
            string trattini = "";
            foreach (char c in parola)
            {
                if (c != ' ')
                {
                    trattini += "_ ";
                }
               
            }
            return trattini;
        }
        private void btnLett_Click(object sender, EventArgs e)
        {
            if (txtLettera.Text.Length == 0)
            {
                return;
            }

            char lettera = char.ToUpper(txtLettera.Text[0]);
            string parolaVisibile = lblP.Text;
            string parolaAgg = "";
            bool trovata = false;
            int i2 = 0;

            for (int i = 0; i < parola.Length; i++)
            {
                if (parola[i] == ' ')
                {
                    parolaAgg += "  ";
                    i2 += 2;
                }
                else
                {
                    if (char.ToUpper(parola[i]) == lettera)
                    {
                        parolaAgg += lettera + " ";
                        trovata = true;
                    }
                    else
                    {
                        parolaAgg += parolaVisibile[i2] + " ";
                    }
                    i2 += 2;
                }
            }

            if (trovata==true)
            {
                lblP.Text = parolaAgg;
                lblMess.Text = "lettera giusta";
                if (!lblP.Text.Contains('_'))
                {
                    lblMess.Text = "hai vinto la par era " + parola;
                    finish();
                }
            }
            else
            {
                errori++;
                lblErr.Text = "errori " + errori + "/" + maxErrori;
                lblMess.Text = "non ce la lettera";
                if (errori >= maxErrori)
                {
                    lblMess.Text = "hai perso la par era " + parola;
                    finish();
                }
            }

            txtLett.Clear();
        }
        private void btnPar_Click(object sender, EventArgs e)
        {
            if (txtParolaIntera.Text.Trim().Length == 0)
            {
                return;
            }

            if (txtParolaIntera.Text.Trim().ToUpper() == parola.ToUpper())
            {
                lblP.Text = parola.ToUpper();
                lblMess.Text = "hai vinto la parola era " + parola;
                finish();
            }
            else
            {
                errori++;
                lblErr.Text = "errori " + errori + "/" + maxErrori;
                lblMess.Text = "parola sbagliat";
                if (errori >= maxErrori)
                {
                    lblMess.Text = "hai perso la parola era: " + parola;
                    finish();
                }
            }

            txtParolaIntera.Clear();
        }
        private void finish()
        {
            txtLettera.Enabled = false;
            txtParolaIntera.Enabled = false;
            btnLett.Enabled = false;
            btnPar.Enabled = false;
            btnCor.Show(); 
            btnCor.Enabled = true;
            btnSer.Show(); 
            btnSer.Enabled = true;
            btnCit.Show(); 
            btnCit.Enabled = true;
        }

    }
}
