namespace Departamento
{
    class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine("---------------------------------");

            Console.Write("Entre com o departamento");
            Departamento departamento = new Departamento(Console.ReadLine());

            Console.WriteLine("Dados do trabalhador");

            Console.Write("Nome ");
            string nome = Console.ReadLine();

            Console.Write("Escolha a Senioridade ");
            Senioridade level = Enum.Parse<Senioridade>(Console.ReadLine());

            Console.Write("Insira o salario ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("----------------");
            Console.WriteLine("Quantos contratos?");
            int qtdContratos = int.Parse(Console.ReadLine());

            Trabalhador trabalhador = new Trabalhador(nome, level, salario, departamento);

            for (int i = 0; i < qtdContratos; i++)
            {
                Console.WriteLine($"Contrato {i}");

                Console.Write("Data: ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Valor da hora");
                int valorPH = int.Parse(Console.ReadLine());

                Console.WriteLine("Quantas horas");
                int horas = int.Parse(Console.ReadLine());

                HoraContrato contrato = new HoraContrato(data, valorPH, horas);
                trabalhador.addContrato(contrato);
                


            }



        }
    }
}