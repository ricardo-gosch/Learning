namespace HelloWorld.Referencia
{
    public interface IVeiculoTransporte
    {
        void CalcularConsumo();
        int PeriodoManutencao();
        int CalcularAutonomia();

        decimal CalcularPrecoLocacao();

        void VeiculoDisponivel(bool disponibilidade);
    }
}
