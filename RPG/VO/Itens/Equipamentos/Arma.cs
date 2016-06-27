using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.VO.Item.Equipamentos
{
    class Arma
    {
        public String nome { get; set; }
        public Dinheiro valor { get; set; }
        public Dano dano { get; set; }
        public float peso { get; set; }
        public String propriedades { get; set; }
        public String categoria { get; set; }

        public Arma(String nome,Dinheiro dinheiro, Dano dano, float peso,String propriedades, String categoria)
        {
            this.nome = nome;
            this.valor = dinheiro;
            this.dano = dano;
            this.peso = peso;
            this.propriedades = propriedades;
            this.categoria = categoria;
        }
        public Arma()
        {

        }

        public override String ToString()
        {
            String valor = "Nome: " + this.nome + " Valor: " + this.valor.ToString() + " Peso: " + this.peso +" Categoria: " + this.categoria + " Propriedades: " + this.propriedades ;
            return valor;
        }

    }
}
