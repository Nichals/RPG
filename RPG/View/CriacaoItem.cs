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
    public partial class CriacaoItem : Form
    {
        public CriacaoItem()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedText.Equals("Armadura")){

            }
            else if (cbCategoria.SelectedText.Equals("Arma")){

            }
            else if (cbCategoria.SelectedText.Equals("Item")){

            }
        }
    }
}
