using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Gonella
{
    internal class clsBici : clsCicliGonella
    {
        private string telaio;

        public string Telaio
        {
            get => telaio;
            set => telaio = value;
        }

        public clsBici(string _telaio, string _marca, string _annoProduzione, string _costo)
            : base(_marca, _annoProduzione, _costo)
        {
            Telaio = _telaio;
        }

        public override string stampa() => $"{base.stampa()}\nTipo telaio: {telaio}\nTipologia del mezzo: bici";

        public override double calcolaPrezzo() 
        {
            double aumento = (costo * 30) / 100;
            return costo + aumento;
        }
    }
}
