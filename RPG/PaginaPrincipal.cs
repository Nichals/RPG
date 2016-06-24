using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG
{
    public partial class PaginaPrincipal : Form
    {
        CriacaoPersonagem criacaoPersonagem;
        ConsultarPersonagem consultarPersonagem;
        CriacaoEncontro criacaoEncontro;
        ConsultarEncontro consultarEncontro;
        CriacaoItem criacaoItem;
        ConsultarItem consultarItem;
        CriacaoMonstro criacaoMonstro;
        ConsultarMonstro consultarMonstro;
        CriacaoAventura criacaoAventura;
        ConsultarAventura consultarAventura;



        public PaginaPrincipal()
        {
            InitializeComponent();
            
        }
        

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            criacaoPersonagem = new CriacaoPersonagem();
            criacaoPersonagem.ShowDialog();
        }

        private void novoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            criacaoEncontro = new CriacaoEncontro();
            criacaoEncontro.ShowDialog();
        }

        private void novoToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            criacaoItem = new CriacaoItem();
            criacaoItem.ShowDialog();
        }

        private void novoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            criacaoMonstro = new CriacaoMonstro();
            criacaoMonstro.ShowDialog();
        }

        private void novoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            criacaoAventura = new CriacaoAventura();
            criacaoAventura.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultarAventura = new ConsultarAventura();
            consultarAventura.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consultarPersonagem = new ConsultarPersonagem();
            consultarPersonagem.ShowDialog();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            consultarMonstro = new ConsultarMonstro();
            consultarMonstro.ShowDialog();
        }

        private void consultarItem_Click(object sender, EventArgs e)
        {
            consultarItem = new ConsultarItem();
            consultarItem.ShowDialog();
        }

        private void consultarEncontro_Click(object sender, EventArgs e)
        {
            consultarEncontro = new ConsultarEncontro();
            consultarEncontro.ShowDialog();
        }
    }
}
