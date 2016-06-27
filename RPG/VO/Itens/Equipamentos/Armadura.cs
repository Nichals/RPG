using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.VO.Item.Equipamentos
{
    class Armadura
    {
        public String nome { get; set; }
        public Dinheiro valor { get; set; }
        public int classeArmadura { get; set; }
        public int maxModificadorClasseArmadura { get; set; }
        public int minForcaReq { get; set; }
        public bool furtividade { get; set; }
        public float peso { get; set; }
        public int vestir { get; set; }
        public int remover { get; set; }
        public String unidadeMedidaVestirRemover { get; set; }
        public String categoria { get; set; }


        public Armadura()
        {

        }
        

    }
}
