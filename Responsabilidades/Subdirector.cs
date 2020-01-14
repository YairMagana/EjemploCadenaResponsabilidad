namespace EjemploCadenaResponsabilidad
{
    public class Subdirector : AbstractAprobador
    {
        public override string DecidirAprobacion(decimal monto)
        {
            if (monto <= 15000)
                return $"Compra de Aires Acondicionados \"AUTORIZADA\" por el subdirector";
            else
                return base.DecidirAprobacion(monto);
        }
    }
}
