using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ao clicar no botão, o código abaixo será executado, mostrando dois botões de opção Cadastro de aluno e Cadastro de Produto
            button2.Visible = true;
            button3.Visible = true;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // Ao clicar no botão Cadastro de aluno, aparecerá a nova janela de cadastro de aluno
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Fechar o programa
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }
    }
}
