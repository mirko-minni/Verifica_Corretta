using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Gonella
{
    abstract class clsCicliGonella
    {
        private static int ultimoCodice = 1;
        protected int codice = 0;
        protected string marca;
        protected int annoProduzione;
        protected double costo;

        public clsCicliGonella(string _marca, string _annoPrdoduzione, string _costo)
        {
            Marca = _marca;
            AnnoProduzione = _annoPrdoduzione;
            Costo = _costo;
            codice = ultimoCodice;
            ultimoCodice++;
        }

        public string Codice
        {
            get => codice.ToString();
        }

        public string Marca
        {
            get => marca;
            set
            {
                value = value.Trim();
                if (value.Length >= 2)
                    marca = value;
                else
                    throw new Exception("Formato marca errato");
            }
        }

        public string AnnoProduzione
        {
            get => annoProduzione.ToString();
            set
            {
                value = value.Trim();
                int aus;
                if (int.TryParse(value, out aus))
                {
                    if (aus>= 1990 && aus <= 2021)
                        annoProduzione = aus;
                    else
                        throw new Exception("L'anno deve essere compreso tra 1990 e 2021");
                } else
                    throw new Exception("Formato della data non valido");
            }
        }

        public string Costo
        {
            get => costo.ToString();
            set
            {
                value = value.Trim();
                double aus;
                if (double.TryParse(value, out aus))
                {
                    if (aus > 0)
                        costo = aus;
                    else
                        throw new Exception("Il costo deve essere maggiore di 0");
                }
                else
                    throw new Exception("Formato del costo non valido");
            }
        }

        public virtual string stampa() => $"Codice: {codice}\nMarca: {marca}\nCosto: {costo}\nAnno Produzione: {annoProduzione}";
        public abstract double calcolaPrezzo();
    }
}
