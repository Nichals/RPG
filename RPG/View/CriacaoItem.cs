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
        private String mensagemErro;
        private bool flagErro;
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
            // Atribuindo valores iniciais para as variaveis utilizadas

            mensagemErro = "Informação invalida nos campos: ";
            flagErro = false;

            //Valida se no campo categoria foi selecionado a opção "Armadura"
            if (cbCategoria.SelectedIndex.Equals(0))
            {
                //Cria nova instância para o objeto armadura
                armadura = new Armadura();

                //Valida e atribui o valor informado no campo CategoriaArmadura para o objeto armadura

                if (!cbxCategoriaArmadura.SelectedIndex.Equals(-1))
                {
                    armadura.categoria = cbxCategoriaArmadura.Text;

                }
                else
                {
                    mensagemErro += "@-> Catergoria - Armadura";
                    if (!flagErro)
                    {
                        flagErro = true;
                    }
                }

                //Valida e atribui o valor informado no campo nome para o objeto armadura

                if (tbNome.Text.Length != 0)
                {
                    armadura.nome = tbNome.Text;

                }
                else
                {
                    mensagemErro += "@-> Nome";
                    if (!flagErro)
                    {
                        flagErro = true;
                    }
                }
                //Valida e atribui os valores informado nos campos da categoria valor para o objeto armadura

                if (tbPl.TextLength != 0 || tbPo.TextLength != 0 || tbPe.TextLength != 0 || tbPp.TextLength != 0 || tbPc.TextLength != 0)
                {
                    armadura.valor.pl = int.Parse(tbPl.Text);
                    armadura.valor.po = int.Parse(tbPo.Text);
                    armadura.valor.pe = int.Parse(tbPe.Text);
                    armadura.valor.pp = int.Parse(tbPp.Text);
                    armadura.valor.pc = int.Parse(tbPc.Text);
                }
                else
                {
                    mensagemErro += "@-> Valor";
                    if (!flagErro)
                    {
                        flagErro = true;
                    }
                }

                //Valida e atribui o valor informado no campo peso para o objeto armadura

                if (tbPeso.TextLength != 0)
                {
                    armadura.peso = float.Parse(tbPeso.Text);
                }
                else
                {
                    mensagemErro += "@-> Peso";
                    if (!flagErro)
                    {
                        flagErro = true;
                    }
                }

                //Valida e atribui informações do campo CA para a ClasseArmadura do objeto armadura.

                if (tbCa.TextLength != 0)
                {
                    armadura.classeArmadura = int.Parse(tbCa.Text);
                }
                else
                {
                    mensagemErro += "@-> CA";
                    if (!flagErro)
                    {
                        flagErro = true;
                    }
                }

                //Valida e atribui informações do campo MAX para a maxModificadorClasseArmadura do objeto armadura.

                if (tbMaxModificador.TextLength != 0)
                {
                    armadura.maxModificadorClasseArmadura = int.Parse(tbMaxModificador.Text);
                }
                else
                {
                    mensagemErro += "@-> Max +";
                    if (!flagErro)
                    {
                        flagErro = true;
                    }
                }

                //Valida e atribui informações do campo Força necessária para a minForcaReq do objeto armadura.

                if (tbMinForca.TextLength != 0)
                {
                    armadura.minForcaReq = int.Parse(tbMinForca.Text);
                }
                else
                {
                    mensagemErro += "@-> Força necessária";
                    if (!flagErro)
                    {
                        flagErro = true;
                    }
                }

                //Valida e atribui informações do campo Tempo para vestir para a vestir do objeto armadura.

                if (tbTempoVestir.TextLength != 0)
                {
                    armadura.vestir = int.Parse(tbTempoVestir.Text);
                }
                else
                {
                    mensagemErro += "@-> Tempo para vestir";
                    if (!flagErro)
                    {
                        flagErro = true;
                    }
                }

                //Valida e atribui o valor informado no campo peso para o objeto armadura

                if (tbPropriedades.TextLength != 0)
                {
                    armadura.propriedades = tbPropriedades.Text;
                }
                else
                {
                    mensagemErro += "@-> Propriedades";
                    if (!flagErro)
                    {
                        flagErro = true;
                    }
                }

                armadura.furtividade = cbFurtividade.Checked;

                //Valida se possui campo com erro, se sim, mostra quais campos estão com erro, se não, permite que o sistema salve o objeto.
                if (flagErro)
                {
                    mensagemErro = mensagemErro.Replace("@", Environment.NewLine);
                    MessageBox.Show(mensagemErro);
                }
                else
                {
                    MessageBox.Show("Armadura salva com sucesso!");
                }
            }

            //Valida se no campo categoria foi selecionado a opção "Arma"

            else if (cbCategoria.SelectedIndex.Equals(1))
            {
                // Atribuindo valores iniciais para as variaveis utilizadas

                mensagemErro = "Informação invalida nos campos: ";
                flagErro = false;
                //Cria nova instância para o objeto armadura
                arma = new Arma();

                //Valida e atribui o valor informado no campo CategoriaArmadura para o objeto arma

                if (!cbCategoriaArma.SelectedIndex.Equals(-1))
                {
                    arma.categoria = cbCategoriaArma.Text;

                }
                else
                {
                    mensagemErro += "@-> Catergoria - Arma";
                    if (!flagErro)
                    {
                        flagErro = true;
                    }
                }

                //Valida e atribui o valor informado no campo nome para o objeto arma

                if (tbNome.Text.Length != 0)
                {
                    arma.nome = tbNome.Text;

                }
                else
                {
                    mensagemErro += "@-> Nome";
                    if (!flagErro)
                    {
                        flagErro = true;
                    }
                }
                //Valida e atribui os valores informado nos campos da categoria valor para o objeto arma

                if (tbPl.TextLength != 0 || tbPo.TextLength != 0 || tbPe.TextLength != 0 || tbPp.TextLength != 0 || tbPc.TextLength != 0)
                {
                    arma.valor.pl = int.Parse(tbPl.Text);
                    arma.valor.po = int.Parse(tbPo.Text);
                    arma.valor.pe = int.Parse(tbPe.Text);
                    arma.valor.pp = int.Parse(tbPp.Text);
                    arma.valor.pc = int.Parse(tbPc.Text);
                }
                else
                {
                    mensagemErro += "@-> Valor";
                    if (!flagErro)
                    {
                        flagErro = true;
                    }
                }

                //Valida e atribui o valor informado no campo peso para o objeto arma

                if (tbPeso.TextLength != 0)
                {
                    arma.peso = float.Parse(tbPeso.Text);
                }
                else
                {
                    mensagemErro += "@-> Peso";
                    if (!flagErro)
                    {
                        flagErro = true;
                    }
                }

                //Valida e atribui o valor informado no campo quantidade de dados a serem rolados para o objeto arma

                if (tbQuantidadeDano.TextLength != 0)
                {
                    arma.dano.quantidade = int.Parse(tbQuantidadeDano.Text);
                }
                else
                {
                    mensagemErro += "@-> Quantidade de dados a serem rolados";
                    if (!flagErro)
                    {
                        flagErro = true;
                    }
                }

                //Valida e atribui o valor informado no campo dado para o objeto arma

                if (!cbDadoDano.SelectedIndex.Equals(-1))
                {
                    arma.dano.dado = cbDadoDano.SelectedText;
                }
                else
                {
                    mensagemErro += "@-> Dado de dano";
                    if (!flagErro)
                    {
                        flagErro = true;
                    }
                }
                //Valida e atribui o valor informado no campo Tipo de dano para o objeto arma

                if (!cbTipo.SelectedIndex.Equals(-1))
                {
                    arma.dano.tipo = cbTipo.SelectedText;
                }
                else
                {
                    mensagemErro += "@-> Tipo de dano";
                    if (!flagErro)
                    {
                        flagErro = true;
                    }
                }

                //Valida e atribui o valor informado no campo peso para o objeto arma

                if (tbPropriedades.TextLength != 0)
                {
                    arma.propriedades = tbPropriedades.Text;
                }
                else
                {
                    mensagemErro += "@-> Propriedades";
                    if (!flagErro)
                    {
                        flagErro = true;
                    }
                }

                //Valida se possui campo com erro, se sim, mostra quais campos estão com erro, se não, permite que o sistema salve o objeto.

                if (flagErro)
                {
                    mensagemErro = mensagemErro.Replace("@", Environment.NewLine);
                    MessageBox.Show(mensagemErro);
                }
                else
                {
                    MessageBox.Show("Arma salva com sucesso!");
                }

            }

            //Valida se no campo categoria foi selecionado a opção "Item"

            else if (cbCategoria.SelectedIndex.Equals(2))
            {

                // Atribuindo valores iniciais para as variaveis utilizadas

                mensagemErro = "Informação invalida nos campos: ";
                flagErro = false;
                //Cria nova instância para o objeto armadura
                item = new Item();

                //Valida e atribui o valor informado no campo nome para o objeto item

                if (tbNome.Text.Length != 0)
                {
                    item.nome = tbNome.Text;

                }
                else
                {
                    mensagemErro += "@-> Nome";
                    if (!flagErro)
                    {
                        flagErro = true;
                    }
                }
                //Valida e atribui os valores informado nos campos da categoria valor para o objeto item

                if (tbPl.TextLength != 0 || tbPo.TextLength != 0 || tbPe.TextLength != 0 || tbPp.TextLength != 0 || tbPc.TextLength != 0)
                {
                    item.valor.pl = int.Parse(tbPl.Text);
                    item.valor.po = int.Parse(tbPo.Text);
                    item.valor.pe = int.Parse(tbPe.Text);
                    item.valor.pp = int.Parse(tbPp.Text);
                    item.valor.pc = int.Parse(tbPc.Text);
                }
                else
                {
                    mensagemErro += "@-> Valor";
                    if (!flagErro)
                    {
                        flagErro = true;
                    }
                }

                //Valida e atribui o valor informado no campo peso para o objeto item

                if (tbPeso.TextLength != 0)
                {
                    item.peso = float.Parse(tbPeso.Text);
                }
                else
                {
                    mensagemErro += "@-> Peso";
                    if (!flagErro)
                    {
                        flagErro = true;
                    }
                }

                //Valida e atribui o valor informado no campo peso para o objeto item

                if (tbPropriedades.TextLength != 0)
                {
                    item.propriedades = tbPropriedades.Text;
                }
                else
                {
                    mensagemErro += "@-> Propriedades";
                    if (!flagErro)
                    {
                        flagErro = true;
                    }
                }

                //Valida se possui campo com erro, se sim, mostra quais campos estão com erro, se não, permite que o sistema salve o objeto.

                if (flagErro)
                {
                    mensagemErro = mensagemErro.Replace("@", Environment.NewLine);
                    MessageBox.Show(mensagemErro);
                }
                else
                {
                    MessageBox.Show("Item salvo com sucesso!");
                }


            }
            else if (cbCategoria.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Selecione o tipo do item!");
            }
        }
    }
}

