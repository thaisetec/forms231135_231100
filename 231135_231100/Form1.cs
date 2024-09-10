using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _231135_231100
{
    public partial class Form1 : Form
    {
        int cont = 1;
        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvProdutos.Rows.Add(TxtProduto.Text,Txtquantidade.Text, TxtValor.Text);
            TxtProduto.Clear();
            TxtNovaQuantidade.Clear();
            Txtquantidade.Clear();
            MessageBox.Show("Produto incluido com sucesso!", "inclusão",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
            LblTtotal.Text= dgvProdutos.RowCount.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            if (TxtNovaQuantidade.Text !="")
            {
                dgvProdutos.CurrentRow.Cells["Quantidade"].Value=Txtquantidade.Text;
                MessageBox.Show("Produto alterado com sucesso!", "Alterar",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.RowCount > 0)
                dgvProdutos.Rows.Clear();
            LblVenda.Text = "";
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.RowCount > 0)
            {
                dgvProdutos.Rows.RemoveAt(dgvProdutos.CurrentCell.RowIndex);
                MessageBox.Show("produto removido com sucesso!", "remoção",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LblTtotal.Text = dgvProdutos.RowCount.ToString();
            }
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void LblQuantidade_Click(object sender, EventArgs e)
        {

        }

        private void Txt_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LblVenda_Click(object sender, EventArgs e)
        {

        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if (dgvProdutos.RowCount > 0)
            {
                dgvProdutos.Rows.Clear();
                LblTtotal.Text = "";
                cont++;
                Lblvalorvenda.Text = cont.ToString();
            }
        }
    }
}
