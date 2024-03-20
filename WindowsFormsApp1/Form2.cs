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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Pegar os dados digitados e armazenar nas variáveis
            BLL_ALUNO.ra = textBox1.Text;
            BLL_ALUNO.nome = textBox2.Text;
            
            // Verificar qual botão de sexo foi selecionado
            if (radioButton1.Checked)
            {
                BLL_ALUNO.sexo = "masculino";
            }
            else
            {
                BLL_ALUNO.sexo = "Feminino";
            }

            BLL_ALUNO.datanascimento = maskedTextBox1.Text;
            BLL_ALUNO.telefone = maskedTextBox2.Text;

            // Realizar a validação dos campos
            
            bool verifica  = Validar.CampoPreenchido(new List<string> { BLL_ALUNO.ra, BLL_ALUNO.nome, BLL_ALUNO.datanascimento, BLL_ALUNO.telefone });

            if (verifica)
            {
                // Se todos os campos estiverem preenchidos, mostrar a mensagem de cadastro realizado com sucesso
                MessageBox.Show("Cadastro realizado com sucesso");


                // Salvar os dados em um TextBox personalizado
                listBox1.Items.Add("\nRA: " + BLL_ALUNO.ra);
                listBox1.Items.Add("Nome: " + BLL_ALUNO.nome);
                listBox1.Items.Add("Sexo: " + BLL_ALUNO.sexo);
                listBox1.Items.Add("Data de Nascimento: " + BLL_ALUNO.datanascimento);
                listBox1.Items.Add("Telefone: " + BLL_ALUNO.telefone);
                listBox1.Items.Add("\n");

            }

            else
            {
               ERROR_BLL.VerificarErro(true, "Todos os campos são de preenchimento obrigatório");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Esconder a listBox1
            listBox1.Visible = false;

            // Limpar os campos
            textBox1.Text = "";
            textBox2.Text = "";
            
            // Desmarcar os radioButtons
            radioButton1.Checked = false;
            radioButton2.Checked = false;

            // Limpar os maskedTextBox
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";

            // Esconder o listBox1
            listBox1.Visible = false;
            //limpar o listBox1
            listBox1.Items.Clear();
        }

     
        private void button3_Click_1(object sender, EventArgs e)
        {
            // Mostrar a listBox1
            listBox1.Visible = true;
        }
    }
}
