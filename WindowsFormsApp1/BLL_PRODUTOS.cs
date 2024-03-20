using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class BLL_PRODUTOS
    {
        public static string codigo { get; set; }
        public static string descricao { get; set; }
        public static string fornecedor { get; set; }
        public static string qtdestoque { get; set; }
        public static string valorunitario { get; set; }
    }

    public class ValidarProdutos
    {
        public static bool CampoPreenchido(List<string> campo)
        {
            
            // O campo código não pode ter letras inteiro e maior que 0
            if (int.Parse(campo[0]) <= 0)
            {
                ERROR_BLL.VerificarErro(true, "Código precisa ser maior que 0");
                return false;
            }

            if (campo[0].Any(char.IsLetter))
            {
                ERROR_BLL.VerificarErro(true, "Código precisa ter só números");
                return false;
            }

            if (campo[1].Any(char.IsDigit))
            {
                ERROR_BLL.VerificarErro(true, "Descrição não pode ter números");
                return false;
            }

            if (campo[2].Any(char.IsDigit))
            {
                ERROR_BLL.VerificarErro(true, "Fornecedor não pode ter números");
                return false;
            }

            if (int.Parse(campo[3]) <= 0)
            {
                ERROR_BLL.VerificarErro(true, "Quantidade em estoque precisa ser maior que 0");
                return false;
            }   

            if (campo[3].Any(char.IsLetter))
            {
                ERROR_BLL.VerificarErro(true, "Quantidade em estoque precisa ter só números");
                return false;
            }

            if (float.Parse(campo[4]) <= 0)
            {
                ERROR_BLL.VerificarErro(true, "Valor unitário precisa ser maior que 0");
                return false;
            }

            if (campo[4].Any(char.IsLetter))
            {
                ERROR_BLL.VerificarErro(true, "Valor unitário precisa ter só números");
                return false;
            }



            for (int i = 0; i < campo.Count; i++)
            {
                if (campo[i].Trim() == "")
                {
                    ERROR_BLL.VerificarErro(true, "Todos os campos são de preenchimento obrigatório");
                    return false;
                }
            }

            return true;

        }
    }

}
