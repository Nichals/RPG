using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.VO
{
    class Dinheiro
    {
        public int pl { get; set; }
        public int po { get; set; }
        public int pe { get; set; }
        public int pp { get; set; }
        public int pc { get; set; }

        public override string ToString()
        {
            String valor = "";
            if (!pl.Equals(0))
            {
                valor = this.pl + " PL ";
            }
            if (!po.Equals(0))
            {
                valor = this.po + " PO ";
            }
            if (!pe.Equals(0))
            {
                valor = this.pe + " PE ";
            }
            if (!pp.Equals(0))
            {
                valor = this.pp + " PL ";
            }
            if (!pc.Equals(0))
            {
                valor = this.pc + " PC ";
            }


            return valor;
        }

    }
}
