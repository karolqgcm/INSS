using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    public class CalculardorINSS
    {
        public decimal CalcularDesconto(DateTime data, decimal salario)
        {
            decimal desconto = 0;

            var ano = data.Year;
            var aliquota = RecuperarAliquota(ano, salario);

            desconto = aliquota > 100 ? aliquota : aliquota/100 * salario;

            return desconto;
        }

        private decimal RecuperarAliquota(int ano, decimal salario)
        {
            decimal aliquota = 0;

            if(ano == 2011)
            {
                if(salario <= 1106.90M)
                {
                    aliquota = 8;
                }
                else if (salario >= 1106.91M && salario <= 1844.83M)
                {
                    aliquota = 9;
                }
                else if (salario >= 1844.84M && salario <= 3689.66M)
                {
                    aliquota = 11;
                }
                else
                {
                    aliquota = 405.86M;
                }
            }
            else if(ano == 2012)
            {
                if (salario <= 1000)
                {
                    aliquota = 7;
                }
                else if (salario >= 1000 && salario <= 1500)
                {
                    aliquota = 8;
                }
                else if (salario >= 1500.01M && salario <= 3000)
                {
                    aliquota = 9;
                }
                else if (salario >= 3000.01M && salario <= 4000)
                {
                    aliquota = 11;
                }
                else
                {
                    aliquota = 500;
                }
            }

            return aliquota; 
        }
    }
}
