using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioMed.Modelo
{
    public static class Estaticos
    {
        public static int idUser;
        public static int idPac;
        public static string tipoExame;
        public static string usuario = "";
        public static string nomeUsuario = "";
        public static string dominio = "";

        public static bool VerificarCpf(string cpf)
        {
            //==============================================================================
            int[] verificarDigito1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] verificarDigito2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string CPF1, CPF2;
            int soma, resultado;
            //==============================================================================
            cpf = cpf.Trim();
            cpf = cpf.Replace(",", "").Replace("-", "").Replace(".", "");
            //==============================================================================
            if (cpf.Length != 11)
            {
                return false;
            }
            //==============================================================================
            CPF1 = cpf.Substring(0, 10);
            soma = 0;
            for (int a = 0; a < 9; a++)
            {
                soma += Convert.ToInt32(CPF1[a].ToString()) * verificarDigito1[a];
            }
            resultado = soma % 11;//Resto da divisão

            if (resultado < 2)
            {
                resultado = 0;
            }
            else
            {
                resultado = 11 - resultado;
            }
            //==============================================================================
            CPF2 = resultado.ToString();//Recebe o primeiro digito verificador
            CPF1 = CPF1 + CPF2;
            //==============================================================================
            soma = 0;//Reseta a variavel soma
            for (int b = 0; b < 10; b++)
            {
                soma += Convert.ToInt32(CPF1[b].ToString()) * verificarDigito2[b];
            }
            resultado = soma % 11;
            //==============================================================================
            if (resultado < 2)
            {
                resultado = 0;
            }
            else
            {
                resultado = 11 - resultado;
            }
            //==============================================================================
            CPF2 = CPF2 + resultado.ToString();
            return cpf.EndsWith(CPF2);
        }
    }
}
