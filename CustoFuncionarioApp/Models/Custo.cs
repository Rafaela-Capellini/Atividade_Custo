namespace CustoFuncionarioApp.Models
{
    public class Custo
    {
        public decimal SalarioBruto { get; set; }
        public decimal PlanoSaude { get; set; }
        public decimal SeguroVida { get; set; }
        public decimal OutrosBeneficios { get; set; }

        /*
            Calculado com base no salário:
            Até R$ 1.412,00	---> 7,5%
            De R$ 1.412,01 até R$ 2.666,68	---> 9%
            De R$ 2.666,69 até R$ 4.000,03	---> 12%
            De R$ 4.000,04 até R$ 7.786,02	---> 14%
            Acima disso, desconto fixo de R$ 908,85 ---> 0%
         */
        public decimal getINSS_Aliquota()
        {
            if (SalarioBruto >= 1412.00M) return 7.5M;
            if (SalarioBruto > 1412.01M && SalarioBruto < 2666.68M) return 9M;
            if (SalarioBruto > 2666.69M && SalarioBruto < 4000.03M) return 12M;
            if (SalarioBruto > 4000.04M && SalarioBruto < 7786.02M) return 14M;
            return 0M;
        }

        public decimal getINSS_Valor()
        {
            return this.SalarioBruto * this.getINSS_Aliquota();
        }

        // Calculado como sendo 8% sobre o salário
        public decimal getFGTS()
        {
            return this.SalarioBruto * 0.08M;
        }

        public decimal get13oSalario()
        {
            return this.SalarioBruto;
        }

        // Salário base + 1/3
        public decimal getFerias()
        {
            return this.SalarioBruto + this.SalarioBruto / 3;
        }

        public decimal getCustoTotal()
        {
            return this.SalarioBruto +
                   this.getINSS_Valor() +
                   this.getFGTS() +
                   this.get13oSalario() +
                   this.getFerias() +
                   this.PlanoSaude +
                   this.SeguroVida +
                   this.OutrosBeneficios;
        }
    }
}
