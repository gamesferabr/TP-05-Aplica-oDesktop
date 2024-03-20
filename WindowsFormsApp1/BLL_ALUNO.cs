using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class BLL_ALUNO
    {
        public static string ra { get; set; }
        public static string nome { get; set; }
        public static string sexo { get; set; }
        public static string datanascimento { get; set; }
        public static string telefone { get; set; }
    }

    // Métodos de validação de dados Todos os campos são de preenchimento obrigatório
    public class Validar
    {
        public static bool CampoPreenchido(List<string> campo)
        {
            // RA precisa ter só números
            if (campo[0].Any(char.IsLetter))
            {
                ERROR_BLL.VerificarErro(true, "RA precisa ter só números");
                return false;
            }

            if (campo[1].Any(char.IsDigit))
            {
                ERROR_BLL.VerificarErro(true, "Nome não pode ter números");
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
