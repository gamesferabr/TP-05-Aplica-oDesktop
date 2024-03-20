using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pegar os dados digitados e armazenar nas variáveis
            BLL_PRODUTOS.codigo = textBox1.Text;
            BLL_PRODUTOS.descricao = textBox2.Text;
            BLL_PRODUTOS.fornecedor = textBox3.Text;
            BLL_PRODUTOS.qtdestoque = textBox4.Text;
            BLL_PRODUTOS.valorunitario = textBox5.Text;

            // Realizar a validação dos campos
            bool verifica = ValidarProdutos.CampoPreenchido(new List<string> { BLL_PRODUTOS.codigo, BLL_PRODUTOS.descricao, BLL_PRODUTOS.fornecedor, BLL_PRODUTOS.qtdestoque, BLL_PRODUTOS.valorunitario });

            if (verifica)
            {
                // Se todos os campos estiverem preenchidos, mostrar a mensagem de cadastro realizado com sucesso
                MessageBox.Show("Cadastro realizado com sucesso");


                // Salvar os dados em um TextBox personalizado
                listBox1.Items.Add("Código: " + BLL_PRODUTOS.codigo);
                listBox1.Items.Add("Descrição: " + BLL_PRODUTOS.descricao);
                listBox1.Items.Add("Fornecedor: " + BLL_PRODUTOS.fornecedor);
                listBox1.Items.Add("Quantidade em estoque: " + BLL_PRODUTOS.qtdestoque);
                listBox1.Items.Add("Valor unitário: " + BLL_PRODUTOS.valorunitario);
                listBox1.Items.Add("\n");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // limpar os campos
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            // limpar a listbox
            listBox1.Items.Clear();
            listBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Mostrar a listbox
            listBox1.Visible = true;
        }
    }
}

