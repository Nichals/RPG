using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.VO.Itens
{
    class Item
    {
        public String nome { get; set; }
        public Dinheiro valor { get; set; }
        public float peso { get; set; }
        public String propriedades { get; set; }
       
    }
}
