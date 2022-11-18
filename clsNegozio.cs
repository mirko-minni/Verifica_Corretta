using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gonella
{
    sealed class clsNegozio
    {
        //segnalare con un evento che è stata inserita una moto con presso > 50'000€
        public delegate void mioDelegato(string msg); //dichiarazione del delegato
        public event mioDelegato mioEvento; //dichiarazione evento associato al delegato

        public delegate void negozioPieno(string msg);
        public event negozioPieno full;

        static int numeroMassimo;
        private List<clsCicliGonella> lstNegozio;

        public clsNegozio(int _numeroMassimo)
        {
            numeroMassimo = _numeroMassimo;
            lstNegozio = new List<clsCicliGonella>();
        }

        public int NumeroMassimo
        {
            get => numeroMassimo;
        }

        public void inserire(clsCicliGonella nuovo)
        {
            double prezzo;
            if (lstNegozio.Count < numeroMassimo)
            {
                lstNegozio.Add(nuovo);
                if (nuovo is clsMoto)
                {
                    prezzo = nuovo.calcolaPrezzo();
                    if (prezzo > 50000)
                    {
                        mioEvento("moto costosa... prezzo: " + prezzo.ToString());
                    }
                }
            }
            else
            {
                full("Limite massimo di cicli raggiunto");
            }
                
        }

        public void visualizza(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.DataSource = lstNegozio;
        }

        public void vendere()
        {
            if (lstNegozio.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Sei sicuro di rimuovere l'ultimo elemento?", "Rimuovere?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    lstNegozio.RemoveAt(lstNegozio.Count - 1);
                }
            }
            else
                throw new Exception("La lista è vuota");       
        }

        public void vendere(int pos)
        {
            DialogResult dr = MessageBox.Show($"Sei sicuro di rimuovere l'elemento in posizione {pos+1} ?", "Rimuovere?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                lstNegozio.RemoveAt(pos);
            }
        }

        public string totale()
        {
            double totale = 0;

            foreach (clsCicliGonella item in lstNegozio)
            {
                if(item is clsMoto)
                    totale += item.calcolaPrezzo();             
            }

            return totale > 0 ? $"Il prezzo totale è {totale}" : "Nessuna moto inserita"; 
        }   
    }
}
