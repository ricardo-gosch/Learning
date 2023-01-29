namespace HelloWorld.Referencia
{
    public class Corolla : Veiculo, IVeiculoTransporte
    {
        public int CalcularAutonomia()
        {
            return 500;
        }

        public void CalcularConsumo()
        {
            Console.WriteLine("2");
        }

        public decimal CalcularPrecoLocacao()
        {
            return 2000;
        }

        public override void MostrarConsumo()
        {
            throw new NotImplementedException();
        }

        public int PeriodoManutencao()
        {
            return 30;
        }

        public void VeiculoDisponivel(bool disponibilidade)
        {
            EstaDisponivel = disponibilidade;
        }
    }
}
