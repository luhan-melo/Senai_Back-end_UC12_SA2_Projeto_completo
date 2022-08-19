using UC12_ER2.Interfaces;
using System.Text.RegularExpressions;

namespace UC12_ER2.Classes
{
    public class PessoaJuridica : Pessoa, IPessoaJuridica
    {

        public string ?cnpj { get; set; }
        public string ?razaosocial { get; set; }
        
        
        
        
        public override float PagarImposto(float rendimento)
        {
             /*  Vamos utilizar a seguinte escala:
            Até 1500 (considerando 1500) - 3% de impostos
            De 1500 a 3500 (considerando 3500) - 5% de impostos
            De 3500 a 6000 (considerando 6000) - 7% de impostos
            Acima de 6000 - 9% de impostos
            */

            if (rendimento <= 1500)
            {
                return (rendimento /100) *3;
            }
            else if(rendimento >1500 && rendimento <= 3500){
                return (rendimento /100) *5;

            }

            else if (rendimento >3500 && rendimento <= 6000){
                    return (rendimento /100) *7;
            }

            else{
                return (rendimento /100) *9;
            }
        }

        /*
            XX.XXX.XXX/0001-XX
            \d{2}
        */


        public bool ValidarCnpj(string cnpj)
        {
            if(Regex.IsMatch(cnpj,@"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)"))
            {
                if(cnpj.Length == 18) 
                {
                    if(cnpj.Substring(11,4) == "0001") // ele vai iniciar no caracter 11 e pegar os próximos 4
                    {
                        return true;
                    }
                }
                else if(cnpj.Length == 14)
                {
                    if(cnpj.Substring(8,4) == "0001") //ele vai iniciar no caractere 8 e pegar os próximos 4
                    {
                        return true;
                    }
                }
            }
           return false;            
        }
    }
}