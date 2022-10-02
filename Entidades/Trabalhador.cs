namespace Departamento
{
    class Trabalhador
    {
        public string Nome { get; set; }
        public Senioridade Level { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Dept { get; set; }
        public List<HoraContrato> ListaContratos { get; set; } = new List<HoraContrato>();


        public Trabalhador(string nome, Senioridade level, double salarioBase, Departamento dept)
        {
            Nome = nome;
            Level = level;
            SalarioBase = salarioBase;
            Dept = dept;
        }
        public void addContrato(HoraContrato contrato)
        {
            ListaContratos.Add(contrato);
        }
        public void removeContrato(HoraContrato contrato)
        {
            ListaContratos.Remove(contrato);
        }

        public double Ganho(int ano, int mes)
        {
            double soma = SalarioBase;

            foreach (HoraContrato x in ListaContratos)
            {
                if(x.Data.Year == ano && x.Data.Month == mes)
                {
                    soma += x.totalHora();
                }
            }


            return soma;

        }
    }
}