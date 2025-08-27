namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {

            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            // Implementado conforme instruções no Readme.md
            if (hospedes.Count <= Suite.Capacidade)

                if (true)
                {
                    Hospedes = hospedes;
                }
                else
                {
                    // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                    // Implementado conforme instruções no Readme.md
                    throw new InvalidOperationException(
                $"A quantidade de hóspedes ({hospedes.Count}) excede a capacidade da suíte ({Suite.Capacidade})."
            );
                }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // Implementado conforme instruções no Readme.md
            return Hospedes?.Count ?? 0;
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            // // Implementado conforme instruções no Readme.md
            decimal valor = DiasReservados * Suite.ValorDiaria;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            // // Implementado conforme instruções no Readme.md
            if (DiasReservados >= 10)
            {
                valor -= valor * 0.10m; // Aplica um desconto de 10%
            }


            return valor;
        }
    }
}