using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class ERROR_BLL
    {
        
        // Método para verificar se tem erro e lançar a exceção
        public static void VerificarErro(bool erro, string mensagem)
        {
            if (erro)
            {
                MessageBox.Show(mensagem);
            }
            
        }
    }
}
