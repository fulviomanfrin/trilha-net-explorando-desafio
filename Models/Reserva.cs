namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva()
        {
        }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (hospedes.Count <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception($"A quantidade de hóspedes ({hospedes.Count} hóspedes) não pode exceder a" +
                                    $" capacidade da suíte ({Suite.Capacidade} hóspedes).");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            // *IMPLEMENTE AQUI*
            return Hospedes.Count;
        }

        public string CalcularValorDiaria()
        {
            decimal valor = Math.Round(DiasReservados * Suite.ValorDiaria, 2);

            if (DiasReservados >= 10)
            {
                var desconto = valor * (10m / 100);
                valor -= desconto;
            }

            return valor.ToString("0.00");
        }
    }
}