namespace EjemploCadenaResponsabilidad
{
    public class Director : AbstractAprobador
    {
        public override string DecidirAprobacion(decimal monto)
        {
            if (monto <= 50000)
                return $"Compra de Aires Acondicionados \"AUTORIZADA\" por el director";
            else
                return base.DecidirAprobacion(monto);
        }
    }
}
