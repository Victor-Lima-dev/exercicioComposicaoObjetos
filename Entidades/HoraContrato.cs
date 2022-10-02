namespace Departamento
{
    class HoraContrato
    {
        public DateTime Data { get; set; }
        public double ValorPorHora { get; set; }
        public int Horas { get; set; }


        public HoraContrato(){}

        public HoraContrato(DateTime data, double valorPorHora, int horas)
        {
            Data = data;
            ValorPorHora = valorPorHora;
            Horas = horas;
        }

        public double totalHora()
        {
            return ValorPorHora * Horas;
        }

    }
}