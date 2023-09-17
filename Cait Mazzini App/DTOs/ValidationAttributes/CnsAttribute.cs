using System.ComponentModel.DataAnnotations;

namespace Cait_Mazzini_App.DTOs.ValidationAttributes
{
    public class CnsAttribute : ValidationAttribute
    {
        public string GetErrorMessage() => "An invalid CNS value was provided.";

        protected override ValidationResult? IsValid(object? value, ValidationContext context)
        {

            if (value != null && validateCNS((string)value))
                return ValidationResult.Success;
            else
                return new ValidationResult(GetErrorMessage());
        }

        private Boolean validateCNS(string cns)
        {

            if (cns == null || cns.Trim().Length != 15)
            {
                return false;
            }

            //1. Rotina de validação de Números que iniciam com 1 ou 2:
            if (cns.StartsWith("1") || cns.StartsWith("2"))
            {
                float soma;
                float resto, dv;
                String pis = "";
                String resultado = "";
                pis = cns.Substring(0, 11);

                soma = (Convert.ToInt32(pis.Substring(0, 1)) * 15) +
                        (Convert.ToInt32(pis.Substring(1, 1)) * 14) +
                        (Convert.ToInt32(pis.Substring(2, 1)) * 13) +
                        (Convert.ToInt32(pis.Substring(3, 1)) * 12) +
                        (Convert.ToInt32(pis.Substring(4, 1)) * 11) +
                        (Convert.ToInt32(pis.Substring(5, 1)) * 10) +
                        (Convert.ToInt32(pis.Substring(6, 1)) * 9) +
                        (Convert.ToInt32(pis.Substring(7, 1)) * 8) +
                        (Convert.ToInt32(pis.Substring(8, 1)) * 7) +
                        (Convert.ToInt32(pis.Substring(9, 1)) * 6) +
                        (Convert.ToInt32(pis.Substring(10, 1)) * 5);

                //1º teste
                resto = soma % 11;
                dv = 11 - resto;

                //2º teste
                if (dv == 11)
                {
                    dv = 0;
                }

                //3º teste
                if (dv == 10)
                {
                    soma += 2;

                    resto = soma % 11;
                    dv = 11 - resto;
                    resultado = pis + "001" + dv.ToString();
                }
                else
                {
                    resultado = pis + "000" + dv.ToString();
                }

                return cns.Equals(resultado);
            }


            //2. Rotina de validação de Números que iniciam com 7, 8 ou 9:
            if (cns.StartsWith("7") || cns.StartsWith("8") || cns.StartsWith("9"))
            {
                float resto, soma;

                soma = (Convert.ToInt32(cns.Substring(0, 1)) * 15) +
                        (Convert.ToInt32(cns.Substring(1, 1)) * 14) +
                        (Convert.ToInt32(cns.Substring(2, 1)) * 13) +
                        (Convert.ToInt32(cns.Substring(3, 1)) * 12) +
                        (Convert.ToInt32(cns.Substring(4, 1)) * 11) +
                        (Convert.ToInt32(cns.Substring(5, 1)) * 10) +
                        (Convert.ToInt32(cns.Substring(6, 1)) * 9) +
                        (Convert.ToInt32(cns.Substring(7, 1)) * 8) +
                        (Convert.ToInt32(cns.Substring(8, 1)) * 7) +
                        (Convert.ToInt32(cns.Substring(9, 1)) * 6) +
                        (Convert.ToInt32(cns.Substring(10, 1)) * 5) +
                        (Convert.ToInt32(cns.Substring(11, 1)) * 4) +
                        (Convert.ToInt32(cns.Substring(12, 1)) * 3) +
                        (Convert.ToInt32(cns.Substring(13, 1)) * 2) +
                        (Convert.ToInt32(cns.Substring(14, 1)) * 1);


                resto = soma % 11;

                return resto == 0;
            }

            //se for 3, 4, 5 ou 6 é inválido
            return false;
        }
    }
}
