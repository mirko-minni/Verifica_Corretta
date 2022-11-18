using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gonella
{
    internal class clsMoto : clsCicliGonella
    {
        private int cilindrata;

        public int Cilindrata
        {
            get => cilindrata;
            set => cilindrata = value;
        }

        public clsMoto(int _cilindrata, string _marca, string _annoProduzione, string _costo)
            : base(_marca, _annoProduzione, _costo)
        {
            Cilindrata = _cilindrata;
        }

        public override string stampa() => $"{base.stampa()}\nCilindrata: {cilindrata}\nTipologia del mezzo: moto";

        public override double calcolaPrezzo()
        {
            double aumento = (costo * 40) / 100;
            return costo + aumento;
        }
    }
}
