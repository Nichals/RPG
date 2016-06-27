using RPG.VO.Item.Equipamentos;
using RPG.VO.Itens;
using System;
using System.Windows.Forms;

namespace RPG
{
    public partial class CriacaoItem : Form
    {
        private Armadura armadura;
        private Arma arma;
        private Item item;

        public CriacaoItem()
        {
            InitializeComponent();
        }



        private void cbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedIndex.Equals(0))
            {
                tbCa.Enabled = true;
                tbMinForca.Enabled = true;
                tbMaxModificador.Enabled = true;
                cbFurtividade.Enabled = true;
                tbTempoVestir.Enabled = true;
                cbxCategoriaArmadura.Enabled = true;
                cbTipo.Enabled = false;
                tbQuantidadeDano.Enabled = false;
                cbDadoDano.Enabled = false;
                cbCategoriaArma.Enabled = false;
            }
            else if (cbCategoria.SelectedIndex.Equals(1))
            {
                tbCa.Enabled = false;
                tbMinForca.Enabled = false;
                tbMaxModificador.Enabled = false;
                cbFurtividade.Enabled = false;
                tbTempoVestir.Enabled = false;
                cbxCategoriaArmadura.Enabled = false;
                tbQuantidadeDano.Enabled = true;
                cbDadoDano.Enabled = true;
                cbCategoriaArma.Enabled = true;
                cbTipo.Enabled = true;
            }
            else if (cbCategoria.SelectedIndex.Equals(2))
            {
                tbCa.Enabled = false;
                tbMinForca.Enabled = false;
                tbMaxModificador.Enabled = false;
                cbFurtividade.Enabled = false;
                tbTempoVestir.Enabled = false;
                tbQuantidadeDano.Enabled = false;
                cbDadoDano.Enabled = false;
                cbCategoriaArma.Enabled = false;
                cbTipo.Enabled = false;
                cbxCategoriaArmadura.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            arma = new Arma();
            armadura = new Armadura();
            item = new Item();
            this.Hide();
        }

        private void btnSalvarItem_Click(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedIndex.Equals(0))
            {
                armadura = new Armadura();

                if (!cbxCategoriaArmadura.SelectedIndex.Equals(-1))
                {
                    armadura.categoria = cbxCategoriaArmadura.Text;
                }
            }
            else if (cbCategoria.SelectedIndex.Equals(1))
            {

            }
            else if (cbCategoria.SelectedIndex.Equals(2))
            {

            }
            else
            {
                MessageBox.Show("Selecione a categoria do item!");
            }
        }
    }
}
