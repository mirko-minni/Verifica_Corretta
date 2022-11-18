using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Gonella
{
    public partial class frmGonella : Form
    {
        static string[] telai = {"", "carbonio", "ferro", "alluminio" };
        static string[] cilindrate = {"", "50", "125", "150", "200"};

        clsNegozio negozio;

        public frmGonella()
        {
            InitializeComponent();
        }

        private void frmGonella_Load(object sender, EventArgs e)
        {
            cmbTelaio.DataSource = telai;
            cmbCilindrata.DataSource = cilindrate;
            
            bool errore;
            do
            {
                errore = false;
                string risposta = Interaction.InputBox("Qual è il numero massimo di cicli inseribili?");
                int posti;
                if (!string.IsNullOrEmpty(risposta) && int.TryParse(risposta, out posti) && posti > 0)
                {
                    negozio = new clsNegozio(posti);
                    negozio.mioEvento += new clsNegozio.mioDelegato(segnalazione);
                    negozio.full += full;
                    //intercettare evento
                }
                else 
                    errore = true;

            } while (errore);             
        }

        private void segnalazione(string msg)  //procedura di risposta all'evento, eseguita dal delegato
        {
            MessageBox.Show(msg);
        }
        private void full(string msg)
        {
            MessageBox.Show(msg);
            btnInserisci.Enabled = false;
        }

        private void btnInserisci_Click(object sender, EventArgs e)
        {
            clsCicliGonella nuovo;

            try
            {
                if (rdbBici.Checked)
                {
                    if (cmbTelaio.Text != "")
                    {
                        nuovo = new clsBici(cmbTelaio.Text, txtMarca.Text, txtAnnoProduzione.Text, txtCosto.Text);
                        negozio.inserire(nuovo);
                        negozio.visualizza(dgvGonella);
                    }
                    else
                        MessageBox.Show("Telaio non valido");
                }
                else
                {
                    if (cmbCilindrata.Text != "")
                    {
                        nuovo = new clsMoto(Convert.ToInt32(cmbCilindrata.Text), txtMarca.Text, txtAnnoProduzione.Text, txtCosto.Text);
                        negozio.inserire(nuovo);
                        negozio.visualizza(dgvGonella);
                    }
                    else
                        MessageBox.Show("Cilindrata non valido");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVendi_Click(object sender, EventArgs e)
        {
            try
            {
                negozio.vendere();
                negozio.visualizza(dgvGonella);
                btnInserisci.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgvGonella_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int pos = e.RowIndex;

            try
            {
                if(pos > -1)
                {
                    negozio.vendere(pos);
                    negozio.visualizza(dgvGonella);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTotale_Click(object sender, EventArgs e)
        {
            MessageBox.Show(negozio.totale());
        }
    }
}
